//-----------------------------------------------------------------------
// <copyright file="IPhoneNumberFinder.cs" company="ELTE">
//     Copyright (c) ELTE All rights reserved.
// </copyright>
// <author>groberto</author>
// <date>2/26/2015 5:34 PM</date>
//-----------------------------------------------------------------------

namespace PhoneNumberMiner
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents the phone number finder functionality.
    /// </summary>
    public interface IPhoneNumberFinder
    {
        /// <summary>
        /// Finds the phone numbers in the specified source.
        /// </summary>
        /// <param name="provider">The source provider.</param>
        /// <returns>The found phone numbers.</returns>
        IEnumerable<PhoneNumber> FindPhoneNumbers(ITextProvider provider);
    }
}
