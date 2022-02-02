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

        Commande(Serveur leServeur, Client leClient)
        {
            LeServeur = leServeur;
            LeClient = leClient;
        }

        public void AjouterUnProduit(Produit propro)
        {

        }

        public void EnleverUnProduit(Produit propro)
        {

        }

        public void AjouterDesProduits(List<Produit> lesPropro)
        {

        }

        public void EnleverDesProduits(List<Produit> lesPropro)
        {

        }

        public float ObtenirLaSommeDesProduits()
        {
            float sommeDesProduits = 0;
            foreach(Produit produit in LesProduits)
            {
                sommeDesProduits += produit.Prix;
            }
            return sommeDesProduits;
        }
    }
}
