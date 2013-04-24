using DOM;

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace DOMTests
{
    [TestClass]
    public class TextTest
    {
        [TestMethod]
        public void TestInsert()
        {
            var textHello = new Text( "Hello" );
            Glyph textWorld = new Text( "World" );

            textHello.Insert( textWorld );

            Assert.AreEqual( "HelloWorld", textHello.Line );
        }
    }
}