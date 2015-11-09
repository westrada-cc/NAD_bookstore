using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStoreServiceApi;
using BookStoreServiceApi.Models;

namespace BookStoreWebSite.FakeServices
{
    public class FakeBook : IBook
    {
        public int Id
        {
            get { return this.FakeId; }
        }

        public int FakeId { get; set; }

        public string Title { get; set; }

        public string Isbn { get; set; }

        public IList<IAuthor> Authors { get; set; }

        public IList<IPublisher> Publishers { get; set; }

        public int NumberOfPages { get; set; }

        public string Edition { get; set; }

        public bool IsHardCover { get; set; }

        public IUser UserCreated { get; set; }
    }
}