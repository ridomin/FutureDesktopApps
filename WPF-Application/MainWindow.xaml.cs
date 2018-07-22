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

namespace WPF_Application
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

        public void Button1_Click(object sender, EventArgs eargs)
        {
            MyTextBox.Text = WrapperForWinRT.WrapperOne.IsDesignModeEnabled.ToString();
        }

        private void MyTextBox_DragLeave(object sender, DragEventArgs e)
        {

        }
    }
}