using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Mod
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("game_id")]
        public long GameId { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("visible")]
        public long Visible { get; set; }

        [JsonProperty("submitted_by")]
        public SubmittedBy SubmittedBy { get; set; }

        [JsonProperty("date_added")]
        public long DateAdded { get; set; }

        [JsonProperty("date_updated")]
        public long DateUpdated { get; set; }

        [JsonProperty("date_live")]
        public long DateLive { get; set; }

        [JsonProperty("maturity_option")]
        public long MaturityOption { get; set; }

        [JsonProperty("logo")]
        public Logo Logo { get; set; }

        [JsonProperty("homepage_url")]
        public object HomepageUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("name_id")]
        public string NameId { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("description_plaintext")]
        public string DescriptionPlaintext { get; set; }

        [JsonProperty("metadata_blob")]
        public object MetadataBlob { get; set; }

        [JsonProperty("profile_url")]
        public Uri ProfileUrl { get; set; }

        [JsonProperty("media")]
        public Media Media { get; set; }

        [JsonProperty("modfile")]
        public Modfile Modfile { get; set; }

        [JsonProperty("metadata_kvp")]
        public object[] MetadataKvp { get; set; }

        [JsonProperty("tags")]
        public Tag[] Tags { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        public static Mod getByName(List<Mod> mods, string name)
        {
            foreach(Mod mod in mods)
            {
                if (mod.Name == name)
                {
                    return mod;
                }
            }

            return new Mod();
        }
    }

    public partial class Logo
    {
        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("original")]
        public Uri Original { get; set; }

        [JsonProperty("thumb_320x180")]
        public Uri Thumb320X180 { get; set; }

        [JsonProperty("thumb_640x360")]
        public Uri Thumb640X360 { get; set; }

        [JsonProperty("thumb_1280x720")]
        public Uri Thumb1280X720 { get; set; }
    }

    public partial class Media
    {
        [JsonProperty("youtube")]
        public object[] Youtube { get; set; }

        [JsonProperty("sketchfab")]
        public object[] Sketchfab { get; set; }

        [JsonProperty("images")]
        public Image[] Images { get; set; }
    }

    public partial class Image
    {
        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("original")]
        public Uri Original { get; set; }

        [JsonProperty("thumb_320x180")]
        public Uri Thumb320X180 { get; set; }
    }

    public partial class Modfile
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("mod_id")]
        public long ModId { get; set; }

        [JsonProperty("date_added")]
        public long DateAdded { get; set; }

        [JsonProperty("date_scanned")]
        public long DateScanned { get; set; }

        [JsonProperty("virus_status")]
        public long VirusStatus { get; set; }

        [JsonProperty("virus_positive")]
        public long VirusPositive { get; set; }

        [JsonProperty("virustotal_hash")]
        public object VirustotalHash { get; set; }

        [JsonProperty("filesize")]
        public long Filesize { get; set; }

        [JsonProperty("filehash")]
        public Filehash Filehash { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("changelog")]
        public object Changelog { get; set; }

        [JsonProperty("metadata_blob")]
        public object MetadataBlob { get; set; }

        [JsonProperty("download")]
        public Download Download { get; set; }
    }

    public partial class Download
    {
        [JsonProperty("binary_url")]
        public Uri BinaryUrl { get; set; }

        [JsonProperty("date_expires")]
        public long DateExpires { get; set; }
    }

    public partial class Filehash
    {
        [JsonProperty("md5")]
        public string Md5 { get; set; }
    }

    public partial class Stats
    {
        [JsonProperty("mod_id")]
        public long ModId { get; set; }

        [JsonProperty("popularity_rank_position")]
        public long PopularityRankPosition { get; set; }

        [JsonProperty("popularity_rank_total_mods")]
        public long PopularityRankTotalMods { get; set; }

        [JsonProperty("downloads_total")]
        public long DownloadsTotal { get; set; }

        [JsonProperty("subscribers_total")]
        public long SubscribersTotal { get; set; }

        [JsonProperty("ratings_total")]
        public long RatingsTotal { get; set; }

        [JsonProperty("ratings_positive")]
        public long RatingsPositive { get; set; }

        [JsonProperty("ratings_negative")]
        public long RatingsNegative { get; set; }

        [JsonProperty("ratings_percentage_positive")]
        public long RatingsPercentagePositive { get; set; }

        [JsonProperty("ratings_weighted_aggregate")]
        public double RatingsWeightedAggregate { get; set; }

        [JsonProperty("ratings_display_text")]
        public string RatingsDisplayText { get; set; }

        [JsonProperty("date_expires")]
        public long DateExpires { get; set; }
    }

    public partial class SubmittedBy
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name_id")]
        public string NameId { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("date_online")]
        public long DateOnline { get; set; }

        [JsonProperty("avatar")]
        public Avatar Avatar { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("profile_url")]
        public Uri ProfileUrl { get; set; }
    }

    public partial class Avatar
    {
        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("original")]
        public Uri Original { get; set; }

        [JsonProperty("thumb_50x50")]
        public Uri Thumb50X50 { get; set; }

        [JsonProperty("thumb_100x100")]
        public Uri Thumb100X100 { get; set; }
    }

    public partial class Tag
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date_added")]
        public long DateAdded { get; set; }
    }
}
