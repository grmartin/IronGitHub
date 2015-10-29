using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronGitHub.Entities;

namespace IronGitHub.Apis
{
    internal class ReleasesApi : GitHubApiBase
    {

        public ReleasesApi(GitHubApiContext context) : base(context)
        {
        }

        public async Task<ReleaseResponse> CreateRelease(string owner, string repo, Release release)
        {
            var request = CreateRequest($"/repos/{owner}/{repo}/releases");

            var post = await PostAsJson<Release, ReleaseResponse>(request, release);

            return post.Result;
        }

        public async Task<ReleaseResponse> EditRelease(string owner, string repo, int id, Release newRelease)
        {
            var request = CreateRequest($"/repos/{owner}/{repo}/releases/{id}");

            var post = await Patch<Release, ReleaseResponse>(request, newRelease);

            return post.Result;
        }

        public async Task<ReleaseAsset> UploadReleaseAsset(string owner, string repo, ReleaseResponse response, ReleaseAssetBase assetMeta, byte[] data)
        {
            var assetParams = new Dictionary<string, string>(2) {{"name", assetMeta.Name}};

            if (!string.IsNullOrWhiteSpace(assetMeta.Label)) assetParams["label"] = assetMeta.Label;

            var request = CreateRequest(response.UploadURL, $"/repos/{owner}/{repo}/releases/{response.ID}/assets", assetParams);

            var post = await PostAsBinaryForJson<ReleaseAsset>(request, assetMeta.ContentType, data);

            return post.Result;
        }
    }
}
