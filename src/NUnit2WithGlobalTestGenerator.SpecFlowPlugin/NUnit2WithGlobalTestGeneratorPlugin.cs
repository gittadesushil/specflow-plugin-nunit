using TechTalk.SpecFlow.Generator.Plugins;
using TechTalk.SpecFlow.Generator.UnitTestProvider;
using TechTalk.SpecFlow.Infrastructure;

[assembly: GeneratorPlugin(typeof(NUnit2WithGlobalTestGenerator.SpecFlowPlugin.NUnit2WithGlobalTestGeneratorPlugin))]

namespace NUnit2WithGlobalTestGenerator.SpecFlowPlugin
{
    public class NUnit2WithGlobalTestGeneratorPlugin : IGeneratorPlugin
    {
        public void Initialize(GeneratorPluginEvents generatorPluginEvents, GeneratorPluginParameters generatorPluginParameters)
        {
            generatorPluginEvents.CustomizeDependencies += (sender, args) =>
            {
                args.ObjectContainer
                    .RegisterTypeAs<NUnit2WithGlobalTestGeneratorProvider, IUnitTestGeneratorProvider>();
            };
        }
    }
}

