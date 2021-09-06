using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06092021001.Modeles
{
    public class Client
    {
        #region attributs
        public static List<Client> CollClass = new List<Client>();
        private string _nom;
        private string _prenom;
        private List<Commande> _lesCommandes;
        #endregion

        #region constructeur
        public Client()
        {
            _nom = "Disney";
            _prenom = "riri";
            _lesCommandes = new List<Commande>();

            Client.CollClass.Add(this);

        }
        public Client(string nom)
        {
            _nom = nom;

        }
        public Client(string nom, string prenom)
        {
            _nom = nom;
            _prenom = prenom;
        }

        #endregion

        #region getters/setters
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public List<Commande> LesCommandes { get => _lesCommandes; set => _lesCommandes = value; }

        #endregion

        #region methodes
        public List<Commande> GetMesCommandes()
        {
            List<Commande> resultat = new List<Commande>();

            foreach (Commande uneCommande in this.LesCommandes)
            {
                resultat.Add(uneCommande);
            }

            return resultat;
        }
/// <summary>
/// 01- parcours des commandes
/// 02- parcours les lignes de produits commandés par commande
/// 03- recuperation de chaque produit dans une liste
/// </summary>
/// <returns>la liste de tous les produits commandés</returns>
        public List<Produit> GetMesProduits()
        {
            List<Produit> resultat = new List<Produit>();

            foreach (Commande uneCommande in this.LesCommandes)
            {
                foreach (LigneCommande uneLigneCommande in uneCommande.LesLignesCommandes)
                {
                    resultat.Add(uneLigneCommande.LeProduit);
                }
            }

            return resultat;

        }
        #endregion

    }
}
