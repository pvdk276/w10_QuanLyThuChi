﻿using System.IO;
using QuanLyThuChi.Model;
using System;
using System.Diagnostics;
using QuanLyThuChi.Util;
using System.Collections.Generic;

namespace QuanLyThuChi.DAL
{
    public class ConnectToDB
    {
        string path;    //a path to save database
        SQLite.Net.SQLiteConnection conn;   //data connection

        /// <summary>
        /// Creates the database.
        /// </summary>
        public int createDatabase()
        {

            //create database local file name "HD_db.sqlite.sqlite"
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "HD_db.sqlite");
            //File.Delete(path); //Xoa database dua theo duong dan path
            if (!File.Exists(path))
            {
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

                    var listLoaiTaiKhoan = new List<Model_LOAI_TAI_KHOAN>()
                    {
                        new Model_LOAI_TAI_KHOAN() {IdLoaiTaiKhoan = 0, TenLoaiTaiKhoan = "Tiền mặt"},
                        new Model_LOAI_TAI_KHOAN() {IdLoaiTaiKhoan = 1, TenLoaiTaiKhoan = "Tài khoản ngân hàng"},
                        new Model_LOAI_TAI_KHOAN() {IdLoaiTaiKhoan = 2, TenLoaiTaiKhoan = "Thẻ tín dụng"},
                        new Model_LOAI_TAI_KHOAN() {IdLoaiTaiKhoan = 3, TenLoaiTaiKhoan = "Tài khoản đầu tư"},
                        new Model_LOAI_TAI_KHOAN() {IdLoaiTaiKhoan = 4, TenLoaiTaiKhoan = "Khác"},
                    };
                    foreach (var item in listLoaiTaiKhoan)
                    {
                        conn.Insert(item);
                    }

                    var lisLoaiTien = new List<Model_LOAI_TIEN>()
                    {
                        new Model_LOAI_TIEN() {MaLoaiTien="VND",TenLoaiTien="Việt Nam Đồng",TyGiaSoVoiUSD=22426.5f},
                        new Model_LOAI_TIEN() {MaLoaiTien="USD",TenLoaiTien="Đô La Mỹ",TyGiaSoVoiUSD=1},
                        new Model_LOAI_TIEN() {MaLoaiTien="EUR",TenLoaiTien="Euro",TyGiaSoVoiUSD=0.92f},
                    };
                    foreach (var item in lisLoaiTien)
                    {
                        conn.Insert(item);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("[QLTC] " + ex.Message);
                }
            }
            else
            {
                conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            }

            return 1;
        }

        /// <summary>
        /// Gets the connect.
        /// </summary>
        /// <returns></returns>
        public SQLite.Net.SQLiteConnection getConnect()
        {
            if (conn == null)
            {
                this.createDatabase();
            }
            return conn;
        }
    }
}
