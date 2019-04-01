using Com.Org.Commons;
using TechTalk.SpecFlow.Generator;
using TechTalk.SpecFlow.Utils;

namespace Com.Org.SFP.CustomNUnitProperties.SpecFlowPlugin
{
    public class MasterProvider : NUnitCustomTestGeneratorProvider
    {
        public MasterProvider(CodeDomHelper codeDomHelper) : base(codeDomHelper)
        {
        }

        public override void SetTestClass(TestClassGenerationContext generationContext, string featureTitle,
            string featureDescription)
        {
            UnitTestGeneratorProvider.SetTestClass(generationContext, featureTitle, featureDescription);
        }
    }
}
