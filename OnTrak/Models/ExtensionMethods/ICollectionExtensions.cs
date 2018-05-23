﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnTrak.Models.ExtensionMethods
{
    public static class ICollectionExtensions
    {
        public static IEnumerable<SelectListItem> ToSelectListItem<T>(this ICollection<T> items, int selectedValue)
        {
            return from item in items
                   select new SelectListItem
                   {
                       Text = item.GetPropertyValue("Name"),
                       Value = item.GetPropertyValue("BodyAreaId"),
                       Selected = item.GetPropertyValue("BodyAreaId").Equals(selectedValue.ToString())
                   };
        }
    }
}
