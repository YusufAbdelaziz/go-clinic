
namespace goclinic.Models
{
   public enum Gender
    {
        Male,
        Female,
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
        ABNegative
    }
    public class Patient
    {

        public Patient(string id, string name, DateTime birthDate, Gender gender, BloodTypes bloodType, History history, string currentComplaint, string previousComplaint)
        {
            this.BirthDate = birthDate;
            this.Gender = gender;
            this.Name = name;
            this.Id = id;
            this.History = history;
            this.CurrentComplaint = currentComplaint;
            this.PreviousComplaint = previousComplaint;
            this.BloodType = bloodType;
        }
        public string? Id { get; set; }
        public string? Name { get; set; }

        public DateTime? BirthDate { get; set; }

        public Gender? Gender { get; set; }

        public BloodTypes? BloodType { get; set; }

        public History? History { get; set; }

        public string? CurrentComplaint { get; set; }

        public string? PreviousComplaint { get; set; }


        public static Patient createFromDB(string id, string name, DateTime birthDate, Gender gender, BloodTypes bloodType, History history, string currentComplaint, string previousComplaint) 
            => new(bloodType: bloodType, id: id, name: name, birthDate: birthDate, gender: gender, currentComplaint: currentComplaint, previousComplaint: previousComplaint, history : history);
    }
}
