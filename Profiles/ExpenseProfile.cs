using System;
using AutoMapper;
using budget_manager_mapper.Models;

namespace budget_manager_mapper.Profiles
{
    public class ExpenseProfile : Profile
    {
        public ExpenseProfile()
        {
            CreateMap<ExpenseIn, ExpenseOut>()
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => DateTimeOffset.FromUnixTimeMilliseconds(src.Date).ToString("o")))
                .ForMember(dest => dest.Account, opt => opt.MapFrom(src => GetTransferOutAccount(src.Account)))
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => new CategoryExpenseOut(){
                    Color = "#5cc48f",
                    Image = CategoryProfile.GetImage(src.Category.Name),
                    Name = src.Category.Name,
                }))
                .ForMember(dest => dest.Subcategory, opt => opt.MapFrom(src => src.Category.Subcategory.Name))
                ;
        }

        private TransferOutAccount GetTransferOutAccount(AccountExpenseIn account)
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