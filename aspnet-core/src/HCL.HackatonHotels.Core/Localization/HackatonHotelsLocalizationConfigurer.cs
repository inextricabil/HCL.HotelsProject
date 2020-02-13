using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace HCL.HackatonHotels.Localization
{
    public static class HackatonHotelsLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(HackatonHotelsConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(HackatonHotelsLocalizationConfigurer).GetAssembly(),
                        "HCL.HackatonHotels.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
