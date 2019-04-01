using System.CodeDom;
using System.Collections.Generic;
using TechTalk.SpecFlow.Generator;
using TechTalk.SpecFlow.Generator.UnitTestProvider;
using TechTalk.SpecFlow.Utils;

namespace Com.Org.Commons
{
    public abstract class NUnitCustomTestGeneratorProvider : IUnitTestGeneratorProvider
    {
        private const string NUnitFrameworkNamespace = "NUnit.Framework";

        protected readonly IUnitTestGeneratorProvider UnitTestGeneratorProvider;

        protected NUnitCustomTestGeneratorProvider(CodeDomHelper codeDomHelper)
        {
            UnitTestGeneratorProvider = new NUnit3TestGeneratorProvider(codeDomHelper);
        }

        public UnitTestGeneratorTraits GetTraits()
        {
            return UnitTestGeneratorProvider.GetTraits();
        }

        public abstract void SetTestClass(TestClassGenerationContext generationContext, string featureTitle,
            string featureDescription);
        /*{
            _unitTestGeneratorProvider.SetTestClass(generationContext, featureTitle, featureDescription);
            UpdateAttributes(generationContext.TestClass);
        }*/

        public void SetTestClassCategories(TestClassGenerationContext generationContext, IEnumerable<string> featureCategories)
        {
            UnitTestGeneratorProvider.SetTestClassCategories(generationContext, featureCategories);

            UpdateAttributes(generationContext.TestClass);
        }

        public void SetTestClassIgnore(TestClassGenerationContext generationContext)
        {
            UnitTestGeneratorProvider.SetTestClassIgnore(generationContext);

            UpdateAttributes(generationContext.TestClass);
        }

        public void FinalizeTestClass(TestClassGenerationContext generationContext)
        {
            UnitTestGeneratorProvider.FinalizeTestClass(generationContext);

            UpdateAttributes(generationContext.TestClass);
        }

        public void SetTestClassParallelize(TestClassGenerationContext generationContext)
        {
            UnitTestGeneratorProvider.SetTestClassParallelize(generationContext);

            UpdateAttributes(generationContext.TestClass);
        }

        public void SetTestClassInitializeMethod(TestClassGenerationContext generationContext)
        {
            UnitTestGeneratorProvider.SetTestClassInitializeMethod(generationContext);

            UpdateAttributes(generationContext.TestClassInitializeMethod);
        }

        public void SetTestClassCleanupMethod(TestClassGenerationContext generationContext)
        {
            UnitTestGeneratorProvider.SetTestClassCleanupMethod(generationContext);

            UpdateAttributes(generationContext.TestClassCleanupMethod);
        }

        public void SetTestInitializeMethod(TestClassGenerationContext generationContext)
        {
            UnitTestGeneratorProvider.SetTestInitializeMethod(generationContext);

            UpdateAttributes(generationContext.TestInitializeMethod);
        }

        public void SetTestCleanupMethod(TestClassGenerationContext generationContext)
        {
            UnitTestGeneratorProvider.SetTestCleanupMethod(generationContext);

            UpdateAttributes(generationContext.TestCleanupMethod);
        }

        public void SetTestMethod(TestClassGenerationContext generationContext, CodeMemberMethod testMethod, string friendlyTestName)
        {
            UnitTestGeneratorProvider.SetTestMethod(generationContext, testMethod, friendlyTestName);

            UpdateAttributes(testMethod);
        }

        public void SetTestMethodCategories(TestClassGenerationContext generationContext, CodeMemberMethod testMethod,
            IEnumerable<string> scenarioCategories)
        {
            UnitTestGeneratorProvider.SetTestMethodCategories(generationContext, testMethod, scenarioCategories);

            UpdateAttributes(testMethod);
        }

        public void SetTestMethodIgnore(TestClassGenerationContext generationContext, CodeMemberMethod testMethod)
        {
            UnitTestGeneratorProvider.SetTestMethodIgnore(generationContext, testMethod);

            UpdateAttributes(testMethod);
        }

        public void SetRowTest(TestClassGenerationContext generationContext, CodeMemberMethod testMethod, string scenarioTitle)
        {
            UnitTestGeneratorProvider.SetRowTest(generationContext, testMethod, scenarioTitle);

            UpdateAttributes(testMethod);
        }

        public void SetRow(TestClassGenerationContext generationContext, CodeMemberMethod testMethod, IEnumerable<string> arguments,
            IEnumerable<string> tags, bool isIgnored)
        {
            UnitTestGeneratorProvider.SetRow(generationContext, testMethod, arguments, tags, isIgnored);

            UpdateAttributes(testMethod);
        }

        public void SetTestMethodAsRow(TestClassGenerationContext generationContext, CodeMemberMethod testMethod, string scenarioTitle,
            string exampleSetName, string variantName, IEnumerable<KeyValuePair<string, string>> arguments)
        {
            UnitTestGeneratorProvider.SetTestMethodAsRow(generationContext, testMethod, scenarioTitle, exampleSetName,
                variantName, arguments);

            UpdateAttributes(testMethod);
        }

        private void UpdateAttributes(CodeTypeMember codeTypeMember)
        {
            foreach (CodeAttributeDeclaration codeAttribute in codeTypeMember.CustomAttributes)
            {
                if (codeAttribute.Name.StartsWith(NUnitFrameworkNamespace))
                    codeAttribute.Name = "global::" + codeAttribute.Name;
            }
        }
    }
}
