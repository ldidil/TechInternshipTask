using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TechInternshipTask.Tests
{
    class MultiCultureFormatterTests
    {

        [TestCase("30.04.2018", 30,  4)]
        [TestCase("04.30.2018", 30, 4)]
        [Test]

        public void ShouldParseMultiCultureSetCultureInfo(string data1,
                                                          int expectedDay,
                                                          int expectedMonth)
        {

            var result = new MultiCultureFormatter().ParseMultiCulture(data1);
            Assert.AreEqual(result.Day, expectedDay);
            Assert.AreEqual(result.Month, expectedMonth);

        }

        [TestCase("")]
        [Test]

        public void ShouldtParseMultiCultureThrowExeprion(string data1)
        {

            Assert.That(() => new MultiCultureFormatter().ParseMultiCulture(data1),
            Throws.Exception
            .TypeOf<NotSupportedException>()
            .With.Property("Message")
            .EqualTo("Given datestring is in a format that is not supported."));

        }
    }
}
