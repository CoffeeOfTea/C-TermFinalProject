using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;
using StudentDormitoryManager.Entity;

namespace StudentDormitoryManager.DAO
{
    class DormitoryDAO
    {
        private static String dbConnStr = ConfigurationManager.ConnectionStrings["ConStr"].ToString();
        public ArrayList GetAllDormitories() {
            ArrayList dormitories = new ArrayList();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = dbConnStr;
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * from T_Dormitory";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Dormitory dor = new Dormitory();
                dor.Dorid = (int)dr[0];
                dor.Dorhonor = dr[1].ToString();
                dor.Blockno = (int)dr[2];
                dormitories.Add(dor);
            }
            dr.Close();
            conn.Close();
            return dormitories;
        }
        public void AddDormitory(Dormitory dor) {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = dbConnStr;
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = String.Format("Insert T_Dormitory values({0},'{1}',{2})",dor.Dorid,dor.Dorhonor,dor.Blockno);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteDormitory(int dorid) {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = dbConnStr;
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = String.Format("Delete from T_Dormitory where dorid = {0}",dorid);
            cmd.ExecuteNonQuery();
            cmd.CommandText = String.Format("Update T_Student Set dorid = null where dorid = {0}", dorid);
            cmd.ExecuteNonQuery();
            cmd.CommandText = String.Format("Delete from T_HealthScore where dorid = {0}", dorid);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void UpdateDormitory(Dormitory dor) {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = dbConnStr;
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = String.Format("Update T_Dormitory Set dorhonor = '{0}',blockno = {1} where dorid= {2}",dor.Dorhonor,dor.Blockno,dor.Dorid);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
