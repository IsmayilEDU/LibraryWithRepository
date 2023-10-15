using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Group : IId, IName
    {
        #region Fields
        public int Id { get; set; }
        public string Name { get; set; }
        public int Id_Faculty { get; set; }

        #endregion

        #region Navigation properties
        public Faculty Faculty { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        #endregion
    }
}
