using BusinessLayer.ViewModels;
using DataAccessLayer.Enums;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BusinessLayer.Repository
{
    public class BillRepository : Repository<Bill>
    {
        public IEnumerable<BillFormatVM> GetList(string CustomerName)
        {
            CustomerName = CustomerName.Trim();
            IEnumerable<Bill> list = GetAll(c => c.BillStatus == BillStatus.UnPurchased
                                            && c.Customer.Name.Contains(CustomerName));
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

        public void GetComboBoxCustomer(ComboBox cbb)
        {
            IEnumerable<Customer> listCus = _db.Customers;
            foreach (Customer cus in listCus)
            {
                cbb.Items.Add(new CBBItem
                {
                    Value = cus.Id,
                    Text = cus.Name
                });
            }
            cbb.SelectedIndex = 0;
        }

        public void SetTotal(int Bill_Id)
        {
            Bill b = GetById(Bill_Id);
            // Tong tien va tien coc
            double _total = 0;
            double _deposit = 0;
            foreach (RentOrder ro in b.RentOrders)
            {
                _total += ro.Total;
                _deposit += ro.Deposit;
            }
            foreach (ServiceOrder so in b.ServiceOrders)
            {
                _total += so.Total;
            }
            b.Total = _total;
            b.Deposit = _deposit;
            Save();
        }

        public void AddBill(BillVM bvm)
        {
            if (bvm.Validate().Length == 0)
            {
                Bill b = mapper.Map<Bill>(bvm);
                b.BillStatus = BillStatus.UnPurchased;
                Add(b);
                Save();
            }
            else throw new Exception(bvm.Validate());
        }

        public void PurchaseBill(int Bill_Id)
        {
            Bill b = GetById(Bill_Id);
            b.BillStatus = BillStatus.Purchased;
            b.DateCheckedOut = DateTime.Now;
            Save();
        }

        //Kiểm tra còn sân nào chưa sử dụng xong không
        public string UnFinishedStadium(int Bill_Id)
        {
            StringBuilder sb = new StringBuilder();
            HashSet<RentOrder> listRO = GetById(Bill_Id).RentOrders;
            foreach (RentOrder ro in listRO)
            {
                if (ro.EndRentDate > DateTime.Now)
                {
                    sb.AppendLine($"- {ro.Stadium.Name}");
                }
            }
            return sb.ToString();
        }

        public void DeleteBill(int Bill_Id)
        {
            Remove(Bill_Id);
            Save();
        }

        public string GetContentPrint(int Bill_Id)
        {
            Bill b = GetById(Bill_Id);
            StringBuilder content = new StringBuilder();

            // Header
            content.AppendLine("\t\t\tHệ thống cho thuê sân thể thao chuyên nghiệp 18 Stadium".PadLeft(70));
            content.AppendLine("\t\t\tĐịa chỉ: Ý Yên - Nam Định".PadLeft(60));
            content.AppendLine();
            content.AppendLine("\t\t\tHÓA ĐƠN THANH TOÁN".PadLeft(60));
            content.AppendLine($"\t\t\tMã số hóa đơn: {b.BillCode}".PadLeft(60));
            content.AppendLine();
            content.AppendLine($"\tNgày tạo lập: {b.DateCreated}");
            /*content.AppendLine($"Ngày thanh toán: {b.DateCheckedOut}".PadLeft(56));*/
            content.AppendLine($"\tKhách hàng: {b.Customer.Name}");
            content.AppendLine($"\tSố điện thoại: {b.Customer.PhoneNumber}");
            content.AppendLine($"\tThu ngân: {b.Cashier.Name}");

            //Thuê sân
            content.AppendLine("_______________________________________THÔNG TIN SÂN THUÊ______________________________________\n");
            content.AppendLine($"{"Tên sân".PadRight(24)}{"Đơn giá".PadRight(15)}{"Bắt đầu thuê".PadRight(20)}{"Kết thúc thuê".PadRight(20)}{"Tổng cộng".PadRight(15)}{"Tiền cọc".PadRight(10)}");


            foreach (RentOrder ro in b.RentOrders)
            {
                content.Append("| ")
                       .Append(ro.Stadium.Name.PadRight(15))
                       .Append(" | ")
                       .Append(ro.Stadium.Price.ToString("N0").PadRight(12))
                       .Append(" | ")
                       .Append(ro.StartRentDate.ToString("HH:mm:ss").PadRight(20))
                       .Append(" | ")
                       .Append(ro.EndRentDate.ToString("HH:mm:ss").PadRight(16))
                       .Append(" | ")
                       .Append(ro.Deposit.ToString("N0").PadRight(15))
                       .Append(" | ")
                       .Append(ro.Total.ToString("N0").PadRight(10))
                       .Append(" |\n");
            }

            // Dịch vụ
            content.AppendLine("\n_______________________________________THÔNG TIN DỊCH VỤ_______________________________________\n");
            content.AppendLine($"{"Tên dịch vụ".PadRight(54)}{"Đơn giá".PadRight(15)}{"Số lượng".PadRight(12)}{"Tổng cộng".PadRight(15)}");

            foreach (ServiceOrder so in b.ServiceOrders)
            {
                content.Append("| ")
                       .Append(so.Service.Name.PadRight(54))
                       .Append(" | ")
                       .Append(so.Service.Price.ToString("N0").PadRight(10))
                       .Append(" | ")
                       .Append(so.Count.ToString().PadRight(12))
                       .Append(" | ")
                       .Append(so.Total.ToString("N0").PadRight(16))
                       .Append(" |\n");
            }

            // Tong ket
            content.AppendLine();
            content.AppendLine("\n_______________________________________TỔNG THANH TOÁN_______________________________________\n");
            content.AppendLine();
            content.AppendLine($"\t>> Tổng tiền: {b.Total.ToString("N0")} VND");
            content.AppendLine($"\t>> Tiền cọc: {b.Deposit.ToString("N0")} VND");
            content.AppendLine($"\t>> Tiền phải trả: {(b.Total - b.Deposit).ToString("N0")} VND");
            content.AppendLine();
            content.AppendLine("\t\tCảm ơn quý khách!".PadLeft(76));

            return content.ToString();
        }

    }
}
