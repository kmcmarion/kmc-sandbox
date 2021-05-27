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
	/// <summary>Two Columns Two Rows</summary>
	[PublishedModel("twoColumnSection11")]
	public partial class TwoColumnSection11 : PublishedContentModel, IXmlSiteMapSettings
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const string ModelTypeAlias = "twoColumnSection11";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new static PublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<TwoColumnSection11, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public TwoColumnSection11(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Center Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("centerTitle")]
		public IHtmlString CenterTitle => this.Value<IHtmlString>("centerTitle");

		///<summary>
		/// Image Alt Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("imageAltText")]
		public string ImageAltText => this.Value<string>("imageAltText");

		///<summary>
		/// Image Desktop
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("imageDesktop")]
		public Image ImageDesktop => this.Value<Image>("imageDesktop");

		///<summary>
		/// Image Location
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("imageLocation")]
		public string ImageLocation => this.Value<string>("imageLocation");

		///<summary>
		/// Image Mobile
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("imageMobile")]
		public Image ImageMobile => this.Value<Image>("imageMobile");

		///<summary>
		/// Play Button Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("playButtonImage")]
		public Image PlayButtonImage => this.Value<Image>("playButtonImage");

		///<summary>
		/// Play Button Label
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("playButtonLabel")]
		public string PlayButtonLabel => this.Value<string>("playButtonLabel");

		///<summary>
		/// Text Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("textContent")]
		public IHtmlString TextContent => this.Value<IHtmlString>("textContent");

		///<summary>
		/// Video Link: Get the embed link not the url.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("videoLink")]
		public string VideoLink => this.Value<string>("videoLink");

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