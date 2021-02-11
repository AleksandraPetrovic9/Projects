using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCompany.QueryEntities
{
    public class Zadatak
    {
        public string idZadatka { get; set; }
        public string idRadnika { get; set; }
        public string idVodje { get; set; }
        public string naziv { get; set; }
        public string obavljeno { get; set; }
        public string opis { get; set; }
        public string aktivan { get; set; }
    }
}
