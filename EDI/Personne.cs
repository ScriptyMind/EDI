using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI
{
    public class Personne
    {
        //champs
        private string cin;
        private string nom;
        private string prenom;
        private DateTime dateNaissance;
        private string nomUtilisateur;
        private int motPasse;
        private string image;

        //constructeur avec tout les parametres
        public Personne(string cin, string nom, string prenom, DateTime dateNaissance, string nomUtilisateur, int motPasse, string image)
        {
            this.cin = cin;
            this.nom = nom;
            this.dateNaissance = dateNaissance;
            this.prenom = prenom;
            this.motPasse = motPasse;
            this.nomUtilisateur = nomUtilisateur;
            this.image = image;

        }
        //propreites

        public int MotPasse
        {
            get { return motPasse; }
            set { motPasse = value; }
        }


        public string NomUtilisateur
        {
            get { return nomUtilisateur; }
            set { nomUtilisateur = value; }
        }



        public DateTime DateNaissance
        {
            get { return dateNaissance; }
            set { dateNaissance = value; }
        }


        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }


        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }


        public string Cin
        {
            get { return cin; }
            set { cin = value; }
        }
        public string Image
        {
            get { return image; }
            set { image = value; }
        }



    }
}
