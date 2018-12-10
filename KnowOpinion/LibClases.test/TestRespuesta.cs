using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibClases.test
{
    [TestClass]
    public class TestRespuesta
    {
        [TestMethod]
        public void PruebaRespuesta()
        {
            DateTime fecha = DateTime.Now;
            Respuesta r1 = new Respuesta(1, 1,"Muy mal", fecha);
            Respuesta r2 = new Respuesta(2, 2, "mal", fecha);
            Respuesta r3 = new Respuesta(3, 3, "bien", fecha);
            Respuesta r4 = new Respuesta(4, 4, "Muy bien", fecha);
            Respuesta rvacia = new Respuesta(5, 420, "Este valor es inválido", fecha);

            Assert.AreEqual(r1.Valoracion, 1);
            Assert.AreEqual(r2.Valoracion, 2);
            Assert.AreEqual(r3.Valoracion, 3);
            Assert.AreEqual(r4.Valoracion, 4);
            Assert.AreEqual(rvacia.Valoracion, 0);

        }
    }
}
