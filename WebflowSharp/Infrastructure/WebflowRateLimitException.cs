﻿
using System.Net;

namespace WebflowSharp.Infrastructure
{
    /// <summary>
    /// An exception thrown when an API call has reached SquareSpaceSharp's rate limit.
    /// </summary>
    public class WebflowRateLimitException : WebflowException
    {
        public WebflowRateLimitException()
        { }

        public WebflowRateLimitException(string message) : base(message) { }

        public WebflowRateLimitException(HttpStatusCode httpStatusCode, string type, string subType, string message, string details) : base(httpStatusCode, type, subType, message, details) { }
    }
}