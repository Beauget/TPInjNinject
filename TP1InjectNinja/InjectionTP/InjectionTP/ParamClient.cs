namespace InjectionTP
{
    public class ParamClient
    {
        public string chaine;

        public ParamClient(string newChaine)
        {
            this.chaine = newChaine;
        }

        public override string ToString()
        {
            return chaine;
        }

    }
}