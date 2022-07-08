﻿using MediaBrowser.Controller.Entities.TV;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Model.Entities;

namespace Emby.Plugins.AniList
{
    public class AniListExternalId : IExternalId
    {
        public bool Supports(IHasProviderIds item)
        {
            return item is Series;
        }

        public string Name
        {
            get { return "AniList"; }
        }

        public string Key
        {
            get { return ProviderNames.AniList; }
        }

        public string UrlFormatString
        {
            get { return "http://anilist.co/anime/{0}/"; }
        }
    }
}