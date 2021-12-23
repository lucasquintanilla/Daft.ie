using Newtonsoft.Json;

namespace Daft.Services.Daft.Auth.Models
{
    public class ContactInfo
    {
        [JsonProperty("phoneInfo")]
        public string PhoneInfo { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("altEmail")]
        public string AltEmail { get; set; }
    }

    public class Consent
    {
        [JsonProperty("termsOfUseAccepted")]
        public bool TermsOfUseAccepted { get; set; }

        [JsonProperty("receiveEmailAccepted")]
        public bool ReceiveEmailAccepted { get; set; }

        [JsonProperty("receiveNotificationAccepted")]
        public bool ReceiveNotificationAccepted { get; set; }
    }

    public class UserDetails
    {
        [JsonProperty("userId")]
        public int UserId { get; set; }

        [JsonProperty("legacyId")]
        public int LegacyId { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("createdAt")]
        public long CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public long UpdatedAt { get; set; }

        [JsonProperty("contactInfo")]
        public ContactInfo ContactInfo { get; set; }

        [JsonProperty("consent")]
        public Consent Consent { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }
    }

    public class AuthResponse
    {
        [JsonProperty("sub")]
        public string Sub { get; set; }

        [JsonProperty("email_verified")]
        public bool EmailVerified { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("user_details")]
        public UserDetails UserDetails { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("preferred_username")]
        public string PreferredUsername { get; set; }

        [JsonProperty("given_name")]
        public string GivenName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("expires_at")]
        public int ExpiresAt { get; set; }

        [JsonProperty("id_token")]
        public string IdToken { get; set; }
    }


}
