﻿using System;
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

            Usuario u1 = new Usuario(15, "cuenta1", "PasTWrd");
            Assert.AreEqual(u1.IdUsuario, 15);
            Assert.AreNotEqual(u1.IdUsuario, 5);
            Assert.AreNotEqual(u1.IdUsuario, "");
            Assert.AreEqual(u1.Cuenta, "cuenta1");
            Assert.AreNotEqual(u1.Cuenta, "cuentoti1");
            Assert.AreNotEqual(u1.Cuenta, "");
            Assert.AreEqual(u1.Contrasena, "PasTWrd");
            Assert.AreNotEqual(u1.Contrasena, "NemoSeVa");
            Assert.AreNotEqual(u1.Contrasena, "");
        }

        [TestMethod]
        public void TestComprobarContraseña()
        {
            Usuario u = new Usuario(1, "Cuenta365", "Yatube");
            Assert.IsTrue(u.comprobarcontrasena("Yatube"));
            Assert.IsFalse(u.comprobarcontrasena("Nemo"));

        }

        [TestMethod]
        public void TestAsignarContraseña()
        {
            Usuario u = new Usuario(1, "Cuenta36", "ContAsig");
            u.asignacontrasena("tiburcio");
            Assert.IsTrue(u.comprobarcontrasena("tiburcio"));
            Assert.IsFalse(u.comprobarcontrasena("ContAsig"));
        }
    }
}
