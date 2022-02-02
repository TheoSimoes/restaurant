using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantTP
{
    class Produit
    {

        public float Prix { get; private set; }
        public string Nom { get; private set; }
        public int Stock { get; private set; }
        public string Statut { get; set; }
    
        public Produit(int prix, string nom, int stock, string statut)
        {
            Prix = prix;
            Nom = nom;
            Stock = stock;
            Statut = "non prêt";
        }
    
    }
}
