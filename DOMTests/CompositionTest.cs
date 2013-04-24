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
            var composition = new Composition();
            var pasted = new Composition();

            composition.Insert( pasted );

            Assert.AreEqual( 1, composition.ChildGlyphs.Count );
            Assert.AreEqual( pasted, composition.ChildGlyphs[0] );
        }
    }
}