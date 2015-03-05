//-----------------------------------------------------------------------
// <copyright file="itextprovider.cs" company="ELTE">
//     Copyright (c) ELTE All rights reserved.
// </copyright>
// <author>groberto</author>
// <date>2/26/2015 5:22 PM</date>
//-----------------------------------------------------------------------

namespace PhoneNumberMiner
{
    /// <summary>
    /// Represents a text source provider.
    /// </summary>
    public interface ITextProvider
    {
        /// <summary>
        /// Reads the text content from the specified address.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <returns>The text content.</returns>
        string Read(string address);
    }
}
