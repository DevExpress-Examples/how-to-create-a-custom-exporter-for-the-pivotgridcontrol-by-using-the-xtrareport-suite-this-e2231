namespace WindowsApplication1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.customerReportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new WindowsApplication1.nwindDataSet();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCompanyName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderMonth = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.customerReportsTableAdapter = new WindowsApplication1.nwindDataSetTableAdapters.CustomerReportsTableAdapter();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create and Show the Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.customerReportsBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldProductName,
            this.fieldCompanyName,
            this.fieldOrderMonth,
            this.fieldProductAmount,
            this.pivotGridField1});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsChartDataSource.SelectionOnly = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(714, 463);
            this.pivotGridControl1.TabIndex = 1;
            // 
            // customerReportsBindingSource
            // 
            this.customerReportsBindingSource.DataMember = "CustomerReports";
            this.customerReportsBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldProductName
            // 
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldProductName.AreaIndex = 1;
            this.fieldProductName.Caption = "Product Name";
            this.fieldProductName.FieldName = "ProductName";
            this.fieldProductName.Name = "fieldProductName";
            // 
            // fieldCompanyName
            // 
            this.fieldCompanyName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCompanyName.AreaIndex = 0;
            this.fieldCompanyName.Caption = "Company Name";
            this.fieldCompanyName.FieldName = "CompanyName";
            this.fieldCompanyName.Name = "fieldCompanyName";
            // 
            // fieldOrderMonth
            // 
            this.fieldOrderMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderMonth.AreaIndex = 0;
            this.fieldOrderMonth.Caption = "Month";
            this.fieldOrderMonth.FieldName = "OrderDate";
            this.fieldOrderMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.fieldOrderMonth.Name = "fieldOrderMonth";
            this.fieldOrderMonth.UnboundFieldName = "fieldOrderDate";
            // 
            // fieldProductAmount
            // 
            this.fieldProductAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldProductAmount.AreaIndex = 0;
            this.fieldProductAmount.Caption = "Sum";
            this.fieldProductAmount.FieldName = "ProductAmount";
            this.fieldProductAmount.Name = "fieldProductAmount";
            // 
            // customerReportsTableAdapter
            // 
            this.customerReportsTableAdapter.ClearBeforeFill = true;
            // 
            // radioGroup1
            // 
            this.radioGroup1.EditValue = "autosize";
            this.radioGroup1.Location = new System.Drawing.Point(186, 5);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("autosize", "autosize to page width"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("do not autosize column width", "do not autosize and use column width"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("do not autosize and best fit columns", "do not autosize and best fit columns")});
            this.radioGroup1.Size = new System.Drawing.Size(248, 70);
            this.radioGroup1.TabIndex = 2;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(459, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Column Width";
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.spinEdit1.Enabled = false;
            this.spinEdit1.Location = new System.Drawing.Point(530, 2);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit1.Properties.MaxValue = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.spinEdit1.Properties.MinValue = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.spinEdit1.Size = new System.Drawing.Size(100, 20);
            this.spinEdit1.TabIndex = 4;
            // 
            // checkEdit2
            // 
            this.checkEdit2.Enabled = false;
            this.checkEdit2.Location = new System.Drawing.Point(457, 53);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "Repeat row header on every page";
            this.checkEdit2.Size = new System.Drawing.Size(216, 19);
            this.checkEdit2.TabIndex = 6;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.button1);
            this.panelControl1.Controls.Add(this.checkEdit2);
            this.panelControl1.Controls.Add(this.radioGroup1);
            this.panelControl1.Controls.Add(this.spinEdit1);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 383);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(714, 80);
            this.panelControl1.TabIndex = 7;
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField1.AreaIndex = 1;
            this.pivotGridField1.Caption = "Count";
            this.pivotGridField1.FieldName = "ProductAmount";
            this.pivotGridField1.Name = "pivotGridField1";
            this.pivotGridField1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 463);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource customerReportsBindingSource;
        private WindowsApplication1.nwindDataSetTableAdapters.CustomerReportsTableAdapter customerReportsTableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCompanyName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderMonth;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductAmount;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
    }
}

