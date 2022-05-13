using goclinic.Models;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace goclinic.Repos
{
    public class PatientRepositiory
    {
        public List<Patient> GetPatientsByPhoneNumber(string phoneNumber)
        {
            using (IDbConnection connection = new SqlConnection(DBHelper.CnnVal("Patients")))
            {
                List<Patient> patients = new();
                var patientsResults = connection.Query($"SELECT * FROM PatientMainInfo WHERE phoneNumber LIKE '{phoneNumber}%'").Cast<IDictionary<string, object>>().ToList();
                patientsResults.ForEach((IDictionary<string, object> patientDirectionary) =>
                {
                    var patient = Patient.CreateFromData(patientDirectionary);
                    patient.History = GetPatientHistory(connection, patient.Id);
                    patients.Add(patient);
                });
                return patients;

            }





        }

        public void AddNewPatient(Patient patient)
        {
            using (IDbConnection connection = new SqlConnection(DBHelper.CnnVal("Patients")))
            {
                var newPatientId = connection.QuerySingle<int>($"INSERT INTO [dbo].[PatientMainInfo]([name],[phoneNumber] ,[registrationDate] ,[DOB], [bloodType] ,[gender]) OUTPUT INSERTED.id VALUES (N'{patient.Name}','{patient.PhoneNumber}', '{patient.RegistrationDate}', '{patient.BirthDate}', '{patient.ConvertBloodTypeToString()}', {patient.ConvertGenderToInt()})");


                var illness = patient.History!.Illness;
                var health = patient.History!.Health;
                var familyHistory = patient.History.Family;

                InsertPatientIllnessData(illness, connection, newPatientId);
                InsertPatientHealthData(health, connection, newPatientId);
                InsertPatientFamilyHistoryData(familyHistory, connection, newPatientId);

            }
        }

        private History GetPatientHistory(IDbConnection connection, int? patientId)
        {

            var illnessResults = connection.Query($"SELECT * FROM Illness WHERE patientId = '{patientId}'").Cast<IDictionary<string, object>>().ToList();
            var healthResults = connection.Query($"SELECT * FROM Health WHERE patientId = '{patientId}'").Cast<IDictionary<string, object>>().ToList();
            var familyHistoryResults = connection.Query($"SELECT * FROM FamilyHistory WHERE patientId = '{patientId}'").Cast<IDictionary<string, object>>().ToList();

            return new History(illness: Illness.FromData(illnessResults.First()), health: Health.FromData(healthResults.First()), family: FamilyHistory.FromData(familyHistoryResults.First()));
        }

        private void InsertPatientIllnessData(Illness illness, IDbConnection connection, int newPatientId)
        {

            connection.Execute($"INSERT INTO [dbo].[Illness]([patientID],[currentDisease],[diet],[newbornHistory],[developmentHistory],[accidentsHistory],[bloodTransfer]) VALUES ({newPatientId}, N'{illness.CurrentDisease}', N'{illness.Diet}', N'{illness.NewbornHistory}', N'{illness.DevelopmentHistory}', N'{illness.AccidentsHistory}', {(illness.BloodTransfer ? 1 : 0)})");
        }

        private void InsertPatientHealthData(Health health, IDbConnection connection, int newPatientId)
        {


            connection.Execute($"INSERT INTO [dbo].[Health] ([patientID],[medication],[chronicPatient],[repetation],[allergies]) VALUES ({newPatientId}, N'{health.Medication}', N'{health.Chronic}', {(health.Repetation ? 1 : 0)}, N'{health.Allergies}')");


        }

        private void InsertPatientFamilyHistoryData(FamilyHistory family, IDbConnection connection, int newPatientId) {

            connection.Execute($"INSERT INTO [dbo].[FamilyHistory]([patientID],[parentsRelated],[chronicFamily],[chronicDiseases],[sameDiseasesWithParents]) VALUES({newPatientId}, {(family.ParentsRelated ? 1 : 0)}, {(family.ChronicFamily ? 1 : 0)}, N'{family.ChronicDiseases}',{(family.SameDiseasesWithParents ? 1 : 0)})");
        }
    }
}
