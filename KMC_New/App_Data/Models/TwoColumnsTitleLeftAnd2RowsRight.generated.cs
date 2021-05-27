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
	// Mixin Content Type with alias "twoColumnsTitleLeftAnd2RowsRight"
	/// <summary>Two Columns - Title Left and 2 Rows Right</summary>
	public partial interface ITwoColumnsTitleLeftAnd2RowsRight : IPublishedContent
	{
		/// <summary>Row 1 Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		Image Row1Image { get; }

		/// <summary>Row 1 Text</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		IHtmlString Row1Text { get; }

		/// <summary>Row 2 Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		Image Row2Image { get; }

		/// <summary>Row 2 Text</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		IHtmlString Row2Text { get; }

		/// <summary>SectionTitle</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		string SectionTitle { get; }

		/// <summary>Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		IHtmlString Title { get; }
	}

	/// <summary>Two Columns - Title Left and 2 Rows Right</summary>
	[PublishedModel("twoColumnsTitleLeftAnd2RowsRight")]
	public partial class TwoColumnsTitleLeftAnd2RowsRight : PublishedContentModel, ITwoColumnsTitleLeftAnd2RowsRight
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const string ModelTypeAlias = "twoColumnsTitleLeftAnd2RowsRight";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new static PublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<TwoColumnsTitleLeftAnd2RowsRight, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public TwoColumnsTitleLeftAnd2RowsRight(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Row 1 Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("row1Image")]
		public Image Row1Image => GetRow1Image(this);

		/// <summary>Static getter for Row 1 Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static Image GetRow1Image(ITwoColumnsTitleLeftAnd2RowsRight that) => that.Value<Image>("row1Image");

		///<summary>
		/// Row 1 Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("row1Text")]
		public IHtmlString Row1Text => GetRow1Text(this);

		/// <summary>Static getter for Row 1 Text</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static IHtmlString GetRow1Text(ITwoColumnsTitleLeftAnd2RowsRight that) => that.Value<IHtmlString>("row1Text");

		///<summary>
		/// Row 2 Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("row2Image")]
		public Image Row2Image => GetRow2Image(this);

		/// <summary>Static getter for Row 2 Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static Image GetRow2Image(ITwoColumnsTitleLeftAnd2RowsRight that) => that.Value<Image>("row2Image");

		///<summary>
		/// Row 2 Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("row2Text")]
		public IHtmlString Row2Text => GetRow2Text(this);

		/// <summary>Static getter for Row 2 Text</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static IHtmlString GetRow2Text(ITwoColumnsTitleLeftAnd2RowsRight that) => that.Value<IHtmlString>("row2Text");

		///<summary>
		/// SectionTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("sectionTitle")]
		public string SectionTitle => GetSectionTitle(this);

		/// <summary>Static getter for SectionTitle</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static string GetSectionTitle(ITwoColumnsTitleLeftAnd2RowsRight that) => that.Value<string>("sectionTitle");

		///<summary>
		/// Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("title")]
		public IHtmlString Title => GetTitle(this);

		/// <summary>Static getter for Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static IHtmlString GetTitle(ITwoColumnsTitleLeftAnd2RowsRight that) => that.Value<IHtmlString>("title");
	}
}