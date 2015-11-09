using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStoreServiceApi;
using BookStoreServiceApi.Models;

namespace BookStoreWebSite.FakeServices
{
    public class FakeUser : IUser
    {
        public int Id
        {
            get { return this.FakeId; }
        }

        public int FakeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Nickname { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public bool IsAdmin
        {
            get { return this.FakeIsAdmin; }
        }

        public bool FakeIsAdmin { get; set; }
    }
}