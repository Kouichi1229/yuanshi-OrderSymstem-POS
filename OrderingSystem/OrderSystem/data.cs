using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    class data
    {
    }//end of class

    public class Account // 帳號管理 帳號 密碼 等級
    {
        private string pAccount;
        private string pPassword;
        private string pLevel;

        public string account { get { return pAccount; } set { pAccount = value; } }
        public string password { get { return pPassword; } set { pPassword = value; } }

        public string level { get { return pLevel; } set { pLevel = value; } }

        public Account(string aa, string pp, string ll)
        {
            if ((aa != null) && (aa.Trim().Length > 0)) pAccount = aa;
            else pAccount = "Test";
            if ((pp != null) && (pp.Trim().Length > 0)) pPassword = pp;
            else pPassword = "Test";
            if ((ll != null) && (ll.Trim().Length > 0)) pLevel = ll;
            else pLevel = "c";
        }
    }//end of account



    public class Item // 商品項目 產品名稱 價格 M L XL
    {

        private string iName; // 品名
        private string iType;//項目
        private uint mPrice;//價格
        private uint lPrice;
        private uint xlPrice;


        public string name
        {
            get { return iName; }
            set { iName = value; }
        }

        public string type { get { return iType; } set { iType = value; } }
        public uint mprice { get { return mPrice; } set { mPrice = value; } }
        public uint lprice { get { return lPrice; } set { lPrice = value; } }
        public uint xlprice { get { return xlPrice; } set { xlPrice = value; } }
        //-- constructor---///

        //  public Item( string nn,uint pp) { name = nn;price = pp; }
        public Item() { setInitialInfo("Type", "item", 0, 0, 0); }
        //public Item(string nn,uint mp,uint lp,uint xlp ) { setInitialInfo(nn,mp,lp,xlp); }//品名 項目 價格(M L XL)

        public Item(string tt)
        {
            setInitialInfo(tt, "item", 0, 0, 0);
        }

        public Item(string tt, string nn)
        {
            setInitialInfo(tt, nn, 0, 0, 0);
        }
        public Item(string tt, string nn, uint mp)
        {
            setInitialInfo(tt, nn, mp, 0, 0);
        }
        public Item(string tt, string nn, uint mp, uint lp)
        {
            setInitialInfo(tt, nn, mp, lp, 0);
        }


        public Item(string tt, string nn, uint mp, uint lp, uint xlp)
        {
            iType = tt;
            iName = nn;
            mPrice = mp;
            lPrice = lp;
            xlPrice = xlp;
        }

        void setInitialInfo(string tt, string nn, uint mp, uint lp, uint xlp) //品名 項目 價格(M L XL)
        {
            iType = tt;
            iName = nn;
            mPrice = mp;
            lPrice = lp;
            xlPrice = xlp;

        }
        public override string ToString()
        {
            string ss = type + ":" + name + ":" + mprice + ":" + lprice + ":" + xlprice + "\n";

            return ss;
        }




    }//end of item

    public class Category //產品類別  名稱
    {
        private string cType;//  商品類別
                             //  private string cName;//品名
        private List<Item> Item = new List<Item>();
        private List<AddOnItem> pAdddOnItem = new List<AddOnItem>();
        //private List<Option> pOption = new List<Option>();


        public string type { get { return cType; } set { cType = value; } }

        //public string name
        //{
        //    get { return cName; }
        //    set { if ((value != null) && (value.Trim().Length > 0)) { cName = value; } }
        //}//end 
        public List<Item> item
        {

            get { return Item; } set { Item = value; } 
        }

        public List<AddOnItem> adddOnItem { get { return pAdddOnItem; } set { pAdddOnItem = value; } }

        //  public List<Option> option { get; set; }

        //public Category() { setInitialInfo(1, "Category", new List<Item>(), new List<AddOnItem>()/*,new List<Option>())*/; }
        //public Category(uint cc, string nn) { setInitialInfo(cc, nn, new List<Item>(), new List<AddOnItem>()/*, new List<Option>())*/; }
        //public Category(uint cc, string nn,List<Item>ii) { setInitialInfo(cc, nn, ii, new List<AddOnItem>()/*, new List<Option>())*/; }
        /*  public Category(uint cc, string nn, List<Item> ii , List<AddOnItem> aa, List<Option> oo)
          {
              setInitialInfo(cc, nn, ii,aa,oo);
          }
          */
        //  public Category() { setInitialInfo("Type","new List<Item>(),new List<AddOnItem>()); }
        public Category()
        {
            setInitialInfo("Type", new List<Item>(), new List<AddOnItem>());
        }

        public Category(string tt)
        {
            setInitialInfo(tt, new List<Item>(), new List<AddOnItem>());
        }
        public Category(string tt, List<Item> ii)
        {
            setInitialInfo(tt, ii, new List<AddOnItem>());
        }
        public Category(string tt, List<Item> ii, List<AddOnItem> aa)
        {
            setInitialInfo(tt, ii, aa);
        }



        void setInitialInfo(string tt, /*string nn, */List<Item> ii, List<AddOnItem> aa/*,List<Option>oo */)
        {
            cType = tt;
            //name = nn;
            item = ii;
            adddOnItem = aa;
            // option = oo;
        }

    }//end of class Category


    public class AddOnItem //添加項目 加料
    {
        private string aItem;
        private uint aprice;

        public string addItim { get { return aItem; } set { aItem = value; } }
        public uint addPrice { get { return aprice; } set { aprice = value; } }

        public AddOnItem() { setInitialInfo("AddItem", 0); }
        public AddOnItem(string aa) { setInitialInfo(aa, 0); }
        public AddOnItem(string ad, uint pp)
        {
            aItem = ad;
            aprice = pp;
        }


        void setInitialInfo(string inn, uint ap)
        {
            aItem = inn;
            aprice = ap;
        }

        public override string ToString()
        {
            string ss = addItim + ":" + addPrice + "\n";

            return ss;
        }

    }//end of addonitem

    //public class Option // 項目 大杯 小杯 
    //{ }//end of option

    //交易紀錄
    public class TransactionInfo
    {
        private DateTime t_dt;// 日期
        private string t_employeeAcount;//登入人員
        private List<TransactionDetail> t_td = new List<TransactionDetail>();// 細項
        private uint t_total;//總價 2018/6/19 上午 09:24:35,4, 235 <==
        private uint t_count; // 幾筆  2018/6/19 上午 09:24:35,4 <==,235

        public DateTime datatime
        {
            get { return t_dt; }
            set { t_dt = value; }
        }

        public string employeeAccount
        {
            get { return t_employeeAcount; }
            set { t_employeeAcount = value; }

        }


        public List<TransactionDetail> detail
        {
            get { return t_td; }
            set { t_td = value; }
        }

        public uint total
        {
            get { return t_total; }
            set { t_total = value; }
        }
      public uint count
        {
            get { return t_count; }
            set { t_count = value; }
        }


        //----------------construct

        public TransactionInfo()
        {
            setInitialInfo(datatime, "Name", new List<TransactionDetail>(),0, 0);
        }
        
        public TransactionInfo(DateTime dt)
        {
            setInitialInfo(dt,"Name",new List<TransactionDetail>(),0,0);
        }
        public TransactionInfo(DateTime dt, string employee)
        {
            setInitialInfo(dt, employee,new List<TransactionDetail>(),0,0);
        }

        public TransactionInfo(DateTime dt, string employee,uint tot)
        {
            setInitialInfo(dt, employee, new List<TransactionDetail>(), tot, 0);
        }
      
        public TransactionInfo(DateTime dt, string employee, List<TransactionDetail> tt, uint tot, uint cc)
        {
            setInitialInfo(dt, employee, tt, tot, cc);
        }
        


        void setInitialInfo(DateTime dt, string employee, List<TransactionDetail> tt, uint tot, uint cc)
        {
            t_dt = dt;
            t_employeeAcount = employee;
            t_td = tt;
            t_total = tot;
            count = cc;

        }

        public override string ToString()
        {
            string ss = datatime +":" +count+ ": Total = " + total + "\n" + detail.ToString() ;
            return ss;
        }
        //private DateTime t_dt;// 日期
        //private string t_employeeAcount;//登入人員
        //private List<TransactionDetail> t_td = new List<TransactionDetail>();// 細項
        //private uint t_total;//總價 2018/6/19 上午 09:24:35,4, 235 <==
        //private uint t_count; // 幾筆  2018/6/19 上午 09:24:35,4 <==,235


    }//end of Transaction


    public class TransactionDetail
    {
        private string tType;
        private string tName;
        private uint t_mprice;
        private uint t_lprice;
        private uint t_xlprice;
        private uint t_mquantity;
        private uint t_lquantity;
        private uint t_xlquantity;
        // private List<AddOnItem> t_additem = new List<AddOnItem>();
        private uint t_aprice;
        private uint t_aquantity;
        private uint t_subtotal;

        public string type { get { return tType; } set { tType = value; } }

        public string name { get { return tName; } set { tName = value; } }
        // 價格
        public uint mprice
        { get { return t_mprice; } set { t_mprice = value; } }
        public uint lprice
        { get { return t_lprice; } set { t_lprice = value; } }
        public uint xlprice
        { get { return t_xlprice; } set { t_xlprice = value; } }


        // 數量
        public uint mquantity
        {
            get { return t_mquantity; }
            set { t_mquantity = value; }
        }

        public uint lquantity
        {
            get { return t_lquantity; }
            set { t_lquantity = value; }
        }
        public uint xlquantity
        {
            get { return t_xlquantity; }
            set { t_xlquantity = value; }
        }
        public uint addonPrice
        {
            get { return t_aprice; }
            set { t_aprice = value; }
        }

        public uint addonQuantity
        {
            get { return t_aquantity; }
            set { t_aquantity = value; }
        }


        //private List<AddOnItem> additem
        //{
        //    //get; set;
        //    get { return t_additem; }
        //    set { t_additem = value; }
        //}

     public uint subtotal
        {
            get { return t_subtotal; }
            set { t_subtotal = value; }
        }

        //----------------------------------
        public TransactionDetail(string tt, string nn, uint mp, uint lp, uint xlp, uint mqq, uint lqq, uint xlqq,/* List<AddOnItem> ad, */ uint ap,uint aq, uint st)
        {
            setInitialInfo(tt, nn, mp, lp, xlp, mqq, lqq, xlqq,/*ad,*/ap, aq,st);
        }
        public TransactionDetail()
        {
            setInitialInfo("type", "name", 1, 1, 1, 1, 1, 1,/*ad,*/1,1, 1);
        }
        public TransactionDetail(string nn, uint mp, uint lp, uint xlp, uint mqq, uint lqq, uint xlqq,/* List<AddOnItem> ad, */ uint ap)
        {
            setInitialInfo("type", nn, mp, lp, xlp, mqq, lqq, xlqq,/*ad,*/ap, 1, 1);
        }

        public TransactionDetail(string tt)
        {
            setInitialInfo(tt,"name", 1, 1, 1,1, 1, 1,/*ad,*/1, 1,1);
        }
        public TransactionDetail(string tt, string nn)
        {
            setInitialInfo(tt, nn, 1, 1, 1, 1, 1, 1,/*ad,*/1,1 ,1);
        }
        public TransactionDetail(string tt, string nn, uint mp)
        {
            setInitialInfo(tt, nn, mp, 1, 1, 1, 1, 1,/*ad,*/1, 1,1);
        }
        public TransactionDetail(string tt, string nn, uint mp,uint lp)
        {
            setInitialInfo(tt, nn, mp, lp, 1, 1, 1, 1,/*ad,*/1, 1,1);
        }
        public TransactionDetail(string tt, string nn, uint mp, uint lp,uint xlp)
        {
            setInitialInfo(tt, nn, mp, lp, xlp, 1, 1, 1,/*ad,*/1, 1,1);
        }
        public TransactionDetail(string tt, string nn, uint mp, uint lp, uint xlp,uint mqq )
        {
            setInitialInfo(tt, nn, mp, lp, xlp, mqq, 1, 1,/*ad,*/1, 1,1);
        }

        public TransactionDetail(string tt, string nn, uint mp, uint lp, uint xlp, uint mqq,uint lqq)
        {
            setInitialInfo(tt, nn, mp, lp, xlp, mqq, lqq, 1,/*ad,*/1, 1,1);
        }
        public TransactionDetail(string tt, string nn, uint mp, uint lp, uint xlp, uint mqq, uint lqq,uint xlqq)
        {
            setInitialInfo(tt, nn, mp, lp, xlp, mqq, lqq,xlqq,/*ad,*/xlqq, 1,1);
        }
        public TransactionDetail(uint mp, uint lp, uint xlp, uint mqq, uint lqq, uint xlqq,/* List<AddOnItem> ad, */ uint ap)
        {
            setInitialInfo("type","name", mp, lp, xlp, mqq, lqq, xlqq,/*ad,*/ap, 1,1);
        }
        public TransactionDetail(uint mp, uint lp, uint xlp, uint mqq, uint lqq, uint xlqq,/* List<AddOnItem> ad, */ uint ap,uint aq)
        {
            setInitialInfo("type", "name", mp, lp, xlp, mqq, lqq, xlqq,/*ad,*/ap, aq, 1);
        }

      
        void setInitialInfo(string tt, string nn, uint mp, uint lp, uint xlp, uint mqq, uint lqq, uint xlqq,/*List<AddOnItem> ad,*/uint ap, uint aq, uint st)
        {
            tType = tt;
            tName = nn;
            t_mprice = mp;
            t_lprice = lp;
            t_xlprice = xlp;
            mquantity = mqq;
            lquantity = lqq;
            xlquantity = xlqq;
            t_aprice = ap;
            t_aquantity = aq;
            //  t_additem = ad;
            subtotal = st;

        }
        public override string ToString()
        {
            string ss = type+":"+name+":"+mprice+ ":"+mquantity+ ":"+lprice+ ":"+lquantity+ ":"+xlprice+ ":"+xlquantity+ ":"+addonPrice+ ":"+addonQuantity+ ":"+subtotal;
            return ss;
        }

        

    }//end of TransactionDetail







}//end of OrderSystem
