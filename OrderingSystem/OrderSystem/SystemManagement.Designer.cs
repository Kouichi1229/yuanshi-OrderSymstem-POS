namespace OrderSystem
{
    partial class SystemManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemManagement));
            this.lb_storename = new System.Windows.Forms.Label();
            this.btn_exit_p = new System.Windows.Forms.Button();
            this.btn_save_p = new System.Windows.Forms.Button();
            this.btn_load_p = new System.Windows.Forms.Button();
            this.cbx_dataloding = new System.Windows.Forms.ComboBox();
            this.ofd_sm = new System.Windows.Forms.OpenFileDialog();
            this.sfd_sm = new System.Windows.Forms.SaveFileDialog();
            this.emplyee = new System.Windows.Forms.TabPage();
            this.btn_save_employee = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_acount = new System.Windows.Forms.TextBox();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.tbx_level = new System.Windows.Forms.TextBox();
            this.dgv_empolyee = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.TabPage();
            this.btn_categorydelete = new System.Windows.Forms.Button();
            this.btn_categoryinsert = new System.Windows.Forms.Button();
            this.tbx_category = new System.Windows.Forms.TextBox();
            this.cbx_category = new System.Windows.Forms.ComboBox();
            this.lb_category = new System.Windows.Forms.Label();
            this.gbx_items = new System.Windows.Forms.GroupBox();
            this.gbx_manament = new System.Windows.Forms.GroupBox();
            this.btn_up_c = new System.Windows.Forms.Button();
            this.btn_clear_C = new System.Windows.Forms.Button();
            this.nud_L = new System.Windows.Forms.NumericUpDown();
            this.nud_XL = new System.Windows.Forms.NumericUpDown();
            this.nud_M = new System.Windows.Forms.NumericUpDown();
            this.tbx_name_c = new System.Windows.Forms.TextBox();
            this.tbx_type_c = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_t = new System.Windows.Forms.Label();
            this.btn_insert_C = new System.Windows.Forms.Button();
            this.gbx_additem = new System.Windows.Forms.GroupBox();
            this.btn_updata = new System.Windows.Forms.Button();
            this.lbx_addonitem = new System.Windows.Forms.ListBox();
            this.btn_deletadditem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nup_additemprice = new System.Windows.Forms.NumericUpDown();
            this.tbx_additem = new System.Windows.Forms.TextBox();
            this.btn_clearall = new System.Windows.Forms.Button();
            this.btn_additem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_delete_item = new System.Windows.Forms.Button();
            this.dgv_mainItem = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbc_systemManagemt = new System.Windows.Forms.TabControl();
            this.btn_updata_E = new System.Windows.Forms.Button();
            this.btn_clearAll_E = new System.Windows.Forms.Button();
            this.btn_add_E = new System.Windows.Forms.Button();
            this.btn_delete_E = new System.Windows.Forms.Button();
            this.emplyee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empolyee)).BeginInit();
            this.product.SuspendLayout();
            this.gbx_items.SuspendLayout();
            this.gbx_manament.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_L)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_XL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_M)).BeginInit();
            this.gbx_additem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_additemprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mainItem)).BeginInit();
            this.tbc_systemManagemt.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_storename
            // 
            this.lb_storename.AutoSize = true;
            this.lb_storename.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_storename.ForeColor = System.Drawing.Color.Black;
            this.lb_storename.Location = new System.Drawing.Point(48, 6);
            this.lb_storename.Name = "lb_storename";
            this.lb_storename.Size = new System.Drawing.Size(81, 40);
            this.lb_storename.TabIndex = 17;
            this.lb_storename.Text = "圓石";
            // 
            // btn_exit_p
            // 
            this.btn_exit_p.Location = new System.Drawing.Point(613, 8);
            this.btn_exit_p.Name = "btn_exit_p";
            this.btn_exit_p.Size = new System.Drawing.Size(80, 32);
            this.btn_exit_p.TabIndex = 14;
            this.btn_exit_p.Text = "Exit";
            this.btn_exit_p.UseVisualStyleBackColor = true;
            this.btn_exit_p.Click += new System.EventHandler(this.btn_exit_p_Click);
            // 
            // btn_save_p
            // 
            this.btn_save_p.Location = new System.Drawing.Point(521, 8);
            this.btn_save_p.Name = "btn_save_p";
            this.btn_save_p.Size = new System.Drawing.Size(80, 32);
            this.btn_save_p.TabIndex = 16;
            this.btn_save_p.Text = "Save";
            this.btn_save_p.UseVisualStyleBackColor = true;
            this.btn_save_p.Click += new System.EventHandler(this.btn_save_p_Click);
            // 
            // btn_load_p
            // 
            this.btn_load_p.Location = new System.Drawing.Point(429, 8);
            this.btn_load_p.Name = "btn_load_p";
            this.btn_load_p.Size = new System.Drawing.Size(80, 32);
            this.btn_load_p.TabIndex = 15;
            this.btn_load_p.Text = "Load";
            this.btn_load_p.UseVisualStyleBackColor = true;
            this.btn_load_p.Click += new System.EventHandler(this.btn_load_p_Click);
            // 
            // cbx_dataloding
            // 
            this.cbx_dataloding.FormattingEnabled = true;
            this.cbx_dataloding.Items.AddRange(new object[] {
            ".txt",
            ".csv"});
            this.cbx_dataloding.Location = new System.Drawing.Point(296, 14);
            this.cbx_dataloding.Name = "cbx_dataloding";
            this.cbx_dataloding.Size = new System.Drawing.Size(121, 20);
            this.cbx_dataloding.TabIndex = 13;
            // 
            // ofd_sm
            // 
            this.ofd_sm.FileName = "openFileDialog1";
            // 
            // emplyee
            // 
            this.emplyee.BackColor = System.Drawing.Color.Silver;
            this.emplyee.Controls.Add(this.btn_updata_E);
            this.emplyee.Controls.Add(this.btn_clearAll_E);
            this.emplyee.Controls.Add(this.btn_add_E);
            this.emplyee.Controls.Add(this.btn_delete_E);
            this.emplyee.Controls.Add(this.btn_save_employee);
            this.emplyee.Controls.Add(this.label5);
            this.emplyee.Controls.Add(this.label4);
            this.emplyee.Controls.Add(this.label3);
            this.emplyee.Controls.Add(this.tbx_acount);
            this.emplyee.Controls.Add(this.tbx_password);
            this.emplyee.Controls.Add(this.tbx_level);
            this.emplyee.Controls.Add(this.dgv_empolyee);
            this.emplyee.Location = new System.Drawing.Point(4, 22);
            this.emplyee.Name = "emplyee";
            this.emplyee.Padding = new System.Windows.Forms.Padding(3);
            this.emplyee.Size = new System.Drawing.Size(1210, 538);
            this.emplyee.TabIndex = 2;
            this.emplyee.Text = "員工管理";
            // 
            // btn_save_employee
            // 
            this.btn_save_employee.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_save_employee.Location = new System.Drawing.Point(849, 174);
            this.btn_save_employee.Name = "btn_save_employee";
            this.btn_save_employee.Size = new System.Drawing.Size(170, 44);
            this.btn_save_employee.TabIndex = 17;
            this.btn_save_employee.Text = "Save Information";
            this.btn_save_employee.UseVisualStyleBackColor = true;
            this.btn_save_employee.Click += new System.EventHandler(this.btn_save_employee_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(717, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "員工密碼";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(586, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "員工帳號";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(455, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "員工等級";
            // 
            // tbx_acount
            // 
            this.tbx_acount.Location = new System.Drawing.Point(586, 81);
            this.tbx_acount.Name = "tbx_acount";
            this.tbx_acount.Size = new System.Drawing.Size(98, 22);
            this.tbx_acount.TabIndex = 4;
            // 
            // tbx_password
            // 
            this.tbx_password.Location = new System.Drawing.Point(717, 81);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(98, 22);
            this.tbx_password.TabIndex = 3;
            // 
            // tbx_level
            // 
            this.tbx_level.Location = new System.Drawing.Point(455, 81);
            this.tbx_level.Name = "tbx_level";
            this.tbx_level.Size = new System.Drawing.Size(98, 22);
            this.tbx_level.TabIndex = 1;
            // 
            // dgv_empolyee
            // 
            this.dgv_empolyee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empolyee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column6});
            this.dgv_empolyee.Location = new System.Drawing.Point(18, 6);
            this.dgv_empolyee.Name = "dgv_empolyee";
            this.dgv_empolyee.RowTemplate.Height = 24;
            this.dgv_empolyee.Size = new System.Drawing.Size(360, 442);
            this.dgv_empolyee.TabIndex = 0;
            this.dgv_empolyee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_empolyee_CellContentClick);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "員工等級";
            this.Column7.Name = "Column7";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "員工帳號";
            this.Column1.Name = "Column1";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "員工密碼";
            this.Column6.Name = "Column6";
            // 
            // product
            // 
            this.product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.product.Controls.Add(this.btn_categorydelete);
            this.product.Controls.Add(this.btn_categoryinsert);
            this.product.Controls.Add(this.tbx_category);
            this.product.Controls.Add(this.cbx_category);
            this.product.Controls.Add(this.lb_category);
            this.product.Controls.Add(this.gbx_items);
            this.product.Location = new System.Drawing.Point(4, 22);
            this.product.Name = "product";
            this.product.Padding = new System.Windows.Forms.Padding(3);
            this.product.Size = new System.Drawing.Size(1210, 538);
            this.product.TabIndex = 0;
            this.product.Text = "產品";
            // 
            // btn_categorydelete
            // 
            this.btn_categorydelete.Location = new System.Drawing.Point(493, 7);
            this.btn_categorydelete.Name = "btn_categorydelete";
            this.btn_categorydelete.Size = new System.Drawing.Size(80, 32);
            this.btn_categorydelete.TabIndex = 6;
            this.btn_categorydelete.Text = "刪除";
            this.btn_categorydelete.UseVisualStyleBackColor = true;
            this.btn_categorydelete.Click += new System.EventHandler(this.btn_categorydelete_Click);
            // 
            // btn_categoryinsert
            // 
            this.btn_categoryinsert.Location = new System.Drawing.Point(397, 6);
            this.btn_categoryinsert.Name = "btn_categoryinsert";
            this.btn_categoryinsert.Size = new System.Drawing.Size(80, 32);
            this.btn_categoryinsert.TabIndex = 6;
            this.btn_categoryinsert.Text = "增新";
            this.btn_categoryinsert.UseVisualStyleBackColor = true;
            this.btn_categoryinsert.Click += new System.EventHandler(this.btn_categoryinsert_Click);
            // 
            // tbx_category
            // 
            this.tbx_category.Location = new System.Drawing.Point(244, 8);
            this.tbx_category.Name = "tbx_category";
            this.tbx_category.Size = new System.Drawing.Size(97, 22);
            this.tbx_category.TabIndex = 5;
            // 
            // cbx_category
            // 
            this.cbx_category.FormattingEnabled = true;
            this.cbx_category.Location = new System.Drawing.Point(132, 9);
            this.cbx_category.Name = "cbx_category";
            this.cbx_category.Size = new System.Drawing.Size(97, 20);
            this.cbx_category.TabIndex = 4;
            // 
            // lb_category
            // 
            this.lb_category.AutoSize = true;
            this.lb_category.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_category.Location = new System.Drawing.Point(14, 7);
            this.lb_category.Name = "lb_category";
            this.lb_category.Size = new System.Drawing.Size(90, 23);
            this.lb_category.TabIndex = 3;
            this.lb_category.Text = "商品種類";
            // 
            // gbx_items
            // 
            this.gbx_items.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbx_items.Controls.Add(this.gbx_manament);
            this.gbx_items.Controls.Add(this.dgv_mainItem);
            this.gbx_items.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbx_items.Location = new System.Drawing.Point(6, 41);
            this.gbx_items.Name = "gbx_items";
            this.gbx_items.Size = new System.Drawing.Size(1196, 489);
            this.gbx_items.TabIndex = 0;
            this.gbx_items.TabStop = false;
            this.gbx_items.Text = "主項目";
            // 
            // gbx_manament
            // 
            this.gbx_manament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbx_manament.Controls.Add(this.btn_up_c);
            this.gbx_manament.Controls.Add(this.btn_clear_C);
            this.gbx_manament.Controls.Add(this.nud_L);
            this.gbx_manament.Controls.Add(this.nud_XL);
            this.gbx_manament.Controls.Add(this.nud_M);
            this.gbx_manament.Controls.Add(this.tbx_name_c);
            this.gbx_manament.Controls.Add(this.tbx_type_c);
            this.gbx_manament.Controls.Add(this.label9);
            this.gbx_manament.Controls.Add(this.label8);
            this.gbx_manament.Controls.Add(this.label7);
            this.gbx_manament.Controls.Add(this.label6);
            this.gbx_manament.Controls.Add(this.lb_t);
            this.gbx_manament.Controls.Add(this.btn_insert_C);
            this.gbx_manament.Controls.Add(this.gbx_additem);
            this.gbx_manament.Controls.Add(this.btn_delete_item);
            this.gbx_manament.Location = new System.Drawing.Point(593, 27);
            this.gbx_manament.Name = "gbx_manament";
            this.gbx_manament.Size = new System.Drawing.Size(597, 456);
            this.gbx_manament.TabIndex = 7;
            this.gbx_manament.TabStop = false;
            this.gbx_manament.Text = "系統更新";
            // 
            // btn_up_c
            // 
            this.btn_up_c.Location = new System.Drawing.Point(169, 156);
            this.btn_up_c.Name = "btn_up_c";
            this.btn_up_c.Size = new System.Drawing.Size(80, 32);
            this.btn_up_c.TabIndex = 27;
            this.btn_up_c.Text = "更新";
            this.btn_up_c.UseVisualStyleBackColor = true;
            this.btn_up_c.Click += new System.EventHandler(this.btn_up_c_Click);
            // 
            // btn_clear_C
            // 
            this.btn_clear_C.Location = new System.Drawing.Point(299, 156);
            this.btn_clear_C.Name = "btn_clear_C";
            this.btn_clear_C.Size = new System.Drawing.Size(80, 32);
            this.btn_clear_C.TabIndex = 26;
            this.btn_clear_C.Text = "全部清除";
            this.btn_clear_C.UseVisualStyleBackColor = true;
            this.btn_clear_C.Click += new System.EventHandler(this.btn_clear_C_Click);
            // 
            // nud_L
            // 
            this.nud_L.Location = new System.Drawing.Point(351, 69);
            this.nud_L.Name = "nud_L";
            this.nud_L.Size = new System.Drawing.Size(50, 27);
            this.nud_L.TabIndex = 25;
            // 
            // nud_XL
            // 
            this.nud_XL.Location = new System.Drawing.Point(430, 69);
            this.nud_XL.Name = "nud_XL";
            this.nud_XL.Size = new System.Drawing.Size(50, 27);
            this.nud_XL.TabIndex = 24;
            // 
            // nud_M
            // 
            this.nud_M.Location = new System.Drawing.Point(275, 69);
            this.nud_M.Name = "nud_M";
            this.nud_M.Size = new System.Drawing.Size(50, 27);
            this.nud_M.TabIndex = 23;
            // 
            // tbx_name_c
            // 
            this.tbx_name_c.Location = new System.Drawing.Point(143, 69);
            this.tbx_name_c.Name = "tbx_name_c";
            this.tbx_name_c.Size = new System.Drawing.Size(102, 27);
            this.tbx_name_c.TabIndex = 22;
            // 
            // tbx_type_c
            // 
            this.tbx_type_c.Location = new System.Drawing.Point(31, 69);
            this.tbx_type_c.Name = "tbx_type_c";
            this.tbx_type_c.Size = new System.Drawing.Size(89, 27);
            this.tbx_type_c.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(430, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "XL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(351, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "L";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "M";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "品名";
            // 
            // lb_t
            // 
            this.lb_t.AutoSize = true;
            this.lb_t.Location = new System.Drawing.Point(36, 34);
            this.lb_t.Name = "lb_t";
            this.lb_t.Size = new System.Drawing.Size(72, 16);
            this.lb_t.TabIndex = 16;
            this.lb_t.Text = "商品種類";
            // 
            // btn_insert_C
            // 
            this.btn_insert_C.Location = new System.Drawing.Point(39, 156);
            this.btn_insert_C.Name = "btn_insert_C";
            this.btn_insert_C.Size = new System.Drawing.Size(80, 32);
            this.btn_insert_C.TabIndex = 15;
            this.btn_insert_C.Text = "增新";
            this.btn_insert_C.UseVisualStyleBackColor = true;
            this.btn_insert_C.Click += new System.EventHandler(this.btn_insert_C_Click);
            // 
            // gbx_additem
            // 
            this.gbx_additem.Controls.Add(this.btn_updata);
            this.gbx_additem.Controls.Add(this.lbx_addonitem);
            this.gbx_additem.Controls.Add(this.btn_deletadditem);
            this.gbx_additem.Controls.Add(this.label1);
            this.gbx_additem.Controls.Add(this.nup_additemprice);
            this.gbx_additem.Controls.Add(this.tbx_additem);
            this.gbx_additem.Controls.Add(this.btn_clearall);
            this.gbx_additem.Controls.Add(this.btn_additem);
            this.gbx_additem.Controls.Add(this.label2);
            this.gbx_additem.Location = new System.Drawing.Point(6, 230);
            this.gbx_additem.Name = "gbx_additem";
            this.gbx_additem.Size = new System.Drawing.Size(403, 219);
            this.gbx_additem.TabIndex = 12;
            this.gbx_additem.TabStop = false;
            this.gbx_additem.Text = "加料項目";
            // 
            // btn_updata
            // 
            this.btn_updata.Location = new System.Drawing.Point(120, 172);
            this.btn_updata.Name = "btn_updata";
            this.btn_updata.Size = new System.Drawing.Size(80, 32);
            this.btn_updata.TabIndex = 23;
            this.btn_updata.Text = "更新";
            this.btn_updata.UseVisualStyleBackColor = true;
            this.btn_updata.Click += new System.EventHandler(this.btn_updata_Click);
            // 
            // lbx_addonitem
            // 
            this.lbx_addonitem.FormattingEnabled = true;
            this.lbx_addonitem.ItemHeight = 16;
            this.lbx_addonitem.Location = new System.Drawing.Point(22, 27);
            this.lbx_addonitem.Name = "lbx_addonitem";
            this.lbx_addonitem.Size = new System.Drawing.Size(199, 132);
            this.lbx_addonitem.TabIndex = 22;
            this.lbx_addonitem.SelectedIndexChanged += new System.EventHandler(this.lbx_addonitem_SelectedIndexChanged);
            // 
            // btn_deletadditem
            // 
            this.btn_deletadditem.Location = new System.Drawing.Point(218, 172);
            this.btn_deletadditem.Name = "btn_deletadditem";
            this.btn_deletadditem.Size = new System.Drawing.Size(80, 32);
            this.btn_deletadditem.TabIndex = 21;
            this.btn_deletadditem.Text = "刪除";
            this.btn_deletadditem.UseVisualStyleBackColor = true;
            this.btn_deletadditem.Click += new System.EventHandler(this.btn_deletadditem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "價格";
            // 
            // nup_additemprice
            // 
            this.nup_additemprice.Location = new System.Drawing.Point(231, 122);
            this.nup_additemprice.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nup_additemprice.Name = "nup_additemprice";
            this.nup_additemprice.Size = new System.Drawing.Size(120, 27);
            this.nup_additemprice.TabIndex = 19;
            // 
            // tbx_additem
            // 
            this.tbx_additem.Location = new System.Drawing.Point(231, 43);
            this.tbx_additem.Name = "tbx_additem";
            this.tbx_additem.Size = new System.Drawing.Size(133, 27);
            this.tbx_additem.TabIndex = 17;
            // 
            // btn_clearall
            // 
            this.btn_clearall.Location = new System.Drawing.Point(316, 172);
            this.btn_clearall.Name = "btn_clearall";
            this.btn_clearall.Size = new System.Drawing.Size(80, 32);
            this.btn_clearall.TabIndex = 16;
            this.btn_clearall.Text = "全部清除";
            this.btn_clearall.UseVisualStyleBackColor = true;
            this.btn_clearall.Click += new System.EventHandler(this.btn_clearall_Click);
            // 
            // btn_additem
            // 
            this.btn_additem.Location = new System.Drawing.Point(22, 172);
            this.btn_additem.Name = "btn_additem";
            this.btn_additem.Size = new System.Drawing.Size(80, 32);
            this.btn_additem.TabIndex = 14;
            this.btn_additem.Text = "增新";
            this.btn_additem.UseVisualStyleBackColor = true;
            this.btn_additem.Click += new System.EventHandler(this.btn_additem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "加料";
            // 
            // btn_delete_item
            // 
            this.btn_delete_item.Location = new System.Drawing.Point(429, 156);
            this.btn_delete_item.Name = "btn_delete_item";
            this.btn_delete_item.Size = new System.Drawing.Size(80, 32);
            this.btn_delete_item.TabIndex = 5;
            this.btn_delete_item.Text = "刪除";
            this.btn_delete_item.UseVisualStyleBackColor = true;
            this.btn_delete_item.Click += new System.EventHandler(this.btn_delete_item_Click);
            // 
            // dgv_mainItem
            // 
            this.dgv_mainItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mainItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_mainItem.Location = new System.Drawing.Point(21, 27);
            this.dgv_mainItem.Name = "dgv_mainItem";
            this.dgv_mainItem.RowTemplate.Height = 24;
            this.dgv_mainItem.Size = new System.Drawing.Size(566, 449);
            this.dgv_mainItem.TabIndex = 6;
            this.dgv_mainItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_mainItem_CellContentClick);
            // 
            // Column8
            // 
            this.Column8.HeaderText = "商品種類";
            this.Column8.Name = "Column8";
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
            // tbc_systemManagemt
            // 
            this.tbc_systemManagemt.Controls.Add(this.product);
            this.tbc_systemManagemt.Controls.Add(this.emplyee);
            this.tbc_systemManagemt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbc_systemManagemt.Location = new System.Drawing.Point(0, 89);
            this.tbc_systemManagemt.Name = "tbc_systemManagemt";
            this.tbc_systemManagemt.SelectedIndex = 0;
            this.tbc_systemManagemt.Size = new System.Drawing.Size(1218, 564);
            this.tbc_systemManagemt.TabIndex = 12;
            // 
            // btn_updata_E
            // 
            this.btn_updata_E.Location = new System.Drawing.Point(944, 71);
            this.btn_updata_E.Name = "btn_updata_E";
            this.btn_updata_E.Size = new System.Drawing.Size(80, 32);
            this.btn_updata_E.TabIndex = 31;
            this.btn_updata_E.Text = "更新";
            this.btn_updata_E.UseVisualStyleBackColor = true;
            this.btn_updata_E.Click += new System.EventHandler(this.btn_updata_E_Click);
            // 
            // btn_clearAll_E
            // 
            this.btn_clearAll_E.Location = new System.Drawing.Point(849, 122);
            this.btn_clearAll_E.Name = "btn_clearAll_E";
            this.btn_clearAll_E.Size = new System.Drawing.Size(80, 32);
            this.btn_clearAll_E.TabIndex = 30;
            this.btn_clearAll_E.Text = "全部清除";
            this.btn_clearAll_E.UseVisualStyleBackColor = true;
            this.btn_clearAll_E.Click += new System.EventHandler(this.btn_clearAll_E_Click);
            // 
            // btn_add_E
            // 
            this.btn_add_E.Location = new System.Drawing.Point(849, 71);
            this.btn_add_E.Name = "btn_add_E";
            this.btn_add_E.Size = new System.Drawing.Size(80, 32);
            this.btn_add_E.TabIndex = 29;
            this.btn_add_E.Text = "增新";
            this.btn_add_E.UseVisualStyleBackColor = true;
            this.btn_add_E.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_delete_E
            // 
            this.btn_delete_E.Location = new System.Drawing.Point(944, 122);
            this.btn_delete_E.Name = "btn_delete_E";
            this.btn_delete_E.Size = new System.Drawing.Size(80, 32);
            this.btn_delete_E.TabIndex = 28;
            this.btn_delete_E.Text = "刪除";
            this.btn_delete_E.UseVisualStyleBackColor = true;
            this.btn_delete_E.Click += new System.EventHandler(this.btn_delete_E_Click_1);
            // 
            // SystemManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 653);
            this.Controls.Add(this.lb_storename);
            this.Controls.Add(this.btn_exit_p);
            this.Controls.Add(this.btn_save_p);
            this.Controls.Add(this.btn_load_p);
            this.Controls.Add(this.cbx_dataloding);
            this.Controls.Add(this.tbc_systemManagemt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SystemManagement";
            this.Text = "SystemManagement";
            this.emplyee.ResumeLayout(false);
            this.emplyee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empolyee)).EndInit();
            this.product.ResumeLayout(false);
            this.product.PerformLayout();
            this.gbx_items.ResumeLayout(false);
            this.gbx_manament.ResumeLayout(false);
            this.gbx_manament.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_L)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_XL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_M)).EndInit();
            this.gbx_additem.ResumeLayout(false);
            this.gbx_additem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_additemprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mainItem)).EndInit();
            this.tbc_systemManagemt.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_storename;
        private System.Windows.Forms.Button btn_exit_p;
        private System.Windows.Forms.Button btn_save_p;
        private System.Windows.Forms.Button btn_load_p;
        private System.Windows.Forms.ComboBox cbx_dataloding;
        private System.Windows.Forms.OpenFileDialog ofd_sm;
        private System.Windows.Forms.SaveFileDialog sfd_sm;
        private System.Windows.Forms.TabPage emplyee;
        private System.Windows.Forms.TabPage product;
        private System.Windows.Forms.Button btn_categorydelete;
        private System.Windows.Forms.Button btn_categoryinsert;
        private System.Windows.Forms.TextBox tbx_category;
        private System.Windows.Forms.ComboBox cbx_category;
        private System.Windows.Forms.Label lb_category;
        private System.Windows.Forms.GroupBox gbx_items;
        private System.Windows.Forms.GroupBox gbx_manament;
        private System.Windows.Forms.GroupBox gbx_additem;
        private System.Windows.Forms.Button btn_deletadditem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nup_additemprice;
        private System.Windows.Forms.TextBox tbx_additem;
        private System.Windows.Forms.Button btn_clearall;
        private System.Windows.Forms.Button btn_additem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_delete_item;
        private System.Windows.Forms.DataGridView dgv_mainItem;
        private System.Windows.Forms.TabControl tbc_systemManagemt;
        private System.Windows.Forms.DataGridView dgv_empolyee;
        private System.Windows.Forms.ListBox lbx_addonitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btn_updata;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox tbx_acount;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.TextBox tbx_level;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_save_employee;
        private System.Windows.Forms.Button btn_insert_C;
        private System.Windows.Forms.NumericUpDown nud_L;
        private System.Windows.Forms.NumericUpDown nud_XL;
        private System.Windows.Forms.NumericUpDown nud_M;
        private System.Windows.Forms.TextBox tbx_name_c;
        private System.Windows.Forms.TextBox tbx_type_c;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_t;
        private System.Windows.Forms.Button btn_up_c;
        private System.Windows.Forms.Button btn_clear_C;
        private System.Windows.Forms.Button btn_updata_E;
        private System.Windows.Forms.Button btn_clearAll_E;
        private System.Windows.Forms.Button btn_add_E;
        private System.Windows.Forms.Button btn_delete_E;
    }
}