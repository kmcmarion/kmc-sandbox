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
	/// <summary>Software Application Schema</summary>
	[PublishedModel("softwareApplicationSchema")]
	public partial class SoftwareApplicationSchema : PublishedElementModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const string ModelTypeAlias = "softwareApplicationSchema";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new static PublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SoftwareApplicationSchema, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public SoftwareApplicationSchema(IPublishedElement content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Author
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("author")]
		public string Author => this.Value<string>("author");

		///<summary>
		/// Category
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("category")]
		public string Category => this.Value<string>("category");

		///<summary>
		/// Date Published
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("datePublished")]
		public DateTime DatePublished => this.Value<DateTime>("datePublished");

		///<summary>
		/// Download URL
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("downloadURL")]
		public string DownloadUrl => this.Value<string>("downloadURL");

		///<summary>
		/// Operating System
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("operatingSystem")]
		public string OperatingSystem => this.Value<string>("operatingSystem");

		///<summary>
		/// Publisher
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("publisher")]
		public string Publisher => this.Value<string>("publisher");

		///<summary>
		/// Requirements
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("requirements")]
		public string Requirements => this.Value<string>("requirements");

		///<summary>
		/// Software Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("softwareName")]
		public string SoftwareName => this.Value<string>("softwareName");

		///<summary>
		/// Software Version
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("softwareVersion")]
		public string SoftwareVersion => this.Value<string>("softwareVersion");
	}
}
