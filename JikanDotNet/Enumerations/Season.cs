using System.ComponentModel;
using System.Net;
using System.Text.Json.Serialization;

namespace JikanDotNet
{
	/// <summary>
	/// Enumeration representing seasons of year.
	/// </summary>
#if NET10_0_OR_GREATER
	[JsonConverter(typeof(JsonStringEnumConverter<Season>))]
#else
	[JsonConverter(typeof(JsonStringEnumConverter))]
#endif
	public enum Season
	{
		/// <summary>
		/// Spring season.
		/// </summary>
		[Description("spring")]
		Spring,

		/// <summary>
		/// Summer season.
		/// </summary>
		[Description("summer")]
		Summer,

		/// <summary>
		/// Fall season.
		/// </summary>
		[Description("fall")]
		Fall,

		/// <summary>
		/// Winter season.
		/// </summary>
		[Description("winter")]
		Winter
	}
}