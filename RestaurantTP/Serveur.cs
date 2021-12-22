using System;


namespace RestaurantTP
{
    public class Serveur
    {
        public string Nom { get; private set; }
        public decimal Salaire { get; private set; }
        public decimal ChiffreAffaires { get; private set; }

        public Serveur(string nom, decimal salaire)
        {
            Nom = nom;
            Salaire = salaire;
            ChiffreAffaires = 0;
        }
        public void PrendreCommande(decimal montantCommande)
        {
            ChiffreAffaires += montantCommande;
        }

    }
}
