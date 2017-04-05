using System;
using TechTalk.SpecFlow;

namespace BDD.Tests
{
    public class TestRunner : ITestRunner
    {
        public void InitializeTestRunner(int threadId)
        {
            throw new NotImplementedException();
        }

        public void OnTestRunStart()
        {
            throw new NotImplementedException();
        }

        public void OnTestRunEnd()
        {
            throw new NotImplementedException();
        }

        public void OnFeatureStart(FeatureInfo featureInfo)
        {
            throw new NotImplementedException();
        }

        public void OnFeatureEnd()
        {
            throw new NotImplementedException();
        }

        public void OnScenarioStart(ScenarioInfo scenarioInfo)
        {
            throw new NotImplementedException();
        }

        public void CollectScenarioErrors()
        {
            throw new NotImplementedException();
        }

        public void OnScenarioEnd()
        {
            throw new NotImplementedException();
        }

        public void Given(string text, string multilineTextArg, Table tableArg, string keyword = null)
        {
            throw new NotImplementedException();
        }

        public void When(string text, string multilineTextArg, Table tableArg, string keyword = null)
        {
            throw new NotImplementedException();
        }

        public void Then(string text, string multilineTextArg, Table tableArg, string keyword = null)
        {
            throw new NotImplementedException();
        }

        public void And(string text, string multilineTextArg, Table tableArg, string keyword = null)
        {
            throw new NotImplementedException();
        }

        public void But(string text, string multilineTextArg, Table tableArg, string keyword = null)
        {
            throw new NotImplementedException();
        }

        public void Pending()
        {
            throw new NotImplementedException();
        }

        public int ThreadId { get; }
        public FeatureContext FeatureContext { get; }
        public ScenarioContext ScenarioContext { get; }
    }
}
