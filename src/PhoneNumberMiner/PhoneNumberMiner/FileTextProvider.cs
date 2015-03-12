//-----------------------------------------------------------------------
// <copyright file="FileTextProvider.cs" company="ELTE">
//     Copyright (c) ELTE All rights reserved.
// </copyright>
// <author>groberto</author>
// <date>3/5/2015 5:05 PM</date>
//-----------------------------------------------------------------------

namespace PhoneNumberMiner
{
    using System.IO;

    /// <summary>
    /// Provides text content from files.
    /// </summary>
    public class FileTextProvider : ITextProvider
    {
        /// <summary>
        /// Reads the text content from the file specified by its address.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <returns>
        /// The text content.
        /// </returns>
        public string Read(string address)
        {
            return File.ReadAllText(address);
        }
    }
}
