﻿namespace MyTested.Mvc.Builders.Actions.ShouldReturn
{
    using Microsoft.AspNet.Mvc;
    using Contracts.ActionResults.Created;
    using ActionResults.Created;

    /// <summary>
    /// Class containing methods for testing CreatedResult, CreatedAtActionResult or CreatedAtRouteResult.
    /// </summary>
    /// <typeparam name="TActionResult">Result from invoked action in ASP.NET MVC 6 controller.</typeparam>
    public partial class ShouldReturnTestBuilder<TActionResult>
    {
        /// <summary>
        /// Tests whether action result is CreatedResult, CreatedAtActionResult or CreatedAtRouteResult.
        /// </summary>
        /// <returns>Created test builder.</returns>
        public ICreatedTestBuilder Created()
        {
            this.ValidateActionReturnType(typeof(CreatedResult), typeof(CreatedAtActionResult), typeof(CreatedAtRouteResult));
            return new CreatedTestBuilder<TActionResult>(
                this.Controller,
                this.ActionName,
                this.CaughtException,
                this.ActionResult);
        }
    }
}
