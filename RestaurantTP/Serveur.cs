using System;


namespace RestaurantTP
{
    public class Serveur
    {
        public string Nom { get; private set; }
        public float ChiffreAffaires { get; private set; }

        public Serveur(string nom, decimal salaire)
        {
            Nom = nom;
            ChiffreAffaires = 0;
        }
        public Commande PrendreCommande(Client client, List<Produit> produits)
        {   
            Commande commande = new Commande(this, client);
            commande.AjouterDesProduits(produits);
            ChiffreAffaires += commande.ObtenirLaSommeDesProduits();
            return commande;
        }

    }
}
