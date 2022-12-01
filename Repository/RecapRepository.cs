using FileManagerAPI.Helpers;
using FileManagerAPI.Models;
using FileManagerAPI.Repository.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace FileManagerAPI.Repository
{
    public class RecapRepository : IRecapRepository
    {
        //CODIGOS REUTILIZABLES, ESTAN EN LA CARPETA "HELPERS"
        SQLString sqlString = new(); //INSTANCIA PARA ACCEDER A LA CADENA DE CONEXION


        public async Task<List<HVI>> GetHVI()
        {
            List<HVI> hvi = new();

            using (SqlConnection cn = new(sqlString.GetCadenaSQL()))
            {
                cn.Open();
                var cmd = new SqlCommand("SP_GetHVI", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        hvi.Add(new HVI
                        {
                            Uhml = Convert.ToDecimal(reader["UHML"]),
                            Ui = Convert.ToDecimal(reader["UI"]),
                            Strength = Convert.ToDecimal(reader["STRENGTH"]),
                            Sfi = Convert.ToDecimal(reader["SFI"]),
                            Mic = Convert.ToDecimal(reader["MIC"]),
                            Colorgrade = reader["COLORGRADE"].ToString(),
                            Trashid = Convert.ToDecimal(reader["TRASHID"])
                        });
                    }
                }
            }
            return await Task.FromResult(hvi);
        }
    }
}
