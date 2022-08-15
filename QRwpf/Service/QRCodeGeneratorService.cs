using MessagingToolkit.QRCode.Codec;
using System;
using System.Drawing;
using System.Drawing.Imaging;
namespace QRwpf.Service
{
    public class QRCodeGeneratorService
    {
        private QRCodeEncoder encoder = new QRCodeEncoder();
        Bitmap bitmap;
        public const string BASE_URL = "https://api.qrserver.com/v1/create-qr-code/?size=200x200&data=";

        string filepath;
        public string GenerateQr(string data)
        {
            encoder.QRCodeScale = 8;
            bitmap = encoder.Encode(data);
            ToImage(bitmap);
            return filepath;
        }
        public void ToImage(Bitmap bitmap)
        {
            filepath = $@"C:\Users\muham\source\repos\TextToQrWPF\QRwpf\Images\{Guid.NewGuid():N}.png";
            bitmap.Save(filepath, ImageFormat.Png);
        }
    }
}
