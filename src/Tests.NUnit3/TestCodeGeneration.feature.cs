We could not find a data exchange file at the path TechTalk.SpecFlow.SpecFlowException: Unable to find plugin in the plugin search path: Com.Org.SFP.CustomNUnitProperties. Please check http://go.specflow.org/doc-plugins for details.

Please open an issue at https://github.com/techtalk/SpecFlow/issues/
Complete output: 
TechTalk.SpecFlow.SpecFlowException: Unable to find plugin in the plugin search path: Com.Org.SFP.CustomNUnitProperties. Please check http://go.specflow.org/doc-plugins for details.
   at TechTalk.SpecFlow.Generator.Plugins.GeneratorPluginLoader.LoadPlugin(PluginDescriptor pluginDescriptor)
   at TechTalk.SpecFlow.Generator.GeneratorContainerBuilder.LoadPlugin(PluginDescriptor pluginDescriptor, IGeneratorPluginLoader pluginLoader, GeneratorPluginEvents generatorPluginEvents)
   at TechTalk.SpecFlow.Generator.GeneratorContainerBuilder.LoadPlugins(ObjectContainer container, IGeneratorConfigurationProvider configurationProvider, SpecFlowConfigurationHolder configurationHolder, GeneratorPluginEvents generatorPluginEvents, SpecFlowProjectConfiguration specFlowConfiguration)
   at TechTalk.SpecFlow.Generator.GeneratorContainerBuilder.CreateContainer(SpecFlowConfigurationHolder configurationHolder, ProjectSettings projectSettings)
   at TechTalk.SpecFlow.Generator.TestGeneratorFactory.CreateGenerator(ProjectSettings projectSettings)
   at TechTalk.SpecFlow.VisualStudio.CodeBehindGenerator.Actions.GenerateTestFileAction.GenerateTestFile(GenerateTestFileParameters opts)



Command: c:\users\nlstade\appdata\local\microsoft\visualstudio\15.0_ca5ee3ca\extensions\cdcdogwl.dpi\TechTalk.SpecFlow.VisualStudio.CodeBehindGenerator.exe
Parameters: GenerateTestFile --featurefile C:\Users\nlstade\AppData\Local\Temp\tmp6D72.tmp --outputdirectory C:\Users\nlstade\AppData\Local\Temp --projectsettingsfile C:\Users\nlstade\AppData\Local\Temp\tmp6D71.tmp
Working Directory: C:\POC\gitcopies\specflow-plugin-nunit\packages\SpecFlow.2.2.1\tools
