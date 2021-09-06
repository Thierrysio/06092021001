using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06092021001.Modeles
{
    public class Commande
    {
        #region attributs
        public static List<Commande> CollClass = new List<Commande>();
        private int _numeroCommande ;
        private DateTime _dateCommande;
        private List<LigneCommande> _lesLignesCommandes;
        #endregion

        #region constructeur
        public Commande()
        {
            Commande.CollClass.Add(this);

            _numeroCommande = Commande.CollClass.Count;
            _dateCommande = DateTime.Now;
            _lesLignesCommandes = new List<LigneCommande>();
        }

        #endregion

        #region getters/setters
        public int NumeroCommande { get => _numeroCommande; set => _numeroCommande = value; }
        public DateTime DateCommande { get => _dateCommande; set => _dateCommande = value; }
        public List<LigneCommande> LesLignesCommandes { get => _lesLignesCommandes; set => _lesLignesCommandes = value; }

        #endregion

        #region methodes

        #endregion
    }
}
