using ConsoleApp1.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models.Entities
{
    public class S_Card : IId, IDate
    {
        #region Fields
        public int Id { get; set; }
        public DateTime DateIn { get ; set ; }
        public DateTime DateOut { get; set ; }
        public int Id_Student { get; set; }
        public int Id_Book { get; set; }
        public int Id_Lib { get; set; }

        #endregion

        #region Navigation properties
        public Student Student { get; set; }
        public Lib Lib { get; set; }
        public Book Book { get; set; }
        #endregion
    }
}
