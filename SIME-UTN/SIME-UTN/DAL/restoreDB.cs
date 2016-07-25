using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SIME_UTN.DAL
{ 
    public class restoreDB
    {

        public void Restore()
        {
            string backUpPath = @"C:\DB\SIME.bak";

            SqlCommand UseMasterCommand = new SqlCommand("USE master");
            SqlCommand Alter1Cmd = new SqlCommand(@"ALTER DATABASE [SIMEUTN] SET Single_User WITH Rollback Immediate");
            SqlCommand Restore = new SqlCommand(@"RESTORE DATABASE [SIMEUTN] FROM DISK = N'" + backUpPath + @"' WITH  FILE = 1,  NOUNLOAD,REPLACE,  STATS = 10");
            SqlCommand Alter2Cmd = new SqlCommand(@"ALTER DATABASE [SIMEUTN] SET Multi_User");

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(UseMasterCommand);
                db.ExecuteNonQuery(Alter1Cmd);
                db.ExecuteNonQuery(Restore);
                db.ExecuteNonQuery(Alter2Cmd);
            }
        }
    }
}
