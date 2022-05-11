using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goclinic.Models
{
    public class History
    {
        public string? Nutritional { get; set; }
        public string? Newborn { get; set; }

        public SurgicalHistory? Surgical { get; set; }

        public MedicalHistory? Medical { get; set; }

        public FamilyHistory? Family { get; set; }

        public History() {
        
        }

    }
}
