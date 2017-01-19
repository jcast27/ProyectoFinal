using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIME_UTN.Entities;
using System.Data.SqlClient;
using System.Data;

namespace SIME_UTN.DAL
{
    class TipoBodegaDAL
    {
        internal static TipoBodega ObtenerTipoBodega(int idTipoBodegap)
        {
            TipoBodega tipoBodega = new TipoBodega();
            bool existe = false;
            string sql = @"sp_SELECT_TipoBodega_ByID";

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idtipobodega", idTipoBodegap);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(command, "consulta");


                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    tipoBodega.idTipoBodega = Convert.ToInt32(dr["idtipobodega"].ToString());
                    tipoBodega.descripcion = dr["descripcion"].ToString();
                    tipoBodega.estado = Convert.ToInt32(dr["estado"]);
                }

            }
            return tipoBodega;
        }
    }
}
