using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;

namespace TechInternshipTask.Tests
{
    [TestFixture]
    public class DataRageCreatorTests
    {
        DataRageCreator _dataRageCreator;

        [TestCase("01.01.2018", "02.02.2019", "01.01.2018-02.02.2019")] //EU format

        [TestCase("01.01.2019", "02.02.2019", "01.01-02.02.2019")]
        [TestCase("01.01.2019", "02.01.2019", "01-02.01.2019")]
        [TestCase("02.02.2019", "01.01.2018", "01.01.2018-02.02.2019")]

        [TestCase("02.20.2018", "03.30.2019", "20.02.2018-30.03.2019")] //US format


        [Test]
        public void ShouldPrintCorrectDate(string data1, string data2, string expectResult)
        {
            _dataRageCreator = new DataRageCreator(data1, data2);

            var result = _dataRageCreator.GetPrintableData();

            Assert.IsTrue(String.Equals(result, expectResult));
        }

        [TestCase("")]
        [Test]

        public void ShouldntParseMultiCultureThrowExeprion(string data1)
        {
            _dataRageCreator = new DataRageCreator();

            Assert.That(() => _dataRageCreator.ParseMultiCulture(data1),
            Throws.Exception
            .TypeOf<NotSupportedException>()
            .With.Property("Message")
            .EqualTo("Given datestring is in a format that is not supported."));

        }

    }

}