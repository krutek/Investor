
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;

//namespace Investor.Controllers
//{
    
//    public class ChooseDataController : Controller
//    {
//        //DataBaseMongoDB DBM = new DataBaseMongoDB();
//        //ConnectionJsonModel connectionJsonModel = new ConnectionJsonModel();
//        //List<HistoricalDataModel> HistoricaldataModelList = new List<HistoricalDataModel>();
        

//        //[Route("/ChooseDataController")]
//        //public IActionResult Index()
//        //{
//        //    List<SectorsModel> sectorModelList = new List<SectorsModel>();
//        //    sectorModelList.Add(new SectorsModel { sector = "BodyGuard", sectorID = 1, symbol = "OMG", symbolID = 1 });
//        //    sectorModelList.Add(new SectorsModel { sector = "HealtCare", sectorID = 2, symbol = "PFI", symbolID = 2 });
//        //    sectorModelList.Add(new SectorsModel { sector = "BodyGuard", sectorID = 1, symbol = "RUH", symbolID = 3 });
//        //    ViewBag.ListofSector = sectorModelList;
//        //    ViewBag.HDMList = connectionJsonModel.Test();
//        //    //HistoricaldataModelList = connectionJsonModel.GetDataBySymbol("OMG");

//        //    return View();
//        //}
//        //[Route("/ChooseDataController/RedirectToTable")]
//        //public IActionResult RedirectToTable(string symbolID)
//        //{
//        //    return RedirectToAction("Table", "Table", symbolID);
//        //}

//        //[HttpPost]
//        //[Route("/ChooseDataController")]
//        //public IActionResult Index(SectorsModel objSectorModel, IFormCollection formCollection)
//        //{
//        //    List<SectorsModel> sectorModelList = new List<SectorsModel>();
//        //    sectorModelList.Add(new SectorsModel { sector = "BodyGuard", sectorID = 1, symbol = "OMG", symbolID = 1 });
//        //    sectorModelList.Add(new SectorsModel { sector = "HealtCare", sectorID = 2, symbol = "PFI", symbolID = 2 });
//        //    sectorModelList.Add(new SectorsModel { sector = "BodyGuard", sectorID = 1, symbol = "RUH", symbolID = 3 });
//        //    ViewBag.ListofSector = sectorModelList;
//        //    if (objSectorModel.sectorID == 0)
//        //    {
//        //        ModelState.AddModelError("", "Select Sector");
//        //    }
//        //    else if (objSectorModel.symbolID == 0)
//        //    {
//        //        ModelState.AddModelError("", "Select Symbol");
//        //    }
//        //    HistoricaldataModelList = connectionJsonModel.GetDataBySymbol(objSectorModel.symbol);
//        //    ViewBag.HDMList = HistoricaldataModelList;

//        //    return View();
//        //}

//        //public JsonResult GetSymbolJSON(int sectorID = 1)
//        //{
//        //    List<SectorsModel> sectorModelList = new List<SectorsModel>();
//        //    sectorModelList.Add(new SectorsModel { sector = "BodyGuard", sectorID = 1, symbol = "OMG", symbolID = 1 });
//        //    sectorModelList.Add(new SectorsModel { sector = "HealtCare", sectorID = 2, symbol = "PFI", symbolID = 2 });
//        //    sectorModelList.Add(new SectorsModel { sector = "BodyGuard", sectorID = 1, symbol = "RUH", symbolID = 3 });

//        //    List<SectorsModel> wybrane = new List<SectorsModel>();
//        //    wybrane = sectorModelList.Where(x => x.sectorID == sectorID).ToList();

//        //    Console.WriteLine();
//        //    return Json(new SelectList(wybrane, "symbolID", "symbol"));
//        //}
//        //public IActionResult TestSend()
//        //{
//        //    List<SectorsModel> sectorModelList = new List<SectorsModel>();
//        //    sectorModelList.Add(new SectorsModel { sector = "BodyGuard", sectorID = 1, symbol = "OMG", symbolID = 1 });
//        //    sectorModelList.Add(new SectorsModel { sector = "HealtCare", sectorID = 2, symbol = "PFI", symbolID = 2 });
//        //    sectorModelList.Add(new SectorsModel { sector = "BodyGuard", sectorID = 1, symbol = "RUH", symbolID = 3 });
//        //    HistoricaldataModelList = connectionJsonModel.GetDataBySymbol("OMG");
//        //    var allToupleData = new Tuple<List<SectorsModel>, List<HistoricalDataModel>>(sectorModelList, HistoricaldataModelList);
//        //    return View(HistoricaldataModelList);
//        //}


//    }
//}
