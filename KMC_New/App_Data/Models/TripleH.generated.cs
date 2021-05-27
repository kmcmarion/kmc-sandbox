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
	/// <summary>Triple H</summary>
	[PublishedModel("tripleH")]
	public partial class TripleH : PublishedContentModel, ILeftOverlappedImageAndBorder, IOfficesAboveTheFold, ISEO, IXmlSiteMapSettings
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const string ModelTypeAlias = "tripleH";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new static PublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<TripleH, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public TripleH(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Allow Us to Help You Btn Label
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("allowUsToHelpYouBtnLabel")]
		public string AllowUsToHelpYouBtnLabel => this.Value<string>("allowUsToHelpYouBtnLabel");

		///<summary>
		/// Allow Us to Help You Btn Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("allowUsToHelpYouBtnLink")]
		public string AllowUsToHelpYouBtnLink => this.Value<string>("allowUsToHelpYouBtnLink");

		///<summary>
		/// Allow Us to Help You Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("allowUsToHelpYouDescription")]
		public IHtmlString AllowUsToHelpYouDescription => this.Value<IHtmlString>("allowUsToHelpYouDescription");

		///<summary>
		/// Column 1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("column1")]
		public IHtmlString Column1 => this.Value<IHtmlString>("column1");

		///<summary>
		/// Column 2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("column2")]
		public IHtmlString Column2 => this.Value<IHtmlString>("column2");

		///<summary>
		/// Column 3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("column3")]
		public IHtmlString Column3 => this.Value<IHtmlString>("column3");

		///<summary>
		/// CTA Button Label
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("cTAButtonLabel")]
		public string CTabuttonLabel => this.Value<string>("cTAButtonLabel");

		///<summary>
		/// CTA Button Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("cTAButtonLink")]
		public string CTabuttonLink => this.Value<string>("cTAButtonLink");

		///<summary>
		/// Heading: H2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("heading")]
		public IHtmlString Heading => this.Value<IHtmlString>("heading");

		///<summary>
		/// Video Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("videoDescription")]
		public IHtmlString VideoDescription => this.Value<IHtmlString>("videoDescription");

		///<summary>
		/// Video Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("videoHeading")]
		public IHtmlString VideoHeading => this.Value<IHtmlString>("videoHeading");

		///<summary>
		/// Video Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("videoLink")]
		public string VideoLink => this.Value<string>("videoLink");

		///<summary>
		/// Video Thumbnail
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("videoThumbnail")]
		public IPublishedContent VideoThumbnail => this.Value<IPublishedContent>("videoThumbnail");

		///<summary>
		/// Left Supporting Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("leftSupportingImage")]
		public IPublishedContent LeftSupportingImage => LeftOverlappedImageAndBorder.GetLeftSupportingImage(this);

		///<summary>
		/// Left Supporting Image Alt Tag
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("leftSupportingImageAltTag")]
		public string LeftSupportingImageAltTag => LeftOverlappedImageAndBorder.GetLeftSupportingImageAltTag(this);

		///<summary>
		/// Right Button Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("rightButtonLink")]
		public string RightButtonLink => LeftOverlappedImageAndBorder.GetRightButtonLink(this);

		///<summary>
		/// Right Button Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("rightButtonText")]
		public string RightButtonText => LeftOverlappedImageAndBorder.GetRightButtonText(this);

		///<summary>
		/// Right Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("rightDescription")]
		public IHtmlString RightDescription => LeftOverlappedImageAndBorder.GetRightDescription(this);

		///<summary>
		/// Right Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("rightHeading")]
		public IHtmlString RightHeading => LeftOverlappedImageAndBorder.GetRightHeading(this);

		///<summary>
		/// Right Sub Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("rightSubHeading")]
		public string RightSubHeading => LeftOverlappedImageAndBorder.GetRightSubHeading(this);

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
