using DevExpress.XtraBars.Docking2010.Views.Widget;
using DevExpress.XtraEditors;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

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
            if (formMain is FormMain)
                FormMain = formMain as FormMain;
            controlTypename = typename;
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                /////
                ////保存数据
                ////this.Close();
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void widgetView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {
            if (sender is WidgetView)
            {
                WidgetView senderWidgetView = sender as WidgetView;

                Document senderDocument = e.Document as Document;
                Control senderControl = senderDocument.Control;

                if (e.Document.Tag != null)
                {
                    switch (e.Document.Tag.ToString())
                    {
                        case "Developer":
                            //e.Control = new developerDetailUserControl();
                            break;
                        case "Support":
                            //e.Control = new supportDetailUserControl();
                            break;
                        case "TechWriter":
                            //e.Control = new techWriterDetailUserControl();
                            break;
                        case "QA":
                            //e.Control = new QADetailUserControl();
                            break;
                        case "HR":
                            //e.Control = new HRDetailUserControl();
                            break;
                    }
                }

                if (e.Document.Caption.Equals("document1", StringComparison.InvariantCultureIgnoreCase) ||
                    e.Document.Caption.Equals("document2", StringComparison.InvariantCultureIgnoreCase) ||
                    e.Document.Caption.Equals("document3", StringComparison.InvariantCultureIgnoreCase) ||
                    e.Document.Caption.Equals("document4", StringComparison.InvariantCultureIgnoreCase)
                    )
                {
                    if (string.IsNullOrEmpty(e.Document.ControlTypeName))
                    {
                        if (controlTypename.Equals(typeof(UserControl1).Name))
                        {
                            ////e.Document.ControlTypeName = typeof(UserControl1).ToString();
                            ////e.Document.ControlName = typeof(UserControl1).Name.ToString();
                        }
                        else if (controlTypename.Equals(typeof(ucVaginoscopeView).Name))
                        {
                            ////e.Document.ControlTypeName = typeof(UserControl).ToString();
                            ////e.Document.ControlName = typeof(UserControl).Name.ToString();
                        }
                        else if (controlTypename.Equals(typeof(UserControl).Name))
                        {
                            ////e.Document.ControlTypeName = typeof(UserControl).ToString();
                            ////e.Document.ControlName = typeof(UserControl).Name.ToString();
                        }
                        else
                        {
                            ////e.Document.ControlTypeName = typeof(XtraUserControl).ToString();
                            ////e.Document.ControlName = typeof(XtraUserControl).Name.ToString();
                        }
                    }
                    if (e.Control == null)
                    {
                        if (!string.IsNullOrEmpty(controlTypename))
                        {
                            if (controlTypename.Equals(typeof(UserControl1).Name))
                            {
                                e.Control = new UserControl1(FormMain.newcontrolcount);
                            }
                            else if (controlTypename.Equals(typeof(ucVaginoscopeView).Name))
                            {
                                e.Control = new UserControl();
                            }
                            else if (controlTypename.Equals(typeof(UserControl).Name))
                            {
                                e.Control = new UserControl();
                            }
                            else
                            {
                                e.Control = new XtraUserControl();
                            }

                        }
                        else if (!string.IsNullOrEmpty(e.Document.ControlTypeName))
                        {
                            e.Control = Activator.CreateInstance(Type.GetType(e.Document.ControlTypeName)) as Control;
                        }
                        else
                        {
                            e.Control = new XtraUserControl();
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
           
            ////MessageBox.Show("Test");
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
                    if (eachDocument.Control is UserControl1)
                    {
                        UserControl1 XtraUserControl = eachDocument.Control as UserControl1;
                        {
                            XtraUserControl.Dispose();
                            XtraUserControl = null;
                        }
                        break;
                    }
                    else if (eachDocument.Control is XtraUserControl)
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
            documentManagerMain.View.RestoreLayoutFromXml(Path.Combine(Application.StartupPath, "layout.xml"));
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

        private void widgetViewMain_ControlReleasing(object sender, DevExpress.XtraBars.Docking2010.Views.ControlReleasingEventArgs e)
        {
            String methodname = new StackTrace(true).GetFrame(0).GetMethod().Name.ToString();
            Debug.WriteLine(methodname);
            WriteLog(methodname);
            e.KeepControl = false;
            e.DisposeControl = true;
        }

        private void document1_Maximized(object sender, EventArgs e)
        {






        }

        private void documentManagerMain_ViewChanged(object sender, DevExpress.XtraBars.Docking2010.ViewEventArgs args)
        {
            documentManagerMain.View.SaveLayoutToXml(Path.Combine(Application.StartupPath, "layout.xml"));
        }

        private void XtraFormBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void widgetViewMain_UnregisterDocumentsHostWindow(object sender, DevExpress.XtraBars.Docking2010.DocumentsHostWindowEventArgs e)
        {
           
        }

        private void widgetViewMain_RegisterDocumentsHostWindow(object sender, DevExpress.XtraBars.Docking2010.DocumentsHostWindowEventArgs e)
        {

        }

        private void widgetViewMain_EndSizing(object sender, DevExpress.XtraBars.Docking2010.Views.LayoutEndSizingEventArgs e)
        {
            
        }

        private void widgetViewMain_ControlShown(object sender, DevExpress.XtraBars.Docking2010.Views.DeferredControlLoadEventArgs e)
        {
            String methodname = new StackTrace(true).GetFrame(0).GetMethod().Name.ToString();
            Debug.WriteLine(methodname);
            WriteLog(methodname);

        }

        private void widgetViewMain_ControlReleased(object sender, DevExpress.XtraBars.Docking2010.Views.DeferredControlLoadEventArgs e)
        {
            String methodname = new StackTrace(true).GetFrame(0).GetMethod().Name.ToString();
            Debug.WriteLine(methodname);
            WriteLog(methodname);
        }
    }
}