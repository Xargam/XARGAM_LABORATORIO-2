using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
  public delegate void MiDelegado();
  public delegate void DelegadoTV(Televisor televisor, TVEventsArgs tVEventsArgs);

  public class Televisor
    {
        public int id;
        public string marca;
        public double precio;
        public int pulgadas;
        public string pais;

        public event MiDelegado miEvento;
    public event DelegadoTV delegadoTV;

    public List<Televisor> televisores;

        public Televisor(int id, string marca, double precio, int pul, string pais)
        {
            this.id = id;
            this.marca = marca;
            this.precio = precio;
            this.pulgadas = pul;
            this.pais = pais;
        }

        public Televisor()
        {
            
        }

        public bool Insertar()
        { 
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);

            SqlCommand comando = new SqlCommand();

            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO dbo.Televisores (codigo,marca,precio,pulgadas,pais) " +
                "VALUES (" + this.id + ",'" + this.marca + "'," + this.precio + "," + this.pulgadas + ",'" + this.pais + "')";
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                this.miEvento();
                
                this.delegadoTV(this,new TVEventsArgs());
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        public static bool Modificar(Televisor tele)
        {
          SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);

          SqlCommand comando = new SqlCommand();

          comando.CommandType = CommandType.Text;
          comando.CommandText = "UPDATE dbo.Televisores SET marca='"+ tele.marca + "', precio=" + tele.precio + ",pulgadas=" + tele.pulgadas + "," +
            "pais='" + tele.pais + "' WHERE codigo="+tele.id+"";
          comando.Connection = conexion;

          try
          {
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
            return true;
          }
          catch (Exception)
          {
            return false;
            throw;
          }

        }

        public static bool Borrar(Televisor tele)
        {
          SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);

          SqlCommand comando = new SqlCommand();

          comando.CommandType = CommandType.Text;
          comando.CommandText = "DELETE dbo.Televisores WHERE codigo=" + tele.id + "";
          comando.Connection = conexion;

          try
          {
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
            return true;
          }
          catch (Exception)
          {
            return false;
            throw;
          }
        }

        public static List<Televisor> TraerTodos()
        {
          List<Televisor> televisores = new List<Televisor>();

          SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);

          conexion.Open();

          SqlCommand comando = new SqlCommand();

          comando.CommandType = CommandType.Text;
          comando.CommandText = "SELECT * FROM dbo.Televisores";
          comando.Connection = conexion;

          SqlDataReader reader = comando.ExecuteReader();
      

          while (reader.Read())
          {
            Televisor t = new Televisor(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2), reader.GetInt32(3), reader.GetString(4));
            televisores.Add(t);
          }

          return televisores;
        }

        public static Televisor TraerUno(int id)
        {
          Televisor t = null;
          SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);
          conexion.Open();

          SqlCommand comando = new SqlCommand();

          comando.CommandType = CommandType.Text;
          comando.CommandText = "SELECT * FROM dbo.Televisores WHERE codigo=" + id + "";
          comando.Connection = conexion;

          SqlDataReader reader = comando.ExecuteReader();

      //if (reader.HasRows)
      //{
      //  t = new Televisor(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2), reader.GetInt32(3), reader.GetString(4));
      //}
      while (reader.Read())
      {
        t = new Televisor(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2), reader.GetInt32(3), reader.GetString(4));
      }

      return t;
        }

        public string Mostrar()
        {
          return this.marca+" - "+this.precio+" - "+ this.pulgadas + " - " + this.pais;
        }
  }
}
