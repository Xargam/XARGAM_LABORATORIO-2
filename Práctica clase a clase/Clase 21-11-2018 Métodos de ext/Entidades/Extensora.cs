using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
  public static class Extensora
  {
    public static string ObtenerDatos(this Entidades.Externa.Sellada.PersonaExternaSellada persona)
    {
      StringBuilder datos = new StringBuilder();
      datos.AppendFormat("{0} {1} {2} {3}", persona.Nombre, persona.Apellido, persona.Edad, persona.Sexo.ToString());
      return datos.ToString();
    }
    public static bool EsNulo(this object obj)
    {
      return object.ReferenceEquals(obj, null);
    }

    public static int CantidadDigitos(this int entero)
    {
      // int digitos = (entero < 0) ? entero.ToString().Length-1 : entero.ToString().Length;
      return entero.ToString().Length;
    }
    public static bool TieneLaMismaCantidad(this int entero, int digitos)
    {
      return entero.CantidadDigitos() == digitos;
    }

    // public static string GenerarCadenaDeConexion(this string variable,string cadenaIncial , params object[] inf )
    // {
    //   //"INSERT INTO dbo.Televisores (codigo,marca,precio,pulgadas,pais)"
    //   StringBuilder cadena = new StringBuilder();
    //   cadena.AppendLine(cadenaIncial);
    //   cadena.Append("VALUES (");
    ///*   foreach (object item in inf)
    //   {
    //     if (item is string)
    //     {
    //       cadena.Append(" ''{0}''",item.ToString());

    //     }
    //   }*/
    //   return "";
    // }

    public static List<Persona> TraerDB(this Persona persona)
    {
      List<Persona> personas = new List<Persona>();
      SqlConnection sql = new SqlConnection(Properties.Settings.Default.Conexion);
      SqlCommand comando = new SqlCommand();

      comando.CommandType = CommandType.Text;
      comando.CommandText = "SELECT * FROM Personas_db.dbo.personas ";
      comando.Connection = sql;

      sql.Open();
      SqlDataReader reader = comando.ExecuteReader();
      while (reader.Read())
      {
        Persona per = new Persona(reader.GetString(1), reader.GetString(2), reader.GetInt32(3), (ESexo)reader.GetInt32(4));
        personas.Add(per);
      }
      sql.Close();
      return personas;
    }

    public static bool Modificar(this Persona persona , int id)
    {
      bool verificacion = true;


      try
      {
        StringBuilder consulta = new StringBuilder();
        consulta.AppendFormat("UPDATE Personas_db.dbo.personas SET nombre='{0}',apellido='{1}',edad={2},sexo={3} WHERE id={4}",
          persona.Nombre, persona.Apellido, persona.Edad, (int)persona.Sexo, id);
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);
        SqlCommand comando = new SqlCommand();

        comando.CommandType = CommandType.Text;
        comando.CommandText = consulta.ToString();
        comando.Connection = conexion;

        conexion.Open();
        comando.ExecuteNonQuery();
        conexion.Close();
      }
      catch (Exception)
      {
        verificacion = false;
      }

      return verificacion;
    }


    public static bool QuitarDB(this Persona persona , int id)
    {
      bool verificacion = true;

      try
      {
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);
        SqlCommand comando = new SqlCommand();

        comando.CommandType = CommandType.Text;
        comando.CommandText = new StringBuilder().AppendFormat("DELETE Personas_db.dbo.personas WHERE id={0}", id).ToString();
        comando.Connection = conexion;

        conexion.Open();
        comando.ExecuteNonQuery();
        conexion.Close();
      }
      catch (Exception)
      {
        verificacion = false;
      }

      return verificacion;
    }

    public static bool AgregarDB(this Persona persona)
    {
      bool verificacion = true;
      StringBuilder consulta = new StringBuilder();

      try
      {
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);
        SqlCommand comando = new SqlCommand();

        comando.CommandType = CommandType.Text;
        comando.CommandText = consulta.AppendFormat("INSERT INTO Personas_db.dbo.personas (nombre,apellido,edad,sexo) VALUES ('{0}','{1}',{2},{3})",
          persona.Nombre, persona.Apellido, persona.Edad, (int)persona.Sexo).ToString();
        comando.Connection = conexion;

        conexion.Open();
        comando.ExecuteNonQuery();
        conexion.Close();
      }
      catch (Exception)
      {
        verificacion = false;
      }

      return verificacion;
    }
  }
}
