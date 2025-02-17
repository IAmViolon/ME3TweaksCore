﻿using LegendaryExplorerCore.Packages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME3TweaksCore.Objects
{
    /// <summary>
    /// Describes a language relative to a game
    /// </summary>
    public class GameLanguage
    {
        private static GameLanguage[] me1languages = {
            new GameLanguage(@"INT", @"en-us", @"International English", MELocalization.INT),
            new GameLanguage(@"ES", @"es-es", @"Spanish", MELocalization.ESN),
            new GameLanguage(@"DE", @"de-de", @"German", MELocalization.DEU),
            new GameLanguage(@"RA", @"ru-ru", @"Russian", MELocalization.RUS),
            new GameLanguage(@"FR", @"fr-fr", @"French", MELocalization.FRA),
            new GameLanguage(@"IT", @"it-it", @"Italian", MELocalization.ITA),
            new GameLanguage(@"PLPC", @"pl-pl", @"Polish", MELocalization.POL),
            new GameLanguage(@"JA", @"jp-jp", @"Japanese", MELocalization.JPN),
        };

        private static GameLanguage[] me2languages = {
            new GameLanguage(@"INT", @"en-us", @"International English", MELocalization.INT),
            new GameLanguage(@"ESN", @"es-es", @"Spanish", MELocalization.ESN),
            new GameLanguage(@"DEU", @"de-de", @"German", MELocalization.RUS),
            new GameLanguage(@"RUS", @"ru-ru", @"Russian", MELocalization.RUS),
            new GameLanguage(@"FRA", @"fr-fr", @"French", MELocalization.FRA),
            new GameLanguage(@"ITA", @"it-it", @"Italian", MELocalization.ITA),
            new GameLanguage(@"POL", @"pl-pl", @"Polish", MELocalization.POL),
            new GameLanguage(@"JPN", @"jp-jp", @"Japanese", MELocalization.JPN),
            new GameLanguage(@"HUN", @"hu-hu", @"Hungarian", MELocalization.None), // Only partially supported
            new GameLanguage(@"CZE", @"cs-cz", @"Czech", MELocalization.None), // Only partially supported
        };

        private static GameLanguage[] me3languages = {
            new GameLanguage(@"INT", @"en-us", @"International English", MELocalization.INT),
            new GameLanguage(@"ESN", @"es-es", @"Spanish", MELocalization.ESN),
            new GameLanguage(@"DEU", @"de-de", @"German", MELocalization.RUS),
            new GameLanguage(@"RUS", @"ru-ru", @"Russian", MELocalization.RUS),
            new GameLanguage(@"FRA", @"fr-fr", @"French", MELocalization.FRA),
            new GameLanguage(@"ITA", @"it-it", @"Italian", MELocalization.ITA),
            new GameLanguage(@"POL", @"pl-pl", @"Polish", MELocalization.POL),
            new GameLanguage(@"JPN", @"jp-jp", @"Japanese", MELocalization.JPN)
        };

        private static GameLanguage[] le1languages = {
            new GameLanguage(@"INT", @"en-us", @"International English", MELocalization.INT),
            new GameLanguage(@"ES", @"es-es", @"Spanish (English VO)", MELocalization.ESN),
            new GameLanguage(@"DE", @"de-de", @"German", MELocalization.DEU),
            new GameLanguage(@"RA", @"ru-ru", @"Russian", MELocalization.RUS),
            new GameLanguage(@"FR", @"fr-fr", @"French", MELocalization.FRA),
            new GameLanguage(@"IT", @"it-it", @"Italian", MELocalization.ITA),
            new GameLanguage(@"PLPC", @"pl-pl", @"Polish", MELocalization.POL),
            new GameLanguage(@"JA", @"jp-jp", @"Japanese (English VO)", MELocalization.JPN),
            /* English VO */
            new GameLanguage(@"GE", @"de-de", @"German (English VO)", MELocalization.DEU),
            new GameLanguage(@"RU", @"ru-ru", @"Russian (English VO)", MELocalization.RUS),
            new GameLanguage(@"FE", @"fr-fr", @"French (English VO)", MELocalization.FRA),
            new GameLanguage(@"IE", @"it-it", @"Italian (English VO)", MELocalization.ITA),
            new GameLanguage(@"PL", @"pl-pl", @"Polish (English VO)", MELocalization.POL),
        };

        private static GameLanguage[] le2languages = {
            new GameLanguage(@"INT", @"en-us", @"International English", MELocalization.INT),
            new GameLanguage(@"ESN", @"es-es", @"Spanish", MELocalization.ESN),
            new GameLanguage(@"DEU", @"de-de", @"German", MELocalization.RUS),
            new GameLanguage(@"RUS", @"ru-ru", @"Russian", MELocalization.RUS),
            new GameLanguage(@"FRA", @"fr-fr", @"French", MELocalization.FRA),
            new GameLanguage(@"ITA", @"it-it", @"Italian", MELocalization.ITA),
            new GameLanguage(@"POL", @"pl-pl", @"Polish", MELocalization.POL),
            new GameLanguage(@"JPN", @"jp-jp", @"Japanese", MELocalization.JPN)
        };

        private static GameLanguage[] le3languages = {
            new GameLanguage(@"INT", @"en-us", @"International English", MELocalization.INT),
            new GameLanguage(@"ESN", @"es-es", @"Spanish", MELocalization.ESN),
            new GameLanguage(@"DEU", @"de-de", @"German", MELocalization.RUS),
            new GameLanguage(@"RUS", @"ru-ru", @"Russian", MELocalization.RUS),
            new GameLanguage(@"FRA", @"fr-fr", @"French", MELocalization.FRA),
            new GameLanguage(@"ITA", @"it-it", @"Italian", MELocalization.ITA),
            new GameLanguage(@"POL", @"pl-pl", @"Polish", MELocalization.POL),
            new GameLanguage(@"JPN", @"jp-jp", @"Japanese", MELocalization.JPN)
        };

        /// <summary>
        /// The language code - filenames will be suffixed with this to denote the specific language
        /// </summary>
        public string FileCode { get; }
        /// <summary>
        /// The language code, such as en-us
        /// </summary>
        public string LanguageCode { get; }
        /// <summary>
        /// English human description
        /// </summary>
        public string HumanDescription { get; }
        /// <summary>
        /// The localization enumeration of this language
        /// </summary>
        public MELocalization Localization { get; }

        public GameLanguage(string filecode, string languageCode, string humanDescription, MELocalization loc)
        {
            FileCode = filecode;
            LanguageCode = languageCode;
            HumanDescription = humanDescription;
            Localization = loc;
        }

        public override string ToString()
        {
            return $@"{FileCode} - {HumanDescription}";
        }

        public static GameLanguage[] GetLanguagesForGame(MEGame game)
        {
            if (game is MEGame.ME1) return me1languages;
            if (game is MEGame.ME2) return me2languages;
            if (game is MEGame.ME3) return me3languages;
            if (game is MEGame.LE1) return le1languages;
            if (game is MEGame.LE2) return le2languages;
            if (game is MEGame.LE3) return le3languages;

            throw new Exception($@"Cannot get language for game {game}");
        }
    }
}
