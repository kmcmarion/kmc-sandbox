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
	/// <summary>News Redirect</summary>
	[PublishedModel("newsRedirect")]
	public partial class NewsRedirect : PublishedContentModel, IXmlSiteMapSettings
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const string ModelTypeAlias = "newsRedirect";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new static PublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<NewsRedirect, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public NewsRedirect(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Article Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("articleHeading")]
		public string ArticleHeading => this.Value<string>("articleHeading");

		///<summary>
		/// Article List Image: Small Photo displayed on list of posts. 500x300px
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("articleListImage")]
		public IPublishedContent ArticleListImage => this.Value<IPublishedContent>("articleListImage");

		///<summary>
		/// Date Published
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("datePublished")]
		public DateTime DatePublished => this.Value<DateTime>("datePublished");

		///<summary>
		/// News Category: Select a category. Check 'Popular Post' to display on Popular Posts Section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("newsCategory")]
		public string NewsCategory => this.Value<string>("newsCategory");

		///<summary>
		/// Popular Post?: Enable if it should be added on the Popular Posts section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("popularPost")]
		public bool PopularPost => this.Value<bool>("popularPost");

		///<summary>
		/// Publisher
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("publisher")]
		public string Publisher => this.Value<string>("publisher");

		///<summary>
		/// Redirect Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("redirectLink")]
		public string RedirectLink => this.Value<string>("redirectLink");

		///<summary>
		/// Short Overview: Displayed on Latest Posts/Popular Posts sections
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("shortOverview")]
		public string ShortOverview => this.Value<string>("shortOverview");

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
