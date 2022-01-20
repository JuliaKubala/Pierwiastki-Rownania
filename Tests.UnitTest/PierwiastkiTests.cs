using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pierwiastki.UnitTest
{
    internal class PierwiastkiTests
    {
        [Test]
        public void Pierwiastki_WhenCalled_ShouldReturnBrak()
        {
            var pierwiastki = new PierwiastkiFunkcji();

            var result = pierwiastki.Pierwiastki(1, 1, 1);

            Assert.AreEqual("Brak pierwiastkow rzeczywistych", result);
        }
        [Test]
        public void Pierwiastki_WhenCalled_ShouldReturnx1()
        {
            var pierwiastki = new PierwiastkiFunkcji();

            var result = pierwiastki.Pierwiastki(1, 2, 1);

            Assert.AreEqual("x0 = -1", result);
        }
        [Test]
        public void Pierwiastki_WhenCalled_ShouldReturnx1andx2()
        {
            var pierwiastki = new PierwiastkiFunkcji();

            var result = pierwiastki.Pierwiastki(1, 4, 3);

            Assert.AreEqual("x1 = -3 x2 = -1", result);
        }
    }
}
