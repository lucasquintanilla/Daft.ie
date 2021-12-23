using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Daft.Services.Daft.Listing.Models
{
    public class Filter
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("values")]
        public List<string> Values { get; set; }
    }

    public class Ranx
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GeoFilter
    {
        [JsonProperty("storedShapeIds")]
        public List<string> StoredShapeIds { get; set; }

        [JsonProperty("geoSearchType")]
        public string GeoSearchType { get; set; }
    }

    public class ListingRequest
    {
        [JsonProperty("section")]
        public string Section { get; set; }

        [JsonProperty("filters")]
        public List<Filter> Filters { get; set; } = new List<Filter>();

        [JsonProperty("andFilters")]
        public List<object> AndFilters { get; set; }

        [JsonProperty("ranges")]
        public List<Ranx> Ranges { get; set; }

        [JsonProperty("paging")]
        public PagingRequest Paging { get; set; }

        [JsonProperty("geoFilter")]
        public GeoFilter GeoFilter { get; set; }

        [JsonProperty("terms")]
        public string Terms { get; set; }

        [JsonProperty("sort")]
        public string Sort { get; set; }
    }
}
