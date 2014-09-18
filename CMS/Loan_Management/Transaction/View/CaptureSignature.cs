using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace CMS.Loan_Management.Transaction.View
{
    public partial class CaptureSignature : Form
    {
        SignatureArea sa = new SignatureArea();
        Transaction.View.MembershipApplication memApp;
        PictureBox pic;
        byte[] receiver = null;
        public CaptureSignature(Transaction.View.MembershipApplication memApp, PictureBox pic, byte[] receiver)
        {
            InitializeComponent();
            this.memApp = memApp;
            this.pic = pic;
            this.receiver = receiver;
            sa = new SignatureArea();
            hostSign.Child = sa;
            hostSign.Dock = DockStyle.Fill;
            panel1.Controls.Add(hostSign);
            this.Show();
         
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            byte[] strokes = null;
            strokes = sa.getPicture();

            if (strokes.Length != 0)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                ms.Write(strokes, 0, strokes.Length);
                ms.Position = 0L;
                pic.Image = new Bitmap(ms);

                String controlName = pic.Name;
                switch (controlName) { 
                
                    case "acctholder1": memApp.acctHolderSign1 = strokes;
                                        break;
                    case "acctholder2": memApp.acctHolderSign2 = strokes;
                                        break;
                    case "acctholder3": memApp.acctHolderSign3 = strokes;
                                        break;
                    case "guardian1":   memApp.guardianSign1 = strokes;
                                        break;
                    case "guardian2": memApp.guardianSign2 = strokes;
                                        break;
                    case "guardian3": memApp.guardianSign3 = strokes;
                                        break;
                    default: break;
                }
            }
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        Bitmap BitmapFromStrokes(string Strokes)
        {
            int maxX = 0, minX = int.MaxValue;
            int maxY = 0, minY = int.MaxValue;
            string[] pts = Strokes.Split('|');
            Point[] points = new Point[pts.Length];
            for (int i = 0; i < pts.Length; i++)
            {
                string[] pt = pts[i].Split(',');
                points[i].X = int.Parse(pt[0]);
                points[i].Y = int.Parse(pt[1]);
                if (points[i].X < minX) minX = points[i].X;
                else if (points[i].X > maxX) maxX = points[i].X;
                if (points[i].Y < minY) minY = points[i].Y;
                else if (points[i].Y > maxY) maxY = points[i].Y;
            }
            Bitmap bmp = new Bitmap(minX + maxX, minY + maxY);
            using (GraphicsPath gp = new GraphicsPath())
            {
                gp.AddLines(points);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.LightGray);
                    g.DrawPath(Pens.Black, gp);
                }
            }
            return bmp;
        }



    }
}
