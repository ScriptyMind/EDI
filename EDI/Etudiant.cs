using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI
{
    public class Etudiant : Personne
    {
        private int codeEtudiant;
        private string classe;
        private string languageEutdie;
        private int incr = 1;
        //constructeur 
        public Etudiant(string cin, string nom, string prenom, DateTime dateNaissance, string nomUtilisateur, int motPasse, int codeEtudiant, string classe, string languageEutdie, string image) : base(cin, nom, prenom, dateNaissance, nomUtilisateur, motPasse, image)
        {
            this.codeEtudiant = incr;
            this.classe = classe;
            this.languageEutdie = languageEutdie;
            incr++;

        }

        public string LangageEutdie
        {
            get { return languageEutdie; }
            set { languageEutdie = value; }
        }



        public string Classe
        {
            get { return classe; }
            set { classe = value; }
        }


        public int CodeEtudiant
        {
            get { return codeEtudiant; }
            set { codeEtudiant = value; }
        }
    }
}
