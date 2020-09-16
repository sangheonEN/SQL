using Oracle_Class.DBA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oracle_Class.util
{
    class RandomData
    {
        Random r = new Random();

        static string[] out_date = { "1/10", "2/10", "3/10", "4/10", "5/10" };
        static string[] product = { "A", "B", "C", "D", "E" };
        static string[] temp = { "1도", "2도", "3도", "4도", "5도" };
        static string[] humi = { "1%", "2%", "3%", "4%", "5%" };
        static string[] p_name = { "A.A", "B.A", "C.A", "D.A", "E.A" };
        static string[] tel = { "123", "456", "789", "012", "345" };
        public string getRandProduct()
        {
            return product[r.Next(0, 5)];
        }
        public string getRandOutdate()
        {
            return out_date[r.Next(0, 5)];
        }
        public string getRandTemp()
        {
            return temp[r.Next(0, 5)];
        }
        public string getRandHumi()
        {
            return humi[r.Next(0, 5)];
        }
        public string getRandP_name()
        {
            return p_name[r.Next(0, 5)];
        }
        public string getRandTel()
        {
            return tel[r.Next(0, 5)];
        }


        public Product_List getProductList()
        {
            return new Product_List(out_date[r.Next(0, 5)],
                                    product[r.Next(0, 5)],
                                    temp[r.Next(0, 5)],
                                    humi[r.Next(0, 5)],
                                    p_name[r.Next(0, 5)],
                                    tel[r.Next(0, 5)]);
        }

    }
}
