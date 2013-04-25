namespace DOM
{
    public class Document: Composition
    {
        public override void Accept( Visitor visitor )
        {
            visitor.VisitDocument( this );
        }
    }
}