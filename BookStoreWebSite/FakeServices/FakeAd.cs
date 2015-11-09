using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStoreServiceApi;
using BookStoreServiceApi.Models;
using System.Drawing;

namespace BookStoreWebSite.FakeServices
{
    public class FakeAd : IAd
    {
        public int Id
        {
            get { return this.FakeId; }
        }

        public int FakeId { get; set; }

        public string Title
        {
            get { return _title; }
            set
            {
                if (_title != value)
                {
                    _title = value;
                }
            }
        }
        private string _title;

        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                }
            }
        }
        private string _description;

        public IBook Book
        {
            get { return _book; }
            set
            {
                if (_book != value)
                {
                    _book = value;
                }
            }
        }
        private IBook _book;

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                }
            }
        }
        private decimal _price;

        public IUser UserPosted
        {
            get { return _userPosted; }
            set
            {
                if (_userPosted != value)
                {
                    _userPosted = value;
                }
            }
        }
        private IUser _userPosted;

        public DateTime PostTimestamp
        {
            get { return this.FakePostTimestamp; }
        }

        public DateTime FakePostTimestamp
        {
            get { return _fakePostTImestamp; }
            set
            {
                if (_fakePostTImestamp != value)
                {
                    _fakePostTImestamp = value;
                }
            }
        }
        private DateTime _fakePostTImestamp;

        public IList<string> Tags { get; set; }

        public IList<byte[]> Pictures { get; set; }
    }
}