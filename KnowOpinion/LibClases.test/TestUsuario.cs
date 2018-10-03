using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibClases;

namespace LibClases.test
{
	[TestClass]
	public class UnitTest2
	{
		[TestMethod]
		public void TestConstructor()
		{
			Usuario u = new Usuario("NoMbRe");
            Assert.AreEqual(u.Cuenta, "NoMbRe");
            Usuario u1 = new Usuario(15,"cuenta1", "PasTWrd");
            Assert.AreEqual(u1.IdUsuario, 15);
            Assert.AreNotEqual(u1.IdUsuario, 5);
            Assert.AreNotEqual(u1.IdUsuario, "");
            Assert.AreEqual(u1.Cuenta, "cuenta1");
            Assert.AreNotEqual(u1.Cuenta, "cuentoti1");
            Assert.AreNotEqual(u1.Cuenta, "");
            Assert.AreEqual(u1.Constrasena, "PasTWrd");
            Assert.AreNotEqual(u1.Constrasena, "NemoSeVa");
            Assert.AreNotEqual(u1.Constrasena, "");
        }
	}
}
