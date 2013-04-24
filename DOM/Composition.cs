using System.Collections.Generic;


namespace DOM
{
    public class Composition : Glyph
    {
        public Composition()
        {
            ChildGlyphs = new List<Glyph>();
        }


        public List<Glyph> ChildGlyphs { get; set; }


        public override void Insert( Glyph glyph )
        {
            ChildGlyphs.Add( glyph );
        }


        public override void Accept( Visitor visitor )
        {
            foreach ( Glyph glyph in ChildGlyphs )
            {
                glyph.Accept( visitor );
            }
        }
    }
}