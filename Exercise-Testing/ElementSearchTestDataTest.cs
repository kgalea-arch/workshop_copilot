using System.Collections.ObjectModel;
using Algorithms;
using Exercise_Testing.Help;

namespace Exercise_Testing
{
    public class ElementSearchTestDataTest
    {
        private static Collection<TestCaseData> _testScenario = new Collection<TestCaseData>()
        {

        };

        private ElementSearch _testee;

        [SetUp]
        public void Setup()
        {
            _testee = new ElementSearch();
        }

        [TestCaseSource(nameof(_testScenario))]
        public void ContainsElement_WhenCalled_ThenAsExpected(TestCaseScenarioData testCaseData)
        {
            //Act
            bool result = _testee.ContainsElement(testCaseData.Elements, testCaseData.Target);

            //Assert
            Assert.That(result, Is.EqualTo(testCaseData.Expected));
        }
    }
}