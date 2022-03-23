using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace OrderSystem
{
    public partial class PerformanceManagement : Form
    {

        List<TransactionInfo> tif = new List<TransactionInfo>();
        List<TransactionDetail> td = new List<TransactionDetail>();
        public PerformanceManagement()
        {
            InitializeComponent();
        }

        private void btn_exit_p_Click(object sender, EventArgs e)
        {
            this.Close();
        }//end of exictbtn

        private void creatGraphLine(ZedGraphControl zgc, List<TransactionInfo> tif, List<TransactionDetail> td) // 可以用傳陣列的方式傳入資料 // 線圖

        {
            zgc.GraphPane.CurveList.Clear();

            string[] xData = new string[tif.Count];
            double[] yData = new double[tif.Count];





            GraphPane paneLine = zgc.GraphPane;
            LineItem line;
            //---------------type

            paneLine.Title.FontSpec.Size = 18f;
            paneLine.Title.Text = "銷售資料";
            paneLine.XAxis.Title.Text = "日期";
            paneLine.YAxis.Title.Text = "數量";

            if (rbtn_daySale.Checked)
            {
                paneLine.XAxis.Title.Text = "日期";
                paneLine.YAxis.Title.Text = "營業額";

                for (int i = 0; i < tif.Count; i++)
                {
                    xData[i] = tif[i].datatime.ToShortDateString().ToString();
                    yData[i] = tif[i].total;
                }

            }
            else if (rbtn_itemSale.Checked)
            {
                paneLine.XAxis.Title.Text = "項目";
                paneLine.YAxis.Title.Text = "數量";

                for (int i  =0; i<tif.Count;i++)
                {
                    xData[i] = td[i].name.ToString();
                    yData[i] = (td[i].mquantity + td[i].xlquantity + td[i].lquantity); 
                }


            }
            else if (rbtn_TypeSale.Checked)
            {
                paneLine.XAxis.Title.Text = "種類";
                paneLine.YAxis.Title.Text = "總價";
                for (int i = 0; i < tif.Count; i++)
                {
                    xData[i] = td[i].type.ToString();
                    yData[i] = td[i].subtotal;
                }
            }

          







            zgc.AxisChange();

        }//end of creatGraphLine



        private void creatGraphChart(ZedGraphControl zgc, List<TransactionInfo> tif, List<TransactionDetail> td) //圓餅圖
        {
            zgc.GraphPane.CurveList.Clear();

            GraphPane paneChart = zgc.GraphPane;
            PieItem pie;
            string[] xData = new string[tif.Count];
            double[] yData = new double[tif.Count];





            paneChart.Title.Text = "銷售資料";
            paneChart.XAxis.Title.Text = "日期";
            paneChart.YAxis.Title.Text = "數量";

            paneChart.Fill = new Fill(Color.Wheat, Color.White, 45.0f);

            paneChart.Chart.Fill.Type = FillType.None;
            paneChart.Legend.Position = LegendPos.Float;
            paneChart.Legend.Location = new Location(0f, 0f, CoordType.PaneFraction, AlignH.Left, AlignV.Top);



      













            zgc.AxisChange();

        }//end of creatGraphChart


        private void creatGraphBar(ZedGraphControl zgc, List<TransactionInfo> tif) // 長條圖
        {
            zgc.GraphPane.CurveList.Clear();

            GraphPane paneBar = zgc.GraphPane;
            BarItem bar;
            string[] xData = new string[tif.Count];
            double[] yData = new double[tif.Count];
            List<string> xxData = new List<string>();
            List<double> yyData = new List<double>();

            paneBar.Title.Text = "飲料銷售分析";

            if (rbtn_daySale.Checked)
            {
                paneBar.XAxis.Title.Text = "日期";
                paneBar.YAxis.Title.Text = "營業額";

                //計算相同資料
                for (int i = 0; i < tif.Count; i++)
                {
                    xData[i] = tif[i].datatime.ToShortDateString().ToString();
                    yData[i] = tif[i].total;
                }

            }
            else if (rbtn_itemSale.Checked)
            {
                paneBar.XAxis.Title.Text = "項目";
                paneBar.YAxis.Title.Text = "數量";

                for (int i = 0; i < tif.Count; i++)
                {
                    xData[i] = td[i].name.ToString();
                    yData[i] = (td[i].mquantity + td[i].xlquantity + td[i].lquantity);
                }


            }
            else if (rbtn_TypeSale.Checked)
            {
                paneBar.XAxis.Title.Text = "種類";
                paneBar.YAxis.Title.Text = "總價";
                for (int i = 0; i < tif.Count; i++)
                {
                    xData[i] = td[i].type.ToString();
                    yData[i] = td[i].subtotal;
                }
            }



















            zgc.AxisChange();


        }//end of creatGraphBar

        private void btn_show_Click(object sender, EventArgs e)
        {
            //string title = "餐點類型與銷售金額";
            //string x = "銷售金額(NT$)";
            //string y = "產品類型";


            if (rbtn_chart.Checked == true)
            {

            }
            else if (rbtn_line.Checked==true)
            {

            }

            else
            {

            }

        }//end of show 

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }//exit_q

        private void btn_load_p_Click(object sender, EventArgs e)
        {
            if (ofd_PM.ShowDialog()==DialogResult.OK)
            {
                dataIo.TransactionDetailInfoInText(ofd_PM.FileName,tif,td);
            }
            
        }//end of load product

        private void btn_load_q_Click(object sender, EventArgs e)
        {


            if (ofd_PM.ShowDialog()==DialogResult.OK)
            {
                
                dataIo.TransactionDetailInfoInText(ofd_PM.FileName,tif,td);
                foreach (TransactionDetail data in td)
                {
                    dgv_query.Rows.Add(data.type,data.name,data.mquantity,data.lquantity,data.xlquantity,data.subtotal);
                }

            }
        }//end of load query
    }//end of class
}//end of namespace
