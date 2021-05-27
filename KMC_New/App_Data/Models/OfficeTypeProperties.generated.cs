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
	// Mixin Content Type with alias "officeTypeProperties"
	/// <summary>Office Sub Type Properties (Found In Serviced or Enterprise Page)</summary>
	public partial interface IOfficeTypeProperties : IPublishedContent
	{
		/// <summary>Office Sub Type Button Text</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		string OfficeSubTypeButtonText { get; }

		/// <summary>Office Sub Type Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		IHtmlString OfficeSubTypeDescription { get; }

		/// <summary>Office Sub Type Heading</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		IHtmlString OfficeSubTypeHeading { get; }

		/// <summary>Office Sub Type Image Alt Tag</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		string OfficeSubTypeImageAltTag { get; }

		/// <summary>Office Sub Type Sub Heading</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		IHtmlString OfficeSubTypeSubHeading { get; }

		/// <summary>Office Sub Type Supporting Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		IPublishedContent OfficeSubTypeSupportingImage { get; }
	}

	/// <summary>Office Sub Type Properties (Found In Serviced or Enterprise Page)</summary>
	[PublishedModel("officeTypeProperties")]
	public partial class OfficeTypeProperties : PublishedContentModel, IOfficeTypeProperties
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const string ModelTypeAlias = "officeTypeProperties";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new static PublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<OfficeTypeProperties, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public OfficeTypeProperties(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Office Sub Type Button Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("officeSubTypeButtonText")]
		public string OfficeSubTypeButtonText => GetOfficeSubTypeButtonText(this);

		/// <summary>Static getter for Office Sub Type Button Text</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static string GetOfficeSubTypeButtonText(IOfficeTypeProperties that) => that.Value<string>("officeSubTypeButtonText");

		///<summary>
		/// Office Sub Type Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("officeSubTypeDescription")]
		public IHtmlString OfficeSubTypeDescription => GetOfficeSubTypeDescription(this);

		/// <summary>Static getter for Office Sub Type Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static IHtmlString GetOfficeSubTypeDescription(IOfficeTypeProperties that) => that.Value<IHtmlString>("officeSubTypeDescription");

		///<summary>
		/// Office Sub Type Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("officeSubTypeHeading")]
		public IHtmlString OfficeSubTypeHeading => GetOfficeSubTypeHeading(this);

		/// <summary>Static getter for Office Sub Type Heading</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static IHtmlString GetOfficeSubTypeHeading(IOfficeTypeProperties that) => that.Value<IHtmlString>("officeSubTypeHeading");

		///<summary>
		/// Office Sub Type Image Alt Tag
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("officeSubTypeImageAltTag")]
		public string OfficeSubTypeImageAltTag => GetOfficeSubTypeImageAltTag(this);

		/// <summary>Static getter for Office Sub Type Image Alt Tag</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static string GetOfficeSubTypeImageAltTag(IOfficeTypeProperties that) => that.Value<string>("officeSubTypeImageAltTag");

		///<summary>
		/// Office Sub Type Sub Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("officeSubTypeSubHeading")]
		public IHtmlString OfficeSubTypeSubHeading => GetOfficeSubTypeSubHeading(this);

		/// <summary>Static getter for Office Sub Type Sub Heading</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static IHtmlString GetOfficeSubTypeSubHeading(IOfficeTypeProperties that) => that.Value<IHtmlString>("officeSubTypeSubHeading");

		///<summary>
		/// Office Sub Type Supporting Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("officeSubTypeSupportingImage")]
		public IPublishedContent OfficeSubTypeSupportingImage => GetOfficeSubTypeSupportingImage(this);

		/// <summary>Static getter for Office Sub Type Supporting Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static IPublishedContent GetOfficeSubTypeSupportingImage(IOfficeTypeProperties that) => that.Value<IPublishedContent>("officeSubTypeSupportingImage");
	}
}
