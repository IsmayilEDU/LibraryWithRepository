using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Category : IId, IName
    {
        #region Fields
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion

        #region Navigation properties
        public virtual ICollection<Book> Books { get; set; }
        #endregion
    }
}
