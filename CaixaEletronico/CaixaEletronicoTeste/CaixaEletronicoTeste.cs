using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using caixaEletronico;

namespace CaixaEletronicoTeste
{
    [TestClass]
    public class CaixaEletronicoTeste
    {
        [TestMethod]
        public void Retorna1_100()
        {
            CaixaEletronico caixa1 = new CaixaEletronico();

            string NotasUsadas = caixa1.sacar(100);

            //VAI RETORNAR DESSE MESMO JETO A QUANTIDADE DE NOTAS QUE QUER
            Assert.AreEqual("notade100: 1", NotasUsadas);
        }

        [TestMethod]
        public void Retorna2_100()
        {
            CaixaEletronico caixa1 = new CaixaEletronico();

            string NotasUsadas = caixa1.sacar(200);

            Assert.AreEqual("notade100: 2", NotasUsadas);
     
       }

        [TestMethod]
        public void Retorna1_50()
        {
            CaixaEletronico caixa1 = new CaixaEletronico();

            string NotasUsadas = caixa1.sacar(50);

            Assert.AreEqual("notade50: 1", NotasUsadas);
        }

        [TestMethod]
        public void Retorna1_20()
        {
            CaixaEletronico caixa1 = new CaixaEletronico();

            string NotasUsadas = caixa1.sacar(20);

            Assert.AreEqual("notade20: 1", NotasUsadas);
        }

        [TestMethod]
        public void Retorna1_100_1_50()
        {
            CaixaEletronico caixa1 = new CaixaEletronico();

            string NotasUsadas = caixa1.sacar(150);

            Assert.AreEqual("notade100: 1" + "notade50: 1", NotasUsadas);
        }

        [TestMethod]
        public void Retorna1_100_1_50_1_20_1_10()
        {
            CaixaEletronico caixa1 = new CaixaEletronico();

            string NotasUsadas = caixa1.sacar(180);

            Assert.AreEqual("notade100: 1" + "notade50: 1" + 
                            "notade20: 1" + "notade10: 1", NotasUsadas);
        }

        [TestMethod]
        public void Retorna10_100()
        {
            CaixaEletronico caixa1 = new CaixaEletronico();

            string NotasUsadas = caixa1.sacar(1000);

            Assert.AreEqual("notade100: 10" , NotasUsadas);
        }

        [TestMethod]
        public void Retorna10_100_1_50()
        {
            CaixaEletronico caixa1 = new CaixaEletronico();

            string NotasUsadas = caixa1.sacar(1050);

            Assert.AreEqual("notade100: 10" + "notade50: 1", NotasUsadas);
        }

        [TestMethod]
        public void Retorna10_100_1_50_1_20_1_10()
        {
            CaixaEletronico caixa1 = new CaixaEletronico();

            string NotasUsadas = caixa1.sacar(1080);

            Assert.AreEqual("notade100: 10" + "notade50: 1" + "notade20: 1" + "notade10: 1", NotasUsadas);
        }

        [TestMethod]
        public void Retorna8_100_1_50_1_10()
        {
            CaixaEletronico caixa1 = new CaixaEletronico();

            string NotasUsadas = caixa1.sacar(860);

            Assert.AreEqual("notade100: 8" + "notade50: 1" + "notade10: 1", NotasUsadas);
        }

        [TestMethod]
        public void RetornaCedulaIndisponivel()
        {
            CaixaEletronico caixa1 = new CaixaEletronico();

            string NotasUsadas = caixa1.sacar(0);

            Assert.AreEqual("Valor inválido", NotasUsadas);
        }

        [TestMethod]
        public void RetornaNegativo()
        {
            CaixaEletronico caixa1 = new CaixaEletronico();

            string NotasUsadas = caixa1.sacar(-2);

            Assert.AreEqual("Valor inválido", NotasUsadas);
        }

        [TestMethod]
        public void RetornaSemCedula()
        {
            CaixaEletronico caixa1 = new CaixaEletronico();

            string NotasUsadas = caixa1.sacar(133);

            Assert.AreEqual("Cédula indisponível", NotasUsadas);
        }
       
    }
}
