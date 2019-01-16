using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace DiaryMVVMApp1.Models
{
    public sealed class JianjiDatabase
    {
        private readonly static JianjiDatabase Instance = new JianjiDatabase();

        private JianjiDatabase()
        {
            
            conn = new SqliteConnection("Filename="+ApplicationData.Current.LocalFolder.Path+"\\YourDiary.db3");
            Open();
        }

        public static JianjiDatabase GetInstance()
        {
            return Instance;
        }

        private SqliteConnection conn;
        
        public void Open()
        {
            conn.Open();
        }

        public void Close()
        {
            conn.Close();
        }

        public void Insert(Item item)
        {

        }

        public void Update(Item item)
        {

        }

        public void Remove(Item item)
        {

        }
        
    }
}
