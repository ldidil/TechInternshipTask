using NUnit.Framework;
using System;

namespace TechInternshipTask.Tests
{
    [TestFixture]
    public class DataRageCreatorTests
    {
        DataRageCreator _dataRageCreator;

        [TestCase("01.01.2018","02.02.2019", "01.01.2018-02.02.2019")]

        [TestCase("01.01.2019", "02.02.2019", "01.01-02.02.2019")]
        [TestCase("01.01.2019", "02.01.2019", "01-02.01.2019")]
        [TestCase("02.02.2019", "01.01.2018", "01.01.2018-02.02.2019")]

        [Test]
        public void ShouldDataRageCreatorWorks(string data1, string data2, string expectResult)
        {
            _dataRageCreator = new DataRageCreator(data1, data2);

            var result = _dataRageCreator.GetPrintableData();

            Assert.IsTrue(String.Equals(result, expectResult));
        }

        [TestCase("", "12.12.2019", "12.13.2018-2.12.2019")]
        [Test]
        public void ShouldntDataRageCreatorWorks(string data1, string data2, string expectResult)
        {
            _dataRageCreator = new DataRageCreator(data1, data2);

            Assert.IsTrue(_dataRageCreator.GetPrintableData() == null);
        }

    }

}