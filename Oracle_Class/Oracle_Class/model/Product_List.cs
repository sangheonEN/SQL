using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oracle_Class.DBA
{
    class Product_List
    {
        string out_date;
        string product;
        string temp;
        string humi;
        string p_name;
        string tel;


        public Product_List(string out_date, string product, string temp, string humi, string p_name, string tel)
        {
            this.out_date = out_date;
            this.product = product;
            this.temp = temp;
            this.humi = humi;
            this.p_name = p_name;
            this.tel = tel;
        }

        public string Out_date
        {
            get { return out_date; }
            set { out_date = value; }
        }
        public string Product
        {
            get { return product; }
            set { product = value; }
        }
        public string Temp
        {
            get { return temp; }
            set { temp = value; }
        }
        public string Humi
        {
            get { return humi; }
            set { humi = value; }
        }
        public string P_name
        {
            get { return p_name; }
            set { p_name = value; }
        }        
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }
    }
}
