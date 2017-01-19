using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Data;
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
            //string backUpPath = @"C:\DB\SIME.bak";

            SqlCommand UseMasterCommand = new SqlCommand("USE master");
            //SqlCommand sp = new SqlCommand("[SIMEUTN].[sp_RestoreDB]");
            //sp.CommandType = CommandType.StoredProcedure;
            SqlCommand AlterCommand = new SqlCommand("ALTER DATABASE[SIMEUTN] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
            SqlCommand RestoreCommand = new SqlCommand(@"RESTORE DATABASE[SIMEUTN] FROM DISK = N'C:\DB\SIME.bak' WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 5");
            SqlCommand MultiUserCommand = new SqlCommand("ALTER DATABASE[SIMEUTN] SET MULTI_USER");

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(UseMasterCommand);
                db.ExecuteNonQuery(AlterCommand);
                db.ExecuteNonQuery(RestoreCommand);
                db.ExecuteNonQuery(MultiUserCommand);
            }
        }

        public bool validarPass(string pass) {

            bool r = false;

            if (!string.IsNullOrEmpty(pass))
            {
                if (pass.Equals("xzk23l"))
                {
                    r = true;
                }
            }

            return r;
        }
    }
}
