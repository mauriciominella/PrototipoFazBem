using FazBem.Interfaces;
using FazBem.Models;
using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XLabs.Ioc;

namespace FazBem.Repositories
{
    public interface IUserRepository
    {
        void Insert(User user);
        IList<User> List();
    }

    public class UserRepository : IUserRepository
    {
        private readonly ISQLite _sqlite;
        private SQLiteConnection _connection;

        public UserRepository()
        {
            _sqlite = Resolver.Resolve<ISQLite>();
            _connection = _sqlite.GetConnection();
            _connection.CreateTable<User>();
        }

        public void Insert(User user)
        {
            _connection.Insert(user);
        }

        public IList<User> List()
        {
            return (from i in _connection.Table<User>() select i).ToList();
        }
    }
}
