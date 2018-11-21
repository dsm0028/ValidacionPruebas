using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibClases.test
{
    [TestClass]
    public class TestDB
    {
        public void GeneracionEncuestas(BaseDatos foo)
        {
            foo.AddEncuesta("Pole", "Subpole");
            foo.AddEncuesta("Prueba", "Prueba otra vez");
            foo.AddEncuesta("No hay dos", "sin tres");
        }

        [TestMethod]
        public void PruebaObtencionEncuestas()
        {
            BaseDatos foo = new BaseDatos();
            GeneracionEncuestas(foo);

            Assert.AreEqual(foo.ObtenerActivas().Count, foo.ObtenerTodas().Count);
            Assert.AreEqual(foo.ObtenerActivas().Count, 6);
            Assert.AreEqual(6, foo.ObtenerTodas().Count);
        }

        [TestMethod]
        public void PruebaAdicionEncuesta()
        {
            BaseDatos foo = new BaseDatos();
            Assert.AreEqual(foo.ObtenerTodas().Count, 3); //se generan al lanzar la BD para que la web funcione.
            GeneracionEncuestas(foo);
            Assert.AreNotEqual(foo.ObtenerTodas().Count, 3);
        }

        [TestMethod]
        public void PruebaObtencionEncuesta()
        {
            BaseDatos foo = new BaseDatos();
            GeneracionEncuestas(foo);

            //debemos empezar desde el id = 1
            Assert.AreEqual(foo.GetEncuestaById(1).Titulo, "Prueba 1");
            Assert.IsNull(foo.GetEncuestaById(0));

        }

        [TestMethod]
        public void PruebaBorradoEncuesta()
        {
            BaseDatos foo = new BaseDatos();
            GeneracionEncuestas(foo);

            Assert.IsNotNull(foo.GetEncuestaByTitulo("Pole"));
            foo.BorraEncuesta("Pole");
            Assert.IsNull(foo.GetEncuestaByTitulo("Pole"));
        }

        [TestMethod]
        public void PruebaIniciarSesion()
        {
            BaseDatos foo = new BaseDatos();
            bool intento = foo.Login("NoSoyElAdmin", "aaaaaaaaahsjdga");
            Assert.IsFalse(intento);
            Assert.IsFalse(foo.Autenticado);

            bool intento2 = foo.Login("comandante666", "jofrillos");
            Assert.IsTrue(intento2);
            Assert.IsTrue(foo.Autenticado);
        }

        [TestMethod]
        public void PruebaCerrarSesion()
        {
            BaseDatos foo = new BaseDatos();
            bool inicio = foo.Login("comandante666", "jofrillos");
            Assert.IsTrue(inicio);
            Assert.IsTrue(foo.Autenticado);

            bool cierre = foo.Logoff();
            Assert.IsTrue(cierre);
            Assert.IsFalse(foo.Autenticado);
        }

        [TestMethod]
        public void PruebaManipuladoRespuestas()
        {
            BaseDatos foo = new BaseDatos();
            GeneracionEncuestas(foo);

            foreach (Encuesta item in foo.ObtenerTodas())
            {
                item.AnadirRespuesta(1, "malisima");
                item.AnadirRespuesta(2, "regulera");
                item.AnadirRespuesta(2, "regulera");
                item.AnadirRespuesta(2, "");
                item.AnadirRespuesta(3, "");
                item.AnadirRespuesta(3, "pasable");
                item.AnadirRespuesta(4, "esta buena");
                item.AnadirRespuesta(1, "malisima");
                item.AnadirRespuesta(2, "regulera");
                item.AnadirRespuesta(2, "regulera");
                item.AnadirRespuesta(2, "");
                item.AnadirRespuesta(3, "");
                item.AnadirRespuesta(3, "pasable");
                item.AnadirRespuesta(4, "esta buena");
                item.AnadirRespuesta(1, "malisima");
                item.AnadirRespuesta(2, "regulera");
                item.AnadirRespuesta(2, "regulera");
                item.AnadirRespuesta(2, "");
                item.AnadirRespuesta(3, "");
                item.AnadirRespuesta(3, "pasable");
                item.AnadirRespuesta(4, "esta buena");
            }

            Assert.AreEqual(foo.GetEncuestaByTitulo("Pole").ObtenerRespuestaPorId(1).Valoracion, 1);
            Assert.AreEqual(foo.GetEncuestaByTitulo("Prueba").ObtenerRespuestaPorId(6).Valoracion, 3);

            foo.ActualizaRespuesta(6, 6, 1, "Terrible.");
            Assert.AreEqual(foo.GetEncuestaById(6).ObtenerRespuestaPorId(6).Descripcion, "Terrible.");
            foo.BorraRespuesta(4, 1);
            Assert.IsNull(foo.GetEncuestaById(4).ObtenerRespuestaPorId(1));
            Assert.IsNotNull(foo.GetEncuestaById(1).ObtenerRespuestaPorId(1));

        }
    }
}
