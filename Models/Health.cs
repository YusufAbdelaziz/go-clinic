using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goclinic.Models
{
    public class Health
    {
        public string Chronic { get; set; }

        public bool Repetation { get; set; }

        public string Medication { get; set; }

        public string Allergies { get; set; }

        public Health(string chronic, bool repetation, string medication, string allergies)
        {
            Chronic = chronic;
            Repetation = repetation;
            Medication = medication;
            Allergies = allergies;
        }

        public static Health FromData(IDictionary<string, object> healthDictionary) {

            return new Health(chronic: healthDictionary["chronicPatient"].ToString()!, repetation: healthDictionary["repetation"].ToString()! == "1" ? true : false, medication : healthDictionary["medication"].ToString()!, allergies: healthDictionary["allergies"].ToString()!);
                
        }
    }
}
