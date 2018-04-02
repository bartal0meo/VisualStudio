using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
   
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            double a, b, c;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);


            c = a + b;

            textBlock1.Text = c.ToString();

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            double a, b, c;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);


            c = a - b;

            textBlock1.Text = c.ToString();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {


            double a, b, c;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);



            c = a * b;

            textBlock1.Text = c.ToString();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            double a, b, c;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            

            
            try
            {

                if (b == 0|| a == 0)
                {
                    MessageBox.Show("Attempted divide by zero.");
                }
                else
                {
                    c = a / b;
                    textBlock1.Text = c.ToString();
                }
            }
            catch 
            {
                
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBlock1.Text="";

        }
    }
}
