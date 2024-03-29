﻿using FileManagerAPI.Helpers;
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

        public async Task<string> UploadHVI(List<HVI> model/*, string title*/)
        {
            try
            {
                model.ForEach(async x =>
                {
                    await using (SqlConnection cn = new(sqlString.GetCadenaSQL()))
                    {
                        cn.Open();
                        var cmd = new SqlCommand("SP_GetData", cn);

                        cmd.Parameters.AddWithValue("UHML", x.Uhml);
                        cmd.Parameters.AddWithValue("UI", x.Ui);
                        cmd.Parameters.AddWithValue("STRENGTH", x.Strength);
                        cmd.Parameters.AddWithValue("SFI", x.Sfi);
                        cmd.Parameters.AddWithValue("MIC", x.Mic);
                        cmd.Parameters.AddWithValue("COLORGRADE", x.Colorgrade);
                        cmd.Parameters.AddWithValue("TRASHID", x.Trashid);
                        //cmd.Parameters.AddWithValue("FileName", title);

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteReader();
                    }
                });
                return await Task.FromResult("se ha guardado con exito");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }

        }

        public async Task<string> UploadHVI2(List<HVI> model/*, string title*/)
        {
            try
            {
                model.ForEach(async x =>
                {
                    await using (SqlConnection cn = new(sqlString.GetCadenaSQL()))
                    {
                        cn.Open();
                        var cmd = new SqlCommand("SP_GetData", cn);

                        cmd.Parameters.AddWithValue("UHML", x.Uhml);
                        cmd.Parameters.AddWithValue("UI", x.Ui);
                        cmd.Parameters.AddWithValue("STRENGTH", x.Strength);
                        cmd.Parameters.AddWithValue("SFI", x.Sfi);
                        cmd.Parameters.AddWithValue("MIC", x.Mic);
                        cmd.Parameters.AddWithValue("COLORGRADE", x.Colorgrade);
                        cmd.Parameters.AddWithValue("TRASHID", x.Trashid);
                        //cmd.Parameters.AddWithValue("FileName", title);

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteReader();
                    }
                });
                return await Task.FromResult("se ha guardado con exito");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }

        }

        public async Task<string> UploadHVI3(List<HVI> model/*, string title*/)
        {
            try
            {
                model.ForEach(async x =>
                {
                    await using (SqlConnection cn = new(sqlString.GetCadenaSQL()))
                    {
                        cn.Open();
                        var cmd = new SqlCommand("SP_GetData", cn);

                        cmd.Parameters.AddWithValue("UHML", x.Uhml);
                        cmd.Parameters.AddWithValue("UI", x.Ui);
                        cmd.Parameters.AddWithValue("STRENGTH", x.Strength);
                        cmd.Parameters.AddWithValue("SFI", x.Sfi);
                        cmd.Parameters.AddWithValue("MIC", x.Mic);
                        cmd.Parameters.AddWithValue("COLORGRADE", x.Colorgrade);
                        cmd.Parameters.AddWithValue("TRASHID", x.Trashid);
                        //cmd.Parameters.AddWithValue("FileName", title);

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteReader();
                    }
                });
                return await Task.FromResult("se ha guardado con exito");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }

        }

        public async Task<string> UploadHVI4(List<HVI> model/*, string title*/)
        {
            try
            {
                model.ForEach(async x =>
                {
                    await using (SqlConnection cn = new(sqlString.GetCadenaSQL()))
                    {
                        cn.Open();
                        var cmd = new SqlCommand("SP_GetData", cn);

                        cmd.Parameters.AddWithValue("UHML", x.Uhml);
                        cmd.Parameters.AddWithValue("UI", x.Ui);
                        cmd.Parameters.AddWithValue("STRENGTH", x.Strength);
                        cmd.Parameters.AddWithValue("SFI", x.Sfi);
                        cmd.Parameters.AddWithValue("MIC", x.Mic);
                        cmd.Parameters.AddWithValue("COLORGRADE", x.Colorgrade);
                        cmd.Parameters.AddWithValue("TRASHID", x.Trashid);
                        //cmd.Parameters.AddWithValue("FileName", title);

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteReader();
                    }
                });
                return await Task.FromResult("se ha guardado con exito");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }

        }

        //private async Task<int> HviIdentifier()
        //{
        //    try
        //    {
        //        int TitleId;
        //        using (SqlConnection cn = new(sqlString.GetCadenaSQL()))
        //        {
        //            cn.Open();
        //            var cmd = new SqlCommand("SP_Identifier", cn);

        //            cmd.Parameters.AddWithValue("TitleId", TitleId);

        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.ExecuteNonQuery();
        //        }

        //        return await Task.FromResult(TitleId);
        //    }
        //    catch (Exception e)
        //    {

        //        throw new Exception(e.Message);
        //    }
        //}
    }
}
