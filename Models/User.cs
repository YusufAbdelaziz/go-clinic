
namespace goclinic.Models
{
    public class User
    {

        private static User? instance = null;
        private User()
        { }
        public int? Id { get; set; }
        public string? Name { get; set; }

        public string? Phonenumber { get; set; }

        public string? Password { get; set; }

        public static User Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new User();
                }
                return instance;
            }
        }

        public void InitFromData(string name, int id, string phoneNumber)
        {
            this.Name = name;
            this.Id = id;
            this.Phonenumber = phoneNumber;
        }


    }
}
