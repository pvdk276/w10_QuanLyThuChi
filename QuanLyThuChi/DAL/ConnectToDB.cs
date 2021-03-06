﻿using System.IO;
using QuanLyThuChi.Model;
using System;
using System.Diagnostics;
using QuanLyThuChi.Util;
using System.Collections.Generic;
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
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "HD_db.sqlite");
            if (!File.Exists(path))
            {
                //create database
                conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
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
                catch (Exception ex)
                {
                    Debug.WriteLine("[QLTC] " + ex.Message);
                }

                try
                {
                    var listHangMucChiCha = new List<Model_HANG_MUC_CHI_CHA>()
                    {
                        new Model_HANG_MUC_CHI_CHA() {TenHangMucChiCha= "Trang phục"},
                        new Model_HANG_MUC_CHI_CHA() {TenHangMucChiCha="Ăn uống" }
                    };

                    foreach (var item in listHangMucChiCha)
                    {
                        conn.Insert(item);
                    }


                    var listHangMucChi = new List<Model_HANG_MUC_CHI>()
                    {
                        new Model_HANG_MUC_CHI() {IdHangMucChi=0, IdHangMucChiCha=1,TenHangMucChi="Quần áo",ChinhSuaHangMucChi=false,GhiChuHangMucChi="Mua sắm quần áo" },
                        new Model_HANG_MUC_CHI() {IdHangMucChi=1, IdHangMucChiCha=1,TenHangMucChi="Giầy dép",ChinhSuaHangMucChi=false,GhiChuHangMucChi="Mua sắm giầy dép" },
                        new Model_HANG_MUC_CHI() {IdHangMucChi=2, IdHangMucChiCha=1,TenHangMucChi="Khác",ChinhSuaHangMucChi=false,GhiChuHangMucChi="Mua sắm" },
                        new Model_HANG_MUC_CHI() {IdHangMucChi=3, IdHangMucChiCha=2,TenHangMucChi="Đi chợ/Siêu thị",ChinhSuaHangMucChi=false,GhiChuHangMucChi="Đi chợ, siêu thị" },
                        new Model_HANG_MUC_CHI() {IdHangMucChi=4, IdHangMucChiCha=2,TenHangMucChi="Ăn tiệm",ChinhSuaHangMucChi=false,GhiChuHangMucChi="Ăn tiệm" }
                    };

                    foreach (var item in listHangMucChi)
                    {
                        conn.Insert(item);
                    }


                }
                catch (Exception ex)
                {
                    Debug.WriteLine("[QLTC] " + ex.Message);
                }
            }
            else // if file exist
            {
                conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
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
