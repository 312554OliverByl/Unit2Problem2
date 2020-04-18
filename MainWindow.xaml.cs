/*
 * Oliver Byl
 * April 17, 2020
 * Unit 2 Summative (Problem J2)
 */
using System;
using System.Windows;
using System.IO;

namespace Unit2J2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            try
            {
                StreamReader reader = new StreamReader("input.txt");

                int.TryParse(reader.ReadLine(), out int lines);

                // Loop through each line:
                for(int i = 0; i < lines; i++)
                {
                    // Represent each line as a string array.
                    // Seperate elements using spaces.
                    string[] line = reader.ReadLine().Split(' ');

                    // Extract symbol and symbol number data.
                    int.TryParse(line[0], out int numSymbols);
                    string symbol = line[1];

                    // Construct output.
                    for (int j = 0; j < numSymbols; j++)
                        output.Content += symbol;

                    output.Content += Environment.NewLine;
                }

                reader.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
