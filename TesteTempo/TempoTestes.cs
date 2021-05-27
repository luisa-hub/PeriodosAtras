using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteDATEtIMEConsoleApp1;

namespace TesteTempo
{
    [TestClass]
    public class TempoTestes
    {
        Montagem montagem = new Montagem();
        Periodos periodo1 = new Periodos(2011, 03, 22, 10, 04, 10);
        Periodos periodo2 = new Periodos(2021, 05, 26, 10, 04, 10);

        [TestMethod]
        public void TestPeriodo1()
        {
            Assert.AreEqual("dez anos e  dois meses e  uma semana e  um dia atrás", montagem.ToExtensoDiasEHoras(periodo1));
        }

        [TestMethod]
        public void TestPeriodoHoras()
        {
            Assert.AreEqual("6 horas 2 minutos  atrás", montagem.ToExtensoDiasEHoras(periodo2));
        }


    }
}
