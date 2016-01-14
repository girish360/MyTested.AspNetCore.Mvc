﻿namespace MyTested.Mvc.Builders.Actions.ShouldReturn
{
    using ActionResults.HttpNotFound;
    using Contracts.ActionResults.HttpNotFound;
    using Microsoft.AspNet.Mvc;

    /// <summary>
    /// Class containing methods for testing HttpNotFoundResult or HttpNotFoundObjectResult.
    /// </summary>
    /// <typeparam name="TActionResult">Result from invoked action in ASP.NET MVC 6 controller.</typeparam>
    public partial class ShouldReturnTestBuilder<TActionResult>
    {
        /// <summary>
        /// Tests whether action result is HttpNotFoundResult.
        /// </summary>
        /// <returns>Base test builder with action result.</returns>
        public IHttpNotFoundTestBuilder NotFound()
        {
            this.ValidateActionReturnType(typeof(HttpNotFoundResult), typeof(HttpNotFoundObjectResult));
            return new HttpNotFoundTestBuilder<TActionResult>(
                this.Controller,
                this.ActionName,
                this.CaughtException,
                this.ActionResult);
        }
    }
}