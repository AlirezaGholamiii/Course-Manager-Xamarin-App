using System;
using SQLite;

namespace dbProject2022.Model
{
    public class Course
    {
        [PrimaryKey, AutoIncrement]
        public int Id { set; get; }

        [MaxLength(250)]
        public string Experience { set; get; }




        
    }
}
