namespace DXApplicationSwitchDemo
{
    partial class UserControl1
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.xtraUserControl11 = new DXApplicationSwitchDemo.XtraUserControl1();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 21);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(19, 562);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(7, 77);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 3;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(7, 116);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 20);
            this.comboBox3.TabIndex = 4;
            // 
            // xtraUserControl11
            // 
            this.xtraUserControl11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraUserControl11.Location = new System.Drawing.Point(7, 156);
            this.xtraUserControl11.Name = "xtraUserControl11";
            this.xtraUserControl11.Size = new System.Drawing.Size(154, 71);
            this.xtraUserControl11.TabIndex = 5;
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.treeList1.Location = new System.Drawing.Point(183, 29);
            this.treeList1.Name = "treeList1";
            this.treeList1.BeginUnboundLoad();
            this.treeList1.AppendNode(new object[] {
            "1"}, -1, 0, 0, -1, System.Windows.Forms.CheckState.Unchecked, DevExpress.XtraTreeList.NodeCheckBoxStyle.Check, null);
            this.treeList1.AppendNode(new object[] {
            "12"}, 0);
            this.treeList1.AppendNode(new object[] {
            "123"}, 1, 0, 0, -1, System.Windows.Forms.CheckState.Checked, DevExpress.XtraTreeList.NodeCheckBoxStyle.Check, null);
            this.treeList1.AppendNode(new object[] {
            "1234"}, 2, 0, 0, -1, System.Windows.Forms.CheckState.Checked, DevExpress.XtraTreeList.NodeCheckBoxStyle.Check, null);
            this.treeList1.AppendNode(new object[] {
            null}, 2);
            this.treeList1.AppendNode(new object[] {
            null}, 2);
            this.treeList1.AppendNode(new object[] {
            "13"}, 0);
            this.treeList1.AppendNode(new object[] {
            "14"}, 0);
            this.treeList1.AppendNode(new object[] {
            "15"}, 0);
            this.treeList1.AppendNode(new object[] {
            "2"}, -1, 0, 0, -1, System.Windows.Forms.CheckState.Checked, DevExpress.XtraTreeList.NodeCheckBoxStyle.Check, null);
            this.treeList1.AppendNode(new object[] {
            null}, 9);
            this.treeList1.AppendNode(new object[] {
            null}, 9);
            this.treeList1.EndUnboundLoad();
            this.treeList1.OptionsView.EnableAppearanceEvenRow = true;
            this.treeList1.OptionsView.EnableAppearanceOddRow = true;
            this.treeList1.Size = new System.Drawing.Size(428, 352);
            this.treeList1.TabIndex = 6;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "treeListColumn1";
            this.treeListColumn1.FieldName = "treeListColumn1";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.xtraUserControl11);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(725, 605);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private XtraUserControl1 xtraUserControl11;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
    }
}
