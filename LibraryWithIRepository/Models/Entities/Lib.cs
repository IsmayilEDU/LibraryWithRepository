using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Lib : IId, IFullname
    {
        #region Fields
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        #endregion

        #region Navigation properties
        public virtual ICollection<T_Card> T_Cards { get; set; }
        public virtual ICollection<S_Card> S_Cards { get; set; }
        #endregion
    }
}
