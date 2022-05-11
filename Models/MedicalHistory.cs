using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goclinic.Models
{
    internal class MedicalHistory
    {
        public string? ChronicDiseases { get; set; }

        public string? DrugHistory { get; set; }

        public int? DiseaseRepetition { get; set; }

        public string? Allergies { get; set; }


        public MedicalHistory() { 
        
        }

    }
}
