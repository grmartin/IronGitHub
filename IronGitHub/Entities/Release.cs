using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

#pragma warning disable 1591

namespace IronGitHub.Entities
{
    [DataContract]
    public class Release
    {
        [DataMember(Name = "tag_name")]
        public string TagName { get; set; }

        [DataMember(Name = "target_commitish")]
        public string TargetCommitish { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "body")]
        public string Body { get; set; }

        [DataMember(Name = "draft")]
        public bool Draft { get; set; }

        [DataMember(Name = "prerelease")]
        public bool Prelease { get; set; }
    }



    [DataContract]
    public class ReleaseResponse : Release
    {
        [DataMember(Name = "url")]
        public string URL { get; set; }

        [DataMember(Name = "html_url")]
        public string HTMLURL { get; set; }

        [DataMember(Name = "assets_url")]
        public string AssetsURL { get; set; }

        [DataMember(Name = "upload_url")]
        public string UploadURL { get; set; }

        [DataMember(Name = "tarball_url")]
        public string TarBallURL { get; set; }

        [DataMember(Name = "zipball_url")]
        public string ZipBallURL { get; set; }

        [DataMember(Name = "id")]
        public int ID { get; set; }

        [DataMember(Name = "created_at")]
        public DateTime CreatedAt { get; set; }

        [DataMember(Name = "published_at")]
        public DateTime PublishedAt { get; set; }

        [DataMember(Name = "author")]
        public ReleaseAuthor Author { get; set; }

        [DataMember(Name = "assets")]
        public List<ReleaseAsset> Assets { get; set; }
    }

    [DataContract]
    public class ReleaseAuthor
    {
        [DataMember(Name = "login")]
        public string Login { get; set; }

        [DataMember(Name = "id")]
        public string ID { get; set; }

        [DataMember(Name = "avatar_url")]
        public string AvatarURL { get; set; }

        [DataMember(Name = "gravatar_id")]
        public string GravatarID { get; set; }

        [DataMember(Name = "url")]
        public string URL { get; set; }

        [DataMember(Name = "html_url")]
        public string HTMLURL { get; set; }

        [DataMember(Name = "followers_url")]
        public string FollowersURL { get; set; }

        [DataMember(Name = "following_url")]
        public string FollowingURL { get; set; }

        [DataMember(Name = "gists_url")]
        public string GistsURL { get; set; }

        [DataMember(Name = "starred_url")]
        public string StarredURL { get; set; }

        [DataMember(Name = "subscriptions_url")]
        public string SubscriptionsURL { get; set; }

        [DataMember(Name = "organizations_url")]
        public string OrganizationsURL { get; set; }

        [DataMember(Name = "repos_url")]
        public string ReposURL { get; set; }

        [DataMember(Name = "events_url")]
        public string EventsURL { get; set; }

        [DataMember(Name = "received_events_url")]
        public string ReceivedEventsURL { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "site_admin")]
        public bool SiteAdmin { get; set; }
    }

    [DataContract]
    public class ReleaseAssetBase
    {

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "label")]
        public string Label { get; set; }
        
        [DataMember(Name = "content_type")]
        public string ContentType { get; set; }
    }

    [DataContract]
    public class ReleaseAsset : ReleaseAssetBase
    {
        [DataMember(Name = "url")]
        public string URL { get; set; }

        [DataMember(Name = "browser_download_url")]
        public string BrowserDownloadURL { get; set; }

        [DataMember(Name = "id")]
        public int ID { get; set; }

        [DataMember(Name = "state")]
        public string State { get; set; }

        [DataMember(Name = "size")]
        public int Size { get; set; }

        [DataMember(Name = "download_count")]
        public int DownloadCount { get; set; }

        [DataMember(Name = "created_at")]
        public DateTime CreatedAt { get; set; }

        [DataMember(Name = "updated_at")]
        public DateTime UpdatedAt { get; set; }

        [DataMember(Name = "uploader")]
        public ReleaseAuthor Uploader { get; set; }
    }
}
