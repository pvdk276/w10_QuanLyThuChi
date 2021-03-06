﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuChi.Model;
using QuanLyThuChi.Objects;
using System.Diagnostics;

namespace QuanLyThuChi.DAL
{
    public class DAL_USERS
    {
        SQLite.Net.SQLiteConnection conn = (new ConnectToDB()).getConnect();

        public int insertUser(string email, 
            string firstName, 
            string lastName, 
            string password, 
            string type, 
            bool status)
        {
            //Insert data to Model_USERS
            if (conn.Insert(new Model_USERS()
            {
                Email = email,
                FirstName = firstName,
                LastName = lastName,
                Password = password,
                Type = type,
                Status = status
            }) == 0)
                return 0;
            return 1;
        }
        public USERS getUsersByEmail(string email)
        {
            var query = conn.Table<Model_USERS>().Where(x => x.Email == email);
            USERS usr = new USERS();
            foreach (var item in query)
            {
                usr = new USERS(item.Email, item.FirstName, item.LastName, item.Password, item.Type, item.Status);
                Debug.WriteLine("[QLTC]" + usr.email + " | " + usr.password);
            }
            return usr;
        }
        
        public List<USERS> getUser()
        {
            List<USERS> lstUser = new List<USERS>();
            var query = conn.Table<Model_USERS>();
            foreach (var item in query)
            {
                lstUser.Add(new USERS(item.Email,
                    item.FirstName,
                    item.LastName,
                    item.Password,
                    item.Type,
                    item.Status,
                    item.CodeChangePassword));
                //debug string
                Debug.WriteLine("QLTC" + item.Email + " | " + item.Password + " | " + item.Type);
            }
            return lstUser;
        }

        public int deleteUser(string email)
        {
            var user = conn.Table<Model_USERS>().Where(x => x.Email == email).FirstOrDefault();
            if(user != null)
            {
                conn.Delete(user);
                return 0;
            }
            return 1;
        }
    }
}
