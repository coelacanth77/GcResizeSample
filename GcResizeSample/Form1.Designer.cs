namespace MultiRowSample
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            MultiRowSample.GcMultiRowResizePolicy gcMultiRowResizePolicy2 = new MultiRowSample.GcMultiRowResizePolicy();
            this.ユーザーBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sampleDataSet = new MultiRowSample.SampleDataSet();
            this.ユーザーTableAdapter = new MultiRowSample.SampleDataSetTableAdapters.ユーザーTableAdapter();
            this.tableAdapterManager = new MultiRowSample.SampleDataSetTableAdapters.TableAdapterManager();
            this.gcResize1 = new GrapeCity.Win.Components.GcResize(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.gcMultiRow1 = new GrapeCity.Win.MultiRow.GcMultiRow();
            this.sampleTemplate1 = new MultiRowSample.SampleTemplate();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ユーザーBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcResize1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMultiRow1)).BeginInit();
            this.SuspendLayout();
            // 
            // ユーザーBindingSource
            // 
            this.ユーザーBindingSource.DataMember = "ユーザー";
            this.ユーザーBindingSource.DataSource = this.sampleDataSet;
            // 
            // sampleDataSet
            // 
            this.sampleDataSet.DataSetName = "SampleDataSet";
            this.sampleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ユーザーTableAdapter
            // 
            this.ユーザーTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = MultiRowSample.SampleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ユーザーTableAdapter = this.ユーザーTableAdapter;
            // 
            // gcResize1
            // 
            this.gcResize1.ResizePolicies.Add(gcMultiRowResizePolicy2);
            this.gcResize1.Target = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gcMultiRow1
            // 
            this.gcMultiRow1.AllowAutoExtend = true;
            this.gcMultiRow1.DataSource = this.ユーザーBindingSource;
            this.gcMultiRow1.Location = new System.Drawing.Point(94, 34);
            this.gcMultiRow1.Name = "gcMultiRow1";
            this.gcMultiRow1.Size = new System.Drawing.Size(345, 425);
            this.gcMultiRow1.TabIndex = 0;
            this.gcMultiRow1.Template = this.sampleTemplate1;
            this.gcMultiRow1.Text = "gcMultiRow1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Items.AddRange(new object[] {
            "list1",
            "list2",
            "list3"});
            this.listBox1.Location = new System.Drawing.Point(12, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(76, 88);
            this.listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(480, 504);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gcMultiRow1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ユーザーBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcResize1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMultiRow1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GrapeCity.Win.MultiRow.GcMultiRow gcMultiRow1;
        private SampleTemplate sampleTemplate1;
        private SampleDataSet sampleDataSet;
        private System.Windows.Forms.BindingSource ユーザーBindingSource;
        private SampleDataSetTableAdapters.ユーザーTableAdapter ユーザーTableAdapter;
        private SampleDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private GrapeCity.Win.Components.GcResize gcResize1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

