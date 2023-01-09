using System;
using System.Collections.Generic;
using System.Linq;
using CV.Contexts;
using CV.Models;
using Microsoft.EntityFrameworkCore;

namespace CV.Persistance
{
    public class CvRepository : ICvRepository
    {
        private readonly CvContext _cvContext;

        public CvRepository(CvContext cvContext) => _cvContext = cvContext;

        public IEnumerable<User> GetUsers() => _cvContext.Users.ToList();

        public User GetUser(int id) => _cvContext.Users.FirstOrDefault(x => x.id == id);

        public bool AddUser(User user)
        {
            _cvContext.Users.Add(user);
            return _cvContext.SaveChanges() > 0;
        }

        public bool UpdateUser(User user)
        {
            _cvContext.Update(user);
            return _cvContext.SaveChanges() > 0;
        }

        public bool RemoveUser(User user)
        {
            _cvContext.Remove(user);
            return _cvContext.SaveChanges() > 0;
        }

        public IEnumerable<Image> GetImages() => _cvContext.Images.ToList();

        public Image GetImage(int id) => _cvContext.Images.FirstOrDefault(x => x.id == id);

        public bool AddImage(Image image)
        {
            _cvContext.Images.Add(image);
            return _cvContext.SaveChanges() > 0;
        }

        public bool UpdateImage(Image image)
        {
            _cvContext.Update(image);
            return _cvContext.SaveChanges() > 0;
        }

        public bool RemoveImage(Image image)
        {
            _cvContext.Remove(image);
            return _cvContext.SaveChanges() > 0;
        }
    }
}