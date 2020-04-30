using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DBGestion
{
    public partial class SInventario : Inventario
    {

        SqlConnection cn = new SqlConnection(Conexion);
        //mostrar

        //Insert
        public int Insert()
        {
            try
            {
                SqlCommand sql = new SqlCommand();
                cn.Open();
                sql.Connection = cn;
                sql.CommandType.ToString();
                sql.CommandText = "insert  Inventario  values(,@Inv_Nombre,@ID_cat,@Descripcion,@Cantidad,@Estado)";
               // sql.Parameters.Add("@id", SqlDbType.Int);
               // sql.Parameters["@id"].Value = ID_Inv;
                sql.Parameters.Add("@Inv_Nombre", SqlDbType.NVarChar);
                sql.Parameters["@Inv_Nombre"].Value = Inv_Nombre;
                sql.Parameters.Add("@ID_cat", SqlDbType.Int);
                sql.Parameters["@ID_cat"].Value = ID_categoria;
                sql.Parameters.Add("@Descripcion", SqlDbType.NVarChar);
                sql.Parameters["@Descripcion"].Value = Descripcion;
                sql.Parameters.Add("@Cantidad", SqlDbType.Int);
                sql.Parameters["@Cantidad"].Value = Cantidad;
                sql.Parameters.Add("@Estado", SqlDbType.Int);
                sql.Parameters["@Estado"].Value = Estado;
                sql.ExecuteNonQuery();
                cn.Close();
                return 2;
            }
            catch (Exception)
            {
                return 1;
                throw;
            }
        }
        //Delete
        public int Delete()
        {
            try
            {
                SqlCommand sql = new SqlCommand();
                sql.Connection = cn;
                sql.CommandType.ToString();
                sql.CommandText = "DELETE FROM Inventario WHERE ID_Inv=@id";
                 sql.Parameters.Add("@id", SqlDbType.Int);
                 sql.Parameters["@id"].Value = ID_Inv;
                SqlDataAdapter da = new SqlDataAdapter(sql);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return 2;
            }
            catch (Exception)
            {
                return 1;
                throw;
            }
        }
        //Buscar
        public int Buscar()
        {
            try
            {
                SqlCommand sql = new SqlCommand();
                sql.Connection = cn;
                sql.CommandType.ToString();
                sql.CommandText = "Select * from Inventario where ID_Inv=@id";
                sql.Parameters.Add("@id", SqlDbType.Int);
                sql.Parameters["@id"].Value = ID_Inv;
                SqlDataAdapter da = new SqlDataAdapter(sql);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count>0)
                {
                    ID_Inv = Convert.ToInt32( ds.Tables[0].Rows[0][0].ToString());
                    Inv_Nombre =  ds.Tables[0].Rows[0][1].ToString();
                    ID_categoria = Convert.ToInt32(ds.Tables[0].Rows[0][2].ToString());
                    Descripcion = ds.Tables[0].Rows[0][3].ToString();
                    Cantidad = Convert.ToInt32(ds.Tables[0].Rows[0][4].ToString());
                    Estado = Convert.ToInt32(ds.Tables[0].Rows[0][5].ToString());
                    return 2;
                }
                else
                {
                    return 3;
                }

               
            }
            catch (Exception)
            {
                return 1;
                throw;
            }
        }
        //Update
        public int Modificar()
        {
            try
            {
                SqlCommand sql = new SqlCommand();
                cn.Open();
                sql.Connection = cn;
                sql.CommandType.ToString();
                sql.CommandText = "update  Inventario  set ID_Inv=@id,Onv_Nombre=@Inv_Nombre,ID_Cat=@ID_cat,Descripcion=@Descripcion,cantidad=@Cantidad,Estado=@Estado where ID_Inv=id";
                sql.Parameters.Add("@id", SqlDbType.Int);
                sql.Parameters["@id"].Value = ID_Inv;
                sql.Parameters.Add("@Inv_Nombre", SqlDbType.NVarChar);
                sql.Parameters["@Inv_Nombre"].Value = Inv_Nombre;
                sql.Parameters.Add("@ID_cat", SqlDbType.Int);
                sql.Parameters["@ID_cat"].Value = ID_categoria;
                sql.Parameters.Add("@Descripcion", SqlDbType.NVarChar);
                sql.Parameters["@Descripcion"].Value = Descripcion;
                sql.Parameters.Add("@Cantidad", SqlDbType.Int);
                sql.Parameters["@Cantidad"].Value = Cantidad;
                sql.Parameters.Add("@Estado", SqlDbType.Int);
                sql.Parameters["@Estado"].Value = Estado;
                sql.ExecuteNonQuery();
                cn.Close();
                return 2;
            }
            catch (Exception)
            {
                return 1;
                throw;
            }
        }

        public void mostrar() {
            SqlCommand sql = new SqlCommand();
            sql.Connection = cn;
            sql.CommandType.ToString();
            sql.CommandText = "Select * from Inventario";

            SqlDataAdapter da = new SqlDataAdapter(sql);
            DataSet ds = new DataSet();
            da.Fill(ds);

        }
    }
}
