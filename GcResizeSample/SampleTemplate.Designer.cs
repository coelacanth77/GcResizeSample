namespace MultiRowSample
{          
    [System.ComponentModel.ToolboxItem(true)]
    partial class SampleTemplate
    {
        /// <summary> 
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region MultiRow Template Designer generated code

		/// <summary> 
		/// デザイナ サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディタで変更しないでください。
		/// </summary>
        private void InitializeComponent()
        {
            GrapeCity.Win.MultiRow.CellStyle cellStyle1 = new GrapeCity.Win.MultiRow.CellStyle();
            GrapeCity.Win.MultiRow.Border border1 = new GrapeCity.Win.MultiRow.Border();
            GrapeCity.Win.MultiRow.CellStyle cellStyle2 = new GrapeCity.Win.MultiRow.CellStyle();
            GrapeCity.Win.MultiRow.Border border2 = new GrapeCity.Win.MultiRow.Border();
            GrapeCity.Win.MultiRow.CellStyle cellStyle3 = new GrapeCity.Win.MultiRow.CellStyle();
            GrapeCity.Win.MultiRow.Border border3 = new GrapeCity.Win.MultiRow.Border();
            GrapeCity.Win.MultiRow.CellStyle cellStyle4 = new GrapeCity.Win.MultiRow.CellStyle();
            GrapeCity.Win.MultiRow.Border border4 = new GrapeCity.Win.MultiRow.Border();
            this.columnHeaderSection1 = new GrapeCity.Win.MultiRow.ColumnHeaderSection();
            this.columnHeaderCell1 = new GrapeCity.Win.MultiRow.ColumnHeaderCell();
            this.columnHeaderCell5 = new GrapeCity.Win.MultiRow.ColumnHeaderCell();
            this.columnHeaderCell6 = new GrapeCity.Win.MultiRow.ColumnHeaderCell();
            this.columnHeaderCell7 = new GrapeCity.Win.MultiRow.ColumnHeaderCell();
            this.columnHeaderCell8 = new GrapeCity.Win.MultiRow.ColumnHeaderCell();
            this.columnHeaderCell9 = new GrapeCity.Win.MultiRow.ColumnHeaderCell();
            this.columnHeaderCell10 = new GrapeCity.Win.MultiRow.ColumnHeaderCell();
            this.columnHeaderCell11 = new GrapeCity.Win.MultiRow.ColumnHeaderCell();
            this.columnHeaderCell12 = new GrapeCity.Win.MultiRow.ColumnHeaderCell();
            this.textBoxCell5 = new GrapeCity.Win.MultiRow.TextBoxCell();
            this.textBoxCell6 = new GrapeCity.Win.MultiRow.TextBoxCell();
            this.textBoxCell7 = new GrapeCity.Win.MultiRow.TextBoxCell();
            this.textBoxCell8 = new GrapeCity.Win.MultiRow.TextBoxCell();
            this.textBoxCell9 = new GrapeCity.Win.MultiRow.TextBoxCell();
            this.textBoxCell10 = new GrapeCity.Win.MultiRow.TextBoxCell();
            this.textBoxCell11 = new GrapeCity.Win.MultiRow.TextBoxCell();
            this.textBoxCell12 = new GrapeCity.Win.MultiRow.TextBoxCell();
            this.gcTextBoxCell1 = new GrapeCity.Win.MultiRow.InputMan.GcTextBoxCell(false);
            // 
            // Row
            // 
            this.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Row.Cells.Add(this.gcTextBoxCell1);
            this.Row.Cells.Add(this.textBoxCell5);
            this.Row.Cells.Add(this.textBoxCell6);
            this.Row.Cells.Add(this.textBoxCell7);
            this.Row.Cells.Add(this.textBoxCell8);
            this.Row.Cells.Add(this.textBoxCell9);
            this.Row.Cells.Add(this.textBoxCell10);
            this.Row.Cells.Add(this.textBoxCell11);
            this.Row.Cells.Add(this.textBoxCell12);
            this.Row.Height = 63;
            this.Row.Width = 320;
            // 
            // columnHeaderSection1
            // 
            this.columnHeaderSection1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.columnHeaderSection1.Cells.Add(this.columnHeaderCell1);
            this.columnHeaderSection1.Cells.Add(this.columnHeaderCell5);
            this.columnHeaderSection1.Cells.Add(this.columnHeaderCell6);
            this.columnHeaderSection1.Cells.Add(this.columnHeaderCell7);
            this.columnHeaderSection1.Cells.Add(this.columnHeaderCell8);
            this.columnHeaderSection1.Cells.Add(this.columnHeaderCell9);
            this.columnHeaderSection1.Cells.Add(this.columnHeaderCell10);
            this.columnHeaderSection1.Cells.Add(this.columnHeaderCell11);
            this.columnHeaderSection1.Cells.Add(this.columnHeaderCell12);
            this.columnHeaderSection1.Height = 63;
            this.columnHeaderSection1.Name = "columnHeaderSection1";
            this.columnHeaderSection1.Width = 320;
            // 
            // columnHeaderCell1
            // 
            this.columnHeaderCell1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.columnHeaderCell1.Location = new System.Drawing.Point(0, 0);
            this.columnHeaderCell1.Name = "columnHeaderCell1";
            this.columnHeaderCell1.Size = new System.Drawing.Size(320, 21);
            this.columnHeaderCell1.Style = new GrapeCity.Win.MultiRow.NamedCellStyle("HeaderCellStyle1");
            this.columnHeaderCell1.TabIndex = 0;
            this.columnHeaderCell1.Value = "ID";
            // 
            // columnHeaderCell5
            // 
            this.columnHeaderCell5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.columnHeaderCell5.Location = new System.Drawing.Point(0, 21);
            this.columnHeaderCell5.Name = "columnHeaderCell5";
            this.columnHeaderCell5.Size = new System.Drawing.Size(80, 21);
            this.columnHeaderCell5.Style = new GrapeCity.Win.MultiRow.NamedCellStyle("HeaderCellStyle1");
            this.columnHeaderCell5.TabIndex = 4;
            this.columnHeaderCell5.Value = "姓";
            // 
            // columnHeaderCell6
            // 
            this.columnHeaderCell6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.columnHeaderCell6.Location = new System.Drawing.Point(80, 21);
            this.columnHeaderCell6.Name = "columnHeaderCell6";
            this.columnHeaderCell6.Size = new System.Drawing.Size(80, 21);
            this.columnHeaderCell6.Style = new GrapeCity.Win.MultiRow.NamedCellStyle("HeaderCellStyle1");
            this.columnHeaderCell6.TabIndex = 5;
            this.columnHeaderCell6.Value = "名";
            // 
            // columnHeaderCell7
            // 
            this.columnHeaderCell7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.columnHeaderCell7.Location = new System.Drawing.Point(160, 21);
            this.columnHeaderCell7.Name = "columnHeaderCell7";
            this.columnHeaderCell7.Size = new System.Drawing.Size(80, 21);
            this.columnHeaderCell7.Style = new GrapeCity.Win.MultiRow.NamedCellStyle("HeaderCellStyle1");
            this.columnHeaderCell7.TabIndex = 6;
            this.columnHeaderCell7.Value = "性別";
            // 
            // columnHeaderCell8
            // 
            this.columnHeaderCell8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.columnHeaderCell8.Location = new System.Drawing.Point(240, 21);
            this.columnHeaderCell8.Name = "columnHeaderCell8";
            this.columnHeaderCell8.Size = new System.Drawing.Size(80, 21);
            this.columnHeaderCell8.Style = new GrapeCity.Win.MultiRow.NamedCellStyle("HeaderCellStyle1");
            this.columnHeaderCell8.TabIndex = 7;
            this.columnHeaderCell8.Value = "会社コード";
            // 
            // columnHeaderCell9
            // 
            this.columnHeaderCell9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.columnHeaderCell9.Location = new System.Drawing.Point(0, 42);
            this.columnHeaderCell9.Name = "columnHeaderCell9";
            this.columnHeaderCell9.Size = new System.Drawing.Size(80, 21);
            this.columnHeaderCell9.Style = new GrapeCity.Win.MultiRow.NamedCellStyle("HeaderCellStyle1");
            this.columnHeaderCell9.TabIndex = 8;
            this.columnHeaderCell9.Value = "郵便番号";
            // 
            // columnHeaderCell10
            // 
            this.columnHeaderCell10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.columnHeaderCell10.Location = new System.Drawing.Point(80, 42);
            this.columnHeaderCell10.Name = "columnHeaderCell10";
            this.columnHeaderCell10.Size = new System.Drawing.Size(80, 21);
            this.columnHeaderCell10.Style = new GrapeCity.Win.MultiRow.NamedCellStyle("HeaderCellStyle1");
            this.columnHeaderCell10.TabIndex = 9;
            this.columnHeaderCell10.Value = "住所1";
            // 
            // columnHeaderCell11
            // 
            this.columnHeaderCell11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.columnHeaderCell11.Location = new System.Drawing.Point(160, 42);
            this.columnHeaderCell11.Name = "columnHeaderCell11";
            this.columnHeaderCell11.Size = new System.Drawing.Size(80, 21);
            this.columnHeaderCell11.Style = new GrapeCity.Win.MultiRow.NamedCellStyle("HeaderCellStyle1");
            this.columnHeaderCell11.TabIndex = 10;
            this.columnHeaderCell11.Value = "住所2";
            // 
            // columnHeaderCell12
            // 
            this.columnHeaderCell12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.columnHeaderCell12.Location = new System.Drawing.Point(240, 42);
            this.columnHeaderCell12.Name = "columnHeaderCell12";
            this.columnHeaderCell12.Size = new System.Drawing.Size(80, 21);
            this.columnHeaderCell12.Style = new GrapeCity.Win.MultiRow.NamedCellStyle("HeaderCellStyle1");
            this.columnHeaderCell12.TabIndex = 11;
            this.columnHeaderCell12.Value = "TEL";
            // 
            // textBoxCell5
            // 
            this.textBoxCell5.DataField = "姓";
            this.textBoxCell5.Location = new System.Drawing.Point(0, 21);
            this.textBoxCell5.Name = "textBoxCell5";
            this.textBoxCell5.Size = new System.Drawing.Size(80, 30);
            this.textBoxCell5.TabIndex = 4;
            // 
            // textBoxCell6
            // 
            this.textBoxCell6.DataField = "名";
            this.textBoxCell6.Location = new System.Drawing.Point(80, 21);
            this.textBoxCell6.Name = "textBoxCell6";
            this.textBoxCell6.TabIndex = 5;
            // 
            // textBoxCell7
            // 
            this.textBoxCell7.DataField = "性別";
            this.textBoxCell7.Location = new System.Drawing.Point(142, 21);
            this.textBoxCell7.Name = "textBoxCell7";
            this.textBoxCell7.Size = new System.Drawing.Size(121, 21);
            this.textBoxCell7.TabIndex = 6;
            // 
            // textBoxCell8
            // 
            this.textBoxCell8.DataField = "会社コード";
            this.textBoxCell8.Location = new System.Drawing.Point(240, 21);
            this.textBoxCell8.Name = "textBoxCell8";
            this.textBoxCell8.TabIndex = 7;
            // 
            // textBoxCell9
            // 
            this.textBoxCell9.DataField = "郵便番号";
            this.textBoxCell9.Location = new System.Drawing.Point(0, 30);
            this.textBoxCell9.Name = "textBoxCell9";
            this.textBoxCell9.Size = new System.Drawing.Size(80, 33);
            this.textBoxCell9.TabIndex = 8;
            // 
            // textBoxCell10
            // 
            this.textBoxCell10.DataField = "住所１";
            this.textBoxCell10.Location = new System.Drawing.Point(80, 42);
            this.textBoxCell10.Name = "textBoxCell10";
            this.textBoxCell10.TabIndex = 9;
            // 
            // textBoxCell11
            // 
            this.textBoxCell11.DataField = "住所２";
            this.textBoxCell11.Location = new System.Drawing.Point(160, 42);
            this.textBoxCell11.Name = "textBoxCell11";
            this.textBoxCell11.TabIndex = 10;
            // 
            // textBoxCell12
            // 
            this.textBoxCell12.DataField = "ＴＥＬ";
            this.textBoxCell12.Location = new System.Drawing.Point(240, 42);
            this.textBoxCell12.Name = "textBoxCell12";
            this.textBoxCell12.TabIndex = 11;
            // 
            // gcTextBoxCell1
            // 
            this.gcTextBoxCell1.Location = new System.Drawing.Point(-22, 0);
            this.gcTextBoxCell1.Name = "gcTextBoxCell1";
            this.gcTextBoxCell1.ShortcutKeys.AddRange(new GrapeCity.Win.MultiRow.InputMan.ShortcutDictionaryEntry[] {
            new GrapeCity.Win.MultiRow.InputMan.ShortcutDictionaryEntry(System.Windows.Forms.Keys.F2, "ShortcutClear")});
            this.gcTextBoxCell1.Size = new System.Drawing.Size(102, 21);
            this.gcTextBoxCell1.TabIndex = 0;
            // 
            // SampleTemplate
            // 
            this.AlternatingRowsDefaultCellStyle = new GrapeCity.Win.MultiRow.NamedCellStyle("AlternatingRowsDefaultCellStyle1");
            this.ColumnHeaders.AddRange(new GrapeCity.Win.MultiRow.ColumnHeaderSection[] {
            this.columnHeaderSection1});
            cellStyle1.BackColor = System.Drawing.SystemColors.Control;
            cellStyle1.BackgroundGradientEffect = new GrapeCity.Win.MultiRow.GradientEffect(null, GrapeCity.Win.MultiRow.GradientStyle.None, GrapeCity.Win.MultiRow.GradientDirection.Center);
            cellStyle1.Border = border1;
            cellStyle1.DisabledBackColor = System.Drawing.SystemColors.Control;
            cellStyle1.DisabledForeColor = System.Drawing.SystemColors.GrayText;
            cellStyle1.DisabledGradientEffect = new GrapeCity.Win.MultiRow.GradientEffect(null, GrapeCity.Win.MultiRow.GradientStyle.None, GrapeCity.Win.MultiRow.GradientDirection.Center);
            cellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            cellStyle1.Format = "";
            cellStyle1.GradientDirection = GrapeCity.Win.MultiRow.GradientDirection.Center;
            cellStyle1.GradientStyle = GrapeCity.Win.MultiRow.GradientStyle.None;
            cellStyle1.ImageAlign = GrapeCity.Win.MultiRow.MultiRowContentAlignment.MiddleCenter;
            cellStyle1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            cellStyle1.ImeSentenceMode = GrapeCity.Win.MultiRow.ImeSentenceMode.NoControl;
            cellStyle1.InputScope = GrapeCity.Win.MultiRow.InputScopeNameValue.Default;
            cellStyle1.LineAdjustment = GrapeCity.Win.MultiRow.LineAdjustment.None;
            cellStyle1.Margin = new System.Windows.Forms.Padding(0);
            cellStyle1.MouseOverGradientEffect = new GrapeCity.Win.MultiRow.GradientEffect(null, GrapeCity.Win.MultiRow.GradientStyle.None, GrapeCity.Win.MultiRow.GradientDirection.Center);
            cellStyle1.Multiline = GrapeCity.Win.MultiRow.MultiRowTriState.True;
            cellStyle1.Padding = new System.Windows.Forms.Padding(0);
            cellStyle1.PatternColor = System.Drawing.SystemColors.WindowText;
            cellStyle1.PatternStyle = GrapeCity.Win.MultiRow.MultiRowHatchStyle.None;
            cellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            cellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            cellStyle1.SelectionGradientEffect = new GrapeCity.Win.MultiRow.GradientEffect(null, GrapeCity.Win.MultiRow.GradientStyle.None, GrapeCity.Win.MultiRow.GradientDirection.Center);
            cellStyle1.TextAdjustment = GrapeCity.Win.MultiRow.TextAdjustment.Near;
            cellStyle1.TextAlign = GrapeCity.Win.MultiRow.MultiRowContentAlignment.MiddleCenter;
            cellStyle1.TextAngle = 0F;
            cellStyle1.TextEffect = GrapeCity.Win.MultiRow.TextEffect.Flat;
            cellStyle1.TextImageRelation = GrapeCity.Win.MultiRow.MultiRowTextImageRelation.Overlay;
            cellStyle1.TextIndent = 0;
            cellStyle1.TextVertical = GrapeCity.Win.MultiRow.MultiRowTriState.False;
            cellStyle1.UseCompatibleTextRendering = GrapeCity.Win.MultiRow.MultiRowTriState.False;
            cellStyle1.WordWrap = GrapeCity.Win.MultiRow.MultiRowTriState.True;
            this.ColumnHeadersDefaultHeaderCellStyle = cellStyle1;
            this.Height = 126;
            cellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            border2.Outline = new GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56))))));
            cellStyle2.Border = border2;
            cellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            cellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            border3.Outline = new GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.White);
            cellStyle3.Border = border3;
            cellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            cellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            border4.Outline = new GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.White);
            cellStyle4.Border = border4;
            cellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NamedCellStyles.AddRange(new GrapeCity.Win.MultiRow.NamedCellStyleDictionaryEntry[] {
            new GrapeCity.Win.MultiRow.NamedCellStyleDictionaryEntry("HeaderCellStyle1", cellStyle2),
            new GrapeCity.Win.MultiRow.NamedCellStyleDictionaryEntry("RowsDefaultCellStyle1", cellStyle3),
            new GrapeCity.Win.MultiRow.NamedCellStyleDictionaryEntry("AlternatingRowsDefaultCellStyle1", cellStyle4)});
            this.RowsDefaultCellStyle = new GrapeCity.Win.MultiRow.NamedCellStyle("RowsDefaultCellStyle1");
            this.Width = 320;

        }
        

        #endregion

        private GrapeCity.Win.MultiRow.ColumnHeaderSection columnHeaderSection1;
        private GrapeCity.Win.MultiRow.ColumnHeaderCell columnHeaderCell1;
        private GrapeCity.Win.MultiRow.ColumnHeaderCell columnHeaderCell5;
        private GrapeCity.Win.MultiRow.ColumnHeaderCell columnHeaderCell6;
        private GrapeCity.Win.MultiRow.ColumnHeaderCell columnHeaderCell7;
        private GrapeCity.Win.MultiRow.ColumnHeaderCell columnHeaderCell8;
        private GrapeCity.Win.MultiRow.ColumnHeaderCell columnHeaderCell9;
        private GrapeCity.Win.MultiRow.ColumnHeaderCell columnHeaderCell10;
        private GrapeCity.Win.MultiRow.ColumnHeaderCell columnHeaderCell11;
        private GrapeCity.Win.MultiRow.ColumnHeaderCell columnHeaderCell12;
        private GrapeCity.Win.MultiRow.TextBoxCell textBoxCell5;
        private GrapeCity.Win.MultiRow.TextBoxCell textBoxCell6;
        private GrapeCity.Win.MultiRow.TextBoxCell textBoxCell7;
        private GrapeCity.Win.MultiRow.TextBoxCell textBoxCell8;
        private GrapeCity.Win.MultiRow.TextBoxCell textBoxCell9;
        private GrapeCity.Win.MultiRow.TextBoxCell textBoxCell10;
        private GrapeCity.Win.MultiRow.TextBoxCell textBoxCell11;
        private GrapeCity.Win.MultiRow.TextBoxCell textBoxCell12;
        private GrapeCity.Win.MultiRow.InputMan.GcTextBoxCell gcTextBoxCell1;
    }
}
