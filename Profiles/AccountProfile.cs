using AutoMapper;
using budget_manager_mapper.Models;

namespace budget_manager_mapper.Profiles
{
    public class AccountProfile : Profile
    {
        public AccountProfile()
        {
            CreateMap<AccountIn, AccountOut>()
                .ForMember(dest => dest.Color, opt => opt.MapFrom(o => "#4287f5"))
                .ForMember(dest => dest.Image, opt => opt.MapFrom(o => "money-bill"))
                .ForMember(dest => dest.AccountType, opt => opt.MapFrom(src => GetByType(src.Type)));
        }

        private AccountType GetByType(string typeId){
            switch (typeId)
            {
                case "1":
                    return new AccountType("Debito");
                case "2":
                    return new AccountType("Efectivo");
                case "3":
                    return new AccountType("Credito");
                case "4":
                    return new AccountType("Ahorros Ruben");
                case "5":
                    return new AccountType("Ahorros Sarahi");
                default:
                    return new AccountType("Debito");
            }
        }
    }
}