using LibraryCommon;
using LibraryDatabaseAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBusinessLogicLayer
{
    public class PublisherBusinessLogic
    {
        private PublisherDataAccess _data;

        public PublisherBusinessLogic()
        {
            _data = new PublisherDataAccess();
        }

        public PublisherBusinessLogic(string conn)
        {
            _data = new PublisherDataAccess(conn);
        }

        public List<Publisher> BLGetPublishers()
        {
            List<Publisher> _list = _data.GetPublishers();
            return _list;
        }

        public void BLCreatePublisher(Publisher p)
        {
            _data.CreatePublisher(p);
        }

        public void BLUpdatePublisher(Publisher p)
        {
            _data.UpdatePublisher(p);
        }

        public void BLDeletePublisher(Publisher p)
        {
            _data.DeletePublisher(p);
        }
    }
}
