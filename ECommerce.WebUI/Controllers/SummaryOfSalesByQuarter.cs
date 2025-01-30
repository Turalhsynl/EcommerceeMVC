using ECommerce.Application.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Controllers;

public class SummaryOfSalesByQuarter(ISummaryOfSalesByQuarterService summaryOfSalesByQuarterService) : Controller
{
    private readonly ISummaryOfSalesByQuarterService _summaryOfSalesByQuarterService = summaryOfSalesByQuarterService;

    public IActionResult Index()
    {
        return View();
    }
}
