using System;
using LibClases;
using EstadisticaClases;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace EstadisticaTests
{
    [TestClass]
    public class TestEstadisticas
    {

        BaseDatos bd = null;
        Estadisticas stats = null;

        [TestInitialize]
        public void inicializar()
        {
            bd = new BaseDatos();

            bd.CargaEncuestaDeCSV(@".\encuestas.csv");
            bd.CargaRespuestaDeCSV(@".\respuestas.csv");
            stats = new Estadisticas(bd);

        }

        [TestMethod]
        public void TestEstadoEncuestas()
        {
            DataTable t = stats.estadoEncuestas();
            DataRow activas = t.Rows[0];
            DataRow inactivas = t.Rows[1];

            Assert.AreEqual(8, activas[0]);
            Assert.AreEqual(0, activas[1]);

        }

        [TestMethod]
        public void TestNumeroEncuestas()
        {
            Assert.AreEqual(6, stats.numeroEncuestas());
        }

        [TestMethod]
        public void TestMedia()
        {
            Assert.AreEqual(2.55, stats.media(), 0.01);
        }

        [TestMethod]
        public void TestMediana()
        {
            Assert.AreEqual(2.5, stats.mediana(), 0.01);
        }

        [TestMethod]
        public void TestDesvest()
        {
            Assert.AreEqual(1.149, stats.desvest(), 0.001);
        }

        [TestMethod]
        public void TestRankingEncuestasPorRespuestas()
        {
            DataTable tabla = stats.rankingEncuestasPorRespuestas();
            DataRow encuestaA = tabla.Rows[0];
            DataRow encuestaG = tabla.Rows[6];

            Assert.AreEqual("Encuesta de prueba A", encuestaA[0]);
            Assert.AreEqual(3, encuestaA[1]);
            Assert.AreEqual("Encuesta de prueba G", encuestaG[0]);
            Assert.AreEqual(0, encuestaG[1]);
        }

        [TestMethod]
        public void TestRankingEncuestasPorValoracion()
        {
            DataTable tabla = stats.rankingEncuestasPorValoracion();
            DataRow encuestaA = tabla.Rows[0];
            DataRow encuestaG = tabla.Rows[6];

            Assert.AreEqual("Encuesta de prueba A", encuestaA[0]);
            Assert.AreEqual(4, encuestaA[1]);
            Assert.AreEqual("Encuesta de prueba G", encuestaG[0]);
            Assert.AreEqual(0, encuestaG[1]);
        }
    }
}
