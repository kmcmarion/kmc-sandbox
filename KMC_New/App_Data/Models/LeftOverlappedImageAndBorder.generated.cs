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
	// Mixin Content Type with alias "leftOverlappedImageAndBorder"
	/// <summary>Left - Overlapped Image and Border</summary>
	public partial interface ILeftOverlappedImageAndBorder : IPublishedContent
	{
		/// <summary>Left Supporting Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		IPublishedContent LeftSupportingImage { get; }

		/// <summary>Left Supporting Image Alt Tag</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		string LeftSupportingImageAltTag { get; }

		/// <summary>Right Button Link</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		string RightButtonLink { get; }

		/// <summary>Right Button Text</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		string RightButtonText { get; }

		/// <summary>Right Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		IHtmlString RightDescription { get; }

		/// <summary>Right Heading</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		IHtmlString RightHeading { get; }

		/// <summary>Right Sub Heading</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		string RightSubHeading { get; }
	}

	/// <summary>Left - Overlapped Image and Border</summary>
	[PublishedModel("leftOverlappedImageAndBorder")]
	public partial class LeftOverlappedImageAndBorder : PublishedContentModel, ILeftOverlappedImageAndBorder
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const string ModelTypeAlias = "leftOverlappedImageAndBorder";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new static PublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<LeftOverlappedImageAndBorder, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public LeftOverlappedImageAndBorder(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Left Supporting Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("leftSupportingImage")]
		public IPublishedContent LeftSupportingImage => GetLeftSupportingImage(this);

		/// <summary>Static getter for Left Supporting Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static IPublishedContent GetLeftSupportingImage(ILeftOverlappedImageAndBorder that) => that.Value<IPublishedContent>("leftSupportingImage");

		///<summary>
		/// Left Supporting Image Alt Tag
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("leftSupportingImageAltTag")]
		public string LeftSupportingImageAltTag => GetLeftSupportingImageAltTag(this);

		/// <summary>Static getter for Left Supporting Image Alt Tag</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static string GetLeftSupportingImageAltTag(ILeftOverlappedImageAndBorder that) => that.Value<string>("leftSupportingImageAltTag");

		///<summary>
		/// Right Button Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("rightButtonLink")]
		public string RightButtonLink => GetRightButtonLink(this);

		/// <summary>Static getter for Right Button Link</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static string GetRightButtonLink(ILeftOverlappedImageAndBorder that) => that.Value<string>("rightButtonLink");

		///<summary>
		/// Right Button Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("rightButtonText")]
		public string RightButtonText => GetRightButtonText(this);

		/// <summary>Static getter for Right Button Text</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static string GetRightButtonText(ILeftOverlappedImageAndBorder that) => that.Value<string>("rightButtonText");

		///<summary>
		/// Right Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("rightDescription")]
		public IHtmlString RightDescription => GetRightDescription(this);

		/// <summary>Static getter for Right Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static IHtmlString GetRightDescription(ILeftOverlappedImageAndBorder that) => that.Value<IHtmlString>("rightDescription");

		///<summary>
		/// Right Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("rightHeading")]
		public IHtmlString RightHeading => GetRightHeading(this);

		/// <summary>Static getter for Right Heading</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static IHtmlString GetRightHeading(ILeftOverlappedImageAndBorder that) => that.Value<IHtmlString>("rightHeading");

		///<summary>
		/// Right Sub Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("rightSubHeading")]
		public string RightSubHeading => GetRightSubHeading(this);

		/// <summary>Static getter for Right Sub Heading</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static string GetRightSubHeading(ILeftOverlappedImageAndBorder that) => that.Value<string>("rightSubHeading");
	}
}