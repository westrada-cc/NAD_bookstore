using BookStoreServiceApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreWebSite.FakeServices
{
    public class FakeAuthor : IAuthor
    {
        public int Id
        {
            get { return this.FakeId; }
        }

        public int FakeId { get; set; }


        public string FullName { get; set; }
    }
}