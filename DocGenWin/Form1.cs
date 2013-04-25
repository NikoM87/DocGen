using System;
using System.Windows.Forms;

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
    }
}