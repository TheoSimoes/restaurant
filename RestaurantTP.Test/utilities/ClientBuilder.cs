namespace RestaurantTP.Test.Utilities
{
  internal class ClientBuilder
  {
    private string _nom = string.Empty;

    public ClientBuilder Nommé(string nom)
    {
      _nom = nom;
      return this;
    }

    public Client Build()
    {
      return new Client(_nom);
    }
  }
}
