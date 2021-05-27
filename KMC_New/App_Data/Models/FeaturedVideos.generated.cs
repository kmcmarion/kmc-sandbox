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
	// Mixin Content Type with alias "featuredVideos"
	/// <summary>Featured Videos</summary>
	public partial interface IFeaturedVideos : IPublishedContent
	{
		/// <summary>Featured Video Image 1</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		IPublishedContent FeaturedVideoImage1 { get; }

		/// <summary>Featured Video Image 2</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		IPublishedContent FeaturedVideoImage2 { get; }

		/// <summary>Featured Video Image 3</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		IPublishedContent FeaturedVideoImage3 { get; }

		/// <summary>Featured Video Link 1</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		string FeaturedVideoLink1 { get; }

		/// <summary>Featured Video Link 2</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		string FeaturedVideoLink2 { get; }

		/// <summary>Featured Video Link 3</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		string FeaturedVideoLink3 { get; }
	}

	/// <summary>Featured Videos</summary>
	[PublishedModel("featuredVideos")]
	public partial class FeaturedVideos : PublishedContentModel, IFeaturedVideos
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const string ModelTypeAlias = "featuredVideos";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new static PublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<FeaturedVideos, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public FeaturedVideos(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Featured Video Image 1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("featuredVideoImage1")]
		public IPublishedContent FeaturedVideoImage1 => GetFeaturedVideoImage1(this);

		/// <summary>Static getter for Featured Video Image 1</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static IPublishedContent GetFeaturedVideoImage1(IFeaturedVideos that) => that.Value<IPublishedContent>("featuredVideoImage1");

		///<summary>
		/// Featured Video Image 2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("featuredVideoImage2")]
		public IPublishedContent FeaturedVideoImage2 => GetFeaturedVideoImage2(this);

		/// <summary>Static getter for Featured Video Image 2</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static IPublishedContent GetFeaturedVideoImage2(IFeaturedVideos that) => that.Value<IPublishedContent>("featuredVideoImage2");

		///<summary>
		/// Featured Video Image 3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("featuredVideoImage3")]
		public IPublishedContent FeaturedVideoImage3 => GetFeaturedVideoImage3(this);

		/// <summary>Static getter for Featured Video Image 3</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static IPublishedContent GetFeaturedVideoImage3(IFeaturedVideos that) => that.Value<IPublishedContent>("featuredVideoImage3");

		///<summary>
		/// Featured Video Link 1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("featuredVideoLink1")]
		public string FeaturedVideoLink1 => GetFeaturedVideoLink1(this);

		/// <summary>Static getter for Featured Video Link 1</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static string GetFeaturedVideoLink1(IFeaturedVideos that) => that.Value<string>("featuredVideoLink1");

		///<summary>
		/// Featured Video Link 2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("featuredVideoLink2")]
		public string FeaturedVideoLink2 => GetFeaturedVideoLink2(this);

		/// <summary>Static getter for Featured Video Link 2</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static string GetFeaturedVideoLink2(IFeaturedVideos that) => that.Value<string>("featuredVideoLink2");

		///<summary>
		/// Featured Video Link 3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("featuredVideoLink3")]
		public string FeaturedVideoLink3 => GetFeaturedVideoLink3(this);

		/// <summary>Static getter for Featured Video Link 3</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static string GetFeaturedVideoLink3(IFeaturedVideos that) => that.Value<string>("featuredVideoLink3");
	}
}
