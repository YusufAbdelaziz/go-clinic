using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goclinic.Models
{
    public class FamilyHistory
    {
        public bool ParentsRelated { get; set; }

        public string? ChronicDiseases { get; set; }

        public bool SameDiseasesWithParents { get; set; }

        public bool ChronicFamily { get; set; }

        public FamilyHistory(bool parentsRelated, string? chronicDiseases, bool sameDiseasesWithParents, bool chronicFamily)
        {
            ParentsRelated = parentsRelated;
            ChronicDiseases = chronicDiseases;
            SameDiseasesWithParents = sameDiseasesWithParents;
            ChronicFamily = chronicFamily;
        }

        public static FamilyHistory FromData(IDictionary<string, object> data)
        {

            return new FamilyHistory(parentsRelated: bool.Parse(data["parentsRelated"].ToString()!), chronicDiseases: data["chronicDiseases"].ToString(), sameDiseasesWithParents: bool.Parse(data["sameDiseasesWithParents"].ToString()!), chronicFamily: bool.Parse(data["chronicFamily"].ToString()!));

        }
    }
}
