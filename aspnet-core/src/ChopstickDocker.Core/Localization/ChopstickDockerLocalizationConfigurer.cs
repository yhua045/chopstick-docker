using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ChopstickDocker.Localization
{
    public static class ChopstickDockerLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ChopstickDockerConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ChopstickDockerLocalizationConfigurer).GetAssembly(),
                        "ChopstickDocker.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
