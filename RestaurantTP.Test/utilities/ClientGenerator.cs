using System.Collections.Generic;

namespace RestaurantTP.Test.Utilities
{
  internal class ClientGenerator
  {
    private ClientBuilder _builder = new ();

    public ClientGenerator Nommés(string nom)
    {
      _builder = _builder.Nommé(nom);
      return this;
    }

    public IEnumerable<Client> Generate(int howMany)
    {
      for (var i = 0; i < howMany; i++)
      {
        yield return _builder.Build();
      }
  }
  }
}
