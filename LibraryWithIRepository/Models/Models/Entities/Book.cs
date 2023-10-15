using ConsoleApp1.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models.Entities
{
    public class Book : IId, IName
    {
        #region Fields
        public int Id { get; set; }
        public string Name { get; set; }
        public int Pages { get; set; }
        public int YearPress { get; set; }
        public int Id_Themes { get; set; }
        public int Id_Category { get; set; }
        public int Id_Author { get; set; }
        public int Id_Press { get; set; }
        public string Comment { get; set; }
        public int Quantity { get; set; }
        #endregion

        #region Navigation properties
        public Author Author { get; set; }
        public Category Category { get; set; }
        public Press Press { get; set; }
        public ICollection<T_Card> T_Cards { get; set; }
        public ICollection<S_Card> S_Cards { get; set; }
        public Theme Theme { get; set; }
        #endregion
    }
}
