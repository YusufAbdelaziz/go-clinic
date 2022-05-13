using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goclinic.Models
{
    public class History
    {
        public Illness Illness { get; set; }

        public Health Health { get; set; }

        public FamilyHistory Family { get; set; }

        public History(Illness illness, Health health, FamilyHistory family)
        {
            Illness = illness;
            Health = health;
            Family = family;
        }



        public static History FromData(IDictionary<string, object> illnessDictionary, IDictionary<string, object> healthDictionary, IDictionary<string, object> familyDictionary)
        {

            return new History(illness: Illness.FromData(illnessDictionary), health: Health.FromData(healthDictionary), family: FamilyHistory.FromData(familyDictionary));
        }
    }
}
