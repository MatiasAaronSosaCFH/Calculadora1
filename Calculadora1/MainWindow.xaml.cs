using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Calculadora1
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

        private void Button_Click(object sender, RoutedEventArgs e) // 0
        {
            if (Calculado.Text == "Calculado" || Calculado.Text == Resultado.ToString()) Calculado.Text = "0";
            else Calculado.Text = Calculado.Text + "0";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // 1
        {
            if (Calculado.Text == "Calculando" || Calculado.Text == Resultado.ToString()) Calculado.Text = "1";
            else Calculado.Text = Calculado.Text + "1";

        }
        private void Button_Click_2(object sender, RoutedEventArgs e) // 2
        {
            if (Calculado.Text == "Calculando" || Calculado.Text == Resultado.ToString()) Calculado.Text = "2";
            else Calculado.Text = Calculado.Text + "2";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) // 3
        {
            if (Calculado.Text == "Calculando" || Calculado.Text == Resultado.ToString()) Calculado.Text = "3";
            else Calculado.Text = Calculado.Text + "3";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e) // 4
        {
            if (Calculado.Text == "Calculando" || Calculado.Text == Resultado.ToString()) Calculado.Text = "4";
            else Calculado.Text = Calculado.Text + "4";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e) // 5
        {
            if (Calculado.Text == "Calculando" || Calculado.Text == Resultado.ToString()) Calculado.Text = "5";
            else Calculado.Text = Calculado.Text + "5";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e) // 6
        {
            if (Calculado.Text == "Calculando" || Calculado.Text == Resultado.ToString()) Calculado.Text = "6";
            else Calculado.Text = Calculado.Text + "6";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e) // 7
        {
            if (Calculado.Text == "Calculando" || Calculado.Text == Resultado.ToString()) Calculado.Text = "7";
            else Calculado.Text = Calculado.Text + "7";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e) // 8
        {
            if (Calculado.Text == "Calculando" || Calculado.Text == Resultado.ToString()) Calculado.Text = "8";
            else Calculado.Text = Calculado.Text + "8";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e) // 9
        {
            if (Calculado.Text == "Calculando" || Calculado.Text == Resultado.ToString()) Calculado.Text = "9";
            else Calculado.Text = Calculado.Text + "9";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e) // X multiplicacion
        {
            numer = Calculado.Text;
            Calculado.Text = null;
            numero1 = double.Parse(numer);
            signo = "*";

        }

        private void Button_Click_11(object sender, RoutedEventArgs e) //  / division 
        {
            numer = Calculado.Text;
            Calculado.Text = null;
            numero1 = double.Parse(numer);
            signo = "/";

        }

        private void Button_Click_12(object sender, RoutedEventArgs e)// - resta 
        {
            numer = Calculado.Text;
            Calculado.Text = null;
            numero1 = double.Parse(numer);
            signo = "-";
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)// . punto
        {
            if (Calculado.Text != "Calculado") Calculado.Text = Calculado.Text + ".";

        }

        private void Button_Click_14(object sender, RoutedEventArgs e)// = igual 
        {
            numer = Calculado.Text;
            numero2 = double.Parse(numer);
            Calculo(numero1, numero2, signo);
            Calculado.Text = Resultado.ToString();            
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)// + suma 
        {            
            numer = Calculado.Text;
            Calculado.Text = null;
            numero1 = double.Parse(numer);
            signo = "+";

        }

        private void Button_Click_16(object sender, RoutedEventArgs e)// CE borrar
        {
            Calculado.Text = null;

        }

        

        public double Calculo(double num1, double num2, string signo)
        {
            switch (signo)
            {

                case "+":

                Resultado = num1 + num2;
                    break;

                case "/":

                    Resultado = num1 / num2;
                    break;

                case "*":

                    Resultado = num1 * num2;
                    break;

                case "-":

                    Resultado = num1 - num2;
                    break;

            }


            return Resultado;
        }        

        private string numer;
        private string signo = null;

        

        private double numero1, Resultado, numero2;
    }
}
