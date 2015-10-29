using System;
using System.Runtime.Serialization;

#pragma warning disable 1591

namespace IronGitHub.Entities
{

    public enum TagType
    {
        [EnumMember(Value = "commit")]
        Commit,
        [EnumMember(Value = "tree")]
        Tree,
        [EnumMember(Value = "blob")]
        Blob
    }

    [DataContract]
    public class TagBase
    {
        [DataMember(Name = "tag")]
        public string TagName { get; set; }
        [DataMember(Name = "message")]
        public string Message { get; set; }

        [DataMember(Name = "tagger")]
        public Tagger Tagger { get; set; }
    }

    [DataContract]
    public class TagResponse : TagBase
    {
        [DataMember(Name = "sha")]
        public string SHA { get; set; }

        [DataMember(Name = "url")]
        public string URL { get; set; }

        [DataMember(Name = "object")]
        public TagObject TaggedObject { get; set; }
    }

    [DataContract]
    public class Tagger
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "date")]
        public DateTime Date { get; set; }
    }

    [DataContract]
    public class TagObject
    {
        [DataMember(Name = "type")]
        public TagType Type { get; set; }

        [DataMember(Name = "sha")]
        public string SHA { get; set; }

        [DataMember(Name = "url")]
        public string URL { get; set; }
    }

    [DataContract]
    public class TagCreation : TagBase
    {
        [DataMember(Name = "object")]
        public string Object{ get; set; }

        [DataMember(Name = "type")]
        public TagType Type { get; set; }
    }
}
