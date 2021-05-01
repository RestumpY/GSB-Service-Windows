using Microsoft.VisualStudio.TestTools.UnitTesting;
using PPEGSBFINAL;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            GestionDate DC = new GestionDate();


            string date_now = DC.dateDuJour();
            string date_mois_precedent = DC.dateMoisPrecedent();


            //Test valeurs corrects

            Assert.AreEqual("202103",date_now);
            //Assert.AreEqual("202102", date_mois_precedent);

            //Test valeurs incorrects

            //Assert.AreEqual("202003", date_now);
            //Assert.AreEqual("202103", date_mois_precedent);


        }
    }
}
