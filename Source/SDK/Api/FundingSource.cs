//==============================================================================
//
//  This file was auto-generated by a tool using the PayPal REST API schema.
//  More information: https://developer.paypal.com/docs/api/
//
//==============================================================================
using Newtonsoft.Json;

namespace PayPal.Api
{
    /// <summary>
    /// specifies the funding source details.
    /// <para>
    /// See <a href="https://developer.paypal.com/docs/api/">PayPal Developer documentation</a> for more information.
    /// </para>
    /// </summary>
    public class FundingSource : PayPalRelationalObject
    {
        /// <summary>
        /// specifies funding mode of the instrument
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "funding_mode")]
        public string funding_mode { get; set; }

        /// <summary>
        /// Instrument type for this funding source
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "funding_instrument_type")]
        public string funding_instrument_type { get; set; }

        /// <summary>
        /// Soft descriptor used when charging this funding source.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "soft_descriptor")]
        public string soft_descriptor { get; set; }

        /// <summary>
        /// Total anticipated amount of money to be pulled from instrument.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
        public Currency amount { get; set; }

        /// <summary>
        /// Additional amount to be pulled from the instrument to recover a negative balance on the buyer's account that is owed to PayPal.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "negative_balance_amount")]
        public Currency negative_balance_amount { get; set; }

        /// <summary>
        /// Localized legal text relevant to funding source.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "legal_text")]
        public string legal_text { get; set; }

        /// <summary>
        /// URL to legal terms relevant to funding source.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "terms")]
        public string terms { get; set; }

        /// <summary>
        /// Additional detail of the funding.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "funding_detail")]
        public FundingDetail funding_detail { get; set; }

        /// <summary>
        /// Additional text relevant to funding source.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "additional_text")]
        public string additional_text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "extends")]
        public FundingInstrument extends { get; set; }
    }
}