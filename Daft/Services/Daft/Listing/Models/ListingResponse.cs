using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Daft.Services.Daft.Listing.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Seller
    {
        [JsonProperty("sellerId")]
        public int SellerId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sellerType")]
        public string SellerType { get; set; }

        [JsonProperty("showContactForm")]
        public bool ShowContactForm { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("phoneWhenToCall")]
        public string PhoneWhenToCall { get; set; }
    }

    public class Image
    {
        [JsonProperty("size720x480")]
        public string Size720x480 { get; set; }

        [JsonProperty("size600x600")]
        public string Size600x600 { get; set; }

        [JsonProperty("size400x300")]
        public string Size400x300 { get; set; }

        [JsonProperty("size360x240")]
        public string Size360x240 { get; set; }

        [JsonProperty("size300x200")]
        public string Size300x200 { get; set; }

        [JsonProperty("size320x280")]
        public string Size320x280 { get; set; }

        [JsonProperty("size72x52")]
        public string Size72x52 { get; set; }

        [JsonProperty("size680x392")]
        public string Size680x392 { get; set; }
    }

    public class Media
    {
        [JsonProperty("images")]
        public List<Image> Images { get; set; }

        [JsonProperty("totalImages")]
        public int TotalImages { get; set; }

        [JsonProperty("hasVideo")]
        public bool HasVideo { get; set; }

        [JsonProperty("hasVirtualTour")]
        public bool HasVirtualTour { get; set; }

        [JsonProperty("hasBrochure")]
        public bool HasBrochure { get; set; }
    }

    public class Ber
    {
        [JsonProperty("rating")]
        public string Rating { get; set; }
    }

    public class Point
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("coordinates")]
        public List<double> Coordinates { get; set; }
    }

    public class Listing
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("seoTitle")]
        public string SeoTitle { get; set; }

        [JsonProperty("sections")]
        public List<string> Sections { get; set; }

        [JsonProperty("saleType")]
        public List<string> SaleType { get; set; }

        [JsonProperty("featuredLevel")]
        public string FeaturedLevel { get; set; }

        [JsonProperty("publishDate")]
        public object PublishDate { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("abbreviatedPrice")]
        public string AbbreviatedPrice { get; set; }

        [JsonProperty("numBedrooms")]
        public string NumBedrooms { get; set; }

        [JsonProperty("propertyType")]
        public string PropertyType { get; set; }

        [JsonProperty("daftShortcode")]
        public string DaftShortcode { get; set; }

        [JsonProperty("seller")]
        public Seller Seller { get; set; }

        [JsonProperty("media")]
        public Media Media { get; set; }

        [JsonProperty("ber")]
        public Ber Ber { get; set; }

        [JsonProperty("point")]
        public Point Point { get; set; }

        [JsonProperty("seoFriendlyPath")]
        public string SeoFriendlyPath { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("premierPartner")]
        public bool PremierPartner { get; set; }
    }

    public class Listings
    {
        [JsonProperty("listing")]
        public Listing Listing { get; set; }

        [JsonProperty("savedAd")]
        public bool SavedAd { get; set; }
    }

    public class DfpTargetingValues
    {
        [JsonProperty("pageType")]
        public List<string> PageType { get; set; }

        [JsonProperty("cityName")]
        public List<string> CityName { get; set; }

        [JsonProperty("searchPageNo")]
        public List<string> SearchPageNo { get; set; }

        [JsonProperty("areaName")]
        public List<string> AreaName { get; set; }

        [JsonProperty("adState")]
        public List<string> AdState { get; set; }

        [JsonProperty("distilledBrand")]
        public List<string> DistilledBrand { get; set; }

        [JsonProperty("section")]
        public List<string> Section { get; set; }

        [JsonProperty("firstPublishDateTo")]
        public List<string> FirstPublishDateTo { get; set; }

        [JsonProperty("firstPublishDateFrom")]
        public List<string> FirstPublishDateFrom { get; set; }

        [JsonProperty("countyName")]
        public List<string> CountyName { get; set; }

        [JsonProperty("user_id")]
        public List<string> UserId { get; set; }

        [JsonProperty("isUserLoggedIn")]
        public List<string> IsUserLoggedIn { get; set; }
    }

    public class Breadcrumb
    {
        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ListingResponse
    {
        [JsonProperty("listings")]
        public List<Listings> Listings { get; set; }

        [JsonProperty("showcaseListings")]
        public List<object> ShowcaseListings { get; set; }

        [JsonProperty("paging")]
        public PagingResponse Paging { get; set; }

        [JsonProperty("dfpTargetingValues")]
        public DfpTargetingValues DfpTargetingValues { get; set; }

        [JsonProperty("breadcrumbs")]
        public List<Breadcrumb> Breadcrumbs { get; set; }

        [JsonProperty("canonicalUrl")]
        public string CanonicalUrl { get; set; }

        [JsonProperty("mapView")]
        public bool MapView { get; set; }

        [JsonProperty("savedSearch")]
        public bool SavedSearch { get; set; }
    }




}
