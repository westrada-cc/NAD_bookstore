using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreServiceApi.Models
{
    /// <summary>
    /// This class represents a user of a BookStore. 
    /// </summary>
    /// <remarks>
    /// User does not have a password property associated with it because we do not want to keep his/her password in memory for no reason. 
    /// Password is passed directly to the service layer from the client only when needed.
    /// </remarks>
    public interface IUser
    {
        /// <summary>
        /// Unique ID of User in db. Read Only.
        /// </summary>
        int Id { get; }

        /// <summary>
        /// First name of a User.
        /// </summary>
        string FirstName { get; set; }

        /// <summary>
        /// Last name of a User.
        /// </summary>
        string LastName { get; set; }

        /// <summary>
        /// Nick name of a User.
        /// </summary>
        string Nickname { get; set; }

        /// <summary>
        /// Email address of a User.
        /// </summary>
        string Email { get; set; }

        /// <summary>
        /// Address of a User.
        /// </summary>
        string Address { get; set; }

        /// <summary>
        /// Phone number of a User.
        /// </summary>
        string PhoneNumber { get; set; }

        /// <summary>
        /// If User is an Admin. Read Only.
        /// </summary>
        bool IsAdmin { get; }
    }
}
