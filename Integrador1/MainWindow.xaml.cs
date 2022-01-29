﻿using System;
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

namespace Integrador1
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

        private void btnExplorar_Click(object sender, RoutedEventArgs e)
        {
            char[] delimitador = {',' };
            Municipality departamentos;
            // MessageBox.Show("Funciona");
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == true)
            {
                StreamReader streamReader = new StreamReader(openFile.FileName);
                String linea = "";
                linea = streamReader.ReadLine();
                while (linea != null)
                {
                    linea = streamReader.ReadLine();
                    string[] trozos = linea.Split(delimitador);
                   departamentos = new Municipality(trozos[0], trozos[1], trozos[2], trozos[3], trozos[4]);
                    
                }
            }
                }
    }
}
