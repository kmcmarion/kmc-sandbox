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
	/// <summary>Buildings</summary>
	[PublishedModel("buildings")]
	public partial class Buildings : PublishedContentModel, IFeaturedItem, ISEO, IXmlSiteMapSettings
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const string ModelTypeAlias = "buildings";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new static PublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Buildings, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Buildings(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Amenities Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("amenitiesContent")]
		public IHtmlString AmenitiesContent => this.Value<IHtmlString>("amenitiesContent");

		///<summary>
		/// Amenities Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("amenitiesHeading")]
		public IHtmlString AmenitiesHeading => this.Value<IHtmlString>("amenitiesHeading");

		///<summary>
		/// Amenities Photos
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("amenitiesPhotos")]
		public IEnumerable<IPublishedContent> AmenitiesPhotos => this.Value<IEnumerable<IPublishedContent>>("amenitiesPhotos");

		///<summary>
		/// Building Address
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("buildingAddress")]
		public string BuildingAddress => this.Value<string>("buildingAddress");

		///<summary>
		/// Building Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("buildingName")]
		public string BuildingName => this.Value<string>("buildingName");

		///<summary>
		/// Building Overview Carousel - Ribbon Text: CTA for ribbon in Building Overview carousel
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("buildingOverviewCarouselRibbonText")]
		public string BuildingOverviewCarouselRibbonText => this.Value<string>("buildingOverviewCarouselRibbonText");

		///<summary>
		/// Building Photos
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("buildingPhotos")]
		public IEnumerable<IPublishedContent> BuildingPhotos => this.Value<IEnumerable<IPublishedContent>>("buildingPhotos");

		///<summary>
		/// Card - Ribbon Text: CTA for ribbon in card, City Overview page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("cardRibbonText")]
		public string CardRibbonText => this.Value<string>("cardRibbonText");

		///<summary>
		/// Carousel Building Address
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("carouselBuildingAddress")]
		public string CarouselBuildingAddress => this.Value<string>("carouselBuildingAddress");

		///<summary>
		/// Carousel Building Amenities
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("carouselBuildingAmenities")]
		public IHtmlString CarouselBuildingAmenities => this.Value<IHtmlString>("carouselBuildingAmenities");

		///<summary>
		/// Carousel Building Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("carouselBuildingName")]
		public string CarouselBuildingName => this.Value<string>("carouselBuildingName");

		///<summary>
		/// Carousel Photo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("carouselPhoto")]
		public IPublishedContent CarouselPhoto => this.Value<IPublishedContent>("carouselPhoto");

		///<summary>
		/// Carousel Photo Alt Tag
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("carouselPhotoAltTag")]
		public string CarouselPhotoAltTag => this.Value<string>("carouselPhotoAltTag");

		///<summary>
		/// City Overview Carousel - Ribbon Text: CTA for Ribbon in City Overview carousel
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("cityOverviewCarouselRibbonText")]
		public string CityOverviewCarouselRibbonText => this.Value<string>("cityOverviewCarouselRibbonText");

		///<summary>
		/// Coworking Desks
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("coworkingDesks")]
		public string CoworkingDesks => this.Value<string>("coworkingDesks");

		///<summary>
		/// Custom Contact Form: Enable if a custom form is going to be used for a specific building/site.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("customContactForm")]
		public bool CustomContactForm => this.Value<bool>("customContactForm");

		///<summary>
		/// Custom Form Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("customFormHeading")]
		public string CustomFormHeading => this.Value<string>("customFormHeading");

		///<summary>
		/// Custom Form Script: Paste the Hubspot form script in the text area if it is a custom form.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("customFormScript")]
		public string CustomFormScript => this.Value<string>("customFormScript");

		///<summary>
		/// Do Not Show In Locations
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("doNotShowInLocations")]
		public bool DoNotShowInLocations => this.Value<bool>("doNotShowInLocations");

		///<summary>
		/// Featured Location Description: Paragraph below Featured Locations Nav.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("featuredLocationDescription")]
		public IHtmlString FeaturedLocationDescription => this.Value<IHtmlString>("featuredLocationDescription");

		///<summary>
		/// Meeting Rooms
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("meetingRooms")]
		public string MeetingRooms => this.Value<string>("meetingRooms");

		///<summary>
		/// Neighborhood Contents
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("neighborhoodContents")]
		public IHtmlString NeighborhoodContents => this.Value<IHtmlString>("neighborhoodContents");

		///<summary>
		/// Neighborhood Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("neighborhoodHeading")]
		public IHtmlString NeighborhoodHeading => this.Value<IHtmlString>("neighborhoodHeading");

		///<summary>
		/// Neighborhood Photos
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("neighborhoodPhotos")]
		public IEnumerable<IPublishedContent> NeighborhoodPhotos => this.Value<IEnumerable<IPublishedContent>>("neighborhoodPhotos");

		///<summary>
		/// New Building/Pre-Selling?: Check if its an upcoming site or if it offers Pre-Selling. Once checked, a ribbon will be displayed at the upper right corner of the image carousel.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("newBuildingPreSelling")]
		public bool NewBuildingPreSelling => this.Value<bool>("newBuildingPreSelling");

		///<summary>
		/// Office Space
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("officeSpace")]
		public string OfficeSpace => this.Value<string>("officeSpace");

		///<summary>
		/// Office Type Description - Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("officeTypeDescHeading")]
		public IHtmlString OfficeTypeDescHeading => this.Value<IHtmlString>("officeTypeDescHeading");

		///<summary>
		/// Office Type Description - Paragraph
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("officeTypeDescParagraph")]
		public IHtmlString OfficeTypeDescParagraph => this.Value<IHtmlString>("officeTypeDescParagraph");

		///<summary>
		/// Operations Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("operationsContent")]
		public IHtmlString OperationsContent => this.Value<IHtmlString>("operationsContent");

		///<summary>
		/// Operations Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("operationsHeading")]
		public IHtmlString OperationsHeading => this.Value<IHtmlString>("operationsHeading");

		///<summary>
		/// Operations Photo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("operationsPhoto")]
		public IPublishedContent OperationsPhoto => this.Value<IPublishedContent>("operationsPhoto");

		///<summary>
		/// Operations Photo Alt Tag
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("operationsPhotoAltTag")]
		public string OperationsPhotoAltTag => this.Value<string>("operationsPhotoAltTag");

		///<summary>
		/// Private Office
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("privateOffice")]
		public string PrivateOffice => this.Value<string>("privateOffice");

		///<summary>
		/// Telephone Number
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("telephoneNumber")]
		public string TelephoneNumber => this.Value<string>("telephoneNumber");

		///<summary>
		/// Tour Link: Link that will be display in iframe
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("tourLink")]
		public string TourLink => this.Value<string>("tourLink");

		///<summary>
		/// Tour Preview Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("tourPreviewImage")]
		public Image TourPreviewImage => this.Value<Image>("tourPreviewImage");

		///<summary>
		/// Tour Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("tourTitle")]
		public IHtmlString TourTitle => this.Value<IHtmlString>("tourTitle");

		///<summary>
		/// Appear on Page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("appearOnPage")]
		public IEnumerable<string> AppearOnPage => FeaturedItem.GetAppearOnPage(this);

		///<summary>
		/// Featured Building City
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("featuredBuildingCity")]
		public string FeaturedBuildingCity => FeaturedItem.GetFeaturedBuildingCity(this);

		///<summary>
		/// Featured Building Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("featuredBuildingName")]
		public string FeaturedBuildingName => FeaturedItem.GetFeaturedBuildingName(this);

		///<summary>
		/// Featured Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("featuredDescription")]
		public IHtmlString FeaturedDescription => FeaturedItem.GetFeaturedDescription(this);

		///<summary>
		/// Featured Photo: Small featured photo displayed on cards and carousel. Size: 428x175px
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("featuredPhoto")]
		public IPublishedContent FeaturedPhoto => FeaturedItem.GetFeaturedPhoto(this);

		///<summary>
		/// Featured Photo Alt Tag
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("featuredPhotoAltTag")]
		public string FeaturedPhotoAltTag => FeaturedItem.GetFeaturedPhotoAltTag(this);

		///<summary>
		/// Meta Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription => SEO.GetMetaDescription(this);

		///<summary>
		/// Navigation Item Name: Input name of nav item if it's different from the page name.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("navigationItemName")]
		public string NavigationItemName => SEO.GetNavigationItemName(this);

		///<summary>
		/// Og Image: 600 x 600 px
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("ogImage")]
		public IPublishedContent OgImage => SEO.GetOgImage(this);

		///<summary>
		/// Page Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("pageTitle")]
		public string PageTitle => SEO.GetPageTitle(this);

		///<summary>
		/// Schema Type
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("schema")]
		public IEnumerable<IPublishedElement> Schema => SEO.GetSchema(this);

		///<summary>
		/// Structured Data: Add Structured Data from Schema.org
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("structuredData")]
		public string StructuredData => SEO.GetStructuredData(this);

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
