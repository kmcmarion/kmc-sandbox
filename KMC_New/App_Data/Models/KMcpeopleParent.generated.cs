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
	/// <summary>KMC People - Parent</summary>
	[PublishedModel("kMCPeopleParent")]
	public partial class KMcpeopleParent : PublishedContentModel, IFeaturedBanner, IOfficesAboveTheFold, ISEO, IXmlSiteMapSettings
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const string ModelTypeAlias = "kMCPeopleParent";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new static PublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<KMcpeopleParent, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public KMcpeopleParent(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// FAQ Schema
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("fAQSchema")]
		public string FAqschema => this.Value<string>("fAQSchema");

		///<summary>
		/// HR Payroll Button Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("hRPayrollButtonLink")]
		public string HRpayrollButtonLink => this.Value<string>("hRPayrollButtonLink");

		///<summary>
		/// HR Payroll Button Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("hRPayrollButtonText")]
		public string HRpayrollButtonText => this.Value<string>("hRPayrollButtonText");

		///<summary>
		/// HR Payroll Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("hRPayrollDescription")]
		public IHtmlString HRpayrollDescription => this.Value<IHtmlString>("hRPayrollDescription");

		///<summary>
		/// HR Payroll Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("hRPayrollHeading")]
		public IHtmlString HRpayrollHeading => this.Value<IHtmlString>("hRPayrollHeading");

		///<summary>
		/// HR Payroll Image Alt Tag
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("hRPayrollImageAltTag")]
		public string HRpayrollImageAltTag => this.Value<string>("hRPayrollImageAltTag");

		///<summary>
		/// HR Payroll Supporting Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("hRPayrollSupportingImage")]
		public IPublishedContent HRpayrollSupportingImage => this.Value<IPublishedContent>("hRPayrollSupportingImage");

		///<summary>
		/// Offshore Staffing Button Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("offshoreStaffingButtonLink")]
		public string OffshoreStaffingButtonLink => this.Value<string>("offshoreStaffingButtonLink");

		///<summary>
		/// Offshore Staffing Button Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("offshoreStaffingButtonText")]
		public string OffshoreStaffingButtonText => this.Value<string>("offshoreStaffingButtonText");

		///<summary>
		/// Offshore Staffing Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("offshoreStaffingDescription")]
		public IHtmlString OffshoreStaffingDescription => this.Value<IHtmlString>("offshoreStaffingDescription");

		///<summary>
		/// Offshore Staffing Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("offshoreStaffingHeading")]
		public IHtmlString OffshoreStaffingHeading => this.Value<IHtmlString>("offshoreStaffingHeading");

		///<summary>
		/// Offshore Staffing Image Alt Tag
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("offshoreStaffingImageAltTag")]
		public string OffshoreStaffingImageAltTag => this.Value<string>("offshoreStaffingImageAltTag");

		///<summary>
		/// Offshore Staffing Supporting Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("offshoreStaffingSupportingImage")]
		public IPublishedContent OffshoreStaffingSupportingImage => this.Value<IPublishedContent>("offshoreStaffingSupportingImage");

		///<summary>
		/// Staffing Services Button Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("staffingServicesButtonLink")]
		public string StaffingServicesButtonLink => this.Value<string>("staffingServicesButtonLink");

		///<summary>
		/// Staffing Services Button Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("staffingServicesButtonText")]
		public string StaffingServicesButtonText => this.Value<string>("staffingServicesButtonText");

		///<summary>
		/// Staffing Services Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("staffingServicesDescription")]
		public IHtmlString StaffingServicesDescription => this.Value<IHtmlString>("staffingServicesDescription");

		///<summary>
		/// Staffing Services Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("staffingServicesHeading")]
		public IHtmlString StaffingServicesHeading => this.Value<IHtmlString>("staffingServicesHeading");

		///<summary>
		/// Staffing Services Image Alt Tag
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("staffingServicesImageAltTag")]
		public string StaffingServicesImageAltTag => this.Value<string>("staffingServicesImageAltTag");

		///<summary>
		/// Staffing Services Supporting Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("staffingServicesSupportingImage")]
		public IPublishedContent StaffingServicesSupportingImage => this.Value<IPublishedContent>("staffingServicesSupportingImage");

		///<summary>
		/// Banner Alt Tag
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("bannerAltTag")]
		public string BannerAltTag => FeaturedBanner.GetBannerAltTag(this);

		///<summary>
		/// Banner Image - Desktop
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("bannerImageDesktop")]
		public IPublishedContent BannerImageDesktop => FeaturedBanner.GetBannerImageDesktop(this);

		///<summary>
		/// Banner Image - Mobile
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("bannerImageMobile")]
		public IPublishedContent BannerImageMobile => FeaturedBanner.GetBannerImageMobile(this);

		///<summary>
		/// Banner Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("bannerLink")]
		public string BannerLink => FeaturedBanner.GetBannerLink(this);

		///<summary>
		/// Banner on Page: If a banner should appear on a page, enable the button.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("showBannerOnPage")]
		public bool ShowBannerOnPage => FeaturedBanner.GetShowBannerOnPage(this);

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
