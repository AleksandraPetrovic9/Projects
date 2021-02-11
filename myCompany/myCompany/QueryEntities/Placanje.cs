using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCompany.QueryEntities
{
    public class Placanje
    {
        public string idPlate { get; set; }
        public string idRadnika { get; set; }
        public DateTime datumIsplate { get; set; }
        public string idVodje { get; set; }
        public string idSefa { get; set; }
        public int iznos { get; set; }
    }
}
