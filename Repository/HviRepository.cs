using FileManagerAPI.Helpers;
using FileManagerAPI.Models;
using FileManagerAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace FileManagerAPI.Repository
{
    public class HviRepository : IHviRepository
    {
        //CODIGOS REUTILIZABLES, ESTAN EN LA CARPETA "HELPERS"
        SQLString sqlString = new(); //INSTANCIA PARA ACCEDER A LA CADENA DE CONEXION

        public async Task<string> UploadHVI(List<HVI> model)
        {
            try
            {

                using (SqlConnection cn = new(sqlString.GetCadenaSQL()))
                {
                    cn.Open();
                    var cmd = new SqlCommand("SP_GetData", cn);

                    model.ForEach(x =>
                    {
                        var UHML = x.UHML;
                        var UI = x.UI;
                        var STRENGTH = x.STRENGTH;
                        var SFI = x.SFI;
                        var MIC = x.MIC;
                        var COLORGRADE = x.COLORGRADE;
                        var TRASHID = x.TRASHID;

                        cmd.Parameters.AddWithValue("UHML", x.UHML);
                        cmd.Parameters.AddWithValue("UI", x.UI);
                        cmd.Parameters.AddWithValue("STRENGTH", x.STRENGTH);
                        cmd.Parameters.AddWithValue("SFI", x.SFI);
                        cmd.Parameters.AddWithValue("MIC", x.MIC);
                        cmd.Parameters.AddWithValue("COLORGRADE", x.COLORGRADE);
                        cmd.Parameters.AddWithValue("TRASHID", x.TRASHID);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteReader();
                    });

                    //cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.ExecuteReader();


                    //using (var rd = cmd.ExecuteReader())
                    //{
                    //    while (rd.Read())
                    //    {
                    //        model.Append<> = (decimal)rd["UHML"];
                    //        model.UI = (decimal)rd["UI"];
                    //        model.STR = (decimal)rd["STR"];
                    //        model.ELONG = (decimal)rd["ELONG"];
                    //        model.SFI = (decimal)rd["SFI"];
                    //    }
                    //}

                    return "se ha guardado con exito";
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }
    }
}
