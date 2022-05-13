
namespace goclinic.Models
{
    public class User
    {
        public User(string username, string phoneNumber, int id, string password)
        {
            this.UserName = username;
            this.Id = id;
            this.Phonenumber = phoneNumber;
            this.Password = password;
        }
        public int Id { get; set; }
        public string UserName { get; set; }

        public string Phonenumber { get; set; }

        public string Password { get; set; }

    }
}
