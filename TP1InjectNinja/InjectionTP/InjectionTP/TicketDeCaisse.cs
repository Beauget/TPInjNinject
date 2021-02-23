using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjectionTP
{
    class TicketDeCaisse
    {
        // On remplace les références ChargementsParametres par celle de l'interface
        IChargementParametres i;
        
        public TicketDeCaisse(IChargementParametres newI) {
            this.i = newI;
            }

        public ParamClient getParamClientTicket(string id) {
            Client c = this.i.getClient(id);
            return i.getParamClient(c);

}
    }
}
