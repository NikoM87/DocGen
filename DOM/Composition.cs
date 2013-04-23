using System.Collections.Generic;

namespace DOM
{
    public class Composition: Glyph
    {
        public Composition()
        {
            Glyphs = new List<Glyph>();
        }

        public List<Glyph> Glyphs { get; set; }
       
        
        public override void Insert( Glyph glyph )
        {
            Glyphs.Add( glyph );
        }

        public override void Accept( HtmlVisitor visitor )
        {
            foreach ( Glyph glyph in Glyphs )
            {
                glyph.Accept( visitor );
            }
        }
    }
}