using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibClases.test
{
    /// <summary>
    /// Descripción resumida de TestEncuesta
    /// </summary>
    [TestClass]
    public class TestEncuesta
    {

        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de las pruebas que proporciona
        ///información y funcionalidad para la serie de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de prueba adicionales
        //
        // Puede usar los siguientes atributos adicionales conforme escribe las pruebas:
        //
        // Use ClassInitialize para ejecutar el código antes de ejecutar la primera prueba en la clase
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para ejecutar el código una vez ejecutadas todas las pruebas en una clase
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Usar TestInitialize para ejecutar el código antes de ejecutar cada prueba 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para ejecutar el código una vez ejecutadas todas las pruebas
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion


        private void meteRespuestas(Encuesta foo)
        {
            foo.AnadirRespuesta(1, "malisima");
            foo.AnadirRespuesta(2, "regulera");
            foo.AnadirRespuesta(2, "regulera");
            foo.AnadirRespuesta(2, "");
            foo.AnadirRespuesta(3, "");
            foo.AnadirRespuesta(3, "pasable");
            foo.AnadirRespuesta(4, "esta buena");
            foo.AnadirRespuesta(1, "malisima");
            foo.AnadirRespuesta(2, "regulera");
            foo.AnadirRespuesta(2, "regulera");
            foo.AnadirRespuesta(2, "");
            foo.AnadirRespuesta(3, "");
            foo.AnadirRespuesta(3, "pasable");
            foo.AnadirRespuesta(4, "esta buena");
            foo.AnadirRespuesta(1, "malisima");
            foo.AnadirRespuesta(2, "regulera");
            foo.AnadirRespuesta(2, "regulera");
            foo.AnadirRespuesta(2, "");
            foo.AnadirRespuesta(3, "");
            foo.AnadirRespuesta(3, "pasable");
            foo.AnadirRespuesta(4, "esta buena");
        }

        [TestMethod]
        public void ProbarGenEncuestas()
        {
            Encuesta foo = new Encuesta(1,"Encuesta Limpieza Lavabos", "estan sucios o no?");
            Assert.AreEqual(foo.Titulo, "Encuesta Limpieza Lavabos");
            Assert.IsTrue(foo.Activa);
            Assert.IsTrue(foo.ObtenerRespuestas().Count == 0);
            Assert.AreEqual(foo.Descripcion, "estan sucios o no?");
        }

        [TestMethod]
        public void ProbarAdicionRespuestas()
        {
            Encuesta foo = new Encuesta(1, "Mercadona", "Valore nuestra pescadilla");
            Assert.IsTrue(foo.ObtenerRespuestas().Count == 0);
            meteRespuestas(foo);
            Assert.IsTrue(foo.ObtenerRespuestas().Count > 0);
            Assert.IsTrue(foo.ObtenerRespuestas().Count == 21);
        }

        [TestMethod]
        public void ProbarLecturaRespuestas()
        {
            Encuesta foo = new Encuesta(1, "Mercadona", "Valore nuestra pescadilla");
            Encuesta egg = new Encuesta(2, "Electrónica Martínez", "Valore el trato");
            meteRespuestas(foo);

            //empieza el id desde el 1
            Assert.IsNull(foo.ObtenerRespuestaPorId(0));

            Assert.AreEqual(foo.ObtenerRespuestaPorId(1).Valoracion, 1);
            Assert.AreEqual(foo.ObtenerRespuestaPorId(1).Descripcion, "malisima");
      
        }

        [TestMethod]
        public void ProbarCambiosRespuestas()
        {
            Encuesta foo = new Encuesta(1, "Mercadona", "Valore nuestra pescadilla");
            meteRespuestas(foo);


            foo.QuitaRespuesta(3);
            Assert.IsNull(foo.ObtenerRespuestaPorId(3));
        }

    }
}
