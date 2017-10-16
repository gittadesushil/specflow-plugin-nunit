using TechTalk.SpecFlow.Generator.Plugins;
using TechTalk.SpecFlow.Generator.UnitTestProvider;
using TechTalk.SpecFlow.Infrastructure;

[assembly: GeneratorPlugin(typeof(NUnit3WithGlobalTestGenerator.SpecFlowPlugin.NUnit3WithGlobalTestGeneratorPlugin))]

namespace NUnit3WithGlobalTestGenerator.SpecFlowPlugin
{
    public class NUnit3WithGlobalTestGeneratorPlugin : IGeneratorPlugin
    {
        public void Initialize(GeneratorPluginEvents generatorPluginEvents, GeneratorPluginParameters generatorPluginParameters)
        {
            generatorPluginEvents.CustomizeDependencies += (sender, args) =>
            {
                args.ObjectContainer
                    .RegisterTypeAs<NUnit3WithGlobalTestGeneratorProvider, IUnitTestGeneratorProvider>();
            };
        }
    }
}

