using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoFinal;
using System;
using System.IO;

namespace IdentifierTests
{
    [TestClass]
    public class IdentifierTests
    {
        StringWriter strWriter;

        [TestInitialize]
        public void TestInit()
        {
            strWriter = new StringWriter();
            Console.SetOut(strWriter);
            Console.SetError(strWriter);
        }

        [TestMethod]
        public void TestValidClasses() // 1,3,5
        {
            Identifier identifier = new Identifier("a1");
            identifier.ValidateIdentifier();
            identifier.OutputResult();

            var result = strWriter.ToString().TrimEnd();

            Assert.AreEqual(result, "Valido", "Assert falhou");
        }
    }
}
