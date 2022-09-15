﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineBookShop.Api.Models;
using OnlineBookShop.Api.Repositories;
using OnlineBookShop.Models.DTOs;

namespace OnlineBookShop.Api.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartController : ControllerBase
    {
        private readonly ICartRepo _cartRepo;
        private readonly IMapper _mapper;

        public CartController(ICartRepo cartRepo, IMapper mapper)
        {
            _cartRepo = cartRepo;
            _mapper = mapper;
        }
        [HttpGet("{userID}/GetItems")]
        public async Task<ActionResult<IEnumerable<CartItemReadDTO>>> GetCartItems(int userID)
        {
            var carts = await _cartRepo.GetCartItems(userID);
            if (carts != null)
            {
                return Ok(_mapper.Map<List<CartItemReadDTO>>(carts));
            }
            else
            {
                return NoContent();
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<CartItemReadDTO>> GetItem(int id)
        {
            try
            {
                var item = await _cartRepo.GetItem(id);
                if (item == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(_mapper.Map<CartItemReadDTO>(item));
                }
            }
            catch (Exception ex)
            {

                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<CartItemReadDTO>> AddCartItem(CartItemCreateDTO cartItemCreateDTO)
        {
            try
            {
                var newCartItem = await _cartRepo.AddItem(cartItemCreateDTO);
                if (newCartItem == null)
                {
                    return BadRequest();
                }
                else
                {
                    return CreatedAtAction(nameof(GetItem), new {id=newCartItem.Id}, _mapper.Map<CartItemCreateDTO>(newCartItem));
                }
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
            

        }
    }
}
