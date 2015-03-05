//-----------------------------------------------------------------------
// <copyright file="phonenumber.cs" company="ELTE">
//     Copyright (c) ELTE All rights reserved.
// </copyright>
// <author>groberto</author>
// <date>2/26/2015 5:44 PM</date>
//-----------------------------------------------------------------------

namespace PhoneNumberMiner
{
    /// <summary>
    /// Represents a phone number.
    /// </summary>
    public class PhoneNumber
    {
        /// <summary>
        /// Gets or sets the country code.
        /// </summary>
        /// <value>
        /// The country code.
        /// </value>
        public int CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the area.
        /// </summary>
        /// <value>
        /// The area.
        /// </value>
        public int Area { get; set; }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>
        /// The phone number.
        /// </value>
        public int Number { get; set; }
    }
}
