using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OrderSystem
{
    public partial class ordering_v2 : Form
    {
        List<Category> cc = new List<Category>();
        List<Item> tt = new List<Item>();
        List<AddOnItem> aa = new List<AddOnItem>();


        DataTable dt;
        DataView dv;




        public ordering_v2()
        {
            InitializeComponent();

           
           
        }

        public void setting()
        {
            nup_Mquantity.Value = 0;
            nup_Lquantity.Value = 0;
            nup_XLquantity.Value = 0;
        }//end of setting

        /*     public void AddItem_cbx_setting()
             {
                 uint addItemPrice;
                 switch (cbx_additem.SelectedIndex)
                 {
                     case 0: addItemPrice = 1; break;
                     case 1: addItemPrice = 5; ; break;
                     default: addItemPrice = 6; break;

                 }


             }*/
        private void dgv_menu_CellContentClick(object sender, DataGridViewCellEventArgs e)//點擊datagridviewg事件
        {
            if (dgv_menu.Rows[e.RowIndex].Cells[0] == null) return;
            btn_type.Text = dgv_menu.Rows[e.RowIndex].Cells[0].Value.ToString();
            btn_product.Text = dgv_menu.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbx_Mprice.Text = dgv_menu.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbx_Lprice.Text = dgv_menu.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbx_XLprice.Text = dgv_menu.Rows[e.RowIndex].Cells[4].Value.ToString();

        }//end of data_menu cell content click

        public void calculate()// 計算總價
        {

            uint sum = 0;

            for (int i = 0; i < dgv_order.Rows.Count; i++)
            {
                DataGridViewRow row = dgv_order.Rows[i];
                if (row.Cells[0].Value != null)
                {
                    sum += (uint)row.Cells[10].Value;

                }

            }
            // MessageBox.Show(sum.ToString());
            tbx_total.Text = sum.ToString();


        }//end of calculate

        private void btn_order_Click(object sender, EventArgs e)// 小計
        {
            String type = btn_type.Text;
            //品名
            String name = btn_product.Text;
            //飲料價格
            uint priceM;
            uint priceL;
            uint priceXL;
            //數量
            uint quantityM = (uint)nup_Mquantity.Value;
            uint quantityL = (uint)nup_Lquantity.Value;
            uint quantityXL = (uint)nup_XLquantity.Value;
            uint addquantity = (uint)nud_addonitem.Value;
            //小計
            //  uint subtotal = tbx_subtotal.Text.ToString();
            //增加項目
            //int 
            // uint addItemPrice;
            // AddItem_cbx_setting();
            uint addItemPrice;
            switch (cbx_additem.SelectedIndex)
            {
                case 0: addItemPrice = 1; break;
                case 1: addItemPrice = 5; ; break;
                case 2: addItemPrice = 6; break;
                default:
                    addItemPrice = 0;
                     break;
            }
            //total
            //calculate

            if (uint.TryParse(tbx_Mprice.Text, out priceM) && uint.TryParse(tbx_Lprice.Text, out priceL) && uint.TryParse(tbx_XLprice.Text, out priceXL))
            {
                uint sum = +priceM * quantityM + priceL * quantityL + priceXL * quantityXL + addItemPrice * addquantity;
                tbx_subtotal.Text = sum.ToString();
                //show

                dgv_order.Rows.Add(new Object[] {type, name, priceM, quantityM, priceL, quantityL, priceXL, quantityXL, addItemPrice, addquantity, sum });
                // add to order
                //calculate();
            }
           calculate();

            setting();
           
            // dgv_order.AutoResizeColumns();
        }//end of btn_order


        private void btn_exit_order_Click(object sender, EventArgs e)
        {
            this.Close();
        }//end of exit

        private void btn_clearall_Click(object sender, EventArgs e)
        {
            tbx_subtotal.Text = "";
            dgv_order.Rows.Clear();
        }//end of btn_clearAll

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            gbx_report.Visible = true;
        }//end of checkout_btn


        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_order.SelectedRows)
            {
                dgv_order.Rows.Remove(row);
            }
        }//delete
        private void cbx_catelogyitem_SelectedIndexChanged(object sender, EventArgs e) // 選擇飲料項目篩選
        {
            //string selectItem = cbx_catelogyitem.SelectedItem.ToString();


           // dv.RowFilter = selectItem;




        }//end of cbx_catelogyitem
        #region read write file
        private void btn_loadfile_Click(object sender, EventArgs e)
        {
            // tt = new List<Item>();
            // Item ii;


            if (ofd_order.ShowDialog() == DialogResult.OK)
            {
                tt = new List<Item>();
                cc = new List<Category>();

                switch (cbx_filetype.SelectedIndex)
                {
                    case 0:
                    default:
                        ofd_order.Filter = "(*.txt) | *.txt";
                        dataIo.readScoreInfoInText(ofd_order.FileName, tt, cc, aa);
                        foreach (Category type in cc)
                        {
                            cbx_catelogyitem.Items.Add(type.type);
                        }

                        foreach (Item data in tt)
                        {
                            dgv_menu.Rows.Add(data.type, data.name, data.mprice, data.lprice, data.xlprice);
                        }
                   //     dgv_menu.AutoResizeColumns();
                        break;

                }
              



            }//file open ok
            else { MessageBox.Show("Selete right file "); }









        }// loading data

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = System.DateTime.Now;


            // using (StreamWriter sw = new StreamWriter(sfd_order.FileName, true, Encoding.Default))
            
            sfd_order.Filter = "(*.csv) | *.csv|(*.txt) | *.txt";
            if (sfd_order.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd_order.FileName, true, Encoding.UTF8))


                    if (rbtn_txt.Checked == true)
                    {
                        // StreamWriter sw = new StreamWriter(sfd_order.FileName/*, System.Text.Encoding.UTF8*/);
                        
                        sw.WriteLine(dt.ToString("MM/dd/yyyy,HH:mm") + "," + (dgv_order.Rows.Count - 1).ToString() + "," + tbx_total.Text.ToString());// 時間 交易筆數 總價

                        for (int row = 0; row < dgv_order.Rows.Count - 1; row++)
                        {

                            for (int col = 0; col < dgv_order.Columns.Count; col++)
                            {
                                sw.Write(dgv_order.Rows[row].Cells[col].Value.ToString() , System.Text.Encoding.UTF8);//交易明細

                                if (col < 10) { sw.Write(":"); }
                                
                            }//end of datagridveiw col
                            
                            sw.WriteLine();

                        }//end og datagridveiw row
                        sw.Close();


                    }
                    else if (rbtn_excle.Checked == true)
                    {

                        
                        sw.WriteLine(dt.ToString() + "," + (dgv_order.Rows.Count - 1).ToString() + "," + tbx_total.Text.ToString());// 時間 交易筆數 總價

                        for (int row = 0; row < dgv_order.Rows.Count - 1; row++)
                        {

                            for (int col = 0; col < dgv_order.Columns.Count; col++)
                            {
                                sw.Write(dgv_order.Rows[row].Cells[col].Value.ToString(), System.Text.Encoding.UTF8);//交易明細

                                if (col < 10) { sw.Write(":"); }

                            }//end of datagridveiw col

                            sw.WriteLine();

                        }//end og datagridveiw row
                        sw.Close();




                        sw.Close();

                    }

                

                }//end of save if
        }//end of save


        #endregion

        // System.IO.StreamWriter(fs, System.Text.Encoding.ASCII)



    }//end of class
}//end ofnamespace
