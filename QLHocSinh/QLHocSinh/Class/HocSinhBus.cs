using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Quan_Ly_Hoc_Sinh.Class
{
    class HocSinhBus
    {
        public connection doIt = null;
        public int insert(HocSinh_Obj hs)
        {
            int ret = 0;
            string sql = @"insert into HOCSINH (MaHienThi , HoTen , NgaySinh , GioiTinh , DiaChi , QueQuan , DanToc , DienThoai , MaLop,HoTenCha,NgheNghiepCha,DienThoaiCha,HoTenMe,NgheNghiepMe,DienThoaiMe)
                                         values(@MaHienThi,@HoTen,@NgaySinh,@GioiTinh,@DiaChi,@QueQuan,@DanToc,@DienThoai,@MaLop,@HoTenCha ,@NgheNghiepCha,@DienThoaiCha,@HoTenMe,@NgheNghiepMe,@DienThoaiMe)";
            List<SqlParameter> li = new List<SqlParameter>();
            SqlParameter a;
            a = new SqlParameter("MaHS", SqlDbType.Int);
            a.Value = hs.MaHS;
            li.Add(a);
            a = new SqlParameter("HoTen", SqlDbType.NVarChar);
            a.Value = hs.HoTen;
            li.Add(a);
            a = new SqlParameter("NgaySinh", SqlDbType.Date);
            a.Value = hs.NgaySinh;
            li.Add(a);
            a = new SqlParameter("GioiTinh", SqlDbType.Bit);
            a.Value = hs.GioiTinh;
            li.Add(a);
            a = new SqlParameter("QueQuan", SqlDbType.NVarChar);
            a.Value = hs.QueQuan;
            li.Add(a);
            a = new SqlParameter("DiaChi", SqlDbType.NVarChar);
            a.Value = hs.DiaChi;
            li.Add(a);
            a = new SqlParameter("DanToc", SqlDbType.VarChar);
            a.Value = hs.DanToc;
            li.Add(a);
            a = new SqlParameter("DienThoai", SqlDbType.VarChar);
            a.Value = hs.DienThoai;
            li.Add(a);
            a = new SqlParameter("MaLop", SqlDbType.Int);
            a.Value = hs.Lop;
            li.Add(a);
            a = new SqlParameter("MaHienThi", SqlDbType.VarChar);
            a.Value = hs.MaHienThi;
            li.Add(a);
            a = new SqlParameter("HoTenCha", SqlDbType.NVarChar);
            a.Value = hs.HotenCha;
            li.Add(a);
            a = new SqlParameter("NgheNghiepCha", SqlDbType.NVarChar);
            a.Value = hs.NgheNghiepCha;
            li.Add(a);
            a = new SqlParameter("DienThoaiCha", SqlDbType.VarChar);
            a.Value = hs.DienthoaiCha;
            li.Add(a);
            a = new SqlParameter("HoTenMe", SqlDbType.NVarChar);
            a.Value = hs.HotenMe;
            li.Add(a);
            a = new SqlParameter("NgheNghiepMe", SqlDbType.NVarChar);
            a.Value = hs.NgheNghiepMe;
            li.Add(a);
            a = new SqlParameter("DienThoaiMe", SqlDbType.VarChar);
            a.Value = hs.DienthoaiMe;
            li.Add(a);




            if (doIt == null)
            {
                doIt = new connection();
            }
            if (doIt.isOpen() < 0)
            {
                ret = doIt.connect();
            }
            if (ret < 0)
            {
                return -2;
            }
            ret = doIt.doSql(sql, li.ToArray());
            return ret;
        }
        public int update(HocSinh_Obj hs)
        {
            int ret = 0;
            string sql = @"update HOCSINH set  MaHienThi=@MaHienThi,HoTen=@HoTen,NgaySinh=@NgaySinh,GioiTinh=@GioiTinh,DiaChi=@DiaChi,QueQuan=@QueQuan,DanToc=@DanToc,DienThoai=@DienThoai,MaLop=@MaLop,HoTenCha=@HoTenCha,NgheNghiepCha=@NgheNghiepCha,DienThoaiCha=@DienThoaiCha,HoTenMe=@HoTenMe,NgheNghiepMe=@NgheNghiepMe,DienThoaiMe=@DienThoaiMe  where MaHS=@MaHS";
            List<SqlParameter> li = new List<SqlParameter>();
            SqlParameter a;
            a = new SqlParameter("MaHS", SqlDbType.Int);
            a.Value = hs.MaHS;
            li.Add(a);
            a = new SqlParameter("HoTen", SqlDbType.NVarChar);
            a.Value = hs.HoTen;
            li.Add(a);
            a = new SqlParameter("NgaySinh", SqlDbType.Date);
            a.Value = hs.NgaySinh;
            li.Add(a);
            a = new SqlParameter("GioiTinh", SqlDbType.Bit);
            a.Value = hs.GioiTinh;
            li.Add(a);
            a = new SqlParameter("QueQuan", SqlDbType.NVarChar);
            a.Value = hs.QueQuan;
            li.Add(a);
            a = new SqlParameter("DiaChi", SqlDbType.NVarChar);
            a.Value = hs.DiaChi;
            li.Add(a);
            a = new SqlParameter("DanToc", SqlDbType.VarChar);
            a.Value = hs.DanToc;
            li.Add(a);
            a = new SqlParameter("DienThoai", SqlDbType.VarChar);
            a.Value = hs.DienThoai;
            li.Add(a);
            a = new SqlParameter("MaLop", SqlDbType.Int);
            a.Value = hs.Lop;
            li.Add(a);
            a = new SqlParameter("HoTenCha", SqlDbType.NVarChar);
            a.Value = hs.HotenCha;
            li.Add(a);
            a = new SqlParameter("NgheNghiepCha", SqlDbType.NVarChar);
            a.Value = hs.NgheNghiepCha;
            li.Add(a);
            a = new SqlParameter("DienThoaiCha", SqlDbType.VarChar);
            a.Value = hs.DienthoaiCha;
            li.Add(a);
            a = new SqlParameter("HoTenMe", SqlDbType.NVarChar);
            a.Value = hs.HotenMe;
            li.Add(a);
            a = new SqlParameter("NgheNghiepMe", SqlDbType.NVarChar);
            a.Value = hs.NgheNghiepMe;
            li.Add(a);
            a = new SqlParameter("DienThoaiMe", SqlDbType.VarChar);
            a.Value = hs.DienthoaiMe;
            li.Add(a);
            a = new SqlParameter("MaHienThi", SqlDbType.VarChar);
            a.Value = hs.MaHienThi;
            li.Add(a);




            if (doIt == null)
            {
                doIt = new connection();
            }
            if (doIt.isOpen() < 0)
            {
                ret = doIt.connect();
            }
            if (ret < 0)
            {
                return -2;
            }
            ret = doIt.doSql(sql, li.ToArray());
            return ret;
        }

        public void close()
        {
            if (doIt == null)
            {
                return;
            }
            if (doIt.isOpen() < 0)
            {
                return;
            }
            doIt.close();
        }
    }
}
