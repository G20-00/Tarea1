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
using System.Windows.Shapes;

namespace Integrador1
{
    /// <summary>
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        List<Municipality> lista2;
        List<Municipality> lista3;
        int count = 0;
        public Window2()
        {
            InitializeComponent();
        }

        public void ShowList(List<Municipality> lista)
        {
            if(count == 0)
            {
                lista3 = new List<Municipality>();
                lista2 = lista;
                count++;
                Boolean found = false;
                for(int i = 0; i < lista2.Count; i++)
                {
                    for(int j =0; j < lista3.Count  && found == false; j++) 
                    {
                        if(lista2[i].getDepartment() == lista3[j].getDepartment())
                        {
                            found = true;
                        }
                        
                    }
                    if (found == false)
                    {
                        lista3.Add(lista2[i]);

                    }
                    found = false;

                }
                Departamentos.ItemsSource = lista3;
            }
            Municipal.ItemsSource = lista;
            Municipality muni = (Municipality)Municipal.SelectedItem;
        }

        private void btnFiltro_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Municipio_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
