using System;
using System.Collections.Generic;
using CV.Models;

namespace CV.Persistance
{
    public interface ICvRepository
    {
        IEnumerable<User> GetUsers();
        User GetUser(int id);
        bool AddUser(User user);
        bool UpdateUser(User user);
        bool RemoveUser(User user);
        IEnumerable<Image> GetImages();
        Image GetImage(int id);
        bool AddImage(Image image);
        bool UpdateImage(Image image);
        bool RemoveImage(Image image);
    }
}