namespace PreguntadOrt.Models;
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;
public class BD
{
    private static string _connectionString = @"Server=DESKTOP-JHC6CC3\SQLEXPRESS;DataBase=PreguntadOrt;Trusted_Connection=True";
    public static List<Ranking> ObtenerRanking()
    {
        List<Ranking> lista = new List<Ranking>();
        string sql = "SELECT TOP 5 * FROM Ranking order by PuntajeFinal desc";
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            lista = db.Query<Ranking>(sql).ToList();
        }
        return lista;
    }
    public static List<Categoria> ObtenerCategorias()
    {
        List<Categoria> lista = new List<Categoria>();
        string sql = "SELECT * FROM Categorias";
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            lista = db.Query<Categoria>(sql).ToList();
        }
        return lista;
    }
    public static List<Dificultad> ObtenerDificultades()
    {
        List<Dificultad> lista = new List<Dificultad>();
        string sql = "SELECT * FROM Dificultades";
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            lista = db.Query<Dificultad>(sql).ToList();
        }
        return lista;
    }
    public static List<Pregunta> ObtenerPreguntas(int dificultad, int categoria)
    {
        List<Pregunta> lista = new List<Pregunta>();
        if (dificultad == 6 && categoria == 4)
        {
            string sql = "SELECT * FROM Preguntas";
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                lista = db.Query<Pregunta>(sql).ToList();
            }
        }
        else if (dificultad == 6)
        {
            string sql = "SELECT * FROM Preguntas WHERE Preguntas.IdCategoria = @_IdCategoria";
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                lista = db.Query<Pregunta>(sql, new { _IdCategoria = categoria }).ToList();
            }
        }
        else if (categoria == 4)
        {
            string sql = "SELECT * FROM Preguntas WHERE Preguntas.IdDificultad = @_IdDificultad";
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                lista = db.Query<Pregunta>(sql, new { _IdDificultad = dificultad }).ToList();
            }
        }
        else
        {
            string sql = "SELECT * FROM Preguntas WHERE Preguntas.IdDificultad = @_IdDificultad AND Preguntas.IdCategoria = @_IdCategoria";
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                lista = db.Query<Pregunta>(sql, new { _IdDificultad = dificultad, _IdCategoria = categoria }).ToList();
            }
        }
        Console.WriteLine(lista.Count());
        return lista;
    }
    public static List<Respuesta> ObtenerRespuestas(List<Pregunta> preguntas)
    {
        List<Respuesta> lista = new List<Respuesta>();
        List<Respuesta> lista2 = new List<Respuesta>();
        string sql = "SELECT * FROM Respuestas WHERE Respuestas.IdPregunta = @pIdP";
        foreach(Pregunta p in preguntas){
           using (SqlConnection db = new SqlConnection(_connectionString))
            {
                lista2 = db.Query<Respuesta>(sql, new { pIdP = p.IdPregunta}).ToList();
            }
            lista.AddRange(lista2);
        }
        return lista;
    }
    public static void AgregarJugador(Ranking Usuario)
    {      
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "INSERT INTO Ranking VALUES (@_nombreUser, @_puntajeFinal)";
            db.Execute(sql, new 
            {  
                _puntajeFinal = Usuario.PuntajeFinal,
                _nombreUser = Usuario.NombreUser,                
            });
        }
    }
}