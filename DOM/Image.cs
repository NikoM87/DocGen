using System;


namespace DOM
{
    public class Image : Glyph
    {
        public Uri Url;


        public Image( string url )
        {
            Url = new Uri( url );
        }


        public override void Insert( Glyph glyph )
        {
            throw new Exception();
        }


        public override void Accept( Visitor visitor )
        {
            visitor.VisitImage( this );
        }
    }
}