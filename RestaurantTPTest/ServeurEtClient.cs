using System.Linq;
using RestaurantTpTest.Test.Utilities;
using Xunit;

namespace RestaurantTpTest.Test
{
  public class ClientTest
  {
    [Fact]
    public void Client_Passe_Commande_a_un_Serveur()
    {
      var damien = new ClientBuilder().Nommé("Damien").Build();
      var serge = new ServeurBuilder().Nommé("Serge").Build();

      
      Assert.Equal(0, damien.montantAPayer);
    }
  }
}
