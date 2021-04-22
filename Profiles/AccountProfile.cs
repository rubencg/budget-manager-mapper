using AutoMapper;
using budget_manager_mapper.Models;

namespace budget_manager_mapper.Profiles
{
    public class AccountProfile : Profile
    {
        public AccountProfile()
        {
            CreateMap<AccountIn, AccountOut>()
                .ForMember(dest => dest.Color, opt => opt.MapFrom(o => GetColorForAccountName(o.Name)))
                .ForMember(dest => dest.Image, opt => opt.MapFrom(o => GetIconForAccountName(o.Name)))
                .ForMember(dest => dest.AccountType, opt => opt.MapFrom(src => GetByType(src.Type)));
        }

        public static string GetIconForAccountName(string accountName){
            switch (accountName)
            {
                case "Debito Ruben":
                case "Sarahi Banregio":
                case "Debito Sarahi":
                    return "money-check";
                case "Imprevistos Efectivo":
                case "Efectivo Sarahi":
                case "Efectivo Ruben":
                    return "wallet";
                case "Ahorro Inversion Sarahi":
                case "Ahorro Casa Sarahi":
                case "Tikitchen":
                    return "piggy-bank";
                case "Sarahi Credito":
                case "Ruben Banamex Credito":
                    return "money-check-alt";
                default:
                    return "hand-holding-usd";
            }
        }

        public static string GetColorForAccountName(string accountName){
            switch (accountName)
            {
                case "Debito Ruben":
                    return "#000080";
                case "Sarahi Banregio":
                    return "#8d0d0d";
                case "Debito Sarahi":
                    return "#51cec5";
                case "Imprevistos Efectivo":
                    return "#4287f5";
                case "Efectivo Sarahi":
                    return "#23a5a5";
                case "Efectivo Ruben":
                    return "#d6b9d6";
                case "Sarahi Credito":
                    return "#b85cb8";
                case "Ruben Banamex Credito":
                    return "#8d1818";
                default:
                    return "#000080";
            }
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