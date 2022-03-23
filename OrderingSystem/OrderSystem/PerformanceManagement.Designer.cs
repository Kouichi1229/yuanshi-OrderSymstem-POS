namespace OrderSystem
{
    partial class PerformanceManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerformanceManagement));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_a = new System.Windows.Forms.TabPage();
            this.gbx_type1 = new System.Windows.Forms.GroupBox();
            this.rbtn_daySale = new System.Windows.Forms.RadioButton();
            this.rbtn_itemSale = new System.Windows.Forms.RadioButton();
            this.rbtn_TypeSale = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.gbx_control = new System.Windows.Forms.GroupBox();
            this.btn_exit_p = new System.Windows.Forms.Button();
            this.btn_load_p = new System.Windows.Forms.Button();
            this.gbx_showtype = new System.Windows.Forms.GroupBox();
            this.rbtn_chart = new System.Windows.Forms.RadioButton();
            this.rbtn_pie = new System.Windows.Forms.RadioButton();
            this.rbtn_line = new System.Windows.Forms.RadioButton();
            this.btn_show = new System.Windows.Forms.Button();
            this.tab_query = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_exit_q = new System.Windows.Forms.Button();
            this.btn_load_q = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgv_query = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofd_PM = new System.Windows.Forms.OpenFileDialog();
            this.sfd_PM = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tab_a.SuspendLayout();
            this.gbx_type1.SuspendLayout();
            this.gbx_control.SuspendLayout();
            this.gbx_showtype.SuspendLayout();
            this.tab_query.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_query)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_a);
            this.tabControl1.Controls.Add(this.tab_query);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(892, 443);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_a
            // 
            this.tab_a.BackColor = System.Drawing.Color.DarkGray;
            this.tab_a.Controls.Add(this.gbx_type1);
            this.tab_a.Controls.Add(this.zedGraphControl1);
            this.tab_a.Controls.Add(this.gbx_control);
            this.tab_a.Controls.Add(this.gbx_showtype);
            this.tab_a.Location = new System.Drawing.Point(4, 22);
            this.tab_a.Name = "tab_a";
            this.tab_a.Padding = new System.Windows.Forms.Padding(3);
            this.tab_a.Size = new System.Drawing.Size(884, 417);
            this.tab_a.TabIndex = 0;
            this.tab_a.Text = "報表分析";
            // 
            // gbx_type1
            // 
            this.gbx_type1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbx_type1.Controls.Add(this.rbtn_daySale);
            this.gbx_type1.Controls.Add(this.rbtn_itemSale);
            this.gbx_type1.Controls.Add(this.rbtn_TypeSale);
            this.gbx_type1.Controls.Add(this.button1);
            this.gbx_type1.Location = new System.Drawing.Point(586, 193);
            this.gbx_type1.Name = "gbx_type1";
            this.gbx_type1.Size = new System.Drawing.Size(179, 183);
            this.gbx_type1.TabIndex = 6;
            this.gbx_type1.TabStop = false;
            this.gbx_type1.Text = "報表內容";
            // 
            // rbtn_daySale
            // 
            this.rbtn_daySale.AutoSize = true;
            this.rbtn_daySale.Location = new System.Drawing.Point(33, 84);
            this.rbtn_daySale.Name = "rbtn_daySale";
            this.rbtn_daySale.Size = new System.Drawing.Size(83, 16);
            this.rbtn_daySale.TabIndex = 3;
            this.rbtn_daySale.TabStop = true;
            this.rbtn_daySale.Text = "當日營業額";
            this.rbtn_daySale.UseVisualStyleBackColor = true;
            // 
            // rbtn_itemSale
            // 
            this.rbtn_itemSale.AutoSize = true;
            this.rbtn_itemSale.Location = new System.Drawing.Point(33, 53);
            this.rbtn_itemSale.Name = "rbtn_itemSale";
            this.rbtn_itemSale.Size = new System.Drawing.Size(71, 16);
            this.rbtn_itemSale.TabIndex = 2;
            this.rbtn_itemSale.TabStop = true;
            this.rbtn_itemSale.Text = "商品項目";
            this.rbtn_itemSale.UseVisualStyleBackColor = true;
            // 
            // rbtn_TypeSale
            // 
            this.rbtn_TypeSale.AutoSize = true;
            this.rbtn_TypeSale.Location = new System.Drawing.Point(33, 22);
            this.rbtn_TypeSale.Name = "rbtn_TypeSale";
            this.rbtn_TypeSale.Size = new System.Drawing.Size(71, 16);
            this.rbtn_TypeSale.TabIndex = 1;
            this.rbtn_TypeSale.TabStop = true;
            this.rbtn_TypeSale.Text = "商品種類";
            this.rbtn_TypeSale.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(10, 8);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(557, 404);
            this.zedGraphControl1.TabIndex = 5;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // gbx_control
            // 
            this.gbx_control.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gbx_control.Controls.Add(this.btn_exit_p);
            this.gbx_control.Controls.Add(this.btn_load_p);
            this.gbx_control.Location = new System.Drawing.Point(780, 8);
            this.gbx_control.Name = "gbx_control";
            this.gbx_control.Size = new System.Drawing.Size(93, 96);
            this.gbx_control.TabIndex = 4;
            this.gbx_control.TabStop = false;
            this.gbx_control.Text = "control";
            // 
            // btn_exit_p
            // 
            this.btn_exit_p.Location = new System.Drawing.Point(6, 56);
            this.btn_exit_p.Name = "btn_exit_p";
            this.btn_exit_p.Size = new System.Drawing.Size(80, 32);
            this.btn_exit_p.TabIndex = 17;
            this.btn_exit_p.Text = "Exit";
            this.btn_exit_p.UseVisualStyleBackColor = true;
            // 
            // btn_load_p
            // 
            this.btn_load_p.Location = new System.Drawing.Point(6, 18);
            this.btn_load_p.Name = "btn_load_p";
            this.btn_load_p.Size = new System.Drawing.Size(80, 32);
            this.btn_load_p.TabIndex = 18;
            this.btn_load_p.Text = "Load";
            this.btn_load_p.UseVisualStyleBackColor = true;
            this.btn_load_p.Click += new System.EventHandler(this.btn_load_p_Click);
            // 
            // gbx_showtype
            // 
            this.gbx_showtype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbx_showtype.Controls.Add(this.rbtn_chart);
            this.gbx_showtype.Controls.Add(this.rbtn_pie);
            this.gbx_showtype.Controls.Add(this.rbtn_line);
            this.gbx_showtype.Controls.Add(this.btn_show);
            this.gbx_showtype.Location = new System.Drawing.Point(586, 4);
            this.gbx_showtype.Name = "gbx_showtype";
            this.gbx_showtype.Size = new System.Drawing.Size(179, 183);
            this.gbx_showtype.TabIndex = 3;
            this.gbx_showtype.TabStop = false;
            this.gbx_showtype.Text = "Show Type";
            // 
            // rbtn_chart
            // 
            this.rbtn_chart.AutoSize = true;
            this.rbtn_chart.Location = new System.Drawing.Point(33, 84);
            this.rbtn_chart.Name = "rbtn_chart";
            this.rbtn_chart.Size = new System.Drawing.Size(49, 16);
            this.rbtn_chart.TabIndex = 3;
            this.rbtn_chart.TabStop = true;
            this.rbtn_chart.Text = "Chart";
            this.rbtn_chart.UseVisualStyleBackColor = true;
            // 
            // rbtn_pie
            // 
            this.rbtn_pie.AutoSize = true;
            this.rbtn_pie.Location = new System.Drawing.Point(33, 53);
            this.rbtn_pie.Name = "rbtn_pie";
            this.rbtn_pie.Size = new System.Drawing.Size(37, 16);
            this.rbtn_pie.TabIndex = 2;
            this.rbtn_pie.TabStop = true;
            this.rbtn_pie.Text = "Pie";
            this.rbtn_pie.UseVisualStyleBackColor = true;
            // 
            // rbtn_line
            // 
            this.rbtn_line.AutoSize = true;
            this.rbtn_line.Location = new System.Drawing.Point(33, 22);
            this.rbtn_line.Name = "rbtn_line";
            this.rbtn_line.Size = new System.Drawing.Size(44, 16);
            this.rbtn_line.TabIndex = 1;
            this.rbtn_line.TabStop = true;
            this.rbtn_line.Text = "Line";
            this.rbtn_line.UseVisualStyleBackColor = true;
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(33, 128);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(75, 23);
            this.btn_show.TabIndex = 0;
            this.btn_show.Text = "Show";
            this.btn_show.UseVisualStyleBackColor = true;
            // 
            // tab_query
            // 
            this.tab_query.BackColor = System.Drawing.Color.LightGray;
            this.tab_query.Controls.Add(this.groupBox1);
            this.tab_query.Controls.Add(this.label1);
            this.tab_query.Controls.Add(this.textBox1);
            this.tab_query.Controls.Add(this.dgv_query);
            this.tab_query.Location = new System.Drawing.Point(4, 22);
            this.tab_query.Name = "tab_query";
            this.tab_query.Padding = new System.Windows.Forms.Padding(3);
            this.tab_query.Size = new System.Drawing.Size(884, 417);
            this.tab_query.TabIndex = 1;
            this.tab_query.Text = "查詢";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btn_exit_q);
            this.groupBox1.Controls.Add(this.btn_load_q);
            this.groupBox1.Location = new System.Drawing.Point(707, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(91, 108);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "control";
            // 
            // btn_exit_q
            // 
            this.btn_exit_q.Location = new System.Drawing.Point(6, 66);
            this.btn_exit_q.Name = "btn_exit_q";
            this.btn_exit_q.Size = new System.Drawing.Size(80, 32);
            this.btn_exit_q.TabIndex = 17;
            this.btn_exit_q.Text = "Exit";
            this.btn_exit_q.UseVisualStyleBackColor = true;
            this.btn_exit_q.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_load_q
            // 
            this.btn_load_q.Location = new System.Drawing.Point(6, 21);
            this.btn_load_q.Name = "btn_load_q";
            this.btn_load_q.Size = new System.Drawing.Size(80, 32);
            this.btn_load_q.TabIndex = 18;
            this.btn_load_q.Text = "Load";
            this.btn_load_q.UseVisualStyleBackColor = true;
            this.btn_load_q.Click += new System.EventHandler(this.btn_load_q_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(25, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "查詢";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 256);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 22);
            this.textBox1.TabIndex = 1;
            // 
            // dgv_query
            // 
            this.dgv_query.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_query.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv_query.Location = new System.Drawing.Point(19, 17);
            this.dgv_query.Name = "dgv_query";
            this.dgv_query.RowTemplate.Height = 24;
            this.dgv_query.Size = new System.Drawing.Size(672, 222);
            this.dgv_query.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "種類";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "品名";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "M";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "L";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "XL";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "總金額";
            this.Column6.Name = "Column6";
            // 
            // ofd_PM
            // 
            this.ofd_PM.FileName = "ofd_PM";
            // 
            // PerformanceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 442);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PerformanceManagement";
            this.Text = "PerformanceManagement";
            this.tabControl1.ResumeLayout(false);
            this.tab_a.ResumeLayout(false);
            this.gbx_type1.ResumeLayout(false);
            this.gbx_type1.PerformLayout();
            this.gbx_control.ResumeLayout(false);
            this.gbx_showtype.ResumeLayout(false);
            this.gbx_showtype.PerformLayout();
            this.tab_query.ResumeLayout(false);
            this.tab_query.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_query)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_a;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.GroupBox gbx_control;
        private System.Windows.Forms.Button btn_exit_p;
        private System.Windows.Forms.Button btn_load_p;
        private System.Windows.Forms.GroupBox gbx_showtype;
        private System.Windows.Forms.RadioButton rbtn_chart;
        private System.Windows.Forms.RadioButton rbtn_pie;
        private System.Windows.Forms.RadioButton rbtn_line;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.TabPage tab_query;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgv_query;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_exit_q;
        private System.Windows.Forms.Button btn_load_q;
        private System.Windows.Forms.GroupBox gbx_type1;
        private System.Windows.Forms.RadioButton rbtn_daySale;
        private System.Windows.Forms.RadioButton rbtn_itemSale;
        private System.Windows.Forms.RadioButton rbtn_TypeSale;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog ofd_PM;
        private System.Windows.Forms.SaveFileDialog sfd_PM;
    }
}