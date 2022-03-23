using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSystem
{
    public partial class MainEntrace : Form
    {

        List<Account> ac = new List<Account>();
        public MainEntrace()
        {
            InitializeComponent();
        }//end og mainentrace

        private void btn_order_Click(object sender, EventArgs e)
        {
            //Form ff = new ordering();
            Form ff = new ordering_v2();
            ff.Show();
        }//end of btn_order

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//end of exit

        private void btn_systemmangement_Click(object sender, EventArgs e)
        {
            Form sm = new SystemManagement();
            sm.Show();
        }//end of btn_systemmangement

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if ((tbx_account.Text != "") && (tbx_password.Text != ""))
            {
                // 讀到員工資料 在開啟



                btn_order.Enabled = true;
                btn_Performance.Enabled = true;
                btn_systemmangement.Enabled = true;
            }

            else
            {
                MessageBox.Show("請輸入帳號密碼");
            }
        }//end of btn_enter

        private void btn_Performance_Click(object sender, EventArgs e)
        {
            Form pm = new PerformanceManagement();
            pm.Show();
        }//end of btn_Performance
    }//end of class
}//end of namespace
