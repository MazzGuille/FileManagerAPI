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
                        //var UHML = x.Uhml;
                        //var UI = x.Ui;
                        //var STRENGTH = x.Strength;
                        //var SFI = x.Sfi;
                        //var MIC = x.Mic;
                        //var COLORGRADE = x.Colorgrade;
                        //var TRASHID = x.Trashid;

                        cmd.Parameters.AddWithValue("UHML", x.Uhml);
                        cmd.Parameters.AddWithValue("UI", x.Ui);
                        cmd.Parameters.AddWithValue("STRENGTH", x.Strength);
                        cmd.Parameters.AddWithValue("SFI", x.Sfi);
                        cmd.Parameters.AddWithValue("MIC", x.Mic);
                        cmd.Parameters.AddWithValue("COLORGRADE", x.Colorgrade);
                        cmd.Parameters.AddWithValue("TRASHID", x.Trashid);
                    });

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteReader();



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
