
namespace goclinic.Models
{
    public enum GenderTypes
    {
        Male,
        Female,
        Unknown

    }

    public enum BloodTypes
    {
        ANegative,
        APositive,
        BNegative,
        BPositive,
        OPositive,
        ONegative,
        ABPostive,
        ABNegative,
        Unknown
    }
    public class Patient
    {

        public Patient(int id, string name, DateTime birthDate, GenderTypes gender, BloodTypes bloodType, string phoneNumber, DateTime registrationDate)
        {
            this.BirthDate = birthDate;
            this.Gender = gender;
            this.Name = name;
            this.Id = id;
            this.BloodType = bloodType;
            this.PhoneNumber = phoneNumber;
            this.RegistrationDate = registrationDate;
        }
        public int? Id { get; set; }
        public string? Name { get; set; }

        public string? PhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }

        public DateTime? RegistrationDate { get; set; }
        public GenderTypes? Gender { get; set; }

        public BloodTypes? BloodType { get; set; }

        public History? History { get; set; }


        public static Patient CreateFromData(IDictionary<string, object> patientDictionary)
        {
            return new(bloodType: MapBloodTypeTextToValue((patientDictionary[key: "bloodType"] ?? "").ToString()!.Trim()), id: int.Parse(patientDictionary[key: "id"].ToString()!), name: patientDictionary[key: "name"].ToString()!.Trim(), birthDate: DateTime.Parse((patientDictionary[key: "DOB"] ?? "").ToString()!), gender: MapBinaryValueToGender((byte)patientDictionary[key: "gender"]), phoneNumber: patientDictionary[key: "phoneNumber"].ToString()!, registrationDate: DateTime.Parse(patientDictionary["registrationDate"].ToString()!));
        }

        private static BloodTypes MapBloodTypeTextToValue(string bloodTypeText)
        {
            switch (bloodTypeText)
            {
                case "AB+": return BloodTypes.ABPostive;
                case "AB-": return BloodTypes.ABNegative;
                case "A+": return BloodTypes.APositive;
                case "A-": return BloodTypes.ANegative;
                case "B+": return BloodTypes.BPositive;
                case "B-": return BloodTypes.BNegative;
                case "O+": return BloodTypes.OPositive;
                case "O-": return BloodTypes.ONegative;
                default: return BloodTypes.Unknown;
            }
        }

        public string ConvertBloodTypeToString()
        {
            switch (BloodType)
            {
                case BloodTypes.ABPostive: return "AB+";
                case BloodTypes.ABNegative: return "AB-";
                case BloodTypes.APositive: return "A+";
                case BloodTypes.ANegative: return "A-";
                case BloodTypes.BPositive: return "B+";
                case BloodTypes.BNegative: return "B-";
                case BloodTypes.OPositive: return "O+";
                case BloodTypes.ONegative: return "O-";
                default: return "Unknown";
            }

        }

        private static GenderTypes MapBinaryValueToGender(byte gender)
        {
            if (gender == 0) return GenderTypes.Female;
            if (gender == 1) return GenderTypes.Male;
            return GenderTypes.Unknown;

        }

        public int ConvertGenderToInt() {
            if (Gender == GenderTypes.Female) return 0;
            else return 1;
           

        }
    }
}
