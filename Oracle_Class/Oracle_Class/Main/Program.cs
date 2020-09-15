using Oracle.ManagedDataAccess.Client;
using Oracle_Class.DBA;
using Oracle_Class.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oracle_Class
{
    static class Program
    {


        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //ODBM o = new ODBM();
            //o.dbConnect();
            //o.dbClosed();

            ODBM.getInstance().dbConnect();

            util.Menu m = new util.Menu();

            while (true)
            {
                switch (m.showmenu())
                {
                    case 1:
                        ODBM.getInstance().createTable();
                        ODBM.getInstance().createSequence();
                        break;
                    case 2:
                        ODBM.getInstance().deleteTable();
                        ODBM.getInstance().deleteSequence();
                        break;
                    case 3:
                        ODBM.getInstance().insertDB();
                        break;
                    case 4:
                        ODBM.getInstance().selectDB();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
