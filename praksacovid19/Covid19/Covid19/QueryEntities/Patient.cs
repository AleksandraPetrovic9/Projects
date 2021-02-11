using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19.QueryEntities
{
    public class Patient
    {
        public string patient_id { get; set; }
        public string sex { get; set; }
        public string age { get; set; }
        public string infection_case { get; set; }
        public string contact_number { get; set; }
        public string symptom_onset_date { get; set; }
        public string confirmed_date { get; set; }
        public string released_date { get; set; }
        public string state { get; set; }

    }
}
