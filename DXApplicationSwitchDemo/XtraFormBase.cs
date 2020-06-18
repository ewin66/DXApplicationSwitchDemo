using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010.Views.Widget;
using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace DXApplicationSwitchDemo
{
    public partial class XtraFormBase : DevExpress.XtraEditors.XtraForm
    {
        String controlTypename = null;
        public FormMain FormMain = null;
        XtraFormBase(FormMain paraFormMain)
        {
            InitializeComponent();
        }
        public XtraFormBase(Object formMain, String typename)
        {
            InitializeComponent();
            if(formMain is FormMain)
                FormMain = formMain as FormMain;
            controlTypename = typename;
        }
        private void widgetView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {
            if (sender is WidgetView)
            {
                WidgetView senderWidgetView = sender as WidgetView;

                Document senderDocument = e.Document as Document;
                Control senderControl = senderDocument.Control;

                if (e.Document.Caption.Equals("document0", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (string.IsNullOrEmpty(e.Document.ControlTypeName))
                    {
                        if (controlTypename.Equals(typeof(UserControl).Name))
                        {
                            e.Document.ControlTypeName = typeof(UserControl).ToString();
                            e.Document.ControlName = typeof(UserControl).Name.ToString();
                        }
                        else
                        {
                            e.Document.ControlTypeName = typeof(XtraUserControl).ToString();
                            e.Document.ControlName = typeof(XtraUserControl).Name.ToString();
                        }
                    }
                    if (e.Control == null)
                    {
                        if (!string.IsNullOrEmpty(e.Document.ControlTypeName))
                        {
                            e.Control = Activator.CreateInstance(Type.GetType(e.Document.ControlTypeName)) as Control;
                            WriteLog($"{nameof(widgetView1_QueryControl)} : {nameof(Activator.CreateInstance)}: {DateTime.Now.ToString(@"yyyy-MM-dd HH:mm:ss")}");
                        }
                        else
                        {
                            e.Control = new XtraUserControl();
                            e.Control.Dock = DockStyle.Fill;
                        }
                    }
                }
                else
                {
                    e.Control = new XtraUserControl();
                    e.Control.Text = ".Control = new XtraUserControl();";
                    e.Control.BackColor = Color.Red;
                    e.Control.Dock = DockStyle.Fill;
                }
            }
        }
        public static void WriteLog(string info)
        {
            ////if (FormMain.loginfo.IsInfoEnabled)
            ////{
            ////    FormMain.loginfo.Info(info);
            ////}
        }
        private void widgetViewMain_QueryMaximizedControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {

        }

        private void XtraFormBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void widgetViewMain_DocumentAdded(object sender, DevExpress.XtraBars.Docking2010.Views.DocumentEventArgs e)
        {
            //MessageBox.Show("widgetViewMain_DocumentAdded");
        }

        private void widgetViewMain_DocumentClosing(object sender, DevExpress.XtraBars.Docking2010.Views.DocumentCancelEventArgs e)
        {
            ////MessageBox.Show("widgetViewMain_DocumentClosing");
            if (sender is WidgetView)
            {
                WidgetView senderWidgetView = sender as WidgetView;
                foreach (Document eachDocument in senderWidgetView.Documents)
                {
                    if (eachDocument.Control is XtraUserControl)
                    {
                        XtraUserControl XtraUserControl = eachDocument.Control as XtraUserControl;
                        {
                            XtraUserControl.Dispose();
                            XtraUserControl = null;
                        }
                        break;
                    }
                    else if (eachDocument.Control is UserControl)
                    {
                        UserControl UserControl = eachDocument.Control as UserControl;
                        {
                            UserControl.Dispose();
                            UserControl = null;
                        }
                        break;
                    }
                }
            }
        }

        private void widgetViewMain_DocumentClosed(object sender, DevExpress.XtraBars.Docking2010.Views.DocumentEventArgs e)
        {
            //MessageBox.Show("widgetViewMain_DocumentClosed");
        }

        private void widgetViewMain_DocumentRemoved(object sender, DevExpress.XtraBars.Docking2010.Views.DocumentEventArgs e)
        {
            //MessageBox.Show("widgetViewMain_DocumentRemoved");
        }

        private void XtraFormBase_Activated(object sender, EventArgs e)
        {
            String methodname = new StackTrace(true).GetFrame(0).GetMethod().Name.ToString();
            Debug.WriteLine(methodname);
            WriteLog(methodname);
        }

        private void XtraFormBase_Deactivate(object sender, EventArgs e)
        {
            String methodname = new StackTrace(true).GetFrame(0).GetMethod().Name.ToString();
            Debug.WriteLine(methodname);
            WriteLog(methodname);
        }

        private void XtraFormBase_Load(object sender, EventArgs e)
        {
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