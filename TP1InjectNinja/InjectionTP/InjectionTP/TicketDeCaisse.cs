using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjectionTP
{
    class TicketDeCaisse
    {
        IChargementParametres i;

        // Méthode 1 pour injection
        public TicketDeCaisse(IChargementParametres newI) {
            this.i = newI;
            }

        public ParamClient getParamClientTicket(string id) {
            Client c = this.i.getClient(id);
            return i.getParamClient(c);

}
        // Méthode 2 pour injection
        public void SetChargementParametres(IChargementParametres newI)
        {
            this.i = newI;
        }
    }
}
