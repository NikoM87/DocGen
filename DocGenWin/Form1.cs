using System;
using System.Collections;
using System.Windows.Forms;
using System.Xml;

using DOM;


namespace DocGenWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1Load( object sender, EventArgs e )
        {
            var doc = new Document();
            doc.Insert( new Image( @"http://upload.wikimedia.org/wikipedia/commons/6/63/Wikipedia-logo.png" ) );
            doc.Insert( new Text( "Hello" ) );
            doc.Insert( new Text( " world" ) );

            var htmlVisitor = new HtmlVisitor( doc );
            var treeViewVisitor = new TreeViewVisitor( doc, treeView1 );

            htmlVisitor.Start();
            treeViewVisitor.Start();

            webBrowser1.DocumentText = htmlVisitor.OuterHtml;
            richTextBox1.Text = htmlVisitor.OuterHtml;
        }


        private void Button1Click( object sender, EventArgs e )
        {
            var xml = new XmlDocument();
            xml.LoadXml( richTextBox1.Text );

            TreeNode root = treeView2.Nodes.Add( xml.ToString() );

            PrintXmlNode( root, xml.ChildNodes );
        }


        void PrintXmlNode( TreeNode root, IEnumerable nodes )
        {
            foreach ( XmlNode node in nodes )
            {
                var r = new TreeNode( node.Name );
                root.Nodes.Add( r );

                PrintXmlNode(r, node.ChildNodes );
            }
        }
    }
}