using System.Data.Entity;

namespace QuanLyBanHang.Models
{
    public class QuanLyBanHangContext : DbContext
    {
        // Kết nối đến chuỗi connection string tên là "Model1" hoặc "QuanLyBanHangContext" trong App.config
        public QuanLyBanHangContext() : base("name=Model1")
        {
            // Nếu Model thay đổi (VD: Thêm cột), EF sẽ tự xóa DB cũ và tạo lại DB mới.
            // Dữ liệu cũ sẽ mất, nhưng cấu trúc bảng sẽ hoạt động đúng với Model mới.
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<QuanLyBanHangContext>());
        }

        public DbSet<MatHang> MatHangs { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
    }
}