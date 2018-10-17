using Newtonsoft.Json;
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

namespace WpfApp7
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            Lesson lesson1 = new Lesson();

            Word word = new Word();
            word.Value = "Telefon";
            word.Type = Types.Das;

            Word word1 = new Word();
            word1.Value = "Fremdsprache";
            word1.Type = Types.Die;

            lesson1.words.Add(word);
            lesson1.words.Add(word1);

            string json = JsonConvert.SerializeObject(lesson1);

            Lesson lessonFromJson = JsonConvert.DeserializeObject<Lesson>(json);


        }
    }
}
