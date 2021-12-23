using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Daft.Services.Daft.Property.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class DaftCookies
    {
    }

    public class Seller
    {
        [JsonProperty("sellerId")]
        public int SellerId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("alternativePhone")]
        public string AlternativePhone { get; set; }

        [JsonProperty("sellerType")]
        public string SellerType { get; set; }

        [JsonProperty("showContactForm")]
        public bool ShowContactForm { get; set; }

        [JsonProperty("phoneWhenToCall")]
        public string PhoneWhenToCall { get; set; }

        [JsonProperty("branch")]
        public string Branch { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("licenceNumber")]
        public string LicenceNumber { get; set; }
    }

    public class Image
    {
        [JsonProperty("size1440x960")]
        public string Size1440x960 { get; set; }

        [JsonProperty("size1200x1200")]
        public string Size1200x1200 { get; set; }

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

    public class Facility
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PropertyOverview
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class NonFormatted
    {
        [JsonProperty("beds")]
        public int Beds { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }

        [JsonProperty("section")]
        public string Section { get; set; }
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

        [JsonProperty("featuredLevel")]
        public string FeaturedLevel { get; set; }

        [JsonProperty("lastUpdateDate")]
        public string LastUpdateDate { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("numBedrooms")]
        public string NumBedrooms { get; set; }

        [JsonProperty("bathroomType")]
        public string BathroomType { get; set; }

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

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("primaryAreaId")]
        public int PrimaryAreaId { get; set; }

        [JsonProperty("facilities")]
        public List<Facility> Facilities { get; set; }

        [JsonProperty("propertyOverview")]
        public List<PropertyOverview> PropertyOverview { get; set; }

        [JsonProperty("nonFormatted")]
        public NonFormatted NonFormatted { get; set; }
    }

    public class VisibleRelevantAd
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

    public class HiddentRelevantAd
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

    public class DfpTargetingValues
    {
        [JsonProperty("section")]
        public List<string> Section { get; set; }

        [JsonProperty("ber")]
        public List<string> Ber { get; set; }

        [JsonProperty("advertisingType")]
        public List<string> AdvertisingType { get; set; }

        [JsonProperty("adId")]
        public List<string> AdId { get; set; }

        [JsonProperty("pageType")]
        public List<string> PageType { get; set; }

        [JsonProperty("cityName")]
        public List<string> CityName { get; set; }

        [JsonProperty("areaName")]
        public List<string> AreaName { get; set; }

        [JsonProperty("videoShown")]
        public List<string> VideoShown { get; set; }

        [JsonProperty("price")]
        public List<string> Price { get; set; }

        [JsonProperty("propertyType")]
        public List<string> PropertyType { get; set; }

        [JsonProperty("distilledBrand")]
        public List<string> DistilledBrand { get; set; }

        [JsonProperty("priceBracket")]
        public List<string> PriceBracket { get; set; }

        [JsonProperty("sellerType")]
        public List<string> SellerType { get; set; }

        [JsonProperty("beds")]
        public List<string> Beds { get; set; }

        [JsonProperty("countyName")]
        public List<string> CountyName { get; set; }

        [JsonProperty("vrShown")]
        public List<string> VrShown { get; set; }

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

    public class PageProps
    {
        [JsonProperty("daftCookies")]
        public DaftCookies DaftCookies { get; set; }

        [JsonProperty("listing")]
        public Listing Listing { get; set; }

        [JsonProperty("listingViews")]
        public int ListingViews { get; set; }

        [JsonProperty("visibleRelevantAds")]
        public List<VisibleRelevantAd> VisibleRelevantAds { get; set; }

        [JsonProperty("hiddentRelevantAds")]
        public List<HiddentRelevantAd> HiddentRelevantAds { get; set; }

        [JsonProperty("pageVariant")]
        public string PageVariant { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("dfpTargetingValues")]
        public DfpTargetingValues DfpTargetingValues { get; set; }

        [JsonProperty("breadcrumbs")]
        public List<Breadcrumb> Breadcrumbs { get; set; }

        [JsonProperty("savedAd")]
        public bool SavedAd { get; set; }

        [JsonProperty("canonicalUrl")]
        public string CanonicalUrl { get; set; }

        [JsonProperty("shouldIndexPage")]
        public bool ShouldIndexPage { get; set; }
    }

    public class PropertyResponse
    {
        [JsonProperty("pageProps")]
        public PageProps PageProps { get; set; }

        [JsonProperty("__N_SSP")]
        public bool NSSP { get; set; }
    }


}
