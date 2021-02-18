namespace InjectionTP
{
    public interface IChargementParametres
    {

        Client getClient(string s);
        ParamClient getParamClient(Client c);
    }
}