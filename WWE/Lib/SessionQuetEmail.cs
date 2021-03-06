﻿using NCrawler;
using NCrawler.HtmlProcessor;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using System.Threading;

namespace WWE.Lib
{
    [Serializable]
    class SessionQuetEmail
    {
        private string _linkBanDau;

        HashSet<string> _lstLinkDaTruyCap;
        Regex _validationExpression = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
        HashSet<Email> _lstEmail;
        HashSet<string> _linkDangQuet;//Để khôi phục
        HashSet<string> _boLoc;

        public event Action<Email> CoEmailMoi;
        public event Action QuetLinkMoi;
        public int SoLuong { set; get; }
        public int SoLienKetDaQuet
        {
            get { return _lstLinkDaTruyCap.Count; }
        }
        bool _cancel;


        public string BoLoc
        {
            set
            {
                if (value != null)
                {
                    value = value.Replace(" ", "");
                    _boLoc = new HashSet<string>(value.Split(','));
                }
            }
            get
            {
                return _boLoc != null ? string.Join(",", _boLoc) : null;
            }
        }

        public SessionQuetEmail()
        {
            _lstEmail = new HashSet<Email>(new EmailComparer());
            _lstLinkDaTruyCap = new HashSet<string>();
            _linkDangQuet = new HashSet<string>();
            _cancel = false;
        }

        public string LinkBanDau
        {
            get
            {
                return _linkBanDau;
            }

            set
            {
                _linkBanDau = value;
                if (_linkBanDau.EndsWith("/"))
                    _linkBanDau = _linkBanDau.Substring(0, _linkBanDau.Length - 1);
            }
        }

        private void AddEmail(IEnumerable<string> emails, string lien_ket)
        {
            int tmp = _lstEmail.Count;
            foreach (string s in emails)
            {
                var em = new Email() {STT=tmp+1, DiaChiEmail = s, LienKet = lien_ket };
                if(this.BoLoc != null && !_boLoc.Contains(em.DiaChiEmail.Split('@')[1]))
                    continue;
                _lstEmail.Add(em);
                if (tmp != _lstEmail.Count && CoEmailMoi != null)
                {
                    if (_cancel)
                        return;
                    CoEmailMoi(em);
                    tmp = _lstEmail.Count;
                }
            }
        }

        public List<Email> DanhSachEmail()
        {
            return _lstEmail.ToList();
        }

        private string ValidateUrl(string url)
        {
            if (url != null)
            {
                url = url.ToLower();
                if (url.Contains("/") && !url.EndsWith(".css") && !url.EndsWith(".jpg") && !url.EndsWith(".png") && !url.EndsWith(".gif"))
                {
                    try
                    {
                        if (url.StartsWith("/"))
                            url = (this.LinkBanDau + url).Replace("///", "//");
                        if (url.Contains("#"))
                            url = url.Split('#')[0];
                        if (url.Contains(this.LinkBanDau))
                            return url;
                    }
                    catch (Exception ex)
                    {
                        return null;
                    }
                }
            }
            return null;
        }
        
        public void QuetLink(object link)
        {
            if (_cancel || link == null)
                return;
            if (this.LinkBanDau == null)
                this.LinkBanDau = link.ToString();
            if (!_lstLinkDaTruyCap.Contains(link.ToString()))
            {
                try
                {
                    if (_cancel)
                        return;

                    _linkDangQuet.Add(link.ToString());
                    List<PropertyBag> collectedLinks = new List<PropertyBag>();
                    new CrawlerConfiguration()
                        .CrawlSeed(link.ToString())
                        .Do((crawler, bag) =>
                        {
                            collectedLinks.Add(bag);
                        })
                        .MaxCrawlCount(1)
                        .Download()
                        .HtmlProcessor()
                        .AddLoggerStep()
                        .Run();
                    Debug.WriteLine(link.ToString());
                    if (_cancel)
                        return;

                    if (collectedLinks.Count > 0 && collectedLinks[0].Text != null)
                    {
                        var danhSachEmail = _validationExpression.Matches( collectedLinks[0].Text).Cast<Match>().Select(p => p.Value).Distinct();

                        this.AddEmail(danhSachEmail, link.ToString());
                        _lstLinkDaTruyCap.Add(link.ToString());
                        if (QuetLinkMoi != null)
                            QuetLinkMoi();

                        foreach (var l in collectedLinks)
                        {
                            #region Nếu Hủy
                            if (_cancel)
                            {
                                try
                                {
                                    _linkDangQuet.UnionWith(collectedLinks.Select(p => Convert.ToString(p.Step.Uri)));
                                }
                                catch { }
                                if (_linkDangQuet.Count == 0)
                                {
                                    _lstLinkDaTruyCap.Remove(link.ToString());
                                    _linkDangQuet.Add(link.ToString());
                                }
                                return;
                            }
                            #endregion

                            string url = l?.Step?.Uri?.ToString() ?? null;
                            url = ValidateUrl(url);
                            if (url != null)
                                ThreadPool.QueueUserWorkItem(QuetLink, url);
                        }
                    }
                }
                catch(Exception ex)
                {
                    Debug.WriteLine($"Lỗi: {link.ToString()}");
                    return;
                }
            }
            _linkDangQuet.Remove(link.ToString());
        }
        //https://github.com/esbencarlsen/NCrawler


        public void TiepTuc()
        {
            _cancel = false;
            foreach (string s in _linkDangQuet)
            {
                string url = ValidateUrl(s);
                if (url != null)
                    ThreadPool.QueueUserWorkItem(QuetLink, url);
            }
        }

        public void DungSession()
        {
            Debug.WriteLine("Hủy");
            _cancel = true;
        }

        public bool LuuSession(string path)
        {
            
            FileInfo f = new FileInfo(path);

            if (!f.Directory.Exists)
                f.Directory.Create();

            FileStream fs = new FileStream(path, FileMode.Create);
            try
            {
                BinaryFormatter bf = new BinaryFormatter();

                bf.Serialize(fs, this);

                fs.Close();

                return true;
            }
            catch(Exception ex)
            {
                fs.Close();
                return false;
            }
        }

        public void LoadSession(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                SessionQuetEmail tmp = (SessionQuetEmail)bf.Deserialize(fs);
                fs.Close();

                this.LinkBanDau = tmp.LinkBanDau ?? null;
                _lstLinkDaTruyCap = tmp._lstLinkDaTruyCap;
                _lstEmail = tmp._lstEmail;
                _linkDangQuet = tmp._linkDangQuet;
                this.SoLuong = tmp.SoLuong;
                _cancel = false;
            }
            catch
            {
                fs.Close();
            }
        }

        public static SessionQuetEmail Load(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                SessionQuetEmail tmp = (SessionQuetEmail)bf.Deserialize(fs);
                fs.Close();
                tmp._cancel = false;
                return tmp;
            }
            catch(Exception ex)
            {
                fs.Close();
                return null;
            }
        }
    }
}
