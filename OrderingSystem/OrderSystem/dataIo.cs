using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace OrderSystem
{



    class dataIo
    {
        static List<Category> ic = new List<Category>();
        static List<Item> tt = new List<Item>();
        static List<AddOnItem> ai = new List<AddOnItem>();
        static List<TransactionInfo> Tinfo = new List<TransactionInfo>();
        static List<TransactionDetail> Tdetail= new List<TransactionDetail>();
        static List<Account> ac = new List<Account>();
        //------- 讀資料檔案位置

        //public static string setFileFilter()
        //{
        //    string ss = "";
        //    switch ()
        //    {

        //    }
        //    return ss;
        //}

        //---- 讀產品檔案
        //public static bool readData(string fileName, out List<Category> ic)
        //{
        //    bool flag = false;
        //    ic = new List<Category>();
        //    switch ()
        //    {


        //    }
        //    return flag;
        //}//end of  bool readData

        public static bool readScoreInfoInText(string fileName, List<Item> tt, List<Category> ci, List<AddOnItem> ai)
        {
            bool flag = false;
            //string name = 

            // Category cc; //結帳清單 最大類別
            Item ii; // 細部 飲料種類 飲料:價格:價格:價格 
            AddOnItem aa;//  AddOnItem aa; // 加料 名稱: 價格
            Category cc;
            string ss; //全部文字資料
            //string[] allArray;
            string[] allArray; //全部陣列
            string[] typeArray;//飲料種類
            string[] cArray;//類別
            string[] aiArray; // 加項          //string[] aArray;
            string[] aipArray;//加項細分(名稱:價格)
            // uint uTemp; // 資料數目



            try
            {


                StreamReader sr = new StreamReader(fileName);

                ss = sr.ReadToEnd();//讀全部文字資料
                                    //    MessageBox.Show(ss);


                allArray = ss.Trim().Split('\n');// 全部的文字資料切行 放入陣列裡
                                                 //string s1 = "";
                                                 //for (int j = 0; j < allArray.Length; j++)
                                                 //{
                                                 //    s1 += allArray[j] + "\n";
                                                 //}
                                                 //   MessageBox.Show(s1);
                                                 // 解第一行 飲料的類別 寫法 =>>   原始禪飲,原創禪飲,厚奶茶,鮮奶茶
                cArray = allArray[0].Trim().Split(',');
                for (int i = 0; i < cArray.Length; i++)
                {
                    cc = new Category();
                    cc.type = cArray[i];
                    ci.Add(cc);
                }
                //ii = new Item(cArray[i]);
                //for (int i = 0; i < cArray.Length; i++)
                //{
                //    cc = new Category();
                //    cArray[i] = cc.type;
                //    ic.Add(cc);
                //    //ii = new Item(cArray[i]);
                //    //ii.name = cArray[i];
                //    //tt.Add(ii);
                //    //MessageBox.Show(cArray[i]);
                //}
                //string s2 = "";
                //for (int i =0; i < cArray[i].Length;i++)
                //{
                //    s2 += cArray[i] + "\n";
                //}
                //MessageBox.Show(s2);
                //MessageBox.Show(cArray[0]);
                //解第二行 addonitem 寫法 =>> 圓石粉圓:1,復刻仙草凍: 5,奇亞籽: 6
                aiArray = allArray[1].Trim().Split(',');//圓石粉圓:1 加項
                for (int i = 0; i < aiArray.Length; i++)
                {
                    aipArray = aiArray[i].Trim().Split(':');//圓石粉圓 
                    aa = new AddOnItem(aipArray[0], uint.Parse(aipArray[1]));
                    ai.Add(aa);
                }
                ///* string s2 = "*/";
                //for (int i = 0; i < ai.Count(); i++)
                //{

                //    s1 += ai[i].ToString();
                //}
                //MessageBox.Show(s1);


                for (int i = 2; i < allArray.Length; i++) //檔案的第3筆開始 =>>原始禪飲:檸檬水:0:0:35 
                {

                    typeArray = allArray[i].Trim().Split(':');
                    ii = new Item(typeArray[0], typeArray[1], uint.Parse(typeArray[2]), uint.Parse(typeArray[3]), uint.Parse(typeArray[4]));

                    tt.Add(ii);

                }



                //for (int i = 2; i < allArray.Length; i++)
                //{
                //    s2 += allArray[i];
                //}
                //      MessageBox.Show(s2);
                //string s = "";
                //for (int i = 0; i < tt.Count(); i++)
                //{

                //    s += tt[i].ToString();
                //}



                sr.Close();


            }
            catch (Exception ee) { MessageBox.Show(ee.Message); }


            return flag;
        }//end of readScoreInfoInText








        //存交易紀錄

        public static bool TransactionDetailInfoInText(string fileName, List<TransactionInfo> Tinfo, List<TransactionDetail> Tdetail)
        {
            bool flag = false;

            TransactionDetail tDetail;
            TransactionInfo tInfo;

            string ss;
            string[] allArray;
            string[] tarray;// 購買單列
            string[] bArray; // 第一行切的東西
            int tNum; // 紀錄交易筆數
            int numLine;//控制行數

            try
            {
                StreamReader sr = File.OpenText(fileName);

                ss = sr.ReadToEnd();
                allArray = ss.Split('\n');//切行 

                if (allArray.Length > 1)
                {
                    numLine = 0;
                    while ((numLine < allArray.Length) && (allArray[numLine].Trim().Length > 0))
                    {
                        tInfo = new TransactionInfo();
                        tInfo.detail = new List<TransactionDetail>();
                        bArray = allArray[numLine].Trim().Split(','); //06/21/2018,20:16,3,205
                        tInfo.datatime = Convert.ToDateTime(bArray[0].Trim()+" "+bArray[1].Trim());//06/21/2018,20:16
                        tNum = int.Parse(bArray[2].Trim()); // 3 交易筆數
                        tInfo.total = uint.Parse(bArray[3].Trim());//205 總金額

                        for (int i = 1; i <= tNum; i++)//原始禪飲[0]:藍莓水[1]:0[2]:0[3]:0[4]:0[5]:35[6]:1[7]:0[8]:0[9]:35[10]
                        {
                            tarray = allArray[i].Split(':');
                            tDetail = new TransactionDetail();
                            tDetail.type = tarray[0];
                            tDetail.name = tarray[1];
                            tDetail.mprice =uint.Parse( tarray[2]);
                            tDetail.mquantity = uint.Parse(tarray[3]);
                            tDetail.lprice = uint.Parse(tarray[4]);
                            tDetail.lquantity = uint.Parse(tarray[5]);
                            tDetail.xlprice = uint.Parse(tarray[6]);
                            tDetail.xlquantity= uint.Parse(tarray[7]);
                            tDetail.addonPrice = uint.Parse(tarray[8]);
                            tDetail.addonQuantity = uint.Parse(tarray[9]);
                            tDetail.subtotal = uint.Parse(tarray[10]);
                          //  Tdetail.Add(tDetail);
                            tInfo.detail.Add(tDetail);
                          //  Tinfo.Add(tInfo);
                        }//end of for Loop


                    }//end  of while Loop
                    string s = "";
                    for (int i = 0; i < Tinfo.Count; i++)
                    {
                        s += Tinfo[i].ToString();
                    }

                    MessageBox.Show(s);
                }

                sr.Close();
            }//end of try
            catch (Exception ee) { MessageBox.Show(ee.Message); }

            return flag;
        }//end of TransactionDetailInfoInText






        //員工資料

        public static bool empolyeeManagement(string fileName, List<Account> ac)
        {
            bool flag = false;
            Account aa;
            string ss;
            string[] allArray;
            string[] iArray;
            try
            {
                StreamReader sr = new StreamReader(fileName);
               ss =  sr.ReadToEnd();
               allArray =  ss.Split('\n');
                for (int i =0; i<allArray.Length;i++)
                {
                    iArray = allArray[i].Trim().Split(',');
                    aa = new Account(iArray[2],iArray[1],iArray[0]);
                    ac.Add(aa);
                }


            }

            
            catch (Exception ee) { MessageBox.Show(ee.Message); }

            return flag;
        }

    }//end of dataio
}//end of namespace
