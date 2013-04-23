using System;
using DOM;

namespace DocGen
{
    class Program
    {
        static void Main()
        {
            Paragraph doc = new Paragraph();
            doc.Insert( new Text( "Hello" ) );
            doc.Insert( new Text( " world" ) );
            doc.Align = Align.Center;

            HtmlVisitor htmlVisitor = new HtmlVisitor(doc);
            
            htmlVisitor.Start();
            Console.WriteLine( htmlVisitor.OuterHtml );
            Console.ReadKey();
        }
    }
}
