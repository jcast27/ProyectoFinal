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
            string backUpPath = @"C:\DB\SIME.bak";

            SqlCommand UseMasterCommand = new SqlCommand("USE master");
            SqlCommand sp = new SqlCommand("sp_RestoreDB");
            sp.CommandType = CommandType.StoredProcedure;

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(UseMasterCommand);
                db.ExecuteNonQuery(sp);                
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
