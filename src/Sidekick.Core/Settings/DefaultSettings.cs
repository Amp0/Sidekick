using System.Collections.Generic;

namespace Sidekick.Core.Settings
{
    public static class DefaultSettings
    {
        public static SidekickSettings CreateDefault()
        {
            return new SidekickSettings()
            {
                Language_UI = "en",
                Language_Parser = "English",
                LeagueId = string.Empty,
                League_SelectedTabIndex = 0,
                LeaguesHash = string.Empty,
                Character_Name = string.Empty,
                Wiki_Preferred = WikiSetting.PoeWiki,
                RetainClipboard = true,
                CloseOverlayWithMouse = true,
                EnableCtrlScroll = true,
                EnablePricePrediction = true,
                Modifiers = new List<string>(),
                Key_CloseWindow = "Space",
                Key_CheckPrices = "Ctrl+D",
                Key_Exit = "Ctrl+Shift+X",
                Key_FindItems = "Ctrl+F",
                Key_GoToHideout = "F5",
                Key_LeaveParty = "F4",
                Key_OpenSearch = "Alt+Q",
                Key_OpenLeagueOverview = "F6",
                Key_OpenWiki = "Alt+W",
                Key_ReplyToLatestWhisper = "Ctrl+Shift+R",
                Key_AdvancedSearch = "Alt+D",
                Key_Stash_Left = string.Empty,
                Key_Stash_Right = string.Empty,
                ShowSplashScreen = true
            };
        }

        public static SidekickSettings Settings = CreateDefault();
    }
}
