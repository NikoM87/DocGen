using System;


namespace DOM
{
    public class Text : Glyph
    {
        public Text( string line )
        {
            Line = line;
        }


        public string Line { get; set; }


        public override void Insert( Glyph glyph )
        {
            if ( glyph is Text )
            {
                Line += ( glyph as Text ).Line;
            }
            else
            {
                throw new Exception();
            }
        }


        public override void Accept( Visitor visitor )
        {
            visitor.VisitText( this );
        }
    }
}