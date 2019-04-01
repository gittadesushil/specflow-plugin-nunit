using TechTalk.SpecFlow.Generator.Plugins;
using TechTalk.SpecFlow.Generator.UnitTestProvider;
using TechTalk.SpecFlow.Infrastructure;

[assembly: GeneratorPlugin(typeof(Com.Org.SFP.CustomNUnitProperties.SpecFlowPlugin.Nunit3WithTestGeneratorPlugin))]

namespace Com.Org.SFP.CustomNUnitProperties.SpecFlowPlugin
{
    public class Nunit3WithTestGeneratorPlugin : IGeneratorPlugin
    {
        public void Initialize(GeneratorPluginEvents generatorPluginEvents, GeneratorPluginParameters generatorPluginParameters)
        {
            generatorPluginEvents.CustomizeDependencies += (sender, args) =>
            {
                args.ObjectContainer
                    .RegisterTypeAs<MasterProvider, IUnitTestGeneratorProvider>();
            };
        }
    }
}

