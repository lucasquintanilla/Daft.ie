using Daft.Services.Daft;
using Daft.Services.Daft.Listing.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Daft
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var daft = new DaftService();

            await daft.Auth();
            var listing = await daft.GetListing(new ListingRequest()
            {
                Section = "sharing",
                Filters = new List<Filter>{ new Filter() {
                    Name = "adState",
                    Values = new List<string>() { "published" }
                }},
                Ranges = new List<Ranx>()
                {
                    new Ranx()
                    {
                        From = "now-1d/d",
                        To = null,
                        Name = "firstPublishDate"
                    }
                },
                Paging = new PagingRequest()
                {
                    From = "0",
                    PageSize = "20"
                },
                GeoFilter = new GeoFilter()
                {
                    GeoSearchType = "STORED_SHAPES",
                    StoredShapeIds = new List<string> { "66"} // 66 = Dublin 2, 68 = Dublin 4
                    //StoredShapeIds = new List<string> { "66", "68"} // 66 = Dublin 2, 68 = Dublin 4
                },
                Sort = "priceAsc"
            });

            if (!listing.Listings.Any())
            {
                Console.WriteLine("We didn't find any properties");
                return;
            }

            foreach (var item in listing.Listings)
            {
                Console.WriteLine(item.Listing.AbbreviatedPrice);

                var property = await daft.GetProperty(item.Listing.Id);
                Console.WriteLine(JsonConvert.SerializeObject(property));

            }

            
        }
    }
}
