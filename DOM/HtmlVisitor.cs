using System;

namespace DOM
{
    public class HtmlVisitor
    {
        private readonly Glyph _glyph;
        public string OuterHtml { get; set; }

        public HtmlVisitor( Glyph glyph )
        {
            _glyph = glyph;
        }

        public void Start()
        {
            OuterHtml += "<html><body>";
            VisitParagraph( ( _glyph as Paragraph ) );
            OuterHtml += "</body></html>";
        }

        public void VisitText( Text text )
        {
            OuterHtml += text.Line;
        }

        public void VisitParagraph( Paragraph paragraph )
        {
            string param = " ";
            switch ( paragraph.Align )
            {
                case Align.Center:
                    param += "align=center";
                    break;
            }

            OuterHtml += String.Format( "<p{0}>", param );
            paragraph.Accept( this );
            OuterHtml += "</p>";
        }
    }
}