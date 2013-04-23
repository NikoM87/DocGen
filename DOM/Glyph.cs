namespace DOM
{
    public abstract class Glyph
    {
        public abstract void Insert( Glyph glyph );
        public abstract void Accept( HtmlVisitor visitor );
    }
}
