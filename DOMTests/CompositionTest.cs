using DOM;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DOMTests
{
    [TestClass]
    public class CompositionTest
    {
        [TestMethod]
        public void TestInsert()
        {
            Composition composition = new Composition();
            Composition pasted = new Composition();

            composition.Insert( pasted );

            Assert.AreEqual( 1, composition.Glyphs.Count );
            Assert.AreEqual( pasted, composition.Glyphs[0] );
        }
    }
}
