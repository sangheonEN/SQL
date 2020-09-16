using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oracle_Class.DBA
{
    class ODBM
    {
        public string ORADB = "Data Source = (DESCRIPTION=(ADDRESS_LIST=" +
                      "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
                      "(CONNECT_DATA=(SERVER=DEDICATED(SERVICE_NAME=XE)));" +
                      "User id=HR;Password=1234;";

        static ODBM orainst;
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataReader odr;
        public static ODBM getInstance()
        {
            if (orainst == null)
            {
                orainst = new ODBM();
            }
            return orainst;
        }

        public ODBM()
        {
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();

        }

        ~ODBM()
        {
            dbClosed();
        }

        public void dbConnect()
        {
            try
            {
                conn.Open();

                Console.WriteLine("오라클 접속완료!");

                //OracleCommand ocmd = new OracleCommand(&"", o);
                //OracleDataAdapter oda = new OracleDataAdapter(ocmd);
            }
            catch (OracleException e)
            {
                Console.WriteLine("접속 에러 : " + e.Message);
            }
        }

        public void dbClosed()
        {

            try
            {
                conn.Close();
                Console.WriteLine("오라클 접속 해제 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("Close 에러 : " + e.Message);
            }
        }

        public void createTable()
        {
            try
            {
                //Table 생성
                string query = "create table smf (" +
                               "idx number not null, " +
                               "out_date varchar(20) not null," +
                               "product varchar(20) not null, " +
                               "temp varchar(20) not null, " +
                               "humi varchar(20) not null, " +
                               "p_name varchar(20) not null, " +
                               "tel varchar(20) not null, " +
                               "constraint pk_smf_idx primary key(idx))";

                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();                // auto commit! 커밋을 자동으로 해줌

                Console.WriteLine("테이블 생성");
            }
            catch (OracleException e)
            {
                errorMessage("테이블 생성 오류 ", e);
            }
        } 

        public void createSequence()
        {
            try
            {
                //시퀀스 생성
                string query2 = "create sequence seq_idx increment " + "by 1 start with 1";

                cmd.CommandText = query2;
                cmd.ExecuteNonQuery();
                Console.WriteLine("시퀀스 생성");
            }
            catch (OracleException e)
            {
                errorMessage("시퀀스 생성 오류 ", e);
            }

        }

        public void deleteTable()
        {
            try
            {
                //Table 삭제
                string query = "drop table smf";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();                // auto commit! 커밋을 자동으로 해줌

                Console.WriteLine("테이블 삭제");
            }
            catch (OracleException e)
            {
                errorMessage("테이블 삭제 오류 ", e);
            }
        }

        public void deleteSequence()
        {
            try
            {
                //시퀀스 삭제
                string query2 = "drop sequence SEQ_IDX";

                cmd.CommandText = query2;
                cmd.ExecuteNonQuery();
                Console.WriteLine("시퀀스 삭제");
            }
            catch (OracleException e)
            {
                errorMessage("시퀀스 삭제 오류 ", e);
            }
        }

        public void insertDB()
        {
            try
            {
                //Table 삭제
                string query = "insert into smf values (" +
                               "seq_idx.nextval, " +
                               "'2020년09월30일', " +
                               "'자동차', " +
                               "'30도', " +
                               "'30%', " +
                               "'K7', " +
                               "'010-3234-1906')";                                                              ;
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();                // auto commit! 커밋을 자동으로 해줌

                Console.WriteLine("데이터 추가 완료!");
            }
            catch (OracleException e)
            {
                errorMessage("데이터 추가 오류 ", e);
            }
        }

        public void insertDBRandom(Product_List prod)            //매개변수가 있는 DB를 가지고 랜덤하게 숫자를 뽑아줌
        {
            try
            {
                //Table 삭제
                string query = string.Format("insert into smf values (" +
                               "seq_idx.nextval, " +
                               "'{0}', " +
                               "'{1}', " +
                               "'{2}', " +
                               "'{3}', " +
                               "'{4}', " +
                               "'{5}')", prod.Out_date, prod.Product, prod.Temp, prod.Humi, prod.P_name, prod.Tel);
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();                // auto commit! 커밋을 자동으로 해줌

                Console.WriteLine("랜덤 데이터 추가 완료!");
            }
            catch (OracleException e)
            {
                errorMessage("랜덤 데이터 추가 오류 ", e);
            }
        }

        public void selectDB()
        {
            int count = 0;
            try
            {
                //Table 삭제
                string query = "select * from smf";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();

                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        count++;
                        Console.WriteLine($"번호: {count}");
                        Console.WriteLine($"날짜: {reader["out_date"]}");
                        Console.WriteLine($"기업명: {reader["product"]}");
                        Console.WriteLine($"온도: {reader["temp"]}");
                        Console.WriteLine($"습도: {reader["humi"]}");
                        Console.WriteLine($"모델명: {reader["p_name"]}");
                        Console.WriteLine($"연락처: {reader["tel"]}");
                        Console.WriteLine($"------------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("데이터가 존재하지 않습니다.");
                }
                reader.Close();

                cmd.ExecuteNonQuery();                // auto commit! 커밋을 자동으로 해줌

                Console.WriteLine("전체 데이터 조회 완료!");
            }
            catch (OracleException e)
            {
                errorMessage("데이터 조회 오류 ", e);
            }

            //박명회쌤 코드
            //OracleDataAdapter oda = new OracleDataAdapter();
            //DataSet ds = new DataSet(cmd.CommandText);

            //oda.Fill(ds);
            //Console.WriteLine($"{ds}");


        }

        public void errorMessage(string msg, OracleException e)
        {
            Console.WriteLine(msg + "에러 번호 : " + e.Number);
            Console.WriteLine(msg + "에러 코드 : " + e.ErrorCode.ToString());
            Console.WriteLine(msg + "에러 내용 : " + e.Message);
        }
    }
}
