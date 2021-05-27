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
	/// <summary>Contact Us - Thank You</summary>
	[PublishedModel("contactUsThankYou")]
	public partial class ContactUsThankYou : PublishedContentModel, ISEO, IXmlSiteMapSettings
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const string ModelTypeAlias = "contactUsThankYou";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new static PublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ContactUsThankYou, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ContactUsThankYou(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Contact Info Bg Texture
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("contactInfoBgTexture")]
		public IPublishedContent ContactInfoBgTexture => this.Value<IPublishedContent>("contactInfoBgTexture");

		///<summary>
		/// Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("heading")]
		public IHtmlString Heading => this.Value<IHtmlString>("heading");

		///<summary>
		/// Heading Bg Texture: Orange background of Header
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("headingBgTexture")]
		public IPublishedContent HeadingBgTexture => this.Value<IPublishedContent>("headingBgTexture");

		///<summary>
		/// Mailing  Address
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("mailingAddress")]
		public string MailingAddress => this.Value<string>("mailingAddress");

		///<summary>
		/// Reach Us: Contact Numbers
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("reachUs")]
		public IHtmlString ReachUs => this.Value<IHtmlString>("reachUs");

		///<summary>
		/// Sales Hours
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("salesHours")]
		public string SalesHours => this.Value<string>("salesHours");

		///<summary>
		/// Thank You Message
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("thankYouMessage")]
		public IHtmlString ThankYouMessage => this.Value<IHtmlString>("thankYouMessage");

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
