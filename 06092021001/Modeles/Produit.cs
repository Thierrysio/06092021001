using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06092021001.Modeles
{
    public class Produit
    {
        #region attributs
        public static List<Produit> CollClass = new List<Produit>();
        private int _codeProduit;
        private string _nom;
        private int prix;



        #endregion

        #region constructeur
        public Produit(int codeProduit, string nom, int prix)
        {
            _codeProduit = codeProduit;
            _nom = nom;
            this.prix = prix;

            Produit.CollClass.Add(this);
        }

        #endregion

        #region getters/setters
        public int CodeProduit { get => _codeProduit; set => _codeProduit = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public int Prix { get => prix; set => prix = value; }

        #endregion

        #region methodes

        #endregion
    }
}
