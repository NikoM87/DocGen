using System;


namespace DOM
{
    public class HtmlVisitor : Visitor
    {
        public HtmlVisitor( Glyph glyph )
            : base( glyph )
        {
        }


        public string OuterHtml { get; set; }


        public override void Start()
        {
            OuterHtml += "<html><body>";
            Glyph.Accept( this );
            OuterHtml += "</body></html>";
        }


        public override void VisitText( Text text )
        {
            OuterHtml += text.Line;
        }


        public override void VisitParagraph( Paragraph paragraph )
        {
            string param = " ";
            switch ( paragraph.Align )
            {
                case Align.Center:
                    param += "align=center";
                    break;
            }

            OuterHtml += String.Format( "<p{0}>", param );
            foreach ( Glyph glyph in paragraph.ChildGlyphs )
            {
                glyph.Accept( this );
            }
            OuterHtml += "</p>";
        }


        public override void VisitImage( Image image )
        {
            OuterHtml += String.Format( "<img src=\"{0}\"/>", image.Url );
        }
    }
}