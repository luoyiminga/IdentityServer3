﻿/*
 * Copyright 2014, 2015 Dominick Baier, Brock Allen
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using IdentityServer3.Core.Models;
using IdentityServer3.Core.Validation;
using System.Threading.Tasks;

namespace IdentityServer3.Core.Services
{
    /// <summary>
    /// Allows adding custom data to a token response
    /// </summary>
    public interface ICustomTokenResponseGenerator
    {
        /// <summary>
        /// Custom response generation
        /// </summary>
        /// <param name="request">The validated request.</param>
        /// <param name="response">The standard token response.</param>
        /// <returns>The custom token response.</returns>
        Task<TokenResponse> GenerateAsync(ValidatedTokenRequest request, TokenResponse response);
    }
}