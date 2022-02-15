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
using System.Text.RegularExpressions;


namespace Practica_3
{
    // --------------------------------------------
    // Sebastián Moreno
    // 1º DAM
    // Modalidad Presencial
    // Práctica nº 3
    // --------------------------------------------

    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void rdMarcar_Checked(object sender, RoutedEventArgs e)
        {


            if (rbCliente.IsChecked == true)
            {
               
                cbxProvincia.IsEnabled = true;  
                cbAlbacete.Visibility = Visibility.Visible;
                cbCuenca.Visibility = Visibility.Visible;
                cbMurcia.Visibility = Visibility.Visible;
                cbTeruel.Visibility = Visibility.Visible;

            }
           
            if (rbDistribuidor.IsChecked == true)
            {
                cbxProvincia.IsEnabled = true;
                cbAlbacete.Visibility = Visibility.Collapsed;
                cbCuenca.Visibility = Visibility.Collapsed;
                cbMurcia.Visibility = Visibility.Collapsed;
                cbTeruel.Visibility = Visibility.Collapsed;

            }
            Validar();
        }

        private void cbxProvincia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Validar();

        }

        public void Validar()
        {
             int marcador = 0;

            if(txtNombre.Text != "")
            {
                marcador++;
            }
            if (txtPrimerApellido.Text != "")
            {
                marcador++;
            }         
            if (txtTelefono1.Text != "")
            {
                marcador++;
            }
            if(txtEmail.Text != "")
            {
                marcador++;
            }
            if (txtDireccion.Text != "")
            {
                marcador++;
            }
            if(txtcodigopostal.Text != "")
            {
                marcador++;
            }
            if(txtPoblacion.Text !="")
            {
                marcador++;
            }
            if (rbCliente.IsChecked == true || rbDistribuidor.IsChecked == true)
            {
                marcador++;
            }
            if (cbAlicante.IsSelected == true || cbValencia.IsSelected == true || cbCastellon.IsSelected == true || cbTeruel.IsSelected == true ||
                cbCuenca.IsSelected == true || cbAlbacete.IsSelected == true || cbMurcia.IsSelected == true)

            {
                marcador++;
            }
            if (marcador == 9)
            {
                btnAceptar.IsEnabled = true;
            }
            else
            {
                btnAceptar.IsEnabled = false;
            }
            txtPasos.Text = marcador + " de 9";
        }

        private void txtNombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            Validar();
        }

        private void txtPrimerApellido_TextChanged(object sender, TextChangedEventArgs e)
        {
            Validar();
        }

        private void txtTelefono1_TextChanged(object sender, TextChangedEventArgs e)
        {
            Validar();
        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            Validar();
        }

        private void txtDireccion_TextChanged(object sender, TextChangedEventArgs e)
        {
            Validar();
        }

        private void txtcodigopostal_TextChanged(object sender, TextChangedEventArgs e)
        {
            Validar();
        }

        private void txtPoblacion_TextChanged(object sender, TextChangedEventArgs e)
        {
            Validar();
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (rbCliente.IsChecked == true)

                MessageBox.Show("INSERT INTO cliente (nombre, apellido, apellido2, telefono1, telefono2, email, direccion, codigopostal, poblacion, provincia)" +
                    "VALUE ( ));");
            else
                MessageBox.Show("INSERT INTO distribuidor (nombre, apellido, apellido2, telefono1, telefono2, email, direccion, codigopostal, poblacion, provincia)" +
                    "VALUE ( ));");
        }

        
    }

}
