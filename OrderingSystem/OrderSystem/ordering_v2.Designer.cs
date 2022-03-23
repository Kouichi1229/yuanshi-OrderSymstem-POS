namespace OrderSystem
{
    partial class ordering_v2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ordering_v2));
            this.gbx_report = new System.Windows.Forms.GroupBox();
            this.rbtn_txt = new System.Windows.Forms.RadioButton();
            this.rbtn_excle = new System.Windows.Forms.RadioButton();
            this.btn_out = new System.Windows.Forms.Button();
            this.lb_title = new System.Windows.Forms.Label();
            this.gbx_main = new System.Windows.Forms.GroupBox();
            this.gbx_item = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_exit_order = new System.Windows.Forms.Button();
            this.dgv_order = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.btn_clearall = new System.Windows.Forms.Button();
            this.lb_total = new System.Windows.Forms.Label();
            this.tbx_total = new System.Windows.Forms.TextBox();
            this.cbx_catelogyitem = new System.Windows.Forms.ComboBox();
            this.lb_item = new System.Windows.Forms.Label();
            this.gbx_menu = new System.Windows.Forms.GroupBox();
            this.gbx_ordering = new System.Windows.Forms.GroupBox();
            this.btn_type = new System.Windows.Forms.Button();
            this.nud_addonitem = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.cbx_additem = new System.Windows.Forms.ComboBox();
            this.tbx_subtotal = new System.Windows.Forms.TextBox();
            this.nup_XLquantity = new System.Windows.Forms.NumericUpDown();
            this.tbx_XLprice = new System.Windows.Forms.TextBox();
            this.nup_Lquantity = new System.Windows.Forms.NumericUpDown();
            this.tbx_Lprice = new System.Windows.Forms.TextBox();
            this.nup_Mquantity = new System.Windows.Forms.NumericUpDown();
            this.tbx_Mprice = new System.Windows.Forms.TextBox();
            this.btn_product = new System.Windows.Forms.Button();
            this.btn_order = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_menu = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbx_loading = new System.Windows.Forms.GroupBox();
            this.btn_loadfile = new System.Windows.Forms.Button();
            this.cbx_filetype = new System.Windows.Forms.ComboBox();
            this.ofd_order = new System.Windows.Forms.OpenFileDialog();
            this.sfd_order = new System.Windows.Forms.SaveFileDialog();
            this.gbx_report.SuspendLayout();
            this.gbx_main.SuspendLayout();
            this.gbx_item.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).BeginInit();
            this.gbx_menu.SuspendLayout();
            this.gbx_ordering.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_addonitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_XLquantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Lquantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Mquantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menu)).BeginInit();
            this.gbx_loading.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_report
            // 
            this.gbx_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gbx_report.Controls.Add(this.rbtn_txt);
            this.gbx_report.Controls.Add(this.rbtn_excle);
            this.gbx_report.Controls.Add(this.btn_out);
            this.gbx_report.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_report.Location = new System.Drawing.Point(1052, 12);
            this.gbx_report.Name = "gbx_report";
            this.gbx_report.Size = new System.Drawing.Size(216, 83);
            this.gbx_report.TabIndex = 8;
            this.gbx_report.TabStop = false;
            this.gbx_report.Text = "Report";
            this.gbx_report.Visible = false;
            // 
            // rbtn_txt
            // 
            this.rbtn_txt.AutoSize = true;
            this.rbtn_txt.Checked = true;
            this.rbtn_txt.Location = new System.Drawing.Point(6, 43);
            this.rbtn_txt.Name = "rbtn_txt";
            this.rbtn_txt.Size = new System.Drawing.Size(52, 18);
            this.rbtn_txt.TabIndex = 3;
            this.rbtn_txt.TabStop = true;
            this.rbtn_txt.Text = "Text";
            this.rbtn_txt.UseVisualStyleBackColor = true;
            // 
            // rbtn_excle
            // 
            this.rbtn_excle.AutoSize = true;
            this.rbtn_excle.Location = new System.Drawing.Point(6, 21);
            this.rbtn_excle.Name = "rbtn_excle";
            this.rbtn_excle.Size = new System.Drawing.Size(57, 18);
            this.rbtn_excle.TabIndex = 2;
            this.rbtn_excle.Text = "Excle";
            this.rbtn_excle.UseVisualStyleBackColor = true;
            // 
            // btn_out
            // 
            this.btn_out.Location = new System.Drawing.Point(163, 37);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(47, 22);
            this.btn_out.TabIndex = 1;
            this.btn_out.Text = "Out file";
            this.btn_out.UseVisualStyleBackColor = true;
            this.btn_out.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.BackColor = System.Drawing.Color.White;
            this.lb_title.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_title.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_title.Location = new System.Drawing.Point(29, 12);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(158, 64);
            this.lb_title.TabIndex = 7;
            this.lb_title.Text = "圓石";
            // 
            // gbx_main
            // 
            this.gbx_main.BackColor = System.Drawing.Color.White;
            this.gbx_main.Controls.Add(this.gbx_item);
            this.gbx_main.Controls.Add(this.cbx_catelogyitem);
            this.gbx_main.Controls.Add(this.lb_item);
            this.gbx_main.Controls.Add(this.gbx_menu);
            this.gbx_main.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_main.Location = new System.Drawing.Point(12, 101);
            this.gbx_main.Name = "gbx_main";
            this.gbx_main.Size = new System.Drawing.Size(1544, 656);
            this.gbx_main.TabIndex = 6;
            this.gbx_main.TabStop = false;
            this.gbx_main.Text = "Main Order";
            // 
            // gbx_item
            // 
            this.gbx_item.Controls.Add(this.btn_delete);
            this.gbx_item.Controls.Add(this.btn_exit_order);
            this.gbx_item.Controls.Add(this.dgv_order);
            this.gbx_item.Controls.Add(this.btn_checkout);
            this.gbx_item.Controls.Add(this.btn_clearall);
            this.gbx_item.Controls.Add(this.lb_total);
            this.gbx_item.Controls.Add(this.tbx_total);
            this.gbx_item.Location = new System.Drawing.Point(22, 333);
            this.gbx_item.Name = "gbx_item";
            this.gbx_item.Size = new System.Drawing.Size(1493, 305);
            this.gbx_item.TabIndex = 6;
            this.gbx_item.TabStop = false;
            this.gbx_item.Text = "Order Item Information";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(862, 252);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(103, 33);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_exit_order
            // 
            this.btn_exit_order.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit_order.Location = new System.Drawing.Point(1381, 252);
            this.btn_exit_order.Name = "btn_exit_order";
            this.btn_exit_order.Size = new System.Drawing.Size(88, 40);
            this.btn_exit_order.TabIndex = 9;
            this.btn_exit_order.Text = "Exit";
            this.btn_exit_order.UseVisualStyleBackColor = true;
            this.btn_exit_order.Click += new System.EventHandler(this.btn_exit_order_Click);
            // 
            // dgv_order
            // 
            this.dgv_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.c0,
            this.c1,
            this.c2,
            this.c3,
            this.c4,
            this.c5,
            this.c6,
            this.c7,
            this.Column1,
            this.c8});
            this.dgv_order.Location = new System.Drawing.Point(6, 26);
            this.dgv_order.Name = "dgv_order";
            this.dgv_order.RowTemplate.Height = 24;
            this.dgv_order.Size = new System.Drawing.Size(1201, 166);
            this.dgv_order.TabIndex = 0;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "商品種類";
            this.Column2.Name = "Column2";
            // 
            // c0
            // 
            this.c0.HeaderText = "品名";
            this.c0.Name = "c0";
            // 
            // c1
            // 
            this.c1.HeaderText = "M";
            this.c1.Name = "c1";
            // 
            // c2
            // 
            this.c2.HeaderText = "M數量";
            this.c2.Name = "c2";
            // 
            // c3
            // 
            this.c3.HeaderText = "L";
            this.c3.Name = "c3";
            // 
            // c4
            // 
            this.c4.HeaderText = "L數量";
            this.c4.Name = "c4";
            // 
            // c5
            // 
            this.c5.HeaderText = "XL";
            this.c5.Name = "c5";
            // 
            // c6
            // 
            this.c6.HeaderText = "XL數量";
            this.c6.Name = "c6";
            // 
            // c7
            // 
            this.c7.HeaderText = "增加項目";
            this.c7.Name = "c7";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "加項數量";
            this.Column1.Name = "Column1";
            // 
            // c8
            // 
            this.c8.HeaderText = "總價";
            this.c8.Name = "c8";
            // 
            // btn_checkout
            // 
            this.btn_checkout.Location = new System.Drawing.Point(1099, 254);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(105, 31);
            this.btn_checkout.TabIndex = 9;
            this.btn_checkout.Text = "CheckOut";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // btn_clearall
            // 
            this.btn_clearall.Location = new System.Drawing.Point(993, 252);
            this.btn_clearall.Name = "btn_clearall";
            this.btn_clearall.Size = new System.Drawing.Size(81, 33);
            this.btn_clearall.TabIndex = 7;
            this.btn_clearall.Text = "ClearAll";
            this.btn_clearall.UseVisualStyleBackColor = true;
            this.btn_clearall.Click += new System.EventHandler(this.btn_clearall_Click);
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Location = new System.Drawing.Point(14, 214);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(50, 18);
            this.lb_total.TabIndex = 4;
            this.lb_total.Text = "Total";
            // 
            // tbx_total
            // 
            this.tbx_total.Enabled = false;
            this.tbx_total.Location = new System.Drawing.Point(80, 210);
            this.tbx_total.Name = "tbx_total";
            this.tbx_total.Size = new System.Drawing.Size(100, 27);
            this.tbx_total.TabIndex = 5;
            // 
            // cbx_catelogyitem
            // 
            this.cbx_catelogyitem.FormattingEnabled = true;
            this.cbx_catelogyitem.Location = new System.Drawing.Point(223, 19);
            this.cbx_catelogyitem.Name = "cbx_catelogyitem";
            this.cbx_catelogyitem.Size = new System.Drawing.Size(120, 26);
            this.cbx_catelogyitem.TabIndex = 2;
            this.cbx_catelogyitem.SelectedIndexChanged += new System.EventHandler(this.cbx_catelogyitem_SelectedIndexChanged);
            // 
            // lb_item
            // 
            this.lb_item.AutoSize = true;
            this.lb_item.Font = new System.Drawing.Font("新細明體-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_item.Location = new System.Drawing.Point(81, 22);
            this.lb_item.Name = "lb_item";
            this.lb_item.Size = new System.Drawing.Size(94, 21);
            this.lb_item.TabIndex = 1;
            this.lb_item.Text = "商品種類";
            // 
            // gbx_menu
            // 
            this.gbx_menu.BackColor = System.Drawing.Color.White;
            this.gbx_menu.Controls.Add(this.gbx_ordering);
            this.gbx_menu.Controls.Add(this.dgv_menu);
            this.gbx_menu.Location = new System.Drawing.Point(22, 46);
            this.gbx_menu.Name = "gbx_menu";
            this.gbx_menu.Size = new System.Drawing.Size(1493, 281);
            this.gbx_menu.TabIndex = 0;
            this.gbx_menu.TabStop = false;
            this.gbx_menu.Text = "Menu";
            // 
            // gbx_ordering
            // 
            this.gbx_ordering.Controls.Add(this.btn_type);
            this.gbx_ordering.Controls.Add(this.nud_addonitem);
            this.gbx_ordering.Controls.Add(this.label10);
            this.gbx_ordering.Controls.Add(this.cbx_additem);
            this.gbx_ordering.Controls.Add(this.tbx_subtotal);
            this.gbx_ordering.Controls.Add(this.nup_XLquantity);
            this.gbx_ordering.Controls.Add(this.tbx_XLprice);
            this.gbx_ordering.Controls.Add(this.nup_Lquantity);
            this.gbx_ordering.Controls.Add(this.tbx_Lprice);
            this.gbx_ordering.Controls.Add(this.nup_Mquantity);
            this.gbx_ordering.Controls.Add(this.tbx_Mprice);
            this.gbx_ordering.Controls.Add(this.btn_product);
            this.gbx_ordering.Controls.Add(this.btn_order);
            this.gbx_ordering.Controls.Add(this.label9);
            this.gbx_ordering.Controls.Add(this.label8);
            this.gbx_ordering.Controls.Add(this.label6);
            this.gbx_ordering.Controls.Add(this.label7);
            this.gbx_ordering.Controls.Add(this.label4);
            this.gbx_ordering.Controls.Add(this.label5);
            this.gbx_ordering.Controls.Add(this.label1);
            this.gbx_ordering.Controls.Add(this.label3);
            this.gbx_ordering.Controls.Add(this.label2);
            this.gbx_ordering.Location = new System.Drawing.Point(598, 26);
            this.gbx_ordering.Name = "gbx_ordering";
            this.gbx_ordering.Size = new System.Drawing.Size(871, 206);
            this.gbx_ordering.TabIndex = 5;
            this.gbx_ordering.TabStop = false;
            this.gbx_ordering.Text = "點餐";
            // 
            // btn_type
            // 
            this.btn_type.Location = new System.Drawing.Point(21, 130);
            this.btn_type.Name = "btn_type";
            this.btn_type.Size = new System.Drawing.Size(93, 32);
            this.btn_type.TabIndex = 24;
            this.btn_type.Text = "Type";
            this.btn_type.UseVisualStyleBackColor = true;
            this.btn_type.Visible = false;
            // 
            // nud_addonitem
            // 
            this.nud_addonitem.Location = new System.Drawing.Point(694, 78);
            this.nud_addonitem.Name = "nud_addonitem";
            this.nud_addonitem.Size = new System.Drawing.Size(57, 27);
            this.nud_addonitem.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(694, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 21);
            this.label10.TabIndex = 22;
            this.label10.Text = "數量";
            // 
            // cbx_additem
            // 
            this.cbx_additem.FormattingEnabled = true;
            this.cbx_additem.Items.AddRange(new object[] {
            "圓石粉圓: 1元",
            "復刻仙草凍: 5元",
            "奇亞籽: 6元"});
            this.cbx_additem.Location = new System.Drawing.Point(576, 78);
            this.cbx_additem.Name = "cbx_additem";
            this.cbx_additem.Size = new System.Drawing.Size(99, 26);
            this.cbx_additem.TabIndex = 21;
            // 
            // tbx_subtotal
            // 
            this.tbx_subtotal.Enabled = false;
            this.tbx_subtotal.Location = new System.Drawing.Point(764, 78);
            this.tbx_subtotal.Name = "tbx_subtotal";
            this.tbx_subtotal.Size = new System.Drawing.Size(100, 27);
            this.tbx_subtotal.TabIndex = 20;
            // 
            // nup_XLquantity
            // 
            this.nup_XLquantity.Location = new System.Drawing.Point(494, 78);
            this.nup_XLquantity.Name = "nup_XLquantity";
            this.nup_XLquantity.Size = new System.Drawing.Size(57, 27);
            this.nup_XLquantity.TabIndex = 18;
            // 
            // tbx_XLprice
            // 
            this.tbx_XLprice.Enabled = false;
            this.tbx_XLprice.Location = new System.Drawing.Point(431, 78);
            this.tbx_XLprice.Name = "tbx_XLprice";
            this.tbx_XLprice.Size = new System.Drawing.Size(55, 27);
            this.tbx_XLprice.TabIndex = 17;
            // 
            // nup_Lquantity
            // 
            this.nup_Lquantity.Location = new System.Drawing.Point(355, 78);
            this.nup_Lquantity.Name = "nup_Lquantity";
            this.nup_Lquantity.Size = new System.Drawing.Size(57, 27);
            this.nup_Lquantity.TabIndex = 16;
            // 
            // tbx_Lprice
            // 
            this.tbx_Lprice.Enabled = false;
            this.tbx_Lprice.Location = new System.Drawing.Point(286, 78);
            this.tbx_Lprice.Name = "tbx_Lprice";
            this.tbx_Lprice.Size = new System.Drawing.Size(55, 27);
            this.tbx_Lprice.TabIndex = 15;
            // 
            // nup_Mquantity
            // 
            this.nup_Mquantity.Location = new System.Drawing.Point(207, 78);
            this.nup_Mquantity.Name = "nup_Mquantity";
            this.nup_Mquantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nup_Mquantity.Size = new System.Drawing.Size(57, 27);
            this.nup_Mquantity.TabIndex = 14;
            // 
            // tbx_Mprice
            // 
            this.tbx_Mprice.Enabled = false;
            this.tbx_Mprice.Location = new System.Drawing.Point(137, 78);
            this.tbx_Mprice.Name = "tbx_Mprice";
            this.tbx_Mprice.Size = new System.Drawing.Size(55, 27);
            this.tbx_Mprice.TabIndex = 13;
            // 
            // btn_product
            // 
            this.btn_product.Location = new System.Drawing.Point(21, 75);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(110, 32);
            this.btn_product.TabIndex = 12;
            this.btn_product.Text = "name";
            this.btn_product.UseVisualStyleBackColor = true;
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(768, 152);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(83, 27);
            this.btn_order.TabIndex = 11;
            this.btn_order.Text = "Order";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(764, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 21);
            this.label9.TabIndex = 10;
            this.label9.Text = "小計";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(576, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "加項";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(494, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "數量";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(431, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "XL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(355, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "數量";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(286, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "L";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "品名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "數量";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "M";
            // 
            // dgv_menu
            // 
            this.dgv_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_menu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.dgv_menu.Location = new System.Drawing.Point(17, 26);
            this.dgv_menu.Name = "dgv_menu";
            this.dgv_menu.RowTemplate.Height = 24;
            this.dgv_menu.Size = new System.Drawing.Size(575, 206);
            this.dgv_menu.TabIndex = 0;
            this.dgv_menu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_menu_CellContentClick);
            // 
            // Column11
            // 
            this.Column11.HeaderText = "商品種類";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "品名";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "M";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "L";
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.HeaderText = "XL";
            this.Column15.Name = "Column15";
            // 
            // gbx_loading
            // 
            this.gbx_loading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gbx_loading.Controls.Add(this.btn_loadfile);
            this.gbx_loading.Controls.Add(this.cbx_filetype);
            this.gbx_loading.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_loading.Location = new System.Drawing.Point(1293, 12);
            this.gbx_loading.Name = "gbx_loading";
            this.gbx_loading.Size = new System.Drawing.Size(216, 83);
            this.gbx_loading.TabIndex = 5;
            this.gbx_loading.TabStop = false;
            this.gbx_loading.Text = "Load File";
            // 
            // btn_loadfile
            // 
            this.btn_loadfile.Location = new System.Drawing.Point(156, 31);
            this.btn_loadfile.Name = "btn_loadfile";
            this.btn_loadfile.Size = new System.Drawing.Size(54, 34);
            this.btn_loadfile.TabIndex = 1;
            this.btn_loadfile.Text = "Load";
            this.btn_loadfile.UseVisualStyleBackColor = true;
            this.btn_loadfile.Click += new System.EventHandler(this.btn_loadfile_Click);
            // 
            // cbx_filetype
            // 
            this.cbx_filetype.FormattingEnabled = true;
            this.cbx_filetype.Items.AddRange(new object[] {
            ".txt",
            ".csv"});
            this.cbx_filetype.Location = new System.Drawing.Point(16, 39);
            this.cbx_filetype.Name = "cbx_filetype";
            this.cbx_filetype.Size = new System.Drawing.Size(121, 22);
            this.cbx_filetype.TabIndex = 0;
            // 
            // ofd_order
            // 
            this.ofd_order.FileName = "ofd_order";
            // 
            // ordering_v2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1547, 744);
            this.Controls.Add(this.gbx_report);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.gbx_main);
            this.Controls.Add(this.gbx_loading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ordering_v2";
            this.Text = "ordering_v2";
            this.gbx_report.ResumeLayout(false);
            this.gbx_report.PerformLayout();
            this.gbx_main.ResumeLayout(false);
            this.gbx_main.PerformLayout();
            this.gbx_item.ResumeLayout(false);
            this.gbx_item.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).EndInit();
            this.gbx_menu.ResumeLayout(false);
            this.gbx_ordering.ResumeLayout(false);
            this.gbx_ordering.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_addonitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_XLquantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Lquantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Mquantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menu)).EndInit();
            this.gbx_loading.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_report;
        private System.Windows.Forms.RadioButton rbtn_txt;
        private System.Windows.Forms.RadioButton rbtn_excle;
        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.GroupBox gbx_main;
        private System.Windows.Forms.GroupBox gbx_item;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.Button btn_clearall;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.TextBox tbx_total;
        private System.Windows.Forms.ComboBox cbx_catelogyitem;
        private System.Windows.Forms.Label lb_item;
        private System.Windows.Forms.GroupBox gbx_menu;
        private System.Windows.Forms.DataGridView dgv_order;
        private System.Windows.Forms.GroupBox gbx_loading;
        private System.Windows.Forms.Button btn_loadfile;
        private System.Windows.Forms.ComboBox cbx_filetype;
        private System.Windows.Forms.Button btn_exit_order;
        private System.Windows.Forms.DataGridView dgv_menu;
        private System.Windows.Forms.GroupBox gbx_ordering;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_XLprice;
        private System.Windows.Forms.NumericUpDown nup_Lquantity;
        private System.Windows.Forms.TextBox tbx_Lprice;
        private System.Windows.Forms.NumericUpDown nup_Mquantity;
        private System.Windows.Forms.TextBox tbx_Mprice;
        private System.Windows.Forms.Button btn_product;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.TextBox tbx_subtotal;
        private System.Windows.Forms.ComboBox cbx_additem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.OpenFileDialog ofd_order;
        private System.Windows.Forms.SaveFileDialog sfd_order;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.NumericUpDown nud_addonitem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nup_XLquantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c0;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4;
        private System.Windows.Forms.DataGridViewTextBoxColumn c5;
        private System.Windows.Forms.DataGridViewTextBoxColumn c6;
        private System.Windows.Forms.DataGridViewTextBoxColumn c7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c8;
        private System.Windows.Forms.Button btn_type;
    }
}