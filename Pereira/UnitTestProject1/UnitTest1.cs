using System;
using Juan;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Prueba_Save()
        {
            //organizar
            Company comp = new Company("frio", 25.36);
            double ValorEsperado = 35.36;



            //actuar
            comp.Save(10);
            double ValorObtenido = comp.SaveProject;


            //afirmar
            Assert.AreEqual(ValorEsperado, ValorObtenido);
        }

        [TestMethod]
        public void Prueba_Spend()
        {
            //organizar
            Company comp = new Company("frio", 25.36);
            double ValorEsperado = 15.36;



            //actuar
            comp.Spend(10);
            double ValorObtenido = comp.SaveProject;


            //afirmar
            Assert.AreEqual(ValorEsperado, ValorObtenido);
        }
        [TestMethod]
        public void Prueba_Nombre()
        {
            //organizar
            Company comp = new Company("frio", 25.36);
            string ValorEsperado = "juan";



            //actuar
            comp.ChangeName("juan");
            string ValorObtenido = comp.Name;


            //afirmar
            Assert.AreEqual(ValorEsperado, ValorObtenido);
        }

    }
}
