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

        public string? ChronicDiseases{ get; set; }

        public bool SameDiseasesWithParents { get; set; }

        public FamilyHistory() {
        
        }
    }
}
