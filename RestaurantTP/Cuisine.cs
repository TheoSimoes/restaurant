using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantTP
{
    class Cuisine
    {
        public Restaurant restaurant { get; private set; }
        public Cuisine(Restaurant resta)
        {
            restaurant = restaurant;
        }

        public Produit changeStatut(Produit prod){
            prod.Statut = "pret";
            return prod;
        }

    }
}
