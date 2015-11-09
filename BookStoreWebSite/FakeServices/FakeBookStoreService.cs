using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStoreServiceApi;
using BookStoreServiceApi.Models;
using System.Web.UI.WebControls;
using System.IO;

namespace BookStoreWebSite.FakeServices
{
    public class FakeBookStoreService : IBookStoreService
    {
        public string Ip
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Port
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public IList<IBook> GetBooks(string search)
        {
            throw new NotImplementedException();
        }

        public IList<IBook> GetBooksByIsbn(string isbn)
        {
            throw new NotImplementedException();
        }

        public bool PostAd(IAd ad, string userPassword)
        {
            throw new NotImplementedException();
        }

        public IList<IAd> GetAds(string search, DateTime? from, DateTime? to)
        {
            List<IAd> adList = new List<IAd>();
            for (int i = 0; i < 10; i++)
            {
                var ad = new FakeAd() 
                { 
                    FakeId = i + 1,
                    Title = "Used book sale ad title " + (i + 1).ToString(),
                    Description = "I am selling this book because I do not need it anymore and because it sucks like a vacuum cleaner." + (i + 1).ToString(),
                    Book = new FakeBook()
                    {
                        FakeId = (i + 1) % 3 + 1,
                        Title = "Book Title " + ((i + 1) % 3 + 1).ToString(),
                        IsHardCover = true,
                        NumberOfPages = ((i + 1) % 3 + 1) * 100
                    },
                    Price = ((i + 1) % 5 + 1) * 10,
                    Pictures = new List<byte[]>()
                };

                //var image = System.Drawing.Image.FromFile(@"C:\SchoolProject\BookStore\BookStoreWebSite\Resources\No-Book.jpg");
                //ad.Pictures.Add(ImageToBytes(image));
                adList.Add(ad);
            }

            return adList;
        }

        public byte[] ImageToBytes(System.Drawing.Image img)
        {
            var converter = new System.Drawing.ImageConverter();

            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
    }
}