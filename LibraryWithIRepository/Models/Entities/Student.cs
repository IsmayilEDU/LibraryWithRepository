using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Student : IId, IFullname
    {
        #region Fields
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id_Group { get; set; }
        public int Term { get; set; }

        #endregion

        #region Navigation properties
        public virtual ICollection<S_Card> S_Cards { get; set; }
        public virtual Group Group { get; set; }
        #endregion
    }
}
