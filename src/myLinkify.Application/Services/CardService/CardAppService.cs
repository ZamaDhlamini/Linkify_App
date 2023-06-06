using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using AutoMapper;
using myLinkify.Domain;
using myLinkify.Services.CardService.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkify.Services.CardService
{
    public class CardAppService : ApplicationService, ICardAppService
    {
        private readonly IRepository<Card, Guid> _cardRepository;

        public CardAppService(IRepository<Card, Guid> cardRepository)
        {
            _cardRepository = cardRepository;
        }

        public async Task<CardDto> CreateAsync(CardDto input)
        {
            var card = ObjectMapper.Map<Card>(input);
            var newCard = await _cardRepository.InsertAsync(card);
            return ObjectMapper.Map<CardDto>(newCard);
        }

        public async Task Delete(Guid id)
        {
            await _cardRepository.DeleteAsync(id);
        }

        public async Task<List<CardDto>> GetAllAsync()
        {
            var cards = await _cardRepository.GetAllListAsync();
            return ObjectMapper.Map<List<CardDto>>(cards);
        }

        public async Task<CardDto> GetAsync(Guid id)
        {
            var card = await _cardRepository.GetAsync(id);
            return ObjectMapper.Map<CardDto>(card);
        }

        public async Task<CardDto> UpdateAsync(CardDto input)
        {
            var card = await _cardRepository.GetAsync(input.Id);
            ObjectMapper.Map(input, card);
            var updatedCard = await _cardRepository.UpdateAsync(card);
            return ObjectMapper.Map<CardDto>(updatedCard);
        }
    }
}
