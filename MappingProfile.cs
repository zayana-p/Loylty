using System;
using AutoMapper;
using V = TGCLoyaltyApp.Core.ViewModels;
using E = TGCLoyaltyApp.Entities;
using TGCLoyaltyApp.Core.ViewModels;

namespace TGCLoyaltyApp.Web
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<E.Customer, V.Customer>();
			CreateMap<V.Customer, E.Customer>();
			CreateMap<E.User, V.User>();
			CreateMap<V.User, E.User>();
			CreateMap<E.UserRole, V.UserRoles>();
			CreateMap<V.UserRoles, E.UserRole>();
			CreateMap<V.StoreLocation, E.StoreLocation>();
			CreateMap<V.Store, E.Store>();
            CreateMap<E.StoreLocation, V.StoreLocation>();
            CreateMap<E.StoreLocation, V.StoreLocation>()
                .ForMember(dest => dest.ProductTypes, opt => opt.MapFrom(src => src.ProductTypeLocation));
            CreateMap<E.Store, V.Store>();
            CreateMap<E.Order, V.Order>()
                .ForMember(dest => dest.OrderDetail, opt => opt.MapFrom(src => src.OrderDetails)); ;
            CreateMap<V.Order, E.Order>();
            CreateMap<E.OrderDetail, V.OrderDetail>();
            CreateMap<V.OrderDetail, E.OrderDetail>();
            CreateMap<E.Order, V.NewOrder>();
            CreateMap<V.NewOrder, E.Order>();
            CreateMap<E.OrderDetail, V.NewOrderDetail>();
            CreateMap<V.NewOrderDetail, E.OrderDetail>();
            CreateMap<E.Reward, V.Reward>();
            CreateMap<V.Reward, E.Reward>();
            CreateMap<E.StorePromotion, V.StorePromotion>();
            CreateMap<V.StorePromotion, E.StorePromotion>();
            CreateMap<E.Ticket, V.Ticket>();
            CreateMap<V.Ticket, E.Ticket>();
            CreateMap<E.ServiceType, V.ServiceType>();
            CreateMap<V.ServiceType, E.ServiceType>();
            CreateMap<E.ServiceAccess, V.ServiceAccess>();
            CreateMap<V.ServiceAccess, E.ServiceAccess>();
            CreateMap<E.ProductTypeLocation, V.ProductTypeLocation>();
            CreateMap<V.ProductTypeLocation, E.ProductTypeLocation>();
            CreateMap<E.Address, V.Address>();
            CreateMap<V.Address, E.Address>();
            CreateMap<E.PushNotification, V.PushNotification>();
            CreateMap<V.PushNotification, E.PushNotification>();
            CreateMap<E.FamilyMember, V.FamilyMember>();
            CreateMap<V.FamilyMember, E.FamilyMember>();
            CreateMap<E.PaymentType, V.PaymentType>();
            CreateMap<V.PaymentType, E.PaymentType>();
            CreateMap<E.PianoModel, V.PianoServiceType>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
            CreateMap<V.PianoServiceType, E.PianoModel>();
            CreateMap<E.OutletStore, V.OutletStore>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
            CreateMap<V.OutletStore, E.OutletStore>();
            CreateMap<E.ProductType, V.ProductType>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
            CreateMap<V.ProductType, E.ProductType>();
            CreateMap<E.Store, V.AllStores>()
                .ForMember(dest => dest.StoreId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.StoreName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.StoreCode, opt => opt.MapFrom(src => src.Code))
                .ForMember(dest => dest.StoreLocations, opt => opt.MapFrom(src => src.Locations));
            CreateMap<E.ServiceType, V.AllServiceTypes>()
                .ForMember(dest => dest.statuses, opt => opt.MapFrom(src => src.Status));
            CreateMap<V.StoreOrder, E.StoreOrder>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
            CreateMap<E.StoreOrder, V.StoreOrder>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
            CreateMap<V.CreateStoreOrder, E.StoreOrder>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
            CreateMap< E.StoreOrder, V.GetStoreOrders>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
            CreateMap< V.GetStoreOrders, E.StoreOrder>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
            CreateMap<E.Emirates, V.Emirates>();
            CreateMap<V.Emirates, E.Emirates>();
            CreateMap<E.PianoServiceCost, V.PianoServiceCost>();
            CreateMap<V.PianoServiceCost, E.PianoServiceCost>();
            CreateMap<E.PianoModel, V.PianoServiceType>()
                 .ForMember(dest => dest.PianoServiceCost, opt => opt.MapFrom(src => src.PianoServiceCosts));







        }
    }
}

