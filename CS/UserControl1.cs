using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace MergeModules {
    /// <summary>
    /// Summary description for UserControl1.
    /// </summary>
    public class UserControl1 : System.Windows.Forms.UserControl {
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private IContainer components;
        private DevExpress.XtraEditors.TextEdit textEdit1;


        BarManager mainManager;
        BarManager thisManager {
            get {
                return barManager1;
            }
        }
        public UserControl1(BarManager mainManager) {
            this.mainManager = mainManager;
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();

            // TODO: Add any initialization after the InitForm call

        }

        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1});
            this.barManager1.MaxItemId = 1;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 1";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.bar1.Text = "Custom 1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "ModuleButton (Ctrl+M)";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(48, 88);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 4;
            // 
            // UserControl1
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(314, 173);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private void MergeToolbars(bool merge) {
            foreach(Bar bar in thisManager.Bars) {
                Bar mainBar = mainManager.Bars[bar.BarName];
                if(mainBar != null) {
                    if(merge) {
                        mainBar.Merge(bar);
                        bar.Visible = false;
                    }
                    else
                        mainBar.UnMerge();
                }
            }
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if(!DesignMode && mainManager != null) {
                thisManager.ForceInitialize();
                MergeToolbars(true);
            }
        }

        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(mainManager != null)
                    MergeToolbars(false);
                if(components != null) 
                    components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            MessageBox.Show(e.Item.Caption);
        }	
    }
}
