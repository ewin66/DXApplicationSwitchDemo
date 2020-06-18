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
using DevExpress.XtraNavBar;
using System.Diagnostics;
using DevExpress.XtraBars.Navigation;

namespace DXApplicationSwitchDemo
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        int switchDelay = 0;
        int navBarItemIndex = 0;

        ////////public innerclassObject nweinnerclassObject = new innerclassObject();

        public FormMain()
        {
            InitializeComponent();
        }
        void navBarControl_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        {
            navigationFrameMain.SelectedPageIndex = navBarControlMain.Groups.IndexOf(e.Group);
        }
        void barButtonNavigation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
            navBarControlMain.ActiveGroup = navBarControlMain.Groups[barItemIndex];
        }
        XtraFormBase newXtraFormBase(String controlTypename)
        {
            XtraFormBase newFormColpModule = new XtraFormBase(this, controlTypename)
            {
                Name = employeesNavBarGroup.Name,
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                //handleOverlayForm = newHandleOverlayForm,
            };
            return newFormColpModule;
        }

        private void timerSwitch_Tick(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.Timer)
            {
                System.Windows.Forms.Timer sendertimer = sender as System.Windows.Forms.Timer;
                sendertimer.Stop();
                ////if (!stopswitchtimer)
                {
                    switchDelay += sendertimer.Interval;
                    int inrerset = 5;
   
                    if (switchDelay >= inrerset * 100)
                    {
                        if (navBarItemIndex <= 0)
                            navBarItemIndex = 0;
                        if (navBarItemIndex >= navBarControlMain.Items.Count)
                            navBarItemIndex = 0;
                        if (navBarControlMain.Items[navBarItemIndex] is NavBarItem)
                        {
                            try
                            {
                                {
                                    NavBarItem navBarItem = navBarControlMain.Items[navBarItemIndex];
                                    navBarControlMain.ActiveGroup = navBarItem.Links[0].Group;
                                    navBarControlMain.ActiveGroup.SelectedLink = navBarItem.Links[0];  //定位navBarItem
                                    navBarItem.Links[0].PerformClick();    //触发navBarItem_LinkClicked
                                }
                            }
                            catch (Exception catchException)
                            {
                                throw (catchException);
                            }
                        }
                        navBarItemIndex++;
                        switchDelay = 0;
                    }
                    {
                        sendertimer.Start();
                    }
                }
            }
        }

        private void navBarItem_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            String methodname = new StackTrace(true).GetFrame(0).GetMethod().Name.ToString();
            Debug.WriteLine(methodname);

            Boolean formExist = false;
            if (sender is NavBarItem)
            {
                NavBarItem senderNavBarItem = sender as NavBarItem;
                ////var senderNavBarLink = e.Link;
                NavigationPage activeNavigationPage = (NavigationPage)navigationFrameMain.SelectedPage;

                if (senderNavBarItem == employeesNavBarItem || senderNavBarItem == customersNavBarItem)
                {
                    #region  Clear Form or Control
                    foreach (var eachvar in navigationFrameMain.Controls)
                    {
                        if (eachvar is DevExpress.XtraBars.Navigation.NavigationPage)
                        {
                            DevExpress.XtraBars.Navigation.NavigationPage eachNavigationPage = eachvar as DevExpress.XtraBars.Navigation.NavigationPage;
                            if (eachNavigationPage == activeNavigationPage)
                            {
                                foreach (var eachForm in eachNavigationPage.Controls)
                                {
                                    if (eachForm is XtraFormBase)
                                    {
                                        eachNavigationPage.Controls.Clear();
                                        ////(eachForm as XtraFormBase).Dispose();
                                        ////break;
                                    }
                                    else
                                    {
                                        eachNavigationPage.Controls.Clear();
                                    }
                                }
                            }
                        }
                    }
                    #endregion

                    #region  Add Form
                    if (formExist == false)
                    {
                        try
                        {
                            if (navigationFrameMain.Visible == false)
                            {
                                throw new NotSupportedException();
                            }
                            if (navigationFrameMain != null && !navigationFrameMain.IsDisposed)
                            {
                                 {
                                    {
                                        if (activeNavigationPage.Controls.Count > 0)
                                        {
                                            throw new  WarningException();
                                            ////activeNavigationPage.Controls.Clear();
                                        }
                                        String userControlName = typeof(XtraUserControl).Name;
                                        XtraFormBase newFormColpModule = newXtraFormBase(userControlName);
                                        int controlCount = activeNavigationPage.Controls.Count;
                                        activeNavigationPage.Controls.Add((Control)(newFormColpModule));
                                        Debug.WriteLine($"{methodname} : {newFormColpModule}.{newFormColpModule} : {DateTime.Now.ToString(@"yyyy-MM-dd HH:mm:ss")}");
                                        activeNavigationPage.SuspendLayout();
                                        newFormColpModule.Visible = true;
                                        newFormColpModule.Dock = DockStyle.Fill;
                                        newFormColpModule.ResumeLayout(false);
                                    }
                                    activeNavigationPage.ResumeLayout(false);
                                    activeNavigationPage.PerformLayout();
                                }
                            }
                        }
                        catch (Exception catchException)
                        {
                            throw (catchException);
                        }

                    }
                    #endregion
                }
            }
        }
    }
}