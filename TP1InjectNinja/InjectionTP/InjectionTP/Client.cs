using System.Collections;

namespace InjectionTP
{
    public class Client
    {
        string nom {get; set;}
        string prenom{get; set;}
        string idClient{get; set;}
        public ParamClient i{get; set;}

    public Client(string nom, string prenom,string id,ParamClient i)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.idClient = id;
            this.i = i;
        }


        //Pour vérifier
        public override string ToString()
        {
            return "Le client " + nom + "avec l\'id" + idClient + "de paramètre : " + i;
        }
    }
}