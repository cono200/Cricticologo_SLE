using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CRITICOGRAFO__SLE
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        string opcion;
        string opcionAlta;
        string opcionFea;
        string opcionLista;
        string opcionExtravagante;
        string opcionGrande;
        string opcionRaro;
        bool genero;
        string generoLetras;
        private void Button_Clicked(object sender, EventArgs e)
        {
           

            if (mujer.IsChecked)
            {
                string[] opciones = new string[6];
                int contador = 0;
                if (Alto.IsChecked)
                {
                    opciones[contador] = "alta";
                    contador++;
                }
                if (Feo.IsChecked)
                {
                    opciones[contador] = "fea";
                    contador++;
                }
                if (Listo.IsChecked)
                {
                    opciones[contador] = "lista";
                    contador++;
                }
                if (Extravagante.IsChecked)
                {
                    opciones[contador] = "extravagante";
                    contador++;
                }
                if (Grande.IsChecked)
                {
                    opciones[contador] = "grande";
                    contador++;
                }
                if (Raro.IsChecked)
                {
                    opciones[contador] = "rara";
                    contador++;
                }

                string resultado = "";
                if (contador > 1)
                {
                    for (int i = 0; i < contador - 1; i++)
                    {
                        resultado += opciones[i] + ", ";
                    }
                    resultado += "y " + opciones[contador - 1];
                }
                else if (contador == 1)
                {
                    resultado = opciones[0];
                }

                Resultado.Text = Nombre + " es " +  resultado;
            }




            //var nombre = Nombre.Text;
            //// string resultado = "";
            //// int resultado = 0;
            //string[] opciones = new string[6];
            //int contador = 0;

            //if (mujer.IsChecked)
            //{
            //    if (Alto.IsChecked)
            //    {
            //        opciones[contador] = "alta";
            //        contador++;
            //    }
            //    if (Feo.IsChecked)
            //    {
            //        opciones[contador] = "fea";
            //        contador++;
            //    }
            //    if (Listo.IsChecked)
            //    {
            //        opciones[contador] = "lista";
            //        contador++;
            //    }
            //    if (Extravagante.IsChecked)
            //    {
            //        opciones[contador] = "extravagante";
            //        contador++;
            //    }
            //    if (Grande.IsChecked)
            //    {
            //        opciones[contador] = "grande";
            //        contador++;
            //    }
            //    if (Raro.IsChecked)
            //    {
            //        opciones[contador] = "rara";
            //        contador++;
            //    }

            //    string resultado = "";
            //    if (contador > 1)
            //    {
            //        resultado = nombre + " es " + string.Join(", ", opciones.Take(contador - 1)) + " y " + opciones[contador - 1];
            //    }
            //    else if (contador == 1)
            //    {
            //        resultado = opciones[0];
            //    }

            //    Resultado.Text = resultado;
            //}
            //else
            //{

            //}






        }
    }
}
            
            
            
   