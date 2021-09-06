using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06092021001.Modeles
{
    public class LigneCommande
    {
        #region attributs
        public static List<LigneCommande> CollClass = new List<LigneCommande>();
        private int _quantite;
        private Produit _leProduit;


        #endregion

        #region constructeur

        public LigneCommande(int quantite, Produit leProduit)
        {
            _quantite = quantite;

            LigneCommande.CollClass.Add(this);
            _leProduit = leProduit;
        }

        #endregion

        #region getters/setters
        public int Quantite { get => _quantite; set => _quantite = value; }
        public Produit LeProduit { get => _leProduit; set => _leProduit = value; }

        #endregion

        #region methodes

        #endregion
    }
}
