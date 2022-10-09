using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using GerizimZZ.Clases;

namespace GerizimZZ
{
    internal class Cl_Repartidores: Cl_conexiones
    {
        

        //Aquí se realiza la consulta para llenar el DataGridView utilizando datos de dos tablas distintas
        public void infogrid(DataGridView grid)
        {
            SqlCommand cm = new SqlCommand("select repartidores.ID_repartidores, repartidores.nombreRepartidor,repartidores.telefonoRepartidor,repartidores.ID_sucursal,pedidos.direccionEntrega,Pedidos.ID_factura From repartidores INNER JOIN pedidos ON repartidores.ID_repartidores = pedidos.ID_repartidores ;", conex);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();

            da.Fill(dt);

            grid.DataSource = dt;
        }
    }
}



