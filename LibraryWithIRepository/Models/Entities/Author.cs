using Models.Interfaces;


namespace Models.Entities
{
    public class Author : IId, IFullname
    {
        #region Fields
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        #endregion

        #region Navigation properties
        public virtual ICollection<Book> Books { get; set; }
        #endregion
    }
}
