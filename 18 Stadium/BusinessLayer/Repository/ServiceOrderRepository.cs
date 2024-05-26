using BusinessLayer.ViewModels;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Repository
{
    public class ServiceOrderRepository : Repository<ServiceOrder>
    {
        public IEnumerable<ServiceOrderFormatVM> GetList(int Bill_Id, string ServiceName)
        {
            ServiceName = ServiceName.Trim();
            IEnumerable<ServiceOrder> list = GetAll(c => c.Bill_Id == Bill_Id
                                                && c.Service.Name.Contains(ServiceName));
            foreach (ServiceOrder s in list)
            {
                yield return new ServiceOrderFormatVM
                {
                    Id = s.Id,
                    Bill_Id = s.Bill_Id,
                    Bill_Code = s.Bill.BillCode,
                    Service_Id = s.Service.Id,
                    Service_Name = s.Service.Name,
                    Service_Price = s.Service.Price.ToString("N0"),
                    Service_Image = s.Service.Image,
                    Count = s.Count,
                    Total = s.Total.ToString("N0")
                };
                /*yield return mapper.Map<ServiceOrderVM>(s);*/
            }
        }

        public void AddServiceOrder(ServiceOrderVM sovm)
        {
            if (sovm.Validate().Length == 0)
            {
                ServiceOrder so = mapper.Map<ServiceOrder>(sovm);
                Add(so);
                Save();
            }
            else throw new Exception(sovm.Validate());
        }

        public void UpdateServiceOrder(ServiceOrderVM sovm)
        {
            if (sovm.Validate().Length == 0)
            {
                ServiceOrder so = GetById(sovm.Id);
                mapper.Map(sovm, so);
                Save();
            }
            else throw new Exception(sovm.Validate());
        }

        public void DeleteServiceOrder(int id)
        {
            Remove(id);
            Save();
        }
    }
}
