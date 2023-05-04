using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Category
    {
        public Category(int id, string name)
        {
            this.iD = id;
            this.name = name;
        }
        public Category(DataRow row)
        {
            this.iD = (int)row["ID"];
            this.name = row["name"].ToString();
        }
        private string name;
        private int iD;
public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        public string Name 
        { 
            get { return name; }
            set { name = value; } 
        } 
    }
}
