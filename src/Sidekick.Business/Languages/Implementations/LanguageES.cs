using System;

namespace Sidekick.Business.Languages.Implementations
{
    [Language("Spanish", "Rareza", "es")]
    public class LanguageES : ILanguage
    {
        public Uri PoeTradeSearchBaseUrl => new Uri("https://es.pathofexile.com/trade/search/");
        public Uri PoeTradeExchangeBaseUrl => new Uri("https://es.pathofexile.com/trade/exchange/");
        public Uri PoeTradeApiBaseUrl => new Uri("https://es.pathofexile.com/api/trade/");
        public Uri PoeCdnBaseUrl => new Uri("https://web.poecdn.com/");
        public Uri PoeWebsite => new Uri("https://es.pathofexile.com/");
        public string RarityUnique => "Único";
        public string RarityRare => "Raro";
        public string RarityMagic => "Mágico";
        public string RarityNormal => "Normal";
        public string RarityCurrency => "Objetos Monetarios";
        public string RarityGem => "Gema";
        public string RarityDivinationCard => "Carta de Adivinación";
        public string DescriptionUnidentified => "Sin identificar";
        public string DescriptionQuality => "Calidad";
        public string DescriptionCorrupted => "Corrupto";
        public string DescriptionRarity => "Rareza";
        public string DescriptionSockets => "Engarces";
        public string DescriptionItemLevel => "Nivel de Objeto";
        public string DescriptionExperience => "Experiencia";
        public string DescriptionOrgan => "Usa";
        public string PrefixSuperior => "Superior";
        public string InfluenceShaper => "Creador";
        public string InfluenceElder => "Antiguo";
        public string InfluenceCrusader => "Cruzado";
        public string InfluenceHunter => "Cazador";
        public string InfluenceRedeemer => "Redentora";
        public string InfluenceWarlord => "Jefe de guerra";
        public string DescriptionMapTier => "Grado del Mapa";
        public string DescriptionItemQuantity => "Cantidad de Objetos";
        public string DescriptionItemRarity => "Rareza de Objetos";
        public string DescriptionMonsterPackSize => "Tamaño de Grupos de Monstruos";
        public string PrefixBlighted => "Infestado";
        public string KeywordProphecy => "profecía";
        public string KeywordVaal => "Vaal";
        public string KeywordCatalyst => "Catalizador";
        public string KeywordOil => "Aceite";
        public string KeywordIncubator => "Incubadora";
        public string KeywordScarab => "Escarabajo";
        public string KeywordResonator => "Resonador";
        public string KeywordFossil => "Fósil";
        public string KeywordVial => "Vial";
        public string KeywordEssence => "Esencia";

        public string DescriptionPhysicalDamage => "__TranslationRequired__";

        public string DescriptionElementalDamage => "__TranslationRequired__";

        public string DescriptionAttacksPerSecond => "__TranslationRequired__";

        public string DescriptionCriticalStrikeChance => "__TranslationRequired__";

        public string DescriptionEnergyShield => "__TranslationRequired__";

        public string DescriptionArmour => "__TranslationRequired__";

        public string DescriptionEvasion => "__TranslationRequired__";
        public string DescriptionChanceToBlock => "__TranslationRequired__";
        public string DescriptionLevel => "__TranslationRequired__";

        public string ModifierIncreased => "__TranslationRequired__";
        public string ModifierReduced => "__TranslationRequired__";
    }
}
