using NUnit.Framework;
using System;

namespace Tests
{
    [Category("Categoria")]
    [TestFixture(1)]
    public class Tests
    {
        private int data;

        public Tests(int data)
        {
            this.data = data;
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TesteDeIgualdade()
        {
            Assert.AreEqual(1, data);
        }

        [Test]
        public void TesteDeVeracidade()
        {
            Assert.IsTrue(true, "true is true!");
        }

        [Test]
        public void TesteDeExcecoes()
        {
            Assert.Throws<NullReferenceException>(() => { ((object)null).GetType(); });
        }

        [Test]
        public void TesteEmCaracteres()
        {
            StringAssert.Contains("madeira", "Casa de madeira");
        }

        [Test]
        public void TesteEmColecoes()
        {
            CollectionAssert.IsOrdered(new[] { 1, 2, 3 });
        }

        [Test,Ignore("Sem motivo")]
        public void TesteIgnorado()
        {
            CollectionAssert.IsOrdered(new[] { 1, 4,5 });
        }
    }
}