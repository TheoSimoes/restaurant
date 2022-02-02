using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantTP.Test.Utilities
{
    internal class ServeurBuilder
    {
        private string _nom = string.Empty;

        public ServeurBuilder Nomme(string nom)
        {
            _nom = nom;
            return this;
        }

        public Serveur Build()
        {
            return new Serveur(_nom, 0);
        }
    }
}
