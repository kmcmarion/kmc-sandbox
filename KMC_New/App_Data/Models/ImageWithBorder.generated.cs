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
	/// <summary>Image with Border</summary>
	[PublishedModel("imageWithBorder")]
	public partial class ImageWithBorder : PublishedContentModel, ILeftOverlappedImageAndBorder, IRightOverlappedImageAndBorder, IXmlSiteMapSettings
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const string ModelTypeAlias = "imageWithBorder";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new static PublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ImageWithBorder, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ImageWithBorder(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Left Button Onclick
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("leftButtonOnclick")]
		public string LeftButtonOnclick => this.Value<string>("leftButtonOnclick");

		///<summary>
		/// Right Button Onclick
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("rightButtonOnclick")]
		public string RightButtonOnclick => this.Value<string>("rightButtonOnclick");

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
		/// Left Button Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("leftButtonLink")]
		public string LeftButtonLink => RightOverlappedImageAndBorder.GetLeftButtonLink(this);

		///<summary>
		/// Left Button Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("leftButtonText")]
		public string LeftButtonText => RightOverlappedImageAndBorder.GetLeftButtonText(this);

		///<summary>
		/// Left Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("leftDescription")]
		public IHtmlString LeftDescription => RightOverlappedImageAndBorder.GetLeftDescription(this);

		///<summary>
		/// Left Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("leftHeading")]
		public IHtmlString LeftHeading => RightOverlappedImageAndBorder.GetLeftHeading(this);

		///<summary>
		/// Left Sub Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("leftSubHeading")]
		public string LeftSubHeading => RightOverlappedImageAndBorder.GetLeftSubHeading(this);

		///<summary>
		/// Right Supporting Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("rightSupportingImage")]
		public IPublishedContent RightSupportingImage => RightOverlappedImageAndBorder.GetRightSupportingImage(this);

		///<summary>
		/// Right Supporting Image Alt Tag
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("rightSupportingImageAltTag")]
		public string RightSupportingImageAltTag => RightOverlappedImageAndBorder.GetRightSupportingImageAltTag(this);

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
