﻿using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace myLinkify.Localization
{
    public static class myLinkifyLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(myLinkifyConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(myLinkifyLocalizationConfigurer).GetAssembly(),
                        "myLinkify.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
