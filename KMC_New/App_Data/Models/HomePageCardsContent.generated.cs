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
	// Mixin Content Type with alias "homePageCardsContent"
	/// <summary>Home Page Cards - Content</summary>
	public partial interface IHomePageCardsContent : IPublishedContent
	{
		/// <summary>Card Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		IHtmlString CardDescription { get; }

		/// <summary>Card Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		IPublishedContent CardImage { get; }

		/// <summary>Card Image Alt Tag</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		string CardImageAltTag { get; }

		/// <summary>Card Link</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		string CardLink { get; }

		/// <summary>Card Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		string CardTitle { get; }

		/// <summary>CTA ID</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		string CTaid { get; }

		/// <summary>CTA Onclick</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		string CTaonclick { get; }
	}

	/// <summary>Home Page Cards - Content</summary>
	[PublishedModel("homePageCardsContent")]
	public partial class HomePageCardsContent : PublishedContentModel, IHomePageCardsContent
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const string ModelTypeAlias = "homePageCardsContent";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new static PublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<HomePageCardsContent, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public HomePageCardsContent(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Card Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("cardDescription")]
		public IHtmlString CardDescription => GetCardDescription(this);

		/// <summary>Static getter for Card Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static IHtmlString GetCardDescription(IHomePageCardsContent that) => that.Value<IHtmlString>("cardDescription");

		///<summary>
		/// Card Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("cardImage")]
		public IPublishedContent CardImage => GetCardImage(this);

		/// <summary>Static getter for Card Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static IPublishedContent GetCardImage(IHomePageCardsContent that) => that.Value<IPublishedContent>("cardImage");

		///<summary>
		/// Card Image Alt Tag
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("cardImageAltTag")]
		public string CardImageAltTag => GetCardImageAltTag(this);

		/// <summary>Static getter for Card Image Alt Tag</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static string GetCardImageAltTag(IHomePageCardsContent that) => that.Value<string>("cardImageAltTag");

		///<summary>
		/// Card Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("cardLink")]
		public string CardLink => GetCardLink(this);

		/// <summary>Static getter for Card Link</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static string GetCardLink(IHomePageCardsContent that) => that.Value<string>("cardLink");

		///<summary>
		/// Card Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("cardTitle")]
		public string CardTitle => GetCardTitle(this);

		/// <summary>Static getter for Card Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static string GetCardTitle(IHomePageCardsContent that) => that.Value<string>("cardTitle");

		///<summary>
		/// CTA ID
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("cTAID")]
		public string CTaid => GetCTaid(this);

		/// <summary>Static getter for CTA ID</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static string GetCTaid(IHomePageCardsContent that) => that.Value<string>("cTAID");

		///<summary>
		/// CTA Onclick: Onclick Value inside " "
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("cTAOnclick")]
		public string CTaonclick => GetCTaonclick(this);

		/// <summary>Static getter for CTA Onclick</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static string GetCTaonclick(IHomePageCardsContent that) => that.Value<string>("cTAOnclick");
	}
}