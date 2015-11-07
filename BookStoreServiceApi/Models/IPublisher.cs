using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreServiceApi.Models
{
    public interface IPublisher
    {
        /// <summary>
        /// Unique ID of Publisher in DB.
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Publisher's name. 
        /// </summary>
        string Name { get; set; }
    }
}
