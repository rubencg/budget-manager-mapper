using System;
using AutoMapper;
using budget_manager_mapper.Models;

namespace budget_manager_mapper.Profiles
{
    public class TransferProfile : Profile
    {
        public TransferProfile()
        {
            CreateMap<TransferIn, TransferOut>()
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => DateTimeOffset.FromUnixTimeMilliseconds(src.Date).ToString("o")))
                .ForMember(dest => dest.FromAccount, opt => opt.MapFrom(src => GetTransferOutAccount(src.FromAccount)))
                .ForMember(dest => dest.ToAccount, opt => opt.MapFrom(src => GetTransferOutAccount(src.ToAccount)))
                ;
        }

        private TransferOutAccount GetTransferOutAccount(TransferAccount account)
        {
            return new TransferOutAccount()
            {
                Color = "#800080",
                Image = "money-bill",
                Name = account.Name
            };
        }
    }
}