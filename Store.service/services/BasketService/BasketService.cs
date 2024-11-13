﻿using AutoMapper;
using Store.Repository.Basket;
using Store.Repository.Basket.Models;
using Store.service.services.BasketService.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.service.services.BasketService
{
    public class BasketService : IBasketService
    {
        private readonly IBasketRepository _basketRepository;
        private readonly IMapper _mapper;

        public BasketService(IBasketRepository basketRepository, IMapper mapper)
        {
            _basketRepository = basketRepository;
            _mapper = mapper;
        }

        public async Task<bool> DeleteBasketAsync(string basketId)
             => await _basketRepository.DeleteBasketAsync(basketId);

        public async Task<CustomerBasketDto> GetBasketAsync(string basketId)
        {
            var basket = await _basketRepository.GetBasketAsync(basketId);

            if (basket == null)
                return new CustomerBasketDto();

            var mappedBasket = _mapper.Map<CustomerBasketDto>(basket);

            return mappedBasket;
        }

        public async Task<CustomerBasketDto> UpdateBasketAsync(CustomerBasketDto basket)
        {
            if (basket.Id is null)
                basket.Id = GenerateRandomBasketId();

            var customerBasket = _mapper.Map<CustomerBasket>(basket);

            var updatedBasket = await _basketRepository.UpdateBasketAsync(customerBasket);

            var mappedUpdatedBasket = _mapper.Map<CustomerBasketDto>(updatedBasket);

            return mappedUpdatedBasket;
        }

        private string GenerateRandomBasketId()
        {
            Random random = new Random();

            int randomDigits = random.Next(1000, 10000);

            return $"BS_-{randomDigits}";
        }
    }
}
