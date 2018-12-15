using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class InformationAboutOwner
    {
        private string Address;
        private string Proffesion;
        private int IQ;

        public int iq
        {
            get { return IQ; }
            set { IQ = value; }
        }


        public string profession
        {
            get { return Proffesion; }
            set { Proffesion = value; }
        }


        public string address
        {
            get { return Address; }
            set { Address = value; }
        }
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();

            if (this.iq == 0)
            {
                info.AppendLine("Too smart");


            }
            else
            {
                info.AppendLine(string.Format("IQ: {0}", this.iq));
                info.AppendLine(string.Format("Address: {0}", this.address));
                info.AppendLine(string.Format("Proffesion: {0}", this.profession));
            }
            return info.ToString();
        }
    }
}
