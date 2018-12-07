using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex32_linkedlist
{
    public class ClubMember
    {
        private int nr;
        private string fNavn;
        private string eNavn;
        private int alder;
        public int Nr
        {
            get { return nr; }
            set { nr = value; }
        }
        public string FNavn
        {
            get { return fNavn; }
            set { fNavn = value; }
        }
      
        public string ENavn
        {
            get { return eNavn; }
            set { eNavn = value; }
        }
        public int Alder
        {
            get { return alder; }
            set { alder = value; }
        }

        public ClubMember(int nr, string fNavn, string eNavn, int alder)
        {
            Nr = nr;
            FNavn = fNavn;
            ENavn = eNavn;
            Alder = alder;
        }
        public override string ToString()
        {
            string result = null;
            result += $"{Nr} {FNavn} {ENavn} {Alder}";
            return result;
        }
    }
}
