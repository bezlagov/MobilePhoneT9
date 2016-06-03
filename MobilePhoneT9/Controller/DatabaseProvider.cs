using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using MobilePhoneT9.Model;

namespace MobilePhoneT9.Controller
{
    class DatabaseProvider
    {
        public DataSet Dictionary { get; set; }
        private DataTable Words { get; set; }

        private static DatabaseProvider _instance;
        public static DatabaseProvider Instance
        {
            get
            {
                if (_instance == null) _instance = new DatabaseProvider();
                return _instance;
            }
        }


        private DatabaseProvider()
        {
            Dictionary = new DataSet();
            Dictionary.DataSetName = "Dictionary";
            #region cutted data
            //Account = new DataTable("Account");

            //var id = Account.Columns.Add("Id", typeof(Int32));
            //Account.Columns.Add("Login", typeof(String));
            //Account.Columns.Add("Password", typeof(String));

            //var login = new UniqueConstraint(Account.Columns["Login"]);
            //Account.Constraints.Add(login);
            //Account.Constraints.Add("pk account", id, true);
            //id.AutoIncrement = true;

            //Account.Rows.Add(1, "Batman", "123456");
            //Account.Rows.Add(2, "Joker", "123456");

            //Shop.Tables.Add(Account);
            #endregion
        }
        public void LoadData(/*string login, string password*/)
        {
            var adapter = new SqlDataAdapter();

            var conns = new SqlConnectionStringBuilder();
            conns.DataSource = "IVAN\\SQLEXPRESS";
            conns.InitialCatalog = "Dictionary";
            conns.IntegratedSecurity = true;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conns.ConnectionString;
            connection.Open();

            var comm = new SqlCommand("select * from DictionaryTable;", connection);
            adapter.SelectCommand = comm;
            adapter.Fill(Dictionary);
        }
        public void UpdateData()
        {
            var adapter = new SqlDataAdapter();

            var conns = new SqlConnectionStringBuilder();
            conns.DataSource = "IVAN\\SQLEXPRESS";
            conns.InitialCatalog = "MyShopHW3";
            conns.IntegratedSecurity = true;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conns.ConnectionString;
            connection.Open();

            var comm = new SqlCommand("select * from Account;", connection);
            adapter.SelectCommand = comm;
            //TODO update
        }
        public List<Dict> GetData()
        {
            foreach (DataRow item in Dictionary.Tables[0].Rows)
            {
                Data.Instance.dictionaryData.Add(new Dict((int)item["Id"], (item["Russian"] as string), (item["English"] as string)));
            }
            return Data.Instance.dictionaryData;
        }
    }
}
