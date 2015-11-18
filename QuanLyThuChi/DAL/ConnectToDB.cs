using System.IO;
using QuanLyThuChi.Model;
using System;
using System.Diagnostics;
using QuanLyThuChi.Util;
using SQLite.Net;

namespace QuanLyThuChi.DAL
{
    public class ConnectToDB
    {
        string path;    //a path to save database
        string db_name = "HD_db.sqlite";
        SQLite.Net.SQLiteConnection conn;   //data connection

        /// <summary>
        /// Creates the database.
        /// </summary>
        public int createDatabase()
        {
            //create database local file name "HD_db.sqlite.sqlite"
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, this.db_name); 
            conn = new SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            //Thêm bảng
            conn.CreateTable<Model_CHI_TIET_VAY_CHOVAY>();
            conn.CreateTable<Model_GHI_CHEP>();
            conn.CreateTable<Model_GUI_TIET_KIEM>();
            conn.CreateTable<Model_HANG_MUC_CHI>();
            conn.CreateTable<Model_HANG_MUC_CHI_CHA>();
            conn.CreateTable<Model_HANG_MUC_THU>();
            conn.CreateTable<Model_HANG_MUC_THU_CHA>();
            conn.CreateTable<Model_LOAI_TAI_KHOAN>();
            conn.CreateTable<Model_LOAI_TIEN>();
            conn.CreateTable<Model_TAI_KHOAN>();
            conn.CreateTable<Model_THIET_LAP>();
            conn.CreateTable<Model_USERS>();
            conn.CreateTable<Model_VAY_NGAN_HANG>();
            //Thêm record
            try
            {
                EncryptPassword pass = new EncryptPassword();
                conn.Insert(new Model_USERS()
                {
                    Email = "admin@heodat.com",
                    FirstName = "Heo Đất",
                    LastName = "Admin",
                    Password = pass.encrypt("admin"),
                    Type = "Admin",
                    Status = true
                });
                Debug.WriteLine("[QLTC] đã thêm admin");
            }
            catch(Exception ex)
            {
                Debug.WriteLine("[QLTC] " + ex.Message);
            }
            return 1;
        }

        /// <summary>
        /// Gets the connect.
        /// </summary>
        /// <returns></returns>
        public SQLiteConnection getConnect()
        {
            if (conn == null)
            {
                this.createDatabase();
            }
            return conn;
        }
    }
}
