using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Ink;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Reflection;
using System.Windows.Shapes;
using System.Windows.Forms.Integration;

namespace CMS.Loan_Management.Transaction.View
{
    /// <summary>
    /// Interaction logic for SignatureArea.xaml
    /// </summary>
    public partial class SignatureArea : UserControl
    {
        public SignatureArea()
        {
            InitializeComponent();
        }

        public byte[] getPicture(){
           
  
            //get the dimensions of the ink control
            int margin = (int)this.signatureCanvas.Margin.Left;
            int width = (int)this.signatureCanvas.ActualWidth - margin;
            int height = (int)this.signatureCanvas.ActualHeight - margin;
            //render ink to bitmap
            RenderTargetBitmap rtb =
            new RenderTargetBitmap(width, height, 96d, 96d, PixelFormats.Default);
            rtb.Render(signatureCanvas);
            //save the ink to a memory stream
            BmpBitmapEncoder encoder = new BmpBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(rtb));
            byte[] bitmapBytes;
            using (MemoryStream ms = new MemoryStream())
            {
            encoder.Save(ms);
            //get the bitmap bytes from the memory stream
            ms.Position = 0;
            bitmapBytes = ms.ToArray();
            }
            return bitmapBytes;

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            this.signatureCanvas.Strokes.Clear();
        }


    }

    [Serializable]
    public sealed class MyCustomStrokes
    {
        public MyCustomStrokes() { }

        /// <SUMMARY>
        /// The first index is for the stroke no.
        /// The second index is for the keep the 2D point of the Stroke.
        /// </SUMMARY>
        public Point[][] StrokeCollection;
    }

   
}
