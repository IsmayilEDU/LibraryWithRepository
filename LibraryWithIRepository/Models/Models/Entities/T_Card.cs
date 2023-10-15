using ConsoleApp1.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models.Entities
{
    public class T_Card : IId, IDate
    {
        #region Fields
        public int Id { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }
        public int Id_Teacher { get; set; }
        public int Id_Book { get; set; }
        public int Id_Lib { get; set; }
        #endregion

        #region Navigation properties
        public Book Book { get; set; }
        public Teacher Teacher { get; set; }
        public Lib Lib { get; set; }
        #endregion
    }
}
