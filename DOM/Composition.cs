using System.Collections.Generic;


namespace DOM
{
    public abstract class Composition : Glyph
    {
        protected Composition()
        {
            ChildGlyphs = new List<Glyph>();
        }


        public List<Glyph> ChildGlyphs { get; set; }


        public override void Insert( Glyph glyph )
        {
            ChildGlyphs.Add( glyph );
        }
    }
}