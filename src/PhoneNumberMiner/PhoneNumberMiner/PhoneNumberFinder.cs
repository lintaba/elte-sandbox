//-----------------------------------------------------------------------
// <copyright file="PhoneNumberFinder.cs" company="ELTE">
//     Copyright (c) ELTE All rights reserved.
// </copyright>
// <author>groberto</author>
// <date>3/5/2015 5:19 PM</date>
//-----------------------------------------------------------------------

namespace PhoneNumberMiner
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Finds phone numbers in specified providers.
    /// </summary>
    public class PhoneNumberFinder
    {
        /// <summary>
        /// Finds the phone numbers in the specified source.
        /// </summary>
        /// <param name="provider">The source provider.</param>
        /// <param name="address">The address.</param>
        /// <returns>
        /// The found phone numbers.
        /// </returns>
        public IEnumerable<PhoneNumber> FindPhoneNumbers(ITextProvider provider, string address)
        {
            var regex = new Regex(@"\+(\d\d) (\d{1,2})/(\d{6,7})\b");
            var text = provider.Read(address);

            return regex.Matches(text)
                .Cast<Match>()
                .Select(match => new PhoneNumber
                {
                    CountryCode = int.Parse(match.Groups[1].Value),
                    Area = int.Parse(match.Groups[2].Value),
                    Number = int.Parse(match.Groups[3].Value)
                });
        }
    }
}
