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
using Microsoft.Win32;
using System.IO;
using System.Collections;

namespace Integrador1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Municipality> lista;
        public MainWindow()
        {
           
            InitializeComponent();
           

        }
 
        

        private void btnExplorar_Click(object sender, RoutedEventArgs e)
        {
            lista = new List<Municipality>();
            //  MessageBox.Show("Funciona");
            char[] delimitador = {',' };
            Municipality departamentos;
            
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == true)
            {
                StreamReader streamReader = new StreamReader(openFile.FileName);
                String linea = "";
                linea = streamReader.ReadLine();
                while (linea != null)
                {
                    
                    
                    string[] trozos = linea.Split(delimitador);
                   if(trozos.Length == 5 && trozos[3] != "")
                    {
                        
                     departamentos = new Municipality(trozos[0], trozos[1], trozos[2], trozos[3], trozos[4]);
           //      MessageBox.Show(departamentos.getMunicipalityCode());
                   lista.Add(departamentos);
                    }


                    linea = streamReader.ReadLine();
                }

             MessageBox.Show(lista.Count + " " +lista[12].getMunicipalityCode());



            }
                }
    }
}
