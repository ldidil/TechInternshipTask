using NUnit.Framework;
using System;

namespace TechInternshipTask.Tests
{
    [TestFixture]
    public class DataRangeCreatorTests
    {
        DateRangeCreator _dataRangeCreator;

        [TestCase("01.01.2018", "02.02.2019", "01.01.2018-02.02.2019")] //EU format
        [TestCase("01.01.2019", "02.02.2019", "01.01-02.02.2019")]
        [TestCase("01.01.2019", "02.01.2019", "01-02.01.2019")]
        [TestCase("02.02.2019", "01.01.2018", "01.01.2018-02.02.2019")]
        [TestCase("02.20.2018", "03.30.2019", "20.02.2018-30.03.2019")] //US format


        [Test]
        public void ShouldPrintCorrectDate(string data1, string data2, string expectResult)
        {
            _dataRangeCreator = new DateRangeCreator(data1, data2);

            var result = _dataRangeCreator.GetPrintableData();

            Assert.IsTrue(String.Equals(result, expectResult));
        }



    }

}