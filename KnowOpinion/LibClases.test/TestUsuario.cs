using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibClases;

namespace LibClases.test
{
    [TestClass]
    public class TestUsuario
    {
        [TestMethod]
        public void TestConstructor()
        {

            Usuario u = new Usuario("NoMbRe");
            Assert.AreEqual(u.Cuenta, "NoMbRe");

            Usuario u1 = new Usuario("cuenta1", "PasTWrd");
            Assert.AreNotEqual(u1.Cuenta, "cuentoti1");
            Assert.AreNotEqual(u1.Cuenta, "");
            Assert.AreEqual(u1.Contrasena, "PasTWrd");
            Assert.AreNotEqual(u1.Contrasena, "NemoSeVa");
            Assert.AreNotEqual(u1.Contrasena, "");
        }

        [TestMethod]
        public void TestComprobarContraseña()
        {
            Usuario u = new Usuario("Cuenta365", "Yatube");
            Assert.IsTrue(u.comprobarcontrasena("Yatube"));
            Assert.IsFalse(u.comprobarcontrasena("Nemo"));

        }

        [TestMethod]
        public void TestAsignarContrasena()
        {
            Usuario u = new Usuario("Cuenta36", "ContAsig");
            u.asignacontrasena("tiburcio");
            Assert.IsTrue(u.comprobarcontrasena("tiburcio"));
            Assert.IsFalse(u.comprobarcontrasena("ContAsig"));
        }

        [TestMethod]
        public void TestGrabarContrasena()
        {
            Usuario u = new Usuario("Cuenta36", "ContAsig");
            Assert.IsFalse(u.Grabado);
            u.grabarcontrasena();
            Assert.IsTrue(u.Grabado);
        }
    }
}
