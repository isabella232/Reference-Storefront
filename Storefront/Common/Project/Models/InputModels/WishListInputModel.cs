﻿//-----------------------------------------------------------------------
// <copyright file="WishListInputModel.cs" company="Sitecore Corporation">
//     Copyright (c) Sitecore Corporation 1999-2016
// </copyright>
//-----------------------------------------------------------------------
// Copyright 2016 Sitecore Corporation A/S
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file 
// except in compliance with the License. You may obtain a copy of the License at
//       http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the 
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, 
// either express or implied. See the License for the specific language governing permissions 
// and limitations under the License.
// -------------------------------------------------------------------------------------------

namespace Sitecore.Reference.Storefront.Models.InputModels
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Defines the WishListInputModel class.
    /// </summary>
    public class WishListInputModel : BaseInputModel
    {
        /// <summary>
        /// Gets or sets the wish list identifier.
        /// </summary>
        /// <value>The wish list identifier.</value>
        [Required]
        public string ExternalId { get; set; }
        
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is favorite.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is favorite; otherwise, <c>false</c>.
        /// </value>
        public bool IsFavorite { get; set; }
    }
}