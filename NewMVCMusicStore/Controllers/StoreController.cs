﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewMVCMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: / Store
        public string Index()
        {
            return "Hello Store.Index()";
        }
        //GET: / Store/Browse?genre=?Disco
        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);

            return message;

        }
        //GET: /Store/Details
        public string Details(int id)
        {
            string message = "Store.Details, ID = " + id;

            return message;
        }
    }
}

