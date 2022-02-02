﻿using System.Linq;
using RestaurantTpTest.Test.Utilities;
using Xunit;

namespace RestaurantTpTest.Test
{
    public class ServeurTest
    {
        [Fact]
        public void CA_a_0_pour_serveur()
        {
            var serveur = new ServeurBuilder().Nommé("James").Build();

            Assert.Equal(0, serveur.ChiffreAffaires);
        }

        [Fact]
        public void CA_a_0_pour_plusieurs_serveurs()
        {
            var bcpDeServeurs = new ServeurGenerator().Nommés("James").Generate(250);

            Assert.Equal(0, bcpDeServeurs.Sum(serveur => serveur.ChiffreAffaires));
        }

        [Fact]
        public void CA_a_4500_pour_serveur()
        {
            var serveur = new ServeurBuilder().Nommé("James").Build();

            serveur.PrendreCommande(4400);
            serveur.PrendreCommande(100);

            Assert.Equal(4500, serveur.ChiffreAffaires);
        }

        [Fact]
        public void CA_a_25000_pour_plusieurs_serveurs()
        {
            var bcpDeServeurs = new ServeurGenerator().Nommés("James").Generate(100);

            bcpDeServeurs.All(serveur => serveur.PrendreCommande(250));

            Assert.Equal(25000, bcpDeServeurs.Sum(serveur => serveur.ChiffreAffaires));
        }
    }
}
