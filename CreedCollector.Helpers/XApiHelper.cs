using CreedCollector.Models.API.Xbox;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CreedCollector.Helpers
{
    // This class is used for getting information for xbox live user.
    // Some endpoints will not work unless authenticated through xbox, such as sending messages.
    // Some endpoints are not used but are placed here just in case of future implementation.
    public class XApiHelper
    {
        private static string BASE_URL = "https://xapi.us/v2";
        public const string HEADER_X_AUTH = "X-Auth";
        public const string HEADER_X_AUTH_VALUE = "b548f8131564ca0bdb21e39bc2efb8eb71a8411d";
        public const string HEADER_CONTENT_TYPE = "Content-Type";
        public const string HEADER_CONTENT_TYPE_VALUE = "application/json; charset=utf-8";

        public const string GAMERTAG = "ItzCorkyBreh";
        public const string XUID = "placeholder";
        public const string CLUB_ID = "placeholder";
        public const string TITLE_ID = "placeholder";
        public const string SEARCH_QUERY = "placeholder";
        public const string PRODUCT_ID = "placeholder";

        #region XboxOneTitleIds
        private static string assassinsCreedTheEzioCollectionXboxOneTitleId = "514291876";
        private static string assassinsCreedIIIRemasteredXboxOneTitleId = "859011533"; // This also has the Assassin's Creed III Liberation Achievements
        private static string assassinsCreedIVBlackFlagXboxOneTitleId = "556718860"; // This also contains Assassin's Creed Freedom Cry (DLC) Achievements
        private static string assassinsCreedRogueRemasteredXboxOneTitleId = "954605110";
        private static string assassinsCreedUnityXboxOneTitleId = "1998461943";
        private static string assassinsCreedChroniclesChinaXboxOneTitleId = "524641908";
        private static string assassinsCreedChroniclesRussiaXboxOneTitleId = "1445607414";
        private static string assassinsCreedChroniclesIndiaXboxOneTitleId = "132590840";
        private static string assassinsCreedSyndicateXboxOneTitleId = "1560034050";
        private static string assassinsCreedOriginsXboxOneTitleId = "502034863";
        private static string assassinsCreedOdysseyXboxOneTitleId = "964818375";
        #endregion

        private static string AssassinsCreedXbox360TitleId = "1431504955";

        #region EndPoints
        public const string ACCOUNT_PROFILE = "/profile"; // This is your profile information
        public const string ACCOUNT_XUID = "/accountXuid"; // This is your account XUID (Xbox Account User ID)
        public const string ACCOUNT_MESSAGES = "/messages"; // These are your message with full preview...
        public const string ACCOUNT_CONVERSATIONS = "/conversations"; // These are your conversations with full preview of the last message sent/recieved...
        private static string GAMERTAG_XUID = "/xuid/{0}"; // This is the XUID for a specified Gamertag (Xbox Account User ID) replace {0} with gamertag name
        private static string XUID_GAMERTAG = "/gamertag/{0}"; // This is the Gamertag for a specified XUID (Xbox Account User ID) replace {0} with XUID
        public const string NEW_PROFILE = "/{0}/new-profile"; // This is the NEW Profile endpoint for a specified XUID. This gives you the new unique gamertag information, etc... Replace {0} with XUID
        public const string GAMER_CARD = "/{0}/gamercard"; // This is the Gamercard information for a specified XUID, replace {0} with XUID
        public const string PRESENCE = "/{0}/presence"; // This is the current presence information for a specified XUID. Replace {0} with XUID
        public const string ACTIVITY = "/{0}/activity"; // This is the current activity information for a specified XUID. Replace {0} with XUID
        public const string RECENT_ACTIVITY = "/{0}/activity/recent"; // This is the recent activity information for a specified XUID. Replace {0} with XUID
        public const string FRIENDS = "/{0}/friends"; // This is the friends information for a specified XUID. Replace {0} with XUID
        public const string FOLLOWERS = "/{0}/followers"; // This is the followers information for a specified XUID. Replace {0} with XUID
        public const string RECENT_PLAYERS = "/recent-players"; // This is the accounts recent players information.
        public const string FRIENDS_PLAYING_SPECIFIED_GAME = "/{0}/friends-playing/{1}"; // This is the friends information for a specified XUID, playing a specified game. Replace {0} with XUID and {1} with Game TitleID
        public const string USERS_GAME_CLIPS = "/{0}/game-clips"; // This is the game clips for a specified XUID. Replace {0} with XUID.
        public const string USERS_SAVED_GAME_CLIPS = "/{0}/game-clips/saved"; // This is the saved game clips for a specified XUID. Replace {0} with XUID.
        public const string USERS_GAME_CLIPS_FOR_SPECIFIED_GAME = "/{0}/game-clips/{1}"; // This is the saved game clips for a specified XUID, and Game (titleId). Replace {0} with XUID and {1} with Game TitleID.
        public const string GAME_CLIPS_FOR_SPECIFIED_GAME = "/game-clips/{0}"; // This is the saved game clips for a specified Game {titleId}. Replace {0} with Game TitleID.
        public const string USERS_SCREENSHOTS = "/{0}/screenshots"; // This is the screenshots for a specified XUID. Replace {0} with XUID.
        public const string USERS_SCREENSHOTS_FOR_SPECIFIED_GAME = "/{0}/screenshots/{1}"; // This is the saved screenshots for a specified XUID, and Game {titleId}. Replace {0} with XUID and {1} with Game TitleID.
        public const string SCREENSHOTS_FOR_SPECIFIED_GAME = "/screenshots/{0}"; // This is the saved screenshots for a specified Game {titleId}. Replace {0} with Game TitleID.
        public const string GAME_STATS = "/{0}/game-stats/{1}"; // This is the game stats for a specified XUID, on a specified game. (i.e. Driver Level on Forza etc.). Replace {0} with XUID and {1} with Game TitleID.
        public const string XBOX_360_GAMES = "/{0}/xbox360games"; // This is the Xbox 360 Games List for a specified XUID. Replace {0} with XUID.
        public const string XBOX_ONE_GAMES = "/{0}/xboxonegames"; // This is the Xbox One Games List for a specified XUID. Replace {0} with XUID.
        private static string XBOX_GAME_ACHIEVEMENTS = "/{0}/achievements/{1}"; // This is the Xbox Games Achievements for a specified XUID. Replace {0} with XUID and {1} with Game TitleID.
        public const string XBOX_GAME_INFORMATION_GAME_ID_IN_HEX = "/game-details-hex/{0}"; // This is the Xbox Game Information (using the game id in hex format). Replace {0} with Game GameID.
        public const string XBOX_GAME_INFORMATION_PRODUCT_ID = "/game-details/{0}"; // This is the Xbox Game Information (using the product id). Replace {0} with ProductID.
        public const string XBOX_GAME_ADDON_DLC_INFORMATION = "/game-details/{0}/addons/1"; // This is the Xbox Game Information (using the product id). Replace {0} with ProductID.
        public const string XBOX_RELATED_GAME_INFORMATION = "/game-details/{0}/related"; // This is the Xbox Game Information (using the product id). Replace {0} with ProductID.
        public const string LATEST_XBOX_360_GAMES = "/latest-xbox360-games"; // This gets the latest Xbox 360 Games from the Xbox LIVE marketplace.
        public const string BROWSE_XBOX_360_MARKETPLACE = "/browse-marketplace/xbox360/1?sort=releaseDate"; // Browse the Xbox LIVE marketplace for Xbox 360 content.
        public const string ACTIVITY_FEED = "/activity-feed"; // Show your activity feed.
        public const string TITLEHUB_ACHIEVEMENTS_LIST = "/{0}/titlehub-achievement-list"; // Show your achievements list by game with friends who also play. (New TitleHub endpoint). Replace {0} with XUID.
        public const string CLUBS_I_OWN = "/clubs/owned"; // Show clubs that you are an owner of.
        public const string CLUBS_I_HAVE_JOINED = "/clubs/joined/{0}"; // Show clubs that you have joined - Note that the XUID is optional. Replace {0} with XUID.
        public const string CLUB_DETAILS = "/clubs/details/{0}"; // Show all information about a club. Replace {0} with club_id.
        public const string SEARCH_FOR_CLUB_BY_NAME = "/clubs/search/name/{0}"; // Search for clubs by name. Replace {0} with search_query.
        public const string SEARCH_FOR_CLUB_BY_TITLES = "/clubs/search/titles/{0}"; // Search for clubs by title id's (comma seperated for multiple). Replace {0} with search_query.
        public const string SEARCH_FOR_CLUB_BY_TAGS = "/clubs/search/tags/{0}"; // Search for clubs by tag's (comma seperated for multiple) - Note that not all tags are known. Replace {0} with search_query.
        public const string XBOX_SPONSORED_ACTIVITY_FEED = "/xbox-activity-feed"; // This is the Xbox sponsored activity feed.
        public const string ADD_FRIEND = "/{0}/add-as-friend"; // This XUID will be added as a friend (NOTE: This is a GET request, and will add djekl as a friend). Replace {0} with XUID.
        public const string ADD_FAVOURITE_FRIEND = "/{0}/add-as-favourite"; // This XUID will be added as a favourite (NOTE: This is a GET request, and will add djekl as a favourite). Replace {0} with XUID.
        public const string REMOVE_FRIEND = "/{0}/remove-friend"; // This XUID will be removed as a friend (NOTE: This is a DELETE request, and will remove djekl as a friend). Replace {0} with XUID.
        public const string PROFILE_TITLE_HISTORY = "/{0}/title-history"; // Use this endpoint with an XUID to find the title history of a user.
        public const string ALTERNATIVE_GAME_CLIPS = "/{0}/alternative-game-clips"; // This is a new endpoint for game clips, however the data structure is different, and can be used instead of the existing one. Replace {0} with XUID.
        public const string ALTERNATIVE_SCREENSHOTS = "/{0}/alternative-screenshots"; // This is a new endpoint for screenshots, however the data structure is different, and can be used instead of the existing one. Replace {0} with XUID.
        public const string NEW_MARKETPLACE_SEARCH = "/marketplace/search/{0}"; // Search the latest Xbox Marketplace. Replace {0} with search_query.
        public const string NEW_MARKETPLACE_SHOW_TITLE_ID = "/marketplace/show/{0}"; // Show product details from the latest Xbox Marketplace. It takes either a Title ID (integer), Legacy Xbox Product ID (looks like a UUID), or the new Big ID (9NBLGGH537BL). Replace {0} with ID.
        public const string NEW_MARKETPLACE_SHOW_LEGACY_PRODUCT_ID = "/marketplace/show/{0}"; // Show product details from the latest Xbox Marketplace. It takes either a Title ID (integer), Legacy Xbox Product ID (looks like a UUID), or the new Big ID (9NBLGGH537BL). Replace {0} with ID.
        public const string NEW_MARKETPLACE_SHOW_BIG_ID = "/marketplace/show/{0}"; // Show product details from the latest Xbox Marketplace. It takes either a Title ID (integer), Legacy Xbox Product ID (looks like a UUID), or the new Big ID (9NBLGGH537BL). Replace {0} with ID.
        public const string NEW_MARKETPLACE_GAMES_WITH_GOLD = "/marketplace/games-with-gold"; // Show the latest Games with Gold on the latest Xbox Marketplace.
        public const string NEW_MARKETPLACE_DEALS_WITH_GOLD = "/marketplace/deals-with-gold"; // Show the latest Deals With Gold on the latest Xbox Marketplace.
        public const string NEW_LATEST_GAMES_IN_THE_MARKETPLACE = "/marketplace/latest-games"; // Get the latest Games on the latest Xbox Marketplace.
        public const string NEW_FEATURED_GAMES_IN_THE_MARKETPLACE = "/marketplace/featured-games"; // Get the currently featured Games on the latest Xbox Marketplace.
        public const string NEW_GAMES_COMING_SOON_TO_THE_MARKETPLACE = "/marketplace/games-coming-soon"; // Get the Games that are coming soon to the latest Xbox Marketplace.
        public const string NEW_MOST_PLAYED_GAMES_IN_THE_MARKETPLACE = "/marketplace/most-played-games"; // Get the Most Played Games that are in the latest Xbox Marketplace.
        #endregion

        public static async Task<string> GetXboxXuid(string gamertag)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-Auth", "b548f8131564ca0bdb21e39bc2efb8eb71a8411d");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");

                var response = await client.GetAsync(BASE_URL + string.Format(GAMERTAG_XUID, gamertag));

                var responseString = await response.Content.ReadAsStringAsync();

                return responseString;
            }
        }

        public static async Task<List<XboxOneAchievement>> GetXboxOneAchievementsOfUser(string xuid)
        {
            List<XboxOneAchievement> xboxGameAchievements = new List<XboxOneAchievement>(); // List to be returned with all Deserialized objects in it.
            List<XboxOneAchievement> assassinsCreedTheEzioCollectionAchievements = new List<XboxOneAchievement>();
            List<XboxOneAchievement> assassinsCreedIIIRemasteredAchievements = new List<XboxOneAchievement>();
            List<XboxOneAchievement> assassinsCreedIVBlackFlagAchievements = new List<XboxOneAchievement>();
            List<XboxOneAchievement> assassinsCreedRogueAchievements = new List<XboxOneAchievement>();
            List<XboxOneAchievement> assassinsCreedUnityAchievments = new List<XboxOneAchievement>();
            List<XboxOneAchievement> assassinsCreedChroniclesChinaAchievements = new List<XboxOneAchievement>();
            List<XboxOneAchievement> assassinsCreedChroniclesRussiaAchievements = new List<XboxOneAchievement>();
            List<XboxOneAchievement> assassinsCreedChroniclesIndiaAchievements = new List<XboxOneAchievement>();
            List<XboxOneAchievement> assassinsCreedSyndicateAchievmenets = new List<XboxOneAchievement>();
            List<XboxOneAchievement> assassinsCreedOriginsAchievements = new List<XboxOneAchievement>();
            List<XboxOneAchievement> assassinsCreedOdysseyAchievements = new List<XboxOneAchievement>();

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-Auth", HEADER_X_AUTH_VALUE);
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");

                //var assassinsCreedTheEzioCollectionResponse = await client.GetAsync(BASE_URL + string.Format(XBOX_GAME_ACHIEVEMENTS, xuid, assassinsCreedTheEzioCollectionXboxOneTitleId));
                //var assassinsCreedIIIRemasteredResponse = await client.GetAsync(BASE_URL + string.Format(XBOX_GAME_ACHIEVEMENTS, xuid, assassinsCreedIIIRemasteredXboxOneTitleId));
                //var assassinsCreedIVBlackFlagResponse = await client.GetAsync(BASE_URL + string.Format(XBOX_GAME_ACHIEVEMENTS, xuid, assassinsCreedIVBlackFlagXboxOneTitleId));
                //var assassinsCreedRogueResponse = await client.GetAsync(BASE_URL + string.Format(XBOX_GAME_ACHIEVEMENTS, xuid, assassinsCreedRogueRemasteredXboxOneTitleId));
                //var assassinsCreedUnityResponse = await client.GetAsync(BASE_URL + string.Format(XBOX_GAME_ACHIEVEMENTS, xuid, assassinsCreedUnityXboxOneTitleId));
                //var assassinsCreedChroniclesChinaResponse = await client.GetAsync(BASE_URL + string.Format(XBOX_GAME_ACHIEVEMENTS, xuid, assassinsCreedChroniclesChinaXboxOneTitleId));
                //var assassinsCreedChroniclesRussiaResponse = await client.GetAsync(BASE_URL + string.Format(XBOX_GAME_ACHIEVEMENTS, xuid, assassinsCreedChroniclesRussiaXboxOneTitleId));
                //var assassinsCreedChroniclesIndiaResponse = await client.GetAsync(BASE_URL + string.Format(XBOX_GAME_ACHIEVEMENTS, xuid, assassinsCreedChroniclesIndiaXboxOneTitleId));
                //var assassinsCreedSyndicateResponse = await client.GetAsync(BASE_URL + string.Format(XBOX_GAME_ACHIEVEMENTS, xuid, assassinsCreedSyndicateXboxOneTitleId));
                var assassinsCreedOriginsResponse = await client.GetAsync(BASE_URL + string.Format(XBOX_GAME_ACHIEVEMENTS, xuid, assassinsCreedOriginsXboxOneTitleId));
                //var assassinsCreedOdysseyResponse = await client.GetAsync(BASE_URL + string.Format(XBOX_GAME_ACHIEVEMENTS, xuid, assassinsCreedOdysseyXboxOneTitleId));

                //var assassinsCreedTheEzioCollectionResponseString = await assassinsCreedTheEzioCollectionResponse.Content.ReadAsStringAsync();
                //var assassinsCreedIIIRemasteredResponseString = await assassinsCreedIIIRemasteredResponse.Content.ReadAsStringAsync();
                //var assassinsCreedIVBlackFlagResponseString = await assassinsCreedIVBlackFlagResponse.Content.ReadAsStringAsync();
                //var assassinsCreedRogueResponseString = await assassinsCreedRogueResponse.Content.ReadAsStringAsync();
                //var assassinsCreedUnityResponseString = await assassinsCreedUnityResponse.Content.ReadAsStringAsync();
                //var assassinsCreedChroniclesChinaResponseString = await assassinsCreedChroniclesChinaResponse.Content.ReadAsStringAsync();
                //var assassinsCreedChroniclesRussiaResponseString = await assassinsCreedChroniclesRussiaResponse.Content.ReadAsStringAsync();
                //var assassinsCreedChroniclesIndiaResponseString = await assassinsCreedChroniclesIndiaResponse.Content.ReadAsStringAsync();
                //var assassinsCreedSyndicateResponseString = await assassinsCreedSyndicateResponse.Content.ReadAsStringAsync();
                var assassinsCreedOriginsResponseString = await assassinsCreedOriginsResponse.Content.ReadAsStringAsync();
                //var assassinsCreedOdysseyResponseString = await assassinsCreedOdysseyResponse.Content.ReadAsStringAsync();

                //assassinsCreedTheEzioCollectionAchievements = JsonConvert.DeserializeObject<List<XboxOneAchievement>>(assassinsCreedTheEzioCollectionResponseString);
                //assassinsCreedIIIRemasteredAchievements = JsonConvert.DeserializeObject<List<XboxOneAchievement>>(assassinsCreedIIIRemasteredResponseString);
                //assassinsCreedIVBlackFlagAchievements = JsonConvert.DeserializeObject<List<XboxOneAchievement>>(assassinsCreedIVBlackFlagResponseString);
                //assassinsCreedRogueAchievements = JsonConvert.DeserializeObject<List<XboxOneAchievement>>(assassinsCreedRogueResponseString);
                //assassinsCreedUnityAchievments = JsonConvert.DeserializeObject<List<XboxOneAchievement>>(assassinsCreedUnityResponseString);
                //assassinsCreedChroniclesChinaAchievements = JsonConvert.DeserializeObject<List<XboxOneAchievement>>(assassinsCreedChroniclesChinaResponseString);
                //assassinsCreedChroniclesRussiaAchievements = JsonConvert.DeserializeObject<List<XboxOneAchievement>>(assassinsCreedChroniclesRussiaResponseString);
                //assassinsCreedChroniclesIndiaAchievements = JsonConvert.DeserializeObject<List<XboxOneAchievement>>(assassinsCreedChroniclesIndiaResponseString);
                //assassinsCreedSyndicateAchievmenets = JsonConvert.DeserializeObject<List<XboxOneAchievement>>(assassinsCreedSyndicateResponseString);
                assassinsCreedOriginsAchievements = JsonConvert.DeserializeObject<List<XboxOneAchievement>>(assassinsCreedOriginsResponseString);
                //assassinsCreedOdysseyAchievements = JsonConvert.DeserializeObject<List<XboxOneAchievement>>(assassinsCreedOdysseyResponseString);
            }

            //xboxGameAchievements.AddRange(assassinsCreedTheEzioCollectionAchievements);
            //xboxGameAchievements.AddRange(assassinsCreedIIIRemasteredAchievements);
            //xboxGameAchievements.AddRange(assassinsCreedIVBlackFlagAchievements);
            //xboxGameAchievements.AddRange(assassinsCreedRogueAchievements);
            //xboxGameAchievements.AddRange(assassinsCreedUnityAchievments);
            //xboxGameAchievements.AddRange(assassinsCreedChroniclesChinaAchievements);
            //xboxGameAchievements.AddRange(assassinsCreedChroniclesRussiaAchievements);
            //xboxGameAchievements.AddRange(assassinsCreedChroniclesIndiaAchievements);
            //xboxGameAchievements.AddRange(assassinsCreedSyndicateAchievmenets);
            xboxGameAchievements.AddRange(assassinsCreedOriginsAchievements);
            //xboxGameAchievements.AddRange(assassinsCreedOdysseyAchievements);

            return xboxGameAchievements;
        }
    }
}
