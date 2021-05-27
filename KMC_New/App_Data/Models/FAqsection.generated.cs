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
	// Mixin Content Type with alias "fAQSection"
	/// <summary>FAQ Section</summary>
	public partial interface IFAqsection : IPublishedContent
	{
		/// <summary>Answer 1</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		IHtmlString Answer1 { get; }

		/// <summary>Answer 2</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		IHtmlString Answer2 { get; }

		/// <summary>Answer 3</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		IHtmlString Answer3 { get; }

		/// <summary>Answer 4</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		IHtmlString Answer4 { get; }

		/// <summary>Answer 5</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		IHtmlString Answer5 { get; }

		/// <summary>FAQ Heading</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		string FAqheading { get; }

		/// <summary>Question 1</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		string Question1 { get; }

		/// <summary>Question 2</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		string Question2 { get; }

		/// <summary>Question 3</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		string Question3 { get; }

		/// <summary>Question 4</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		string Question4 { get; }

		/// <summary>Question 5</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		string Question5 { get; }
	}

	/// <summary>FAQ Section</summary>
	[PublishedModel("fAQSection")]
	public partial class FAqsection : PublishedContentModel, IFAqsection
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const string ModelTypeAlias = "fAQSection";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new static PublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<FAqsection, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public FAqsection(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Answer 1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("answer1")]
		public IHtmlString Answer1 => GetAnswer1(this);

		/// <summary>Static getter for Answer 1</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static IHtmlString GetAnswer1(IFAqsection that) => that.Value<IHtmlString>("answer1");

		///<summary>
		/// Answer 2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("answer2")]
		public IHtmlString Answer2 => GetAnswer2(this);

		/// <summary>Static getter for Answer 2</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static IHtmlString GetAnswer2(IFAqsection that) => that.Value<IHtmlString>("answer2");

		///<summary>
		/// Answer 3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("answer3")]
		public IHtmlString Answer3 => GetAnswer3(this);

		/// <summary>Static getter for Answer 3</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static IHtmlString GetAnswer3(IFAqsection that) => that.Value<IHtmlString>("answer3");

		///<summary>
		/// Answer 4
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("answer4")]
		public IHtmlString Answer4 => GetAnswer4(this);

		/// <summary>Static getter for Answer 4</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static IHtmlString GetAnswer4(IFAqsection that) => that.Value<IHtmlString>("answer4");

		///<summary>
		/// Answer 5
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("answer5")]
		public IHtmlString Answer5 => GetAnswer5(this);

		/// <summary>Static getter for Answer 5</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static IHtmlString GetAnswer5(IFAqsection that) => that.Value<IHtmlString>("answer5");

		///<summary>
		/// FAQ Heading: Heading for FAQ Section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("fAQHeading")]
		public string FAqheading => GetFAqheading(this);

		/// <summary>Static getter for FAQ Heading</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static string GetFAqheading(IFAqsection that) => that.Value<string>("fAQHeading");

		///<summary>
		/// Question 1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("question1")]
		public string Question1 => GetQuestion1(this);

		/// <summary>Static getter for Question 1</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static string GetQuestion1(IFAqsection that) => that.Value<string>("question1");

		///<summary>
		/// Question 2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("question2")]
		public string Question2 => GetQuestion2(this);

		/// <summary>Static getter for Question 2</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static string GetQuestion2(IFAqsection that) => that.Value<string>("question2");

		///<summary>
		/// Question 3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("question3")]
		public string Question3 => GetQuestion3(this);

		/// <summary>Static getter for Question 3</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static string GetQuestion3(IFAqsection that) => that.Value<string>("question3");

		///<summary>
		/// Question 4
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("question4")]
		public string Question4 => GetQuestion4(this);

		/// <summary>Static getter for Question 4</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static string GetQuestion4(IFAqsection that) => that.Value<string>("question4");

		///<summary>
		/// Question 5
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("question5")]
		public string Question5 => GetQuestion5(this);

		/// <summary>Static getter for Question 5</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static string GetQuestion5(IFAqsection that) => that.Value<string>("question5");
	}
}