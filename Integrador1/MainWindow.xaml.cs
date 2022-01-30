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
        private ArrayList lista;

        public MainWindow()
        {
            InitializeComponent();
           
        }
 
        private void btnExplorar_Click(object sender, RoutedEventArgs e)
        {
            /*lista = new ArrayList();
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == true)
            {
                string fileName = openFileDialog.FileName;

                if (File.Exists(fileName))
                {

                    string[] lines = File.ReadAllLines(fileName);
                    int vali = 0;

                    foreach (var line in lines)
                    {
                        var values = line.Split(',');

                        if (vali == 0)
                        {
                            vali = 1;
                            continue;
                        }

                        lista.Add(new Municipality(values[0], values[1], values[2], values[3], values[4]));

                    }

                }
            }*/

            this.Close();
            App app = new App(lista);
        }
    }
    
}
