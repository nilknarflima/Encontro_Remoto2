using Projeto_teste;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteMSteste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {
            // -> AAA <-
            //Arrange = prepara��o  (forma simplificada "um a um")

            double pNum = 1;
            double Snum = 1;
            double rNum = 2;

            //Act = A��o
            var resultado = Operacoes.Somar(pNum, Snum);

            // Assert = Verifica��o
            Assert.AreEqual(rNum, resultado); 


        }

        //Arrange  EXEMPLO 2
        [DataTestMethod]
        [DataRow(1,1,2)]
        [DataRow(2,2,4)]
        [DataRow(2,1,2)]
        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //Act = a��o
            var resultado = Operacoes.Somar(pNum, sNum);

            // Assert = Verifica��o
          Assert.AreEqual(rNum, resultado);
        }

    }
}