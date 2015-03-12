//-----------------------------------------------------------------------
// <copyright file="PhoneNumberFinderTest.cs" company="ELTE">
//     Copyright (c) ELTE All rights reserved.
// </copyright>
// <author>groberto</author>
// <date>3/5/2015 5:50 PM</date>
//-----------------------------------------------------------------------

namespace PhoneNumberMiner.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Linq;

    /// <summary>
    /// Tests the <see cref="PhoneNumberMiner.PhoneNumberFinder"/> class.
    /// </summary>
    [TestClass]
    public class PhoneNumberFinderTest
    {
        private ITextProvider textProvider;
        private PhoneNumberFinder phoneNumberFinder;

        /// <summary>
        /// Initializes the tests.
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            this.textProvider = new FileTextProvider();
            this.phoneNumberFinder = new PhoneNumberFinder();
        }

        /// <summary>
        /// Tests the finder functionality.
        /// </summary>
        /// <remarks>
        /// Requires the TestInputs/TestInput1.txt file.
        /// </remarks>
        [TestMethod]
        public void FindTest()
        {
            var result = this.phoneNumberFinder.FindPhoneNumbers(this.textProvider, @"TestInputs/TestInput1.txt");

            Assert.IsNotNull(result);

            var resultArray = result.ToArray();

            Assert.AreEqual(3, resultArray.Length);

            Assert.AreEqual(36, resultArray[0].CountryCode);
            Assert.AreEqual(20, resultArray[0].Area);
            Assert.AreEqual(1888884, resultArray[0].Number);

            Assert.AreEqual(36, resultArray[1].CountryCode);
            Assert.AreEqual(20, resultArray[1].Area);
            Assert.AreEqual(888888, resultArray[1].Number);

            Assert.AreEqual(36, resultArray[2].CountryCode);
            Assert.AreEqual(20, resultArray[2].Area);
            Assert.AreEqual(8888884, resultArray[2].Number);
        }
    }
}
