using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWE.Lib
{
    [Serializable]
    class Email
    {
        public int STT { set; get; }
        public string DiaChiEmail { set; get; }
        public string LienKet { set; get; }
        public override bool Equals(object obj)
        {
            return this.DiaChiEmail.Equals(((Email)obj).DiaChiEmail);
        }

        public override int GetHashCode()
        {
            return this.DiaChiEmail.GetHashCode();
        }
    }

    [Serializable]
    class EmailComparer : IEqualityComparer<Email>
    {
        public bool Equals(Email x, Email y)
        {
            return x.DiaChiEmail.Trim().ToLower().Equals(y.DiaChiEmail.Trim().ToLower());
        }

        public int GetHashCode(Email obj)
        {
            return obj.DiaChiEmail.GetHashCode();
        }
    }
}
