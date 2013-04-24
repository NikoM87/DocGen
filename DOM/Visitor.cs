namespace DOM
{
    public abstract class Visitor
    {
        protected Glyph Glyph;


        protected Visitor( Glyph glyph )
        {
            Glyph = glyph;
        }


        public abstract void Start();

        public abstract void VisitText( Text text );

        public abstract void VisitParagraph( Paragraph paragraph );


        public abstract void VisitImage( Image image );
    }
}