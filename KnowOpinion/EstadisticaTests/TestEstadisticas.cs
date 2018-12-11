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

            Assert.AreEqual(8, activas[1]);
            Assert.AreEqual(0, inactivas[1]);

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

        [TestMethod]
        public void TestRespuestasPorAnios()
        {
            DataTable t = stats.respuestasPorAnios();

            DataRow yr2k = t.Rows[0];

            Assert.AreEqual(2000, yr2k[0]);
            Assert.AreEqual(18, yr2k[1]);

        }

        [TestMethod]
        public void TestRespuestasPorMeses()
        {
            DataTable t = stats.respuestasPorMeses();

            DataRow jan = t.Rows[0];

            Assert.AreEqual("enero", jan[0]);
            Assert.AreEqual(18, jan[1]);
        }

        [TestMethod]
        public void TestRespuestasPorSemanas()
        {
            DataTable t = stats.respuestasPorSemanas();

            DataRow mon = t.Rows[0];
            DataRow thu = t.Rows[3];

            Assert.AreEqual("lunes", mon[0]);
            Assert.AreEqual(3, mon[1]);

            Assert.AreEqual("jueves", thu[0]);
            Assert.AreEqual(2, thu[1]);
        }

        [TestMethod]
        public void TestRespuestasPorHoras()
        {
            DataTable t = stats.respuestasPorHoras();

            DataRow morning = t.Rows[10]; //10:00
            DataRow lateNight = t.Rows[0]; //0:00

            Assert.AreEqual(10, morning[0]);
            Assert.AreEqual(1, morning[1]);

            Assert.AreEqual(0, lateNight[0]);
            Assert.AreEqual(1, lateNight[1]);
        }

        [TestMethod]
        public void TestMediaPorEncuesta()
        {
            DataTable t = stats.mediaPorEncuesta();

            DataRow e1 = t.Rows[0];
            DataRow e7 = t.Rows[6]; //no tiene respuestas

            Assert.AreEqual("Encuesta de prueba A", e1[0]);
            Assert.AreEqual(3.66, (double)e1[1], 0.01);

            Assert.AreEqual("Encuesta de prueba G", e7[0]);
            Assert.AreEqual(0.0, e7[1]);
        }

        [TestMethod]
        public void TestMedianaPorEncuesta()
        {
            DataTable t = stats.medianaPorEncuesta();

            DataRow e1 = t.Rows[0];
            DataRow e7 = t.Rows[6]; //no tiene respuestas

            Assert.AreEqual("Encuesta de prueba A", e1[0]);
            Assert.AreEqual(4.0, e1[1]);

            Assert.AreEqual("Encuesta de prueba G", e7[0]);
            Assert.AreEqual(0.0, e7[1]);
        }

        [TestMethod]
        public void TestDesvEstPorEncuesta()
        {
            DataTable t = stats.desvEstPorEncuesta();

            DataRow e2 = t.Rows[0];
            DataRow e7 = t.Rows[6]; //no tiene respuestas

            Assert.AreEqual("Encuesta de prueba E", e2[0]);
            Assert.AreEqual(1.73, (double)e2[1], 0.01);

            Assert.AreEqual("Encuesta de prueba G", e7[0]);
            Assert.AreEqual(0.0, e7[1]);
        }

        [TestMethod]
        public void TestNumRespRangosPorEncuesta()
        {
            DataRow encuestaA = stats.numRespRangosPorEncuesta(1).Rows[0];
            DataRow encuestaB = stats.numRespRangosPorEncuesta(2).Rows[0];

            Assert.AreEqual("Encuesta de prueba A", encuestaA[0]);
            Assert.AreEqual(3, encuestaA[1]);
            Assert.AreEqual(4, encuestaA[2]);

            Assert.AreEqual("Encuesta de prueba B", encuestaB[0]);
            Assert.AreEqual(2, encuestaB[1]);
            Assert.AreEqual(4, encuestaB[2]);
        }

        [TestMethod]
        public void TestNumRespRangos()
        {
            DataTable t = stats.numRespRangos();
            DataRow encuestaA = t.Rows[0];
            DataRow encuestaB = t.Rows[1];

            Assert.AreEqual("Encuesta de prueba A", encuestaA[0]);
            Assert.AreEqual(3, encuestaA[1]);
            Assert.AreEqual(4, encuestaA[2]);

            Assert.AreEqual("Encuesta de prueba B", encuestaB[0]);
            Assert.AreEqual(2, encuestaB[1]);
            Assert.AreEqual(4, encuestaB[2]);
        }
    }
}
