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

namespace Prog122_lecture11_advRTB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // FlowDocument
        // Paragraph (Block element)
        // Run (Inline element)

        FlowDocument fdDisplay = new FlowDocument();

        public MainWindow()
        {
            InitializeComponent();

            
        }
        public void Something()
        {
            Paragraph para1 = new Paragraph();
            Run run1 = new Run("prog 122 - Jonathan Reed"); // creating a sentence
            run1.Background = new SolidColorBrush(Colors.BlueViolet);
            para1.Inlines.Add(run1); // adding a sentence to our paragrash
            para1.Background = new SolidColorBrush(Colors.DarkCyan);
            fdDisplay.Blocks.Add(para1); // adding a paragraph to our document
            //fdDisplay.Background = new SolidColorBrush(Colors.DarkRed);
            rtbDisplay.Document = fdDisplay; // add our document to out ritch text box
            rtbDisplay.Background = new SolidColorBrush(Color.FromRgb(70, 2, 70));
            rtbDisplay.Document = fdDisplay;
        }
        public void Example()
        {
            //Paragraph p = new Paragraph();
            //Run r = new Run("Hi all");
            //r.FontWeight = FontWeights.Bold;
            //r.Foreground = new SolidColorBrush(Color.FromArgb());

            //fdDisplay.Blocks.Add(p);
            //rtbDisplay.Document = fdDisplay;
        }

        private void btnDisplayInfo_Click(object sender, RoutedEventArgs e)
        {
            Paragraph newParagraph= new Paragraph();

            string subjectline = txtSubjectLine.Text;
            string body = runDisplay.Text;

            Run newRun = new Run(subjectline + body);
            newRun.Foreground = new SolidColorBrush(Colors.Red);
            newRun.FontSize= 24;

            newParagraph.Inlines.Add(newRun);
            newParagraph.Inlines.Add("\n");

            fdDisplay.Blocks.Add(newParagraph);

        }
    }
}
