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
            
            var nombre = Nombre.Text;
            string resultado = "";


            if (mujer.IsChecked)
            {
                if (Alto.IsChecked)
                {
                    opcionAlta += "alta";

                }
                if (Feo.IsChecked)
                {
                    opcionFea += "fea";
                }
                if (Listo.IsChecked)
                {
                    opcionLista += "lista";
                }
                if (Extravagante.IsChecked)
                {
                    opcionExtravagante += "extravagante";
                }
                if (Grande.IsChecked)
                {
                    opcionGrande += "grande";
                }
                if (Raro.IsChecked)
                {
                    opcionRaro += "rara";
                }
                resultado = nombre + " es "   + opcionAlta +  "," + opcionFea + "," +  opcionLista + "," + opcionExtravagante + ","  + opcionGrande + "," + opcionRaro;
            } 
            else
            {
                generoLetras = "hombre";


                if (Alto.IsChecked)
                {
                    opcion += "alto";

                }
                if (Feo.IsChecked)
                {
                    opcion += "feo";
                }
                if (Listo.IsChecked)
                {
                    opcion += "listo";
                }
                if (Extravagante.IsChecked)
                {
                    opcion += "extravagante";
                }
                if (Grande.IsChecked)
                {
                    opcion += "grande";
                }
                if (Raro.IsChecked)
                {
                    opcion += "raro";
                }
                
            }
            Resultado.Text = resultado.ToString();
            
           




        }
    }
}
