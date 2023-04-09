using MauiApp1.Entities;

namespace MauiApp1.Services
{
    public interface IDbService
    {
        public IEnumerable<Author> GetAllAuthors();
        public IEnumerable<Book> GetAuthorBooks(int id);
        public void Init();
        void DeleteAllData();

    }
}
