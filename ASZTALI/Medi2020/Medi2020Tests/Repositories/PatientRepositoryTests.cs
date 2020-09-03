using System;
using Medi2020.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Medi2020.Repositories.Tests
{
    [TestClass()]
    public class PatientRepositoryTests
    {
        [TestMethod()]
        public void ValidatePatientTest_TajNemTartalmazKotojelet()
        {
            var patientRepository = new PatientRepository();
            var patient = new patient("123456789", "taron", "Turcsányi", "Áron Bálint", 6725, "Szeged",
                "Példa utca 45.",
                "turcsanyi@gmail.com", "06202345783");

            try
            {
                patientRepository.ValidatePatient(patient);
            }
            catch (Exception)
            {
                return;
            }

            Assert.Fail("Elbukik a teszt nem jó bemenetre.");
        }

        [TestMethod()]
        public void ValidatePatientTest_IranyitoszamNemSzam()
        {
            var patientRepository = new PatientRepository();
            int.TryParse("x", out int iranyitoszam);

            var patient = new patient("123-456-789", "taron", "Turcsányi", "Áron Bálint", iranyitoszam, "Szeged",
                "Példa utca 45.",
                "turcsanyi@gmail.com", "06202345783");

            try
            {
                patientRepository.ValidatePatient(patient);
            }
            catch (Exception)
            {
                return;
            }

            Assert.Fail("Elbukik a teszt nem jó bemenetre.");
        }
    }
}
