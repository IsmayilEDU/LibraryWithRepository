using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
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
        public virtual Book Book { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Lib Lib { get; set; }
        #endregion
    }
}
