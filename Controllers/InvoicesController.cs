﻿using Marlin.sqlite.Data;
using Marlin.sqlite.Filter;
using Marlin.sqlite.Wrappers;
using Marlin.sqlite.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Routing;
using Marlin.sqlite.Services;
using Marlin.sqlite.Helper;

namespace Marlin.sqlite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoicesController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IUriService _uriService;

        public InvoicesController(DataContext context, IUriService uriService)
        {
            _context = context;
           _uriService = uriService;
        }
        [HttpPost]

        public async Task<ActionResult<List<Invoices>>> AddInvoices(Invoices invoices)
        {
            _context.Invoices.Add(invoices);
            await _context.SaveChangesAsync();

            return Ok(await _context.Invoices.ToListAsync());
        }

        [HttpGet]

        public async Task<IActionResult> GetInvoices([FromQuery] PaginationFilter filter)
        {
            var route = Request.Path.Value;
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var pagedData = await _context.Invoices
               .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
               .Take(validFilter.PageSize)
               .ToListAsync();
            var totalRecords = await _context.Invoices.CountAsync();
            var pagedReponse = PaginationHelper.CreatePagedReponse<Invoices>(pagedData, validFilter, totalRecords, _uriService, route);
            return Ok(pagedReponse);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetInvoice(int id)
        {
            var user = await _context.Invoices.Where(a => a.id == id).FirstOrDefaultAsync();
            if (user == null)
            {
                return BadRequest("User not found.");
            }
            return Ok(new Response<Invoices>(user));
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Invoices>> DeleteInvoices(int id)
        {
            var result = await _context.Invoices
            .FirstOrDefaultAsync(e => e.id == id);
            if (result != null)
            {
                _context.Invoices.Remove(result);
                await _context.SaveChangesAsync();
                return result;
            }

            return null;
        }
        [HttpPut]
        public async Task<ActionResult<Invoices>> UpdateInvoices(Invoices item)
        {
            var result = await _context.Invoices
            .FirstOrDefaultAsync(e => e.id == item.id);

            if (result != null)
            {
                result.AccountID = item.AccountID;
                result.OrderID = item.OrderID;
                result.Package = item.Package;
                result.Period = item.Period;
                result.Number = item.Number;
                result.DueDate = item.DueDate;
                result.Amount = item.Amount;
                result.Status = item.Status;



                await _context.SaveChangesAsync();

                return result;
            }

            return null;
        }
    }
}
