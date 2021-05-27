//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.0.4
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedModels
{
	/// <summary>Community & Event Spaces</summary>
	[PublishedModel("communityEventSpaces")]
	public partial class CommunityEventSpaces : PublishedContentModel, IOfficesAboveTheFold, IOfficesOverview, ISEO, IXmlSiteMapSettings
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const string ModelTypeAlias = "communityEventSpaces";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new static PublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<CommunityEventSpaces, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public CommunityEventSpaces(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Display Featured Video?: Toggle on/off the featured video.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("displayFeaturedVideo")]
		public bool DisplayFeaturedVideo => this.Value<bool>("displayFeaturedVideo");

		///<summary>
		/// Featured Video Heading: Add Heading and Description. Preferably, Event Name And Date.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("featuredVideoHeading")]
		public IHtmlString FeaturedVideoHeading => this.Value<IHtmlString>("featuredVideoHeading");

		///<summary>
		/// Featured Video Image: Background Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("featuredVideoImage")]
		public IPublishedContent FeaturedVideoImage => this.Value<IPublishedContent>("featuredVideoImage");

		///<summary>
		/// Featured Video Link: Add Video URL/Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("featuredVideoLink")]
		public string FeaturedVideoLink => this.Value<string>("featuredVideoLink");

		///<summary>
		/// Function Room BGC Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("functionRoomBGCDescription")]
		public string FunctionRoomBgcdescription => this.Value<string>("functionRoomBGCDescription");

		///<summary>
		/// Function Room BGC Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("functionRoomBGCHeading")]
		public string FunctionRoomBgcheading => this.Value<string>("functionRoomBGCHeading");

		///<summary>
		/// Function Room BGC Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("functionRoomBGCImage")]
		public IPublishedContent FunctionRoomBgcimage => this.Value<IPublishedContent>("functionRoomBGCImage");

		///<summary>
		/// Function Room BGC Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("functionRoomBGCLink")]
		public string FunctionRoomBgclink => this.Value<string>("functionRoomBGCLink");

		///<summary>
		/// Function Room Makati Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("functionRoomMakatiDescription")]
		public string FunctionRoomMakatiDescription => this.Value<string>("functionRoomMakatiDescription");

		///<summary>
		/// Function Room Makati Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("functionRoomMakatiHeading")]
		public string FunctionRoomMakatiHeading => this.Value<string>("functionRoomMakatiHeading");

		///<summary>
		/// Function Room Makati Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("functionRoomMakatiImage")]
		public IPublishedContent FunctionRoomMakatiImage => this.Value<IPublishedContent>("functionRoomMakatiImage");

		///<summary>
		/// Function Room Makati Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("functionRoomMakatiLink")]
		public string FunctionRoomMakatiLink => this.Value<string>("functionRoomMakatiLink");

		///<summary>
		/// Function Room Mandaluyong Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("functionRoomMandaluyongDescription")]
		public string FunctionRoomMandaluyongDescription => this.Value<string>("functionRoomMandaluyongDescription");

		///<summary>
		/// Function Room Mandaluyong Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("functionRoomMandaluyongHeading")]
		public string FunctionRoomMandaluyongHeading => this.Value<string>("functionRoomMandaluyongHeading");

		///<summary>
		/// Function Room Mandaluyong Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("functionRoomMandaluyongImage")]
		public IPublishedContent FunctionRoomMandaluyongImage => this.Value<IPublishedContent>("functionRoomMandaluyongImage");

		///<summary>
		/// Function Room Mandaluyong Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("functionRoomMandaluyongLink")]
		public string FunctionRoomMandaluyongLink => this.Value<string>("functionRoomMandaluyongLink");

		///<summary>
		/// Join Our Community Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("joinOurCommunityHeading")]
		public IHtmlString JoinOurCommunityHeading => this.Value<IHtmlString>("joinOurCommunityHeading");

		///<summary>
		/// Join Our Community Image Alt Tag
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("joinOurCommunityImageAltTag")]
		public string JoinOurCommunityImageAltTag => this.Value<string>("joinOurCommunityImageAltTag");

		///<summary>
		/// Join Our Community Supporting Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("joinOurCommunitySupportingImage")]
		public IPublishedContent JoinOurCommunitySupportingImage => this.Value<IPublishedContent>("joinOurCommunitySupportingImage");

		///<summary>
		/// Networking Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("networkingDescription")]
		public IHtmlString NetworkingDescription => this.Value<IHtmlString>("networkingDescription");

		///<summary>
		/// Networking Icon
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("networkingIcon")]
		public IPublishedContent NetworkingIcon => this.Value<IPublishedContent>("networkingIcon");

		///<summary>
		/// Networking Icon Alt Tag
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("networkingIconAltTag")]
		public string NetworkingIconAltTag => this.Value<string>("networkingIconAltTag");

		///<summary>
		/// Networking Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("networkingTitle")]
		public string NetworkingTitle => this.Value<string>("networkingTitle");

		///<summary>
		/// Personal Development Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("personalDevelopmentDescription")]
		public IHtmlString PersonalDevelopmentDescription => this.Value<IHtmlString>("personalDevelopmentDescription");

		///<summary>
		/// Personal Development Icon
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("personalDevelopmentIcon")]
		public IPublishedContent PersonalDevelopmentIcon => this.Value<IPublishedContent>("personalDevelopmentIcon");

		///<summary>
		/// Personal Development Icon Alt Tag
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("personalDevelopmentIconAltTag")]
		public string PersonalDevelopmentIconAltTag => this.Value<string>("personalDevelopmentIconAltTag");

		///<summary>
		/// Personal Development Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("personalDevelopmentTitle")]
		public string PersonalDevelopmentTitle => this.Value<string>("personalDevelopmentTitle");

		///<summary>
		/// Unique Spaces Button Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("uniqueSpacesButtonLink")]
		public string UniqueSpacesButtonLink => this.Value<string>("uniqueSpacesButtonLink");

		///<summary>
		/// Unique Spaces Button Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("uniqueSpacesButtonText")]
		public string UniqueSpacesButtonText => this.Value<string>("uniqueSpacesButtonText");

		///<summary>
		/// Unique Spaces Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("uniqueSpacesDescription")]
		public IHtmlString UniqueSpacesDescription => this.Value<IHtmlString>("uniqueSpacesDescription");

		///<summary>
		/// Unique Spaces Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("uniqueSpacesHeading")]
		public IHtmlString UniqueSpacesHeading => this.Value<IHtmlString>("uniqueSpacesHeading");

		///<summary>
		/// Unique Spaces Image Alt Tag: Supporting Image Alt Tag
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("uniqueSpacesImageAltTag")]
		public string UniqueSpacesImageAltTag => this.Value<string>("uniqueSpacesImageAltTag");

		///<summary>
		/// Unique Spaces Supporting Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("uniqueSpacesSupportingImage")]
		public IPublishedContent UniqueSpacesSupportingImage => this.Value<IPublishedContent>("uniqueSpacesSupportingImage");

		///<summary>
		/// Work Life Balance Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("workLifeBalanceDescription")]
		public IHtmlString WorkLifeBalanceDescription => this.Value<IHtmlString>("workLifeBalanceDescription");

		///<summary>
		/// Work Life Balance Icon
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("workLifeBalanceIcon")]
		public IPublishedContent WorkLifeBalanceIcon => this.Value<IPublishedContent>("workLifeBalanceIcon");

		///<summary>
		/// Work Life Balance Icon Alt Tag
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("workLifeBalanceIconAltTag")]
		public string WorkLifeBalanceIconAltTag => this.Value<string>("workLifeBalanceIconAltTag");

		///<summary>
		/// Work Life Balance Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("workLifeBalanceTitle")]
		public string WorkLifeBalanceTitle => this.Value<string>("workLifeBalanceTitle");

		///<summary>
		/// Above the Fold Button Link: Add redirect link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("aboveTheFoldButtonLink")]
		public string AboveTheFoldButtonLink => OfficesAboveTheFold.GetAboveTheFoldButtonLink(this);

		///<summary>
		/// Above the Fold Button Text: primary button
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("aboveTheFoldButtonText")]
		public string AboveTheFoldButtonText => OfficesAboveTheFold.GetAboveTheFoldButtonText(this);

		///<summary>
		/// Above the Fold Col 1 Bg Image: Transparent Texture Background
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("aboveTheFoldCol1BgImage")]
		public IPublishedContent AboveTheFoldCol1BgImage => OfficesAboveTheFold.GetAboveTheFoldCol1BgImage(this);

		///<summary>
		/// Above the Fold Col 2 Bg Image: Single Image Background. Not applicable on carousel items as background.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("aboveTheFoldCol2BgImage")]
		public IPublishedContent AboveTheFoldCol2BgImage => OfficesAboveTheFold.GetAboveTheFoldCol2BgImage(this);

		///<summary>
		/// Above the Fold Description: paragraph
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("aboveTheFoldDescription")]
		public IHtmlString AboveTheFoldDescription => OfficesAboveTheFold.GetAboveTheFoldDescription(this);

		///<summary>
		/// Above the Fold Heading: h1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("aboveTheFoldHeading")]
		public IHtmlString AboveTheFoldHeading => OfficesAboveTheFold.GetAboveTheFoldHeading(this);

		///<summary>
		/// Above the Fold Sub Heading: h2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("aboveTheFoldSubHeading")]
		public IHtmlString AboveTheFoldSubHeading => OfficesAboveTheFold.GetAboveTheFoldSubHeading(this);

		///<summary>
		/// Bg Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("bgImage")]
		public IPublishedContent BgImage => OfficesOverview.GetBgImage(this);

		///<summary>
		/// Bg Image Alt Tag
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("bgImageAltTag")]
		public string BgImageAltTag => OfficesOverview.GetBgImageAltTag(this);

		///<summary>
		/// Button Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("buttonText")]
		public string ButtonText => OfficesOverview.GetButtonText(this);

		///<summary>
		/// Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("description")]
		public IHtmlString Description => OfficesOverview.GetDescription(this);

		///<summary>
		/// Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("heading")]
		public IHtmlString Heading => OfficesOverview.GetHeading(this);

		///<summary>
		/// Meta Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription => SEO.GetMetaDescription(this);

		///<summary>
		/// Navigation Item Name: Input name of nav item if it's different from the page name.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("navigationItemName")]
		public string NavigationItemName => SEO.GetNavigationItemName(this);

		///<summary>
		/// Og Image: 600 x 600 px
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("ogImage")]
		public IPublishedContent OgImage => SEO.GetOgImage(this);

		///<summary>
		/// Page Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("pageTitle")]
		public string PageTitle => SEO.GetPageTitle(this);

		///<summary>
		/// Schema Type
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("schema")]
		public IEnumerable<IPublishedElement> Schema => SEO.GetSchema(this);

		///<summary>
		/// Structured Data: Add Structured Data from Schema.org
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("structuredData")]
		public string StructuredData => SEO.GetStructuredData(this);

		///<summary>
		/// Hide From Xml SiteMap: Whether to show this page on the XML Sitemap
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("hideFromXmlSiteMap")]
		public bool HideFromXmlSiteMap => XmlSiteMapSettings.GetHideFromXmlSiteMap(this);

		///<summary>
		/// Search Engine Change Frequency
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("searchEngineChangeFrequency")]
		public string SearchEngineChangeFrequency => XmlSiteMapSettings.GetSearchEngineChangeFrequency(this);

		///<summary>
		/// Search Engine Relative Priority: Indicate the relevant priority of this page compared relatively to the rest of the site.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("searchEngineRelativePriority")]
		public decimal SearchEngineRelativePriority => XmlSiteMapSettings.GetSearchEngineRelativePriority(this);
	}
}