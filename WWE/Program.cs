using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WWE.Lib.Security;

namespace WWE
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmMain main = new frmMain();
            try
            {
                var keys = File.ReadAllLines(ConstFilePath.FILE_KEY);
                DateTime? hanSuDung = null;

                foreach (string k in keys)
                {
                    hanSuDung = Crypto.VerifySignature(k);
                    if (hanSuDung != null)
                        break;
                }

                if (hanSuDung != null && hanSuDung >= DataUseForSecurity.GetReadDate())
                {
                    Application.Run(main);
                }
                else
                {
                    if (new frmVerify().ShowDialog() == DialogResult.OK)
                        Application.Run(main);
                }
            }
            catch
            {
                if (new frmVerify().ShowDialog() == DialogResult.OK)
                    Application.Run(main);
            }
        }
    }
}
