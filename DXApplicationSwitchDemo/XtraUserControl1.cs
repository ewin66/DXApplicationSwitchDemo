using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Drawing.Drawing2D;

namespace DXApplicationSwitchDemo
{
    public partial class XtraUserControl1 : DevExpress.XtraEditors.XtraUserControl
    {
        static int xtraUserControlLoadCount = 0;
        static int xtraUserControlDistroyCount = 0;
        public XtraUserControl1()
        {
            InitializeComponent();
        }

        private void XtraUserControl1_Load(object sender, EventArgs e)
        {
            xtraUserControlLoadCount++;
            try
            {
                Bitmap backupBackgroundImage = null;
                if (this.BackgroundImage == null)
                {
                    ////Bitmap newBitmap = new Bitmap(pictureEditVideo.Width, pictureEditVideo.Height);
                    int imageWidth = (960 * 4);
                    int imageHeight = (960 * 4);
                    backupBackgroundImage = new Bitmap(imageWidth, imageHeight);
                    using (Graphics g = Graphics.FromImage(backupBackgroundImage))
                    {
                        g.Clear(Color.Transparent);
                        if (true)
                        {
                            g.SmoothingMode = SmoothingMode.AntiAlias; //
                            g.SmoothingMode = SmoothingMode.HighQuality;//
                            float width = backupBackgroundImage.Width;//
                            float height = backupBackgroundImage.Height;//
                            Color[] colorArray = { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Cyan, Color.Blue, Color.Purple, Color.White, Color.Black };
                            int splitcount = 20;
                            for (int i = 0; i < splitcount; i++)
                            {
                                Pen pen = new Pen(new SolidBrush(colorArray[i % 7]), width / splitcount);
                                int xFromTo = (int)((2 * i + 1) * (width / (splitcount * 2)));
                                g.DrawLine(pen, new PointF(xFromTo, 0), new PointF(xFromTo, height));
                            }
                        }
                    }
                    if (this.ParentForm != null)
                    {
                        if (this.InvokeRequired)
                        {
                            IAsyncResult iar = this.BeginInvoke(new MethodInvoker(delegate
                            {
                                this.BackgroundImage = backupBackgroundImage;
                            }
                        ));
                            this.EndInvoke(iar);
                        }
                        else
                        {
                            this.BackgroundImage = backupBackgroundImage;
                        }
                    }
                    else
                    {
                        ////throw new NotImplementedException();
                    }
                }
            }
            catch (OutOfMemoryException catchOutOfMemoryException)
            {
            }
        }
    }
}
