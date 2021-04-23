using System;
using AutoMapper;
using budget_manager_mapper.Models;

namespace budget_manager_mapper.Profiles
{
    public class IncomeProfile : Profile
    {
        public IncomeProfile()
        {
            CreateMap<IncomeIn, IncomeOut>()
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => DateTimeOffset.FromUnixTimeMilliseconds(src.Date).ToString("o")))
                .ForMember(dest => dest.Account, opt => opt.MapFrom(src => GetTransferOutAccount(src.Account)))
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => new CategoryExpenseOut(){
                    Color = CategoryProfile.GetColor(src.Category.Name),
                    Image = CategoryProfile.GetImage(src.Category.Name),
                    Name = src.Category.Name,
                }))
                ;
        }

        private TransferOutAccount GetTransferOutAccount(AccountExpenseIn account)
        {
            return new TransferOutAccount()
            {
                Color = AccountProfile.GetColorForAccountName(account.Name),
                Image = AccountProfile.GetIconForAccountName(account.Name),
                Name = account.Name
            };
        }
    }
}