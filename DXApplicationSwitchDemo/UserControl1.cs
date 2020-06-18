using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplicationSwitchDemo
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            ////if (this.ParentForm != null)
            ////{
            ////    if (this.ParentForm is FormMain)
            ////    {
            ////        FormMain parentFormMain = this.ParentForm as FormMain;

            ////        if (parentFormMain != null)
            ////        {
            ////            ////////{
            ////            ////////    Binding newbinding = new Binding("Text", parentFormMain.nweinnerclassObject, nameof(innerclassObject.Age), true, DataSourceUpdateMode.OnPropertyChanged);
            ////            ////////    this.comboBox1.DataBindings.Add(newbinding);
            ////            ////////}
            ////            ////////{
            ////            ////////    Binding newbinding = new Binding("Text", parentFormMain.nweinnerclassObject, nameof(innerclassObject.Age), true, DataSourceUpdateMode.OnPropertyChanged);
            ////            ////////    this.comboBox2.DataBindings.Add(newbinding);
            ////            ////////}
            ////            ////////{
            ////            ////////    Binding newbinding = new Binding("Text", parentFormMain.nweinnerclassObject, nameof(innerclassObject.Age), true, DataSourceUpdateMode.OnPropertyChanged);
            ////            ////////    this.comboBox3.DataBindings.Add(newbinding);
            ////            ////////}
            ////        }
            ////    }
            ////}
        }
    }
}
