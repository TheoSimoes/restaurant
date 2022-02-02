using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantTP
{
    class Commande
    {
        public Serveur LeServeur { get; private set; }
        public Client LeClient { get; private set; }
        public List<Produit> LesProduits { get; private set; }

        Commande()
        {
            
        }

        public float ObtenirLaSommeDesProduits()
        {
            float sommeDesProduits;
            foreach(Produit produit in LesProduits)
            {
                sommeDesProduits += produit.Prix;
            }
        }
    }
}
