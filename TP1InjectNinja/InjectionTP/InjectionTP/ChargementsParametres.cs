using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjectionTP
{
    public class ChargementsParametres : IChargementParametres

    {
        public ChargementsParametres(){ }

        public Client getClient(string s) {

            return new Client("Test","Jean","DE67ETDG",new ParamClient("jeune dynamique"));
            }
        public ParamClient getParamClient(Client c) {
            return c.i;
    }

    }
}
