﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.eAita;
using Business.Business;
using Web.Areas.TDKTDangKyDanhHieuArea.Models;
using Web.Custom;
using Business.CommonBusiness;
using Web.FwCore;
using Web.Common;
using Novacode;
using System.Text.RegularExpressions;

namespace Web.Areas.TDKTDangKyDanhHieuArea.Controllers
{
    public class DanhSachThiDuaDonViController : Controller
    {
        //
        // GET: /TDKTDangKyDanhHieuArea/DanhSachThiDuaDonVi/

        public ActionResult Index()
        {
            return View();
        }

    }
}