using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Daft.Services.Daft.Listing.Models
{
    public class PagingRequest
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("pageSize")]
        public string PageSize { get; set; }
    }

    public class PagingResponse
    {
        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("currentPage")]
        public int CurrentPage { get; set; }

        [JsonProperty("nextFrom")]
        public int NextFrom { get; set; }

        [JsonProperty("previousFrom")]
        public int PreviousFrom { get; set; }

        [JsonProperty("displayingFrom")]
        public int DisplayingFrom { get; set; }

        [JsonProperty("displayingTo")]
        public int DisplayingTo { get; set; }

        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }
    }
}
