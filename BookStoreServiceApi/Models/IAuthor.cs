using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreServiceApi.Models
{
    public interface IAuthor
    {
        /// <summary>
        /// Unique ID of Author in DB.
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Author's full name. 
        /// </summary>
        string FullName { get; set; }
    }
}
