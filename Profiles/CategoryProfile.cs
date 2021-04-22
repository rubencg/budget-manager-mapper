using System.Linq;
using AutoMapper;
using budget_manager_mapper.Models;

namespace budget_manager_mapper.Profiles
{
    public class CategoryProfile : Profile
    {
        
        public CategoryProfile()
        {
            CreateMap<CategoryIn, CategoryOut>()
                .ForMember(dest => dest.Image, opt => opt.MapFrom(o => GetImage(o.Name)))
                .ForMember(dest => dest.Color, opt => opt.MapFrom(o => GetColor(o.Name)))
                .ForMember(dest => dest.Subcategories, opt => opt.Ignore());
                // .ForMember(dest => dest.Color, opt => opt.MapFrom(o => "#e5775e")) // Expense categories these two commented
                // .ForMember(dest => dest.Subcategories, opt => opt.MapFrom(s => s.Subcategories.Select(c => c.Name).ToArray()));
        }

        public static string GetColor(string categoryName){
            switch (categoryName)
            {
                case "Servicios": 
                    return "#ffa100";
                case "Viajes": 
                    return "#00b7ff";
                case "Auto/Transporte": 
                    return "#f32b4f";
                case "Comida/Salidas": 
                    return "#19751a";
                case "Salud": 
                    return "#6fe57b";
                case "Cuidado Personal": 
                    return "#4765a9";
                case "Compras": 
                    return "#f56ee6";
                case "Iglesia": 
                    return "#008080";
                case "Entretenimiento": 
                    return "#315bae";
                case "Mascotas": 
                    return "#e5775e";
                case "Otros": 
                    return "#999392";
                case "Salario": 
                    return "#800080";
                case "Bono": 
                    return "#008000";
                default:
                    return "#e5775e";
            }
        }

        public static string GetImage(string categoryName){
            switch (categoryName)
            {
                case "Servicios": 
                    return "burn";
                case "Viajes": 
                    return "plane";
                case "Auto/Transporte": 
                    return "car";
                case "Comida/Salidas": 
                    return "shopping-cart";
                case "Salud": 
                    return "prescription-bottle-alt";
                case "Cuidado Personal": 
                    return "weight";
                case "Compras": 
                    return "tshirt";
                case "Iglesia": 
                    return "church";
                case "Entretenimiento": 
                    return "theater-masks";
                case "Mascotas": 
                    return "dog";
                case "Otros": 
                    return "question";
                case "Salario": 
                    return "briefcase";
                case "Bono": 
                    return "money-bill-wave-alt";
                default:
                    return "";
            }
        }
    }
}