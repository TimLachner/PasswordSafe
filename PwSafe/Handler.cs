using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PwSafe
{
    class Handler
    {
        String path;
        Char Seperator = 'Ѩ';

        public Handler(String pathToFile)
        {
            this.path = pathToFile;
        }

        public bool saveAll(List<Passwort> pwList)
        {


            String PwEncoded = "";
            foreach (var pw in pwList)
            {
                PwEncoded += pw.toStringWithSep() + Seperator;

            }

            string PwEncodedClean = PwEncoded.Substring(0, PwEncoded.Length - 1);



            File.WriteAllText(path, PwEncodedClean);
            return true;
        }

        public List<Passwort> load()
        {
            List<Passwort> listToLoad = new List<Passwort>();
            String PwEncoded = File.ReadAllText(path);
            String[] Pws = PwEncoded.Split(Seperator);




            for (int i = 0; i < Pws.Length; i++)
            {
                string[] PwPieces = Pws[i].Split('Ѭ');

                Passwort loadedPw = new Passwort(Convert.ToInt32(PwPieces[0]), PwPieces[1], PwPieces[2], PwPieces[3], PwPieces[4], PwPieces[5], PwPieces[6]);
                listToLoad.Add(loadedPw);
            }


            return listToLoad;
        }
    }
}