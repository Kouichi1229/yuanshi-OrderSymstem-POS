namespace OrderSystem
{
    partial class MainEntrace
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainEntrace));
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_acount = new System.Windows.Forms.Label();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.tbx_account = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_Performance = new System.Windows.Forms.Button();
            this.btn_systemmangement = new System.Windows.Forms.Button();
            this.btn_order = new System.Windows.Forms.Button();
            this.btn_enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_password.Location = new System.Drawing.Point(35, 116);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(54, 20);
            this.lb_password.TabIndex = 15;
            this.lb_password.Text = "密碼:";
            // 
            // lb_acount
            // 
            this.lb_acount.AutoSize = true;
            this.lb_acount.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_acount.Location = new System.Drawing.Point(35, 72);
            this.lb_acount.Name = "lb_acount";
            this.lb_acount.Size = new System.Drawing.Size(54, 20);
            this.lb_acount.TabIndex = 14;
            this.lb_acount.Text = "帳號:";
            // 
            // tbx_password
            // 
            this.tbx_password.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_password.Location = new System.Drawing.Point(135, 111);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(228, 31);
            this.tbx_password.TabIndex = 13;
            // 
            // tbx_account
            // 
            this.tbx_account.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_account.Location = new System.Drawing.Point(135, 67);
            this.tbx_account.Name = "tbx_account";
            this.tbx_account.Size = new System.Drawing.Size(228, 31);
            this.tbx_account.TabIndex = 12;
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_exit.Location = new System.Drawing.Point(131, 460);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(311, 58);
            this.btn_exit.TabIndex = 11;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_Performance
            // 
            this.btn_Performance.Enabled = false;
            this.btn_Performance.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Performance.Location = new System.Drawing.Point(131, 368);
            this.btn_Performance.Name = "btn_Performance";
            this.btn_Performance.Size = new System.Drawing.Size(311, 58);
            this.btn_Performance.TabIndex = 10;
            this.btn_Performance.Text = "業績管理";
            this.btn_Performance.UseVisualStyleBackColor = true;
            this.btn_Performance.Click += new System.EventHandler(this.btn_Performance_Click);
            // 
            // btn_systemmangement
            // 
            this.btn_systemmangement.Enabled = false;
            this.btn_systemmangement.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_systemmangement.Location = new System.Drawing.Point(131, 277);
            this.btn_systemmangement.Name = "btn_systemmangement";
            this.btn_systemmangement.Size = new System.Drawing.Size(311, 58);
            this.btn_systemmangement.TabIndex = 9;
            this.btn_systemmangement.Text = "系統管理";
            this.btn_systemmangement.UseVisualStyleBackColor = true;
            this.btn_systemmangement.Click += new System.EventHandler(this.btn_systemmangement_Click);
            // 
            // btn_order
            // 
            this.btn_order.Enabled = false;
            this.btn_order.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_order.Location = new System.Drawing.Point(131, 184);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(311, 58);
            this.btn_order.TabIndex = 8;
            this.btn_order.Text = "點餐";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // btn_enter
            // 
            this.btn_enter.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_enter.Location = new System.Drawing.Point(401, 67);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(98, 30);
            this.btn_enter.TabIndex = 16;
            this.btn_enter.Text = "登入";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // MainEntrace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(557, 562);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_acount);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.tbx_account);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_Performance);
            this.Controls.Add(this.btn_systemmangement);
            this.Controls.Add(this.btn_order);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainEntrace";
            this.Text = "Order System Main Entrace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_acount;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.TextBox tbx_account;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_Performance;
        private System.Windows.Forms.Button btn_systemmangement;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Button btn_enter;
    }
}

