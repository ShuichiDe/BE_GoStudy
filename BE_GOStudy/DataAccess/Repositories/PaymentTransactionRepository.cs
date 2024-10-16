﻿    using DataAccess.Model;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    namespace DataAccess.Repositories
    {
        public interface IPaymentTransactionRepository
    {
        Task<IEnumerable<PaymentTransaction>> GetAllTransactionsAsync();
        Task<PaymentTransaction> GetTransactionByIdAsync(int id);
        Task AddTransactionAsync(PaymentTransaction transaction);
        Task UpdateTransactionAsync(PaymentTransaction transaction);
        Task DeleteTransactionAsync(int id); 
        Task<bool> CheckPaymentStatus(string code);
        Task<PaymentTransaction> GetPaymentByPaymentRefId(string code);

        Task<bool> DeletePaymentByPaymentRefId(string code);

        Task<IEnumerable<int>> GetPackageIdsByUserIdAsync(int userId);
    }

    public class PaymentTransactionRepository : IPaymentTransactionRepository
    {
        private readonly GOStudyContext _context;

        public PaymentTransactionRepository(GOStudyContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PaymentTransaction>> GetAllTransactionsAsync()
        {
            return await _context.PaymentTransactions.ToListAsync();
        }

        public async Task<PaymentTransaction> GetTransactionByIdAsync(int id)
        {
            return await _context.PaymentTransactions.FindAsync(id);
        }
        public async Task<bool> CheckPaymentStatus(string code)
        {
            var paystatus = await _context.PaymentTransactions.FirstOrDefaultAsync(pay => pay.PaymentRefId == code);

            // Check if paystatus is null
            if (paystatus == null)
            {
                return false; // No payment found for the provided code
            }

            // Check the payment status
            return paystatus.Status == "PAID" || paystatus.Status == "Canceled";
        }
        public async Task<IEnumerable<int>> GetPackageIdsByUserIdAsync(int userId)
        {
            return await _context.PaymentTransactions
       .Where(pt => pt.UserId == userId && pt.Status == "PAID") // Thêm điều kiện Status là "PAID"
       .Select(pt => pt.PackageId)
       .Distinct() // Đảm bảo không có trùng lặp
       .ToListAsync();
        }

        public async Task AddTransactionAsync(PaymentTransaction transaction)
        {
            await _context.PaymentTransactions.AddAsync(transaction);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTransactionAsync(PaymentTransaction transaction)
        {
            _context.PaymentTransactions.Update(transaction);
            await _context.SaveChangesAsync();
        }
        public async Task<PaymentTransaction> GetPaymentByPaymentRefId(string code)
        {
          
            var paymentTransaction = await _context.PaymentTransactions
                .FirstOrDefaultAsync(pay => pay.PaymentRefId == code);

            // Return the found transaction or null if not found
            return paymentTransaction;
        }
        public async Task<bool> DeletePaymentByPaymentRefId(string code)
        {
            // Tìm đối tượng paymentTransaction theo PaymentRefId
            var paymentTransaction = await _context.PaymentTransactions
                .FirstOrDefaultAsync(pay => pay.PaymentRefId == code);

            // Nếu không tìm thấy thì trả về false
            if (paymentTransaction == null)
            {
                return false;
            }

            // Xóa đối tượng nếu tìm thấy
            _context.PaymentTransactions.Remove(paymentTransaction);

            // Lưu thay đổi vào database
            await _context.SaveChangesAsync();

            // Trả về true nếu xóa thành công
            return true;
        }

        public async Task DeleteTransactionAsync(int id)
        {
            var transaction = await _context.PaymentTransactions.FindAsync(id);
            if (transaction != null)
            {
                _context.PaymentTransactions.Remove(transaction);
                await _context.SaveChangesAsync();
            }
        }
    }
}
