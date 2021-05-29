using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U6_A1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            unsafe
            {
                 int Valor;
                Valor = Int32.Parse(textBox1.Text);
                 int* puntero = null;
                 puntero = &Valor;
                /* Console.Title = "Trabajando con punteros en C#";*/
                /* Console.WriteLine("Digite un valor entero: ");*/
                /*  Valor = int.Parse(Console.ReadLine());*/
                Valor = 10;
                 Console.WriteLine("\nEl numero ingresado es: " + Valor);
                 Console.WriteLine("El valor al que apunta el puntero es: " + (int)*puntero);
                 Console.WriteLine("La direccion de memoria de la variable Valor es: " + (int)puntero);
               
                label3.Text =("El numero ingresado es: " + Valor.ToString());
                label4.Text =("El valor al que apunta el puntero es: " + Convert.ToString((int)*puntero)) ;
                label5.Text = ("La direccion de memoria de la variable Valor es: " + Convert.ToString((int)puntero));
               /* label6.Text = Convert.ToString((int)*puntero);*/

                puntero = puntero + 1;
                Console.WriteLine("La direccion de memoria de la variable Valor incrementada en uno  es: " + (int)puntero);
                label7.Text =("La direccion de memoria de la variable Valor incrementada en uno  es: " + Convert.ToString((int)puntero));
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
