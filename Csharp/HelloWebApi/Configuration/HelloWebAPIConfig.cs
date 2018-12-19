/*
Configuration File for Web Api 

CodeBaes Configuration: 
Web API is configured only using code based configuration 
using GlobalConfiguration class: go to global.asax



ref: http://www.tutorialsteacher.com/webapi/configure-web-api

*/
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Http;
using System.Web.Http.Routing;

namespace HelloWebApi.Configuration
{
    public static class HelloWebAPIConfig
    {
        /*
         *  The HttpConfiguration is the main class which includes following properties 
         *  using which you can override the default behaviour of Web API.
         *  Property	                Description
            DependencyResolver	        Gets or sets the dependency resolver for dependency injection.
            Filters	                    Gets or sets the filters.
            Formatters	                Gets or sets the media-type formatters.
            IncludeErrorDetailPolicy	Gets or sets a value indicating whether error details should be included in error messages.
            MessageHandlers	            Gets or sets the message handlers.
            ParameterBindingRules	    Gets the collection of rules for how parameters should be bound.
            Properties	                Gets the properties associated with this Web API instance.
            Routes	                    Gets the collection of routes configured for the Web API.
            Services	                Gets the Web API services.
        */
        public static void Register(HttpConfiguration config)
        {
            // Web API routes

            // 1. Attribute Routing
            // This is new feature supported in Web API 2
            // In order to use attribute routing with Web API, 
            // it must be enabled in WebApiConfig by calling config.MapHttpAttributeRoutes() method.
            // e.g. Go to /Controller/StudentController.cs
            config.MapHttpAttributeRoutes();

            // 2. Conventional Base Routing
            // Normally, default is used, but if required, set different routing table
            // school route (simliar to default)

            //config.Routes.MapHttpRoute(
            //    name: "differentName",
            //    routeTemplate: "api/someController/{id}",
            //    defaults: new { controller = "school", id = RouteParameter.Optional },
            //    constraints: new { id = "/d+" } // Regex expression to specify characteristic of route values
            //);


            // default
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}", // URL pattern of the route
                defaults: new { id = RouteParameter.Optional } // An object parameter that includes default route values
            );

            // configure json formatter
            JsonMediaTypeFormatter jsonFormatter = config.Formatters.JsonFormatter;
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
    }
}