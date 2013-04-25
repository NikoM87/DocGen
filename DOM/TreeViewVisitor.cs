using System.Collections.Generic;
using System.Windows.Forms;


namespace DOM
{
    public class TreeViewVisitor : Visitor
    {
        private readonly TreeView _treeView;
        private TreeNode _root;
        private readonly Stack<TreeNode> _stack;


        public TreeViewVisitor( Glyph doc, TreeView treeView )
            : base( doc )
        {
            _treeView = treeView;
            _stack = new Stack<TreeNode>();
        }


        public override void Start()
        {
            var node = new TreeNode( "root" );
            _treeView.Nodes.Add( node );
            _stack.Push( node );
            Glyph.Accept( this );
        }


        public override void VisitText( Text text )
        {
            _root = _stack.Pop();
            _root.Nodes.Add( new TreeNode( text.ToString() ) );
        }


        public override void VisitParagraph( Paragraph paragraph )
        {
            var node = new TreeNode( paragraph.ToString() );
            _root = _stack.Pop();

            _root.Nodes.Add( node );
            foreach ( Glyph glyph in paragraph.ChildGlyphs )
            {
                _stack.Push( node );
                glyph.Accept( this );
            }
        }


        public override void VisitImage( Image image )
        {
            _root = _stack.Pop();
            _root.Nodes.Add( new TreeNode( image.ToString() ) );
        }


        public override void VisitDocument( Document document )
        {
            var node = new TreeNode( document.ToString() );
            _root = _stack.Pop();
            
            _root.Nodes.Add( node );
            foreach ( Glyph glyph in document.ChildGlyphs )
            {
                _stack.Push( node );
                glyph.Accept( this );
            }
        }
    }
}