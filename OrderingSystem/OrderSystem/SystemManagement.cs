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
    public partial class SystemManagement : Form
    {
        List<Category> cc = new List<Category>();
        List<Item> ii = new List<Item>();
        List<AddOnItem> aa = new List<AddOnItem>();
        List<Account> ac = new List<Account>();


        public SystemManagement()
        {
            InitializeComponent();

            DataGridViewRowCollection rows = dgv_mainItem.Rows;

            //rows.Add(new Object[] {  "檸檬水", "0", "0", "35" });
            //rows.Add(new Object[] {  "藍莓水", "0", "0", "35" });
            //rows.Add(new Object[] {  "咖啡水", "0", "0", "35" });



            //for (int i = 0; i < 20; i++)
            //{
            //    rows.Add();

            //}



        }//end of SystemManagement

        private void btn_beverageclearall_Click(object sender, EventArgs e)
        {

        }//end of beverageclearall

        private void btn_insert_item_Click(object sender, EventArgs e)
        {

        }

        private void btn_clearall_Click(object sender, EventArgs e)
        {
            tbx_additem.Text = "";
            nup_additemprice.Value = 0;
            lbx_addonitem.Items.Clear();
        }

        private void btn_exit_p_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_deletadditem_Click(object sender, EventArgs e)
        {
            for (int i = lbx_addonitem.SelectedIndices.Count - 1; i >= 0; i--)
            {
                lbx_addonitem.Items.RemoveAt(lbx_addonitem.SelectedIndices[i]);
            }

        }//end additem delelt

        private void btn_additem_Click(object sender, EventArgs e)
        {
            lbx_addonitem.Items.Add(tbx_additem.Text + ": " + nup_additemprice.Value.ToString() );
        }//end of additem 

        private void btn_categoryinsert_Click(object sender, EventArgs e)
        {
            cbx_category.Items.Add(tbx_category.Text.ToString());


        }//end of btn_categoryinsert

        private void btn_categorydelete_Click(object sender, EventArgs e)
        {
            cbx_category.Items.Remove(tbx_category.Text);
        }

        private void btn_load_p_Click(object sender, EventArgs e)
        {
            // OpenFileDialog ofdsystemManagement;

            if (ofd_sm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                switch (tbc_systemManagemt.SelectedIndex)
                {
                    case 0:
                        dataIo.readScoreInfoInText(ofd_sm.FileName, ii, cc, aa);
                        foreach (Category type in cc)
                        { cbx_category.Items.Add(type.type); }
                        foreach (AddOnItem add in aa)
                        {
                            lbx_addonitem.Items.Add(add.addItim + ": " + add.addPrice );
                        }
                        foreach (Item data in ii)
                        {
                            dgv_mainItem.Rows.Add(data.type, data.name, data.mprice, data.lprice, data.xlprice);
                        }
                        break;
                    default:
                        dataIo.empolyeeManagement(ofd_sm.FileName, ac);
                        foreach (Account data in ac)
                        {
                            dgv_empolyee.Rows.Add(data.level, data.account, data.password);
                        }

                        break;
                }//end if switch



            }//end of open






        }// end of btnload _p

        private void btn_delete_item_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_mainItem.SelectedRows)
            {
                dgv_mainItem.Rows.Remove(row);
            }
        }

        private void btn_save_p_Click(object sender, EventArgs e)
        {
            sfd_sm.Filter = "(*.txt) | *.txt";
            if (sfd_sm.ShowDialog() == DialogResult.OK)
            {
              //  StreamWriter sww = new StreamWriter(sfd_sm.FileName);
                using (StreamWriter sw = new StreamWriter(sfd_sm.FileName, true, Encoding.Default))

                    switch (tbc_systemManagemt.SelectedIndex)
                    {
                        case 0:
                            for (int i = 0; i < cbx_category.Items.Count; i++)
                            {
                                sw.Write(cbx_category.Items[i].ToString());
                                if (i < cbx_category.Items.Count - 1)
                                {
                                    sw.Write(",");
                                }
                            }//end of catelogy

                            sw.WriteLine();

                            for (int i = 0; i < lbx_addonitem.Items.Count; i++)
                            {

                                sw.Write(lbx_addonitem.Items[i].ToString());
                                if (i < lbx_addonitem.Items.Count - 1)
                                {
                                    sw.Write(":");
                                }
                            }

                            sw.WriteLine();
                            for (int row = 0; row < dgv_mainItem.Rows.Count - 1; row++)
                            {
                                for (int col = 0; col < dgv_mainItem.Columns.Count; col++)
                                {

                                    sw.Write(dgv_mainItem.Rows[row].Cells[col].Value.ToString());
                                    if (col < dgv_mainItem.Columns.Count - 1)
                                    {

                                        sw.Write(":");
                                    }
                                }

                                sw.WriteLine();

                            }//end of 

                            break;

                        case 1:


                            //for (int row = 0; row < dgv_empolyee.Rows.Count; row++)
                            //{
                            //    for (int col = 0; col < dgv_empolyee.Columns.Count; col++)
                            //    {
                            //        sww.Write(dgv_empolyee.Rows[row].Cells[col].Value.ToString());
                            //        if (col < dgv_empolyee.Columns.Count - 1) { sww.Write(','); }
                            //    }

                            //}


                            break;


                    }// end of switch
            }//end of save btn creat saveShowDialog

        }//end of savebtn


        private void lbx_addonitem_SelectedIndexChanged(object sender, EventArgs e)
        {
            //AddOnItem aa = (AddOnItem)lbx_addonitem.SelectedItem;
            //tbx_additem.Text = aa.addItim;
            //nup_additemprice.Value = aa.addPrice;

        }

      
        private void btn_save_employee_Click(object sender, EventArgs e)
        {
            sfd_sm.Filter = "(*.txt) | *.txt";

            if (sfd_sm.ShowDialog() == DialogResult.OK)
            {
              System.IO.StreamWriter sww = new System.IO.StreamWriter(sfd_sm.FileName);
                for (int row = 0; row < dgv_empolyee.Rows.Count; row++)
                {
                    for (int col = 0; col < dgv_empolyee.Columns.Count; col++)
                    {

                        sww.Write(dgv_empolyee.Rows[row].Cells[col].Value.ToString());
                        if (col < dgv_empolyee.Columns.Count - 1) { sww.Write(','); }
                    }

                }
            }

        }// end of  btn_save_employee_

        private void btn_insert_C_Click(object sender, EventArgs e)
        {
            dgv_mainItem.Rows.Add(tbx_type_c.Text.ToString(), tbx_name_c.Text.ToString(), nud_M.Value.ToString(), nud_L.Value.ToString(), nud_XL.Value.ToString());
        }//end of btn_insert_C_Click

        private void btn_clear_C_Click(object sender, EventArgs e)
        {
            tbx_name_c.Text = "";
            tbx_type_c.Text = "";
            nud_L.Value = 0;
            nud_M.Value = 0;
            nud_XL.Value = 0;
        }//end btn_clear_C_Click

        private void dgv_mainItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_mainItem.Rows[e.RowIndex].Cells[0] == null) return;
            tbx_type_c.Text = dgv_mainItem.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbx_name_c.Text = dgv_mainItem.Rows[e.RowIndex].Cells[1].Value.ToString();
            nud_M.Value = Convert.ToUInt16(dgv_mainItem.Rows[e.RowIndex].Cells[2].Value);
            nud_L.Value = Convert.ToUInt16(dgv_mainItem.Rows[e.RowIndex].Cells[3].Value);
            nud_XL.Value = Convert.ToUInt16(dgv_mainItem.Rows[e.RowIndex].Cells[4].Value);
        }

        private void dgv_empolyee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_empolyee.Rows[e.RowIndex].Cells[0] == null) return;
            tbx_level.Text = dgv_empolyee.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbx_acount.Text = dgv_empolyee.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbx_password.Text = dgv_empolyee.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btn_delete_E_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_empolyee.SelectedRows)
            {
                dgv_empolyee.Rows.Remove(row);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgv_empolyee.Rows.Add(tbx_level.Text, tbx_acount.Text, tbx_password.Text);
            tbx_level.Text = "";
            tbx_acount.Text = "";
            tbx_password.Text = "";
        }

        private void btn_clearAll_E_Click(object sender, EventArgs e)
        {
            tbx_level.Text = "";
            tbx_password.Text = "";
            tbx_acount.Text = "";
        }

        private void btn_updata_Click(object sender, EventArgs e)
        {
            AddOnItem aa = (AddOnItem)lbx_addonitem.SelectedItem;
            aa.addItim = tbx_additem.Text; ;
            aa.addPrice =(uint)nup_additemprice.Value;
        }

        private void btn_up_c_Click(object sender, EventArgs e)
        {
            
            dgv_mainItem.Rows.Add(tbx_type_c.Text.ToString(), tbx_name_c.Text.ToString(), nud_M.Value.ToString(), nud_L.Value.ToString(), nud_XL.Value.ToString());
        }

        private void btn_updata_E_Click(object sender, EventArgs e)
        {
            dgv_empolyee.Rows.Add(tbx_level.Text, tbx_acount.Text, tbx_password.Text);
        }
    }//end of class SystemManagement : Form
}//end of namespace
