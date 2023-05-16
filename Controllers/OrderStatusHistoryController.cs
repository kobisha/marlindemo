﻿using Marlin.sqlite.Data;
using Marlin.sqlite.Filter;
using Marlin.sqlite.Helper;
using Marlin.sqlite.Models;
using Marlin.sqlite.Services;
using Marlin.sqlite.Wrappers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Marlin.sqlite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderStatusHistoryController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IUriService _uriService;

        public OrderStatusHistoryController(DataContext context, IUriService uriService)
        {
            _context = context;
            _uriService = uriService;
        }

        [HttpPost]

        public async Task<ActionResult<List<OrderStatusHistory>>> AddOrder(OrderStatusHistory order)
        {
            _context.OrderStatusHistory.Add(order);
            await _context.SaveChangesAsync();


            return Ok(await _context.OrderStatusHistory.ToListAsync());
        }


        [HttpGet]
        public async Task<IActionResult> GetOrders([FromQuery] PaginationFilter filter)
        {
            var route = Request.Path.Value;
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var pagedData = await _context.OrderStatusHistory
               .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
               .Take(validFilter.PageSize)
               .ToListAsync();
            var totalRecords = await _context.OrderStatusHistory.CountAsync();
            var pagedReponse = PaginationHelper.CreatePagedReponse<OrderStatusHistory>(pagedData, validFilter, totalRecords, _uriService, route);
            return Ok(pagedReponse);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetOrder(int id)
        {
            var header = await _context.OrderStatusHistory.Where(a => a.Id == id).FirstOrDefaultAsync();
            if (header == null)
            {
                return BadRequest("User not found.");
            }
            return Ok(new Response<OrderStatusHistory>(header));
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<OrderStatusHistory>> DeleteStatus(int id)
        {
            var result = await _context.OrderStatusHistory
            .FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _context.OrderStatusHistory.Remove(result);
                await _context.SaveChangesAsync();
                return result;
            }

            return null;
        }

        [HttpPut]
        public async Task<ActionResult<OrderStatusHistory>> UpdateInvoice(OrderStatusHistory item)
        {
            var result = await _context.OrderStatusHistory
            .FirstOrDefaultAsync(e => e.Id == item.Id);

            if (result != null)
            {
                result.OrderID = item.OrderID;
                result.Date = item.Date;
                result.StatusID = item.StatusID;




                await _context.SaveChangesAsync();

                return result;
            }

            return null;
        }
    }
}
