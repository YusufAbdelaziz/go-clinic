namespace goclinic.Models
{
    public class Illness
    {

        public string CurrentDisease { get; set; }

        public string Diet { get; set; }
        public string NewbornHistory { get; set; }

        public string DevelopmentHistory { get; set; }

        public string AccidentsHistory { get; set; }

        public bool BloodTransfer { get; set; }
        public Illness(string currentDisease, string diet, string newbornHistory, string developmentHistory, string accidentsHistory, bool bloodTransfer)
        {
            CurrentDisease = currentDisease;
            Diet = diet;
            NewbornHistory = newbornHistory;
            DevelopmentHistory = developmentHistory;
            AccidentsHistory = accidentsHistory;
            BloodTransfer = bloodTransfer;
        }

        public static Illness FromData(IDictionary<string, object> illnessDictionary)
        {
            return new Illness(currentDisease: illnessDictionary["currentDisease"].ToString()!, diet: illnessDictionary["diet"].ToString()!, newbornHistory: illnessDictionary["newbornHistory"].ToString()!, developmentHistory: illnessDictionary["developmentHistory"].ToString()!, accidentsHistory: illnessDictionary["accidentsHistory"].ToString()!, bloodTransfer: illnessDictionary["bloodTransfer"].ToString()! == "1" ? true : false);
        }


    }
}
