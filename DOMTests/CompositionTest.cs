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
            var composition = new Paragraph();
            var pasted = new Paragraph();

            composition.Insert( pasted );

            Assert.AreEqual( 1, composition.ChildGlyphs.Count );
            Assert.AreEqual( pasted, composition.ChildGlyphs[0] );
        }
    }
}