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
            // string resultado = "";
            int resultado = 0;

            if (mujer.IsChecked)
            {
                if (Alto.IsChecked)
                {
                    opcionAlta += "alta";

                }
                if(!Alto.IsChecked)
                {
                    opcionAlta = "";
                }
                if (Feo.IsChecked)
                {
                    opcionFea += "fea";
                }
                if (!Feo.IsChecked)
                {
                    opcionFea ="";
                }
                if (Listo.IsChecked)
                {
                    opcionLista += "lista";
                }
                if (!Listo.IsChecked)
                {
                    opcionLista ="";
                }
                if (Extravagante.IsChecked)
                {
                    opcionExtravagante += "extravagante";
                }
                if (!Extravagante.IsChecked)
                {
                    opcionExtravagante ="";
                }
                if (Grande.IsChecked)
                {
                    opcionGrande += "grande";
                }
                if (!Grande.IsChecked)
                {
                    opcionGrande ="";
                }
                if (Raro.IsChecked)
                {
                    opcionRaro += "rara";
                }
                if (!Raro.IsChecked)
                {
                    opcionRaro ="";
                }
                int contador = 0;
                string[]arregloIntento = {opcionAlta,opcionFea,opcionLista,opcionExtravagante,opcionGrande,opcionRaro };
                for (int i = 0; i < 5; i++)
                {
                    contador++;
                    //resultado += arregloIntento[i];
                    
                }
                resultado = contador;
                Resultado.Text = resultado.ToString();
                //resultado
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
            //Resultado.Text = resultado.ToString();
            
            
           




        }
    }
}
