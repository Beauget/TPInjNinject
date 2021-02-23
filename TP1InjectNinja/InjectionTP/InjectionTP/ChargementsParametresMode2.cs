namespace InjectionTP
{
    public class ChargementsParametresMode2 : IChargementParametres
    {
        public Client getClient(string s)
        {
            return new Client("Test", "Jean2", s, new ParamClient("jeune un peu moins dynamique"));
        }
        public ParamClient getParamClient(Client c)
        {
            return c.i;
        }
    }
}