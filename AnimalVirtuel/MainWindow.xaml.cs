using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.ComponentModel;
using AnimalVirtuel.Models;


namespace AnimalVirtuel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Animal animal = new Animal();
            animal.Nom = "Mimi";
            animal.Espece = EspeceAnimal.Chien;

            MessageBox.Show($"{animal.Nom} est un {animal.Espece}, sa faim est de {animal.Faim}, son bonheur est de {animal.Bonheur} et son énergie est à {animal.Energie}");
            
        }
    }
}