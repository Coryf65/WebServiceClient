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

namespace WebServiceClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// SOAP WebServices Client Side
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MyWebService.MyWebServiceSoapClient client = new MyWebService.MyWebServiceSoapClient();

            string helloString = client.HelloWorld();

            txtOutput.Text = helloString;

        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double value1 = Convert.ToDouble(txtInput1.Text);

            double value2 = Convert.ToDouble(txtInput2.Text);

            MyWebService.MyWebServiceSoapClient client = new MyWebService.MyWebServiceSoapClient();

            double result = client.addNumbers(value1, value2);

            txtOutput.Text = "Result: " + result;
        }
    }
}
