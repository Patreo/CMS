﻿#region License
// 
// Copyright (c) 2013, Kooboo team
// 
// Licensed under the BSD License
// See the file LICENSE.txt for details.
// 
#endregion
using Kooboo.CMS.SiteKernel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kooboo.CMS.SiteKernel.Services
{
    public interface ILabelCategoryService
    {
        IEnumerable<string> GetCategories(Site site);

        void AddCategory(Site site, string category);

        void DeleteCategory(Site site, string category);
    }
}