﻿using BusinessLayer.ViewModels;
using DataAccessLayer.Enums;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace BusinessLayer.Repository
{
    public class StatisticRepository : Repository<Bill>
    {
        #region Thong Ke Bill
        public IEnumerable<BillFormatVM> GetBillHistory(string CustomerName, DateTime? _fromDate = null,
                                                                        DateTime? _toDate = null)
        {
            CustomerName = CustomerName.Trim();
            IEnumerable<Bill> list = GetAll(c => c.BillStatus == BillStatus.Purchased
                                        && c.Customer.Name.Contains(CustomerName));
            if (_fromDate != null && _toDate != null)
            {
                list = list.Where(c => c.DateCheckedOut.Value.Date >= _fromDate.Value.Date
                                    && c.DateCheckedOut.Value.Date <= _toDate.Value.Date);
            }
            foreach (Bill s in list)
            {
                yield return new BillFormatVM
                {
                    Id = s.Id,
                    BillCode = s.BillCode,
                    Customer_Name = s.Customer.Name,
                    Customer_Phone = s.Customer.PhoneNumber,
                    Cashier_Name = s.Cashier.Name,
                    DateCreated = s.DateCreated,
                    DateCheckedOut = s.DateCheckedOut,
                    Deposit = s.Deposit.ToString("N0"),
                    Total = s.Total.ToString("N0")
                };
                /*yield return mapper.Map<BillVM>(s);*/
            }
        }

        public void GetBillInformation(int Bill_Id, out BillVM _bvm, out IEnumerable<RentOrderVM> _rovm,
                                                                    out IEnumerable<ServiceOrderVM> _sovm)
        {
            Bill bvm = GetById(Bill_Id);
            _bvm = mapper.Map<BillVM>(bvm);

            _rovm = bvm.RentOrders.Select(c => mapper.Map<RentOrderVM>(c));

            _sovm = bvm.ServiceOrders.Select(c => mapper.Map<ServiceOrderVM>(c));
        }
        #endregion

        #region Thong Ke So Lieu   

        public void StatisticMonthAndToday(out int _billMonth, out int _billToday,
                            out int _cusMonth, out int _cusToday, out double _saleMonth, out double _saleToday)
        {
            //Hoa don thang nay, co DateCheckedOut nghia la da thanh toan
            IEnumerable<Bill> listBill = GetAll(c => c.DateCheckedOut.Value.Month == DateTime.Now.Month
                                            && c.DateCheckedOut.Value.Year == DateTime.Now.Year);

            _billMonth = listBill.Count();

            _billToday = listBill.Count(c => c.DateCheckedOut.Value.Day == DateTime.Now.Day);

            _saleMonth = listBill.Sum(c => c.Total);

            _saleToday = listBill.Where(c => c.DateCheckedOut.Value.Day == DateTime.Now.Day).Sum(c => c.Total);

            _cusMonth = listBill.GroupBy(c => c.Customer_Id).Count();

            _cusToday = listBill.Where(c => c.DateCheckedOut.Value.Day == DateTime.Now.Day)
                                .GroupBy(c => c.Customer_Id).Count();
        }

        public void StatisticSalePerMonth(out double[] _doanhThuThang)
        {
            _doanhThuThang = new double[13];
            IEnumerable<Bill> list = GetAll(c => c.BillStatus == BillStatus.Purchased &&
                                            c.DateCheckedOut.Value.Year == DateTime.Now.Year);
            for (int i = 1; i <= 12; i++)
            {
                _doanhThuThang[i] += list.Where(c => c.DateCheckedOut.Value.Month == i)
                                            .Sum(c => c.Total);
            }
        }

        public IEnumerable<Frequency> StatisticStadium()
        {
            IEnumerable<Bill> listBill = GetAll(c => c.DateCheckedOut.Value.Month == DateTime.Now.Month
                                            && c.DateCheckedOut.Value.Year == DateTime.Now.Year);

            //Neu chi dung Select thi no tra ve RentOrders = List<RentOrder>
            IEnumerable<RentOrder> listAllRO = listBill.SelectMany(c => c.RentOrders);

            return listAllRO.GroupBy(c => c.Stadium.Name).Select(c => new Frequency
            {
                Name = c.First().Stadium.Name,
                Count = c.Sum(x => Utility.RentTime(x.StartRentDate, x.EndRentDate))
            });
        }

        public IEnumerable<Frequency> StatisticService()
        {
            IEnumerable<Bill> listBill = GetAll(c => c.DateCheckedOut.Value.Month == DateTime.Now.Month
                                            && c.DateCheckedOut.Value.Year == DateTime.Now.Year);

            IEnumerable<ServiceOrder> listAllSO = listBill.SelectMany(c => c.ServiceOrders);

            return listAllSO.GroupBy(c => c.Service.Name).Select(c => new Frequency
            {
                Name = c.First().Service.Name,
                Count = c.Sum(x => x.Count)
            });
        }
        #endregion
    }

    public class Frequency
    {
        public string Name { get; set; }
        public double Count { get; set; }
    }
}
