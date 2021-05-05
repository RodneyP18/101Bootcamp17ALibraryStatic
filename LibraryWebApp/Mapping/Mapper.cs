using LibraryCommon;
using LibraryWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryWebApp.Mapping
{
    public class Mapper
    {
        public List<RoleModel> RoleListToRoleModels(List<Role> list)
        {
            List<RoleModel> toReturn = new List<RoleModel>();
            

            foreach (Role role in list)
            {
                RoleModel newModel = new RoleModel();
                newModel.RoleID = role.RoleID;
                newModel.RoleName = role.RoleName;

                toReturn.Add(newModel);
            }
            
            return toReturn;
        }

        internal List<UserModel> UserListToUserModels(List<User> list)
        {
            List<UserModel> toReturn = new List<UserModel>();


            foreach (User user in list)
            {
                UserModel newModel = new UserModel();

                newModel.UserID = user.UserID;
                newModel.FirstName = user.FirstName;
                newModel.LastName = user.LastName;
                newModel.UserName = user.UserName;
                newModel.Password = user.Password;
                newModel.RoleID_FK = user.RoleID_FK;

                toReturn.Add(newModel);
            }

            return toReturn;
        }

        internal List<BookModel> BookListToBookModels(List<Book> list)
        {
            throw new NotImplementedException();
        }

        internal List<AuthorModel> AuthorListToAuthorModels(List<Author> list)
        {
            throw new NotImplementedException();
        }

        internal List<GenreModel> GenreListToGenreModels(List<Genre> list)
        {
            throw new NotImplementedException();
        }

        internal List<PublisherModel> PublisherListToPublisherModels(List<Publisher> list)
        {
            List<PublisherModel> toReturn = new List<PublisherModel>();


            foreach (Publisher publisher in list)
            {
                PublisherModel newModel = new PublisherModel();

                newModel.PublisherID = publisher.PublisherID;
                newModel.Name = publisher.Name;
                newModel.Address = publisher.Address;
                newModel.City = publisher.City;
                newModel.State = publisher.State;
                newModel.Zip = publisher.Zip;

                toReturn.Add(newModel);
            }

            return toReturn;
        }
    }
}