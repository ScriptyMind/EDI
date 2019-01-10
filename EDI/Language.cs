using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI
{
    public class Language
    {
        private string type;
        private string nom;
        private string duree;
        private string image;

        public Language() { }

        public Language(string type, string nom, string duree,string image)
        {
            this.type = type;
            this.nom = nom;
            this.duree = duree;
            this.image = image;

        }

        public string Duree
        {
            get { return duree; }
            set { duree = value; }
        }


        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }


        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Image
        {
            get { return image; }
            set { image = value; }
        }

    }
}
