using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using System.Windows.Forms;


namespace test
{
    public partial class HomeScreen
    {
        internal class Search
        {

            public async Task Run(string newText, TextBox searchBox, RichTextBox chatField)
            {
                var youtubeService = new YouTubeService(new BaseClientService.Initializer()
                {
                    //API Key
                    ApiKey = "",
                    ApplicationName = this.GetType().ToString()
                });

                var searchListRequest = youtubeService.Search.List("snippet");
                searchListRequest.Q = searchBox.Text;   //YT Search Keyword from search box
                searchListRequest.MaxResults = 1;   //Num results
                
                var searchListResponse = await searchListRequest.ExecuteAsync();

                //List of video results
                List<string> videos = new List<string>();

                foreach (var searchResult in searchListResponse.Items)
                {
                    switch (searchResult.Id.Kind)
                    {
                        case "youtube#video":
                            videos.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.VideoId));
                            break;
                    }

                    string newSearchTerm = String.Format("This is what we found:\n{0}\n", string.Join("\n", videos));
                    string hyperlink = searchResult.Id.VideoId;

                    //References method back in HomeScreen.cs to output results
                    updatedChat(newSearchTerm,chatField,hyperlink);
                }
            }
        }
    }
}

