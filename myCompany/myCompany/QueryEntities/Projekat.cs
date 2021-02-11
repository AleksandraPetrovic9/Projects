using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCompany.QueryEntities
{
    public class Projekat
    {

        public string idProjekta { get; set; }
        public DateTime datumKraja { get; set; }
        public DateTime datumPocetka { get; set; }
        public string idSefa { get; set; }
        public string idVodje { get; set; }
        public string naziv { get; set; }
        public string prioritet { get; set; }
        public DateTime rok { get; set; }
    }
}
