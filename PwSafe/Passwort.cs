using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PwSafe
{
    public class Passwort
    {
        Char Seperator = 'Ѭ';

        private int id;
        private String titel;
        private String category;
        private String uname;
        private String pass;
        private String website;
        private String Infos;

        public Passwort(int id, String titel, String category, String uname, String pass, String website, String Infos)
        {
            this.id = id;
            this.titel = titel;
            this.category = category;
            this.uname = uname;
            this.pass = pass;
            this.website = website;
            this.Infos = Infos;
        }

        public String toStringWithSep()
        {

            return this.id.ToString() + Seperator + this.titel + Seperator + this.category + Seperator + this.uname + Seperator + this.pass + Seperator + this.website + Seperator + this.Infos;
        }
    }
}