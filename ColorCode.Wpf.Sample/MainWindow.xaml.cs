using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ColorCode.Wpf.Sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var formatter = new RichTextBoxFormatter();
            formatter.FormatRichTextBox("public void Method()\n{\n}", Languages.CSharp, codeBlock1);
            var p = new Paragraph();
            formatter.FormatInlines("<root>\n\t<a name='test'>\n\t</a>\n</root>", Languages.Xml, p.Inlines);
            codeBlock2.Document.Blocks.Add(p);
        }
    }
}
