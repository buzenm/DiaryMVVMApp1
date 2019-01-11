using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryMVVMApp1.Models
{
    public sealed class JianjiDatabase
    {
        private readonly static JianjiDatabase Instance = new JianjiDatabase();

        private JianjiDatabase()
        {
            conn = new SqliteConnection("Filename=ms-appx:///YourDiary.db3");
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
        public IEnumerable<ObservableCollection<Item>> GetDatasListsList()
        {
            return null;
        }
    }
}
