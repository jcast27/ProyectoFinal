﻿using SIME_UTN.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SIME_UTN.DAL
{
    class DepartamentoDAL
    {
        public static List<Departamento> ObtenerDepartamentos()
        {
            string sql = @"sp_SELECT_Departamento_All";

            List<Departamento> lista = new List<Departamento>();

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(command, "consulta");

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    try
                    {
                        Departamento unDepartamento = new Departamento();
                        unDepartamento.idDepartamento = Convert.ToInt32(dr["iddepartamento"].ToString());
                        unDepartamento.descripcion = dr["descripcion"].ToString();
                        unDepartamento.estado = dr["estado"].ToString().Equals("True") ? 1 : 0;

                        lista.Add(unDepartamento);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            return lista;
        }

        public static void GuardarDepartamento(Departamento Departamentop, string usuarioLogueadop)
        {
            string accion = "";
            accion = "Insertar";
            SqlCommand comando = new SqlCommand("sp_INSERT_Departamento");
            comando.CommandType = CommandType.StoredProcedure;

            //  comando.Parameters.AddWithValue("@IDDepartamento", Departamentop.idDepartamento);
            comando.Parameters.AddWithValue("@descripcion", Departamentop.descripcion);
            comando.Parameters.AddWithValue("@estado", Departamentop.estado);

            GuardarLog(Departamentop, usuarioLogueadop, accion, null);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }

        public static Departamento ObtenerDepartamentoID(int idDepartamentop)
        {
            string sql = @"sp_SELECT_Departamento_ByID";

            List<Departamento> lista = new List<Departamento>();

            SqlCommand command = new SqlCommand(sql);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@iddepartamento", idDepartamentop);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                DataSet ds = db.ExecuteReader(command, "consulta");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    Departamento unDepartamento = new Departamento();
                    unDepartamento.idDepartamento = Convert.ToInt32(ds.Tables[0].Rows[0]["iddepartamento"].ToString());
                    unDepartamento.descripcion = ds.Tables[0].Rows[0]["descripcion"].ToString();
                    unDepartamento.estado = ds.Tables[0].Rows[0]["estado"].ToString().Equals("True") ? 1 : 0;

                    return unDepartamento;
                }
                else
                {
                    return null;
                }
            }
        }

        internal static void EliminarDepartamento(int deptoIdp, string deptop, string usuarioLoguadop)
        {
            string accion = "";
            accion = "Eliminar";
            SqlCommand comando = new SqlCommand("sp_DISABLE_Departamento_ByID");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@iddepartamento", deptoIdp);
            GuardarLog(null, usuarioLoguadop, accion, deptop);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }

        /*  internal static void DesactivarDepartamento(string DepartamentoIdp, string accion)
          {
              accion = accion.Equals("Habilitar") ? "1" : "0";

              SqlCommand comando = new SqlCommand("sp_DISABLE_Departamento_ByID");
              comando.CommandType = CommandType.StoredProcedure;

              comando.Parameters.AddWithValue("@IDDepartamento", DepartamentoIdp);
              comando.Parameters.AddWithValue("@estado", accion);


              using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
              {
                  db.ExecuteNonQuery(comando);
              }
          }*/

        internal static void ActualizarDepartamento(Departamento Departamentop, string usuarioLogueadop)
        {
            string accion = "";
            accion = "Modificar";

            SqlCommand comando = new SqlCommand("sp_UPDATE_Departamento");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@iddepartamento", Departamentop.idDepartamento);
            comando.Parameters.AddWithValue("@descripcion", Departamentop.descripcion);
            comando.Parameters.AddWithValue("@estado", Departamentop.estado);

            GuardarLog(Departamentop, usuarioLogueadop, accion, null);

            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }
        }

        public static void GuardarLog(Departamento unDepto, string usuarioLogueado, string accion, string deptoEliminado)
        {

            string descripcion = "";
            string estado = "";
            if (unDepto == null)
            {
                descripcion = "Departamento eliminado: " + deptoEliminado;
                estado = "Desactivado";
            }
            else
            {
                estado = "Activo";
                descripcion = "Departamento: " + unDepto.descripcion + "\r\nEstado: " + estado;

            }
            DateTime date = DateTime.Now;
            string fecha = date.ToString("dd/MM/yyyy");
            SqlCommand comando = new SqlCommand("sp_INSERT_log");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@usuario", usuarioLogueado);
            comando.Parameters.AddWithValue("@accion", accion);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@fechamodificacion", fecha);
            comando.Parameters.AddWithValue("@estado", 1);


            using (DataBase db = DataBaseFactory.CreateDataBase("default", UsuarioDB.GetInstance().usuario, UsuarioDB.GetInstance().contrasenna))
            {
                db.ExecuteNonQuery(comando);
            }

        }
    }
}
