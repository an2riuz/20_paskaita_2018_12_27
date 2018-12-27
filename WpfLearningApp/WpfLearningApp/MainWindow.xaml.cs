using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfLearningApp
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

        private void LabelChangeClickHandler(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Paspaudziau!!" + sender);

            titleLabel.Content = "Pakeista!" + sender;
         }

        private void TextBoxChangeClickHandler(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Paspaudziau!!" + sender);


        }

        private void TextChangedHandler(object sender, TextChangedEventArgs e)
        {
            Debug.WriteLine((sender as TextBox).Text);
        }

        private void HandleTestCheckBoxButtonClick(object sender, RoutedEventArgs e)
        {
            testCheckBox.IsChecked = !testCheckBox.IsChecked;
        }

        private void OpenWindowClickHandler(object sender, RoutedEventArgs e)
        {
            TestWindow mw = new TestWindow();
            mw.ShowDialog();
        }

        private void HandleWindowLoaded(object sender, RoutedEventArgs e)
        {
            Label myLabel = new Label();
            myLabel.Content = "This is my new label.";
            myLabel.Width = 600;

            
        }
    }
}
