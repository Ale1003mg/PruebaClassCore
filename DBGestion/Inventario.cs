using System;
using System.Collections.Generic;
using System.Text;

namespace DBGestion
{
    public partial class Inventario
    {
        protected static string Conexion = "Data Source=ALEJANDRO\SQLPRUEBAS;Initial Catalog=Gestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        protected int ID_Inv { get; set; }
        protected string Inv_Nombre { get; set; }
        protected int ID_categoria { get; set; }
        protected string Descripcion { get; set; }
        protected int Cantidad { get; set; }
        protected int Estado { get; set; }

        //mostrar datos

        public int MID_Inv() { return ID_Inv; }
        public string MInv_Nombre() { return Inv_Nombre; }
        public int MID_categoria() { return ID_categoria; }
        public string MDescripcion() { return Descripcion; }
        public int MCantidad() { return Cantidad; }
        public int MEstado() { return Estado; }


        public void Obtener(int ID,string Nombre,int categoria,string Descrip,int Canti,int Esta) {

            ID_Inv = ID;
            Inv_Nombre = Nombre;
            ID_categoria = categoria;
            Descripcion = Descrip;
            Cantidad = Canti;
            Estado = Esta;

    }
    }
}
