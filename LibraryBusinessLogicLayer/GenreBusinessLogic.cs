using LibraryCommon;
using LibraryDatabaseAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBusinessLogicLayer
{
    public class GenreBusinessLogic
    {
        private GenreDataAccess _data;

        public GenreBusinessLogic()
        {
            _data = new GenreDataAccess();
        }

        public GenreBusinessLogic(string conn)
        {
            _data = new GenreDataAccess(conn);
        }

        public List<Genre> BLGetGenres()
        {
            List<Genre> _list = _data.GetGenres();
            return _list;
        }

        public void BLCreateGenre(Genre g)
        {
            _data.CreateGenre(g);
        }

        public void BLUpdateGenre(Genre g)
        {
            _data.UpdateGenre(g);
        }

        public void BLDeleteGenre(Genre g)
        {
            _data.DeleteGenre(g);
        }
    }
}
