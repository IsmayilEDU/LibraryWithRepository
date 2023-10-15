using ConsoleApp1.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models.Entities
{
    public class Teacher : IId, IFullname
    {
        #region Fields
        public int Id { get ; set; }
        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }
        public int Id_Dep { get; set; }

        #endregion

        #region Navigation properties
        public ICollection<T_Card> T_Cards { get; set; }
        public Department Department { get; set; }
        #endregion
    }
}
