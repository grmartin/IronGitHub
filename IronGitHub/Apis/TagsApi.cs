using System.Threading.Tasks;
using IronGitHub.Entities;

namespace IronGitHub.Apis
{
    public class TagsApi : GitHubApiBase
    {
        public TagsApi(GitHubApiContext context) : base(context)
        {
        }

        async public Task<TagResponse> Get(string owner, string repo, string sha)
        {
            var request = CreateRequest($"/repos/{owner}/{repo}/git/tags/{sha}");

            var response = await Complete<TagResponse>(request);

            return response.Result;
        }
        
        async public Task<TagResponse> CreateTag(string owner, string repo, TagCreation tagMetaData)
        {
            var request = CreateRequest($"/repos/{owner}/{repo}/git/tags");

            var post = await PostAsJson<TagCreation, TagResponse>(request, tagMetaData);

            return post.Result;
        }
   }
}
