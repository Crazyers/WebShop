﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Users.Common.Dtos.Users
{
    /// <summary>
    /// User's profile view DTO
    /// </summary>
    public class UserInfoViewDto
    {
        /// <summary>
        /// User's first name
        /// </summary>
        public String FirstName { get; set; }

        /// <summary>
        /// Users's last name
        /// </summary>
        public String LastName { get; set; }

        /// <summary>
        /// User's email address
        /// </summary>
        public String Email { get; set; }

        /// <summary>
        /// User's date of birth
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// User's occupation
        /// </summary>
        public String Occupation { get; set; }

        /// <summary>
        /// User's education
        /// </summary>
        public String Education { get; set; }

 
    }
}
