using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitSamples.Tiket
{
    public interface ITicketService
    {
        int GetTicketPrice(int ticketId);
    }
}
