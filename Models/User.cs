

namespace goclinic.Models
{
    internal class User
    {
        private User() { }
        private static User? instance = null;
        public int Id { get; set; }
        public string? Name { get; set; }
        public static User Instance { 
            get {
                if (instance == null) {
                    instance = new User(); 
                }
                return instance;
            }
        }

        public void InitFromData(string name, int id) {
            this.Name = name;
            this.Id = id;   
        }
    }
}
