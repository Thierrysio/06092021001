using Microsoft.VisualStudio.TestTools.UnitTesting;
using _06092021001.Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06092021001.Modeles.Tests
{
    [TestClass()]
    public class ClientTests
    {
        [TestMethod()]
        public void GetMesProduitsTest()
        {
            // creation des objets
            Produit P1 = new Produit(01, "lessive", 12);
            Produit P2 = new Produit(02, "savon", 5);

            Client C1 = new Client();

            Commande CO1 = new Commande();
            Commande CO2 = new Commande();

            C1.LesCommandes.Add(CO1);
            C1.LesCommandes.Add(CO2);

            LigneCommande LC1 = new LigneCommande(2, P1);
            LigneCommande LC2 = new LigneCommande(2, P2);

            CO1.LesLignesCommandes.Add(LC1);
            CO1.LesLignesCommandes.Add(LC2);

            LigneCommande LC3 = new LigneCommande(4, P1);
            LigneCommande LC4 = new LigneCommande(4, P2);
            
            CO2.LesLignesCommandes.Add(LC1);
            CO2.LesLignesCommandes.Add(LC2);

            // Lancement de la methode

            List<Produit> listTest = new List<Produit>();
            listTest = C1.GetMesProduits();

            // Assert
            Assert.AreEqual(5,listTest.Count);
        }
    }
}