using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI
{
    public class Professeur : Personne
    {
        private int codeProf;
        private Language languageEnseignee;
        private int incr = 1; 
        //constructeur
        public Professeur(string cin, string nom, string prenom, DateTime dateNaissance, string nomUtilisateur, int motPasse, Language languageEnseignee,  string image) : base(cin, nom, prenom, dateNaissance, nomUtilisateur, motPasse, image)
        {
            this.codeProf = incr;
            this.languageEnseignee = languageEnseignee;
            incr++;

        }

        


        public Language LanguageEnseignee
        {
            get { return languageEnseignee; }
            set { languageEnseignee = value; }
        }





        public int CodeProf
        {
            get { return codeProf; }
            set { codeProf = value; }
        }
    }
}
