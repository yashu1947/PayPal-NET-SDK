//==============================================================================
//
//  This file was auto-generated by a tool using the PayPal REST API schema.
//  More information: https://developer.paypal.com/docs/api/
//
//==============================================================================
using Newtonsoft.Json;

namespace PayPal.Api
{
    public class AgreementStateDescriptor : PayPalSerializableObject
    {
        /// <summary>
        /// Reason for changing the state of the agreement.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "note")]
        public string note { get; set; }

        /// <summary>
        /// The amount and currency of the agreement. 
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
        public Currency amount { get; set; }
    }
}