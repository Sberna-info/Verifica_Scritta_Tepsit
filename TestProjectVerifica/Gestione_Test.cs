using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gestione_Tariffa;

namespace TestProjectVerifica
{
    [TestClass]
    public class Gestione_Test
    {
        [DataTestMethod]
        [DataRow(1 , "La tariffa pi� convenite � quella Open 1 mese")]
        [DataRow(2, "La tariffa pi� convenite � quella Open 1 mese X 2")]
        [DataRow(3, "La tariffa pi� convenite � quella Open 3 mese")]
        [DataRow(4, "La tariffa pi� convenite � quella Open 3 mese + Open 1 mese")]
        [DataRow(5, "La tariffa pi� convenite � quella Open 3 mese + Open 1 mese X 2")]
        [DataRow(6, "La tariffa pi� convenite � quella Open 3 mese X 2")]
        [DataRow(7, "La tariffa pi� convenite � quella Open 3 mese X 2 + Open 1 mese")]
        [DataRow(8, "La tariffa pi� convenite � quella Open 3 mese X 2 + Open 1 mese X 2")]
        [DataRow(9, "La tariffa pi� convenite � quella Open 3 mese X 3")]
        [DataRow(10, "La tariffa pi� convenite � quella Open 3 mese X 3 + Open 1 mese")]
        [DataRow(11, "La tariffa pi� convenite � quella Open 3 mese X 3 + Open 1 mese X 2")]
        [DataRow(12, "La tariffa pi� convenite � quella Open 12 mese")]

        public void VerificaTariffe(int mesi, string risultatoAspettato)
        {
            string risposta = Gestione.TariffaConveniente(mesi);
            Assert.AreEqual(risposta, risultatoAspettato);
        }
    }
}
