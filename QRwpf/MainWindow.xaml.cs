using QRwpf.Service;
using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace QRwpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ScanQRBtn_Click(object sender, RoutedEventArgs e)
        {
            QRCodeGeneratorService codeGeneratorService = new();
            QRCodeImg.Source = new BitmapImage(new Uri(codeGeneratorService.GenerateQr(QRText.Text)));
            //QRCodeImg.Margin = new Thickness(270, 0, 0, 300);


        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
