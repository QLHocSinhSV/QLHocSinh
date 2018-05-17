using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Hoc_Sinh.Class
{
    class GiaoVienBus
    {
        public connection doIt = null;
        public int insert(Giaovien gv)
        {
            int ret = 0;

            string sql = @"insert into GIAOVIEN(MaHienThi,HoTen,NgaySinh,GioiTinh,DiaChi,DienThoai,CMND,TrinhDo,ChuyenMon,ChucVu,MaMH,LopQuanLy)
                                         values(@MaHienThi,@HoTen,@NgaySinh,@GioiTinh,@DiaChi,@DienThoai,@CMND,@TrinhDo,@ChuyenMon,@ChucVu,@MaMH,@LopQuanLy)";
            List<SqlParameter> li = new List<SqlParameter>();
            SqlParameter a;
            a = new SqlParameter("MaGV", SqlDbType.Int);
            a.Value = gv.maGV;
            li.Add(a);
            a = new SqlParameter("MaHienThi", SqlDbType.VarChar);
            a.Value = gv.maHT;
            li.Add(a);
            a = new SqlParameter("HoTen", SqlDbType.NVarChar);
            a.Value = gv.hotenGV;
            li.Add(a);
            a = new SqlParameter("NgaySinh", SqlDbType.Date);
            a.Value = gv.ngaysinhGV;
            li.Add(a);
            a = new SqlParameter("GioiTinh", SqlDbType.Bit);
            a.Value = gv.gioitinhGV;
            li.Add(a);
            a = new SqlParameter("DiaChi", SqlDbType.NVarChar);
            a.Value = gv.diachiGV;
            li.Add(a);
            a = new SqlParameter("CMND", SqlDbType.VarChar);
            a.Value = gv.soCMNDGV;
            li.Add(a);
            a = new SqlParameter("DienThoai", SqlDbType.VarChar);
            a.Value = gv.dienthoaiGV;
            li.Add(a);
            a = new SqlParameter("TrinhDo", SqlDbType.NVarChar);
            a.Value = gv.trinhdoGV;
            li.Add(a);
            a = new SqlParameter("ChuyenMon", SqlDbType.NVarChar);
            a.Value = gv.chuyenmonGV;
            li.Add(a);
            a = new SqlParameter("ChucVu", SqlDbType.NVarChar);
            a.Value = gv.chucvuGV;
            li.Add(a);
            a = new SqlParameter("MaMH", SqlDbType.Int);
            a.Value = gv.maMH;
            li.Add(a);
            a = new SqlParameter("LopQuanLy", SqlDbType.Int);
            a.Value = gv.LopQuanLy;
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
        public int update(Giaovien gv)
        {
            int ret = 0;

            string sql = @"update GIAOVIEN set MaHienThi=@MaHienThi,HoTen=@HoTen,NgaySinh=@NgaySinh,GioiTinh=@GioiTinh,DiaChi=@DiaChi,DienThoai=@DienThoai,CMND=@CMND,TrinhDo=@TrinhDo,ChuyenMon=@ChuyenMon,ChucVu=@ChucVu,MaMH=@MaMH,LopQuanLy=@LopQuanLy where MaGV=@MaGV";
            List<SqlParameter> li = new List<SqlParameter>();
            SqlParameter a;
            a = new SqlParameter("MaGV", SqlDbType.Int);
            a.Value = gv.maGV;
            li.Add(a);
            a = new SqlParameter("MaHienThi", SqlDbType.VarChar);
            a.Value = gv.maHT;
            li.Add(a);
            a = new SqlParameter("HoTen", SqlDbType.NVarChar);
            a.Value = gv.hotenGV;
            li.Add(a);
            a = new SqlParameter("NgaySinh", SqlDbType.Date);
            a.Value = gv.ngaysinhGV;
            li.Add(a);
            a = new SqlParameter("GioiTinh", SqlDbType.Bit);
            a.Value = gv.gioitinhGV;
            li.Add(a);
            a = new SqlParameter("DiaChi", SqlDbType.NVarChar);
            a.Value = gv.diachiGV;
            li.Add(a);
            a = new SqlParameter("CMND", SqlDbType.VarChar);
            a.Value = gv.soCMNDGV;
            li.Add(a);
            a = new SqlParameter("DienThoai", SqlDbType.VarChar);
            a.Value = gv.dienthoaiGV;
            li.Add(a);
            a = new SqlParameter("TrinhDo", SqlDbType.NVarChar);
            a.Value = gv.trinhdoGV;
            li.Add(a);
            a = new SqlParameter("ChuyenMon", SqlDbType.NVarChar);
            a.Value = gv.chuyenmonGV;
            li.Add(a);
            a = new SqlParameter("ChucVu", SqlDbType.NVarChar);
            a.Value = gv.chucvuGV;
            li.Add(a);
            a = new SqlParameter("MaMH", SqlDbType.Int);
            a.Value = gv.maMH;
            li.Add(a);
            a = new SqlParameter("LopQuanLy", SqlDbType.Int);
            a.Value = gv.LopQuanLy;
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

