using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafaPieShop.Models
{
     public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();

        Pie GetPieById (int pieId);

    }
}

