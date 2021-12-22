namespace LeGrandRestaurant
{
    public class Serveur
    {
        public String Nom { get; private set; }
        public decimal Salaire { get; private set; }
        public decimal ChiffreAffaires { get; private set; }

        public Serveur(string nom, decimal salaire)
        {
            Nom = nom;
            Salaire = salaire;
        }
        public void PrendreCommande(decimal montantCommande)
        {
            ChiffreAffaires += montantCommande;
        }

    }
}
