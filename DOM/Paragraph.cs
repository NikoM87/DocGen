using System.Linq;


namespace DOM
{
    public class Paragraph : Composition
    {
        public Align Align { get; set; }


        public override void Insert( Glyph glyph )
        {
            if ( ChildGlyphs.Count > 0 )
            {
                Glyph lastGlyph = ChildGlyphs.Last();
                if ( ( glyph is Text ) && ( lastGlyph is Text ) )
                {
                    ( (Text) lastGlyph ).Line += ( (Text) glyph ).Line;
                }
                else
                {
                    base.Insert( glyph );
                }
            }
            else
            {
                base.Insert( glyph );
            }
        }


        public override void Accept( Visitor visitor )
        {
            visitor.VisitParagraph( this );
        }
    }
}