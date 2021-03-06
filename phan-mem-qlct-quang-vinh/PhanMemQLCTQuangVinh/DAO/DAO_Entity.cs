﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using PhanMemQLCTQuangVinh.DTO;
using System.Text.RegularExpressions;

namespace PhanMemQLCTQuangVinh.DAO
{
    public class DAO_Entity
    {
        KetNoiCSDL ketnoi;
        public DAO_Entity()
        {
            ketnoi = new KetNoiCSDL();
        }
        // DAOKhachHang

        public List<DTOKhachHang> TaoDSKH()
        {
            List<DTOKhachHang> ds = new List<DTOKhachHang>();
            string lenh = "Select * from KhachHang kh, LoaiKH lkh where kh.malkh=lkh.malkh";
            ketnoi.TaoKetNoi();
            DataTable bang = new DataTable();
            try
            {
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);
                //dong bo lenh ket noi voi du lieu trong database
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                foreach (DataRow dongDL in bang.Rows)
                {
                    DTOKhachHang dtoKH = new DTOKhachHang(dongDL);
                    ds.Add(dtoKH);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ds;
        }


        public bool ThemKhachHang(DTOKhachHang dtoKH)
        {
            bool ketqua = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "insert into KhachHang(TenKH, DiaChi, Sdt, MaLKH) values (@tenkh, @diachi, @sdt, @malkh)";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                //ketnoi.LenhKetNoi.Parameters.Add("@makh", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@tenkh", SqlDbType.NVarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@diachi", SqlDbType.NVarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@sdt", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@malkh", SqlDbType.Int);

                //ketnoi.LenhKetNoi.Parameters["@makh"].Value = dtoKH.MaKH;
                ketnoi.LenhKetNoi.Parameters["@tenkh"].Value = dtoKH.TenKH;
                ketnoi.LenhKetNoi.Parameters["@diachi"].Value = dtoKH.DiaChiKH;
                ketnoi.LenhKetNoi.Parameters["@sdt"].Value = dtoKH.SdtKH;
                ketnoi.LenhKetNoi.Parameters["@malkh"].Value = dtoKH.dtoLoaiKH.MaLKH;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                    ketqua = true;
            }
            catch (Exception)
            {


            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ketqua;
        }

        // Sua TT khach hang
        public bool CapNhatKhachHang(DTOKhachHang dtoKH)
        {
            bool ketqua = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "update KhachHang set TenKH= @tenkh, DiaChi = @diachi, Sdt = @sdt, MaLKH = @malkh where MaKH=@makh";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@makh", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@tenkh", SqlDbType.NVarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@diachi", SqlDbType.NVarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@sdt", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@malkh", SqlDbType.Int);

                ketnoi.LenhKetNoi.Parameters["@makh"].Value = dtoKH.MaKH;
                ketnoi.LenhKetNoi.Parameters["@tenkh"].Value = dtoKH.TenKH;
                ketnoi.LenhKetNoi.Parameters["@diachi"].Value = dtoKH.DiaChiKH;
                ketnoi.LenhKetNoi.Parameters["@sdt"].Value = dtoKH.SdtKH;
                ketnoi.LenhKetNoi.Parameters["@malkh"].Value = dtoKH.dtoLoaiKH.MaLKH;//@malkh thi phai gan vao "MaLKH", sao lai gan cho dtoLoaiKh

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                    ketqua = true;
            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ketqua;
        }

        //public bool XoaKhachHang(DTOKhachHang dtoKH)
        //{
        //    bool ketqua = false;
        //    ketnoi.TaoKetNoi();
        //    try
        //    {
        //        string lenh = "delete from KhachHang where MaKH = @makh";
        //        ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

        //        ketnoi.LenhKetNoi.Parameters.Add("@makh", SqlDbType.Int);
        //        ketnoi.LenhKetNoi.Parameters["@makh"].Value = dtoKH.MaKH;

        //        if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
        //            ketqua = true;
        //    }
        //    catch (Exception) 
        //    {

        //    }
        //    finally
        //    {
        //        ketnoi.DongKetNoi();
        //    }
        //    return ketqua;
        //}

        //Lay TTKH tu ma de qua tranh Sua
        public DTOKhachHang LayTTKHTheoMa(string ma)
        {
            ketnoi.TaoKetNoi();
            DTOKhachHang dtoKH = null;
            try
            {
                string lenh = "select L.MaLKH,L.TenLKH,KH.MaKH,KH.TenKH,KH.Sdt,KH.Diachi from KhachHang KH,LoaiKH L where KH.MaKH = " + ma + " and KH.MaLKH=L.MaLKH ";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                //ketnoi.LenhKetNoi.Parameters.Add("@makh", SqlDbType.Int);
                //ketnoi.LenhKetNoi.Parameters["@makh"].Value = maSua;

                DataTable bang = new DataTable();
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                DataRow dong = bang.Rows[0];
                dtoKH = new DTOKhachHang(dong);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dtoKH;
        }

        //Lay thong tin loai khach hang do vao ListBox 29/03/2015
        public List<DTOLoaiKH> LayDSLKH()
        {
            List<DTOLoaiKH> dsLKH = new List<DTOLoaiKH>();
            string lenh = "select * from LoaiKH";
            ketnoi.TaoKetNoi();
            DataTable bang = new DataTable();
            try
            {
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                foreach (DataRow dongDL in bang.Rows)
                {
                    DTOLoaiKH dtoLKH = new DTOLoaiKH(dongDL);
                    dsLKH.Add(dtoLKH);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dsLKH;
        }

        // Xoa KH co dieu kien 03/04/2015
        public bool XoaKhachHang(int maxoa)
        {
            bool ketqua = false;
            ketnoi.TaoKetNoi();
            try
            {
                //neu KH co don hang dang xu ly hoac dang con no
                string lenhktr = "select * from HDBH HD, KhachHang KH, CongNoBanHang CNBH where HD.MaKH = KH.MaKH and KH.MaKH = CNBH.MaKH and KH.MaKH = @makh";
                ketnoi.LenhKetNoi = new SqlCommand(lenhktr, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@makh", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters["@makh"].Value = maxoa;

                DataTable bang = new DataTable();
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);

                //neu KH co don hang dang xu ly hoac dang con no thi ko dc xoa
                if (bang.Rows.Count > 0)
                {
                    ketqua = false;
                }
                else // thuc hien lenh xoa
                {
                    string lenhxoa = "delete from KhachHang where MaKH = @makh";
                    ketnoi.LenhKetNoi = new SqlCommand(lenhxoa, ketnoi.KetNoi);
                    ketnoi.LenhKetNoi.Parameters.Add("@makh", SqlDbType.Int);
                    ketnoi.LenhKetNoi.Parameters["@makh"].Value = maxoa;

                    if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                        ketqua = true;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ketqua;
        }

        public bool KiemTraDienThoai(string sdt)
        {
            //kiem tra chuoi co rong hay nho hon 4 chu so ko
            if (string.IsNullOrEmpty(sdt) || sdt.Length < 4)
            {
                return false;
            }
            //sdt = sdt.Trim();
            //kiem tra do dai chuoi so
            Match dinhDang = Regex.Match(sdt, @"^\d{9,11}$");
            if (dinhDang.Success == false)
            {
                return false;
            }

            //de so sanh voi dauSoMang
            if (sdt.StartsWith("+"))
            {
                sdt = sdt.Replace("+", "0"); // thay dau "+" thanh so 0
            }
            if (sdt.StartsWith("084"))
            {
                sdt = sdt.Replace("084", "0");
            }

            //dau so cac mang di dong
            string[] dauSoMang = { "096", "097", "098", "0163", "0164", "0165", "0166", "0167", "0168", "0169", "090",
                     "093","0120", "0121", "0122","0126","0128", "091", "094","0123","0124",
                   "0125","0127","0129", "092", "0188", "0993", "0994", "0995", "0996", "0199"};// 090???
            //cat dau so tu sdt ==> so sanh
            string dauSo = sdt.Substring(0, 4); //cat 4 chu so tu vi tri thu 0 
            return dauSoMang.Any(dauSo.Contains);
        }

        public List<DTOKhachHang> TimTheoTenKH(string tenTim)
        {
            List<DTOKhachHang> dsTim = new List<DTOKhachHang>();
            string lenh = "select * from KhachHang KH, LoaiKH LKH where KH.MaLKH = LKH.MaLKH and KH.TenKH like @ten";
            ketnoi.TaoKetNoi();
            DataTable bang = new DataTable();
            try
            {
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);
                ketnoi.LenhKetNoi.Parameters.Add("@ten", SqlDbType.NVarChar);
                ketnoi.LenhKetNoi.Parameters["@ten"].Value = "%" + tenTim + "%";

                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                foreach (DataRow dongDL in bang.Rows)
                {
                    DTOKhachHang dtoKH = new DTOKhachHang(dongDL);
                    dsTim.Add(dtoKH);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dsTim;
        }

        #region DonHang
        public List<DTODonDatHang> LayDSDHTheoMa(string ma)
        {
            List<DTODonDatHang> ds = new List<DTODonDatHang>();
            string lenh = "Select * from KhachHang kh, DonDH dh, LoaiKH l where kh.MaKH=" + ma + " and kh.MaKH=dh.MaKH and l.MaLKH=kh.MaLKH";
            //ketnoi.LenhKetNoi.Parameters.Add("@ma", SqlDbType.Int);
            //ketnoi.LenhKetNoi.Parameters["@ma"].Value = ma;
            //string lenh = "Select dh.MaDH,kh.MaKH,kh.TenKH,dh.TongTien,dh.CongNoDH from KhachHang kh, DonDH dh where kh.MaKH=" + ma + " and kh.MaKH=dh.MaKH";
            ketnoi.TaoKetNoi();
            DataTable bang = new DataTable();
            try
            {
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);
                //dong bo lenh ket noi voi du lieu trong database
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                foreach (DataRow dongDL in bang.Rows)
                {
                    DTODonDatHang dtoDH = new DTODonDatHang(dongDL);
                    ds.Add(dtoDH);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ds;
        }
        //DAOThemDonHang
        public bool ThemDonHang(DTODonDatHang dtodh)
        {
            bool ketqua = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "insert into DonDH(maDH, MaKH, NgayTaoDH, NgayGH, TongTien, CongNoDH, TrangThai) values (@madh, @makh, @ngaytao, @ngaygiao, @tongtien, @congno, @trangthai)";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@madh", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@makh", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@ngaytao", SqlDbType.DateTime);
                ketnoi.LenhKetNoi.Parameters.Add("@ngaygiao", SqlDbType.DateTime);
                ketnoi.LenhKetNoi.Parameters.Add("@tongtien", SqlDbType.Int);

                ketnoi.LenhKetNoi.Parameters.Add("@congno", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@trangthai", SqlDbType.NVarChar);

                ketnoi.LenhKetNoi.Parameters["@madh"].Value = dtodh.MaDH;
                ketnoi.LenhKetNoi.Parameters["@makh"].Value = dtodh.MaKH;
                ketnoi.LenhKetNoi.Parameters["@ngaytao"].Value = dtodh.NgayTaoDH;
                ketnoi.LenhKetNoi.Parameters["@ngaygiao"].Value = dtodh.NgayGH;
                ketnoi.LenhKetNoi.Parameters["@tongtien"].Value = dtodh.TongTien;

                ketnoi.LenhKetNoi.Parameters["@congno"].Value = dtodh.CongNoDH;
                ketnoi.LenhKetNoi.Parameters["@trangthai"].Value = dtodh.TrangThai;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                    ketqua = true;
            }
            catch (Exception)
            {


            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ketqua;
        }


        //lay toan bo danh sach don hang
        public List<DTODonDatHang> LayDSDonHang()
        {
            List<DTODonDatHang> dsDonHang = new List<DTODonDatHang>();
            string lenh = "Select * from KhachHang kh, DonDH dh, LoaiKH lkh where dh.TrangThai=N'Đã Sản Xuất' and kh.MaKH=dh.MaKH and lkh.MaLKH=kh.MaLKH";
            ketnoi.TaoKetNoi();
            DataTable bang = new DataTable();
            try
            {
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                foreach (DataRow dongDL in bang.Rows)
                {
                    DTODonDatHang dtoKH = new DTODonDatHang(dongDL);
                    dsDonHang.Add(dtoKH);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dsDonHang;
        }

        //cap nhat don hang
        public bool CapNhatDonHang(string madh, int tongtien, int congno)
        {
            bool ketqua = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "update DonDH set TongTien = @tongtien, congnodh = @congno where madh = @madh";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);
                
                ketnoi.LenhKetNoi.Parameters.Add("@tongtien", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters["@tongtien"].Value = tongtien;
                ketnoi.LenhKetNoi.Parameters.Add("@congno", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters["@congno"].Value = congno;
                ketnoi.LenhKetNoi.Parameters.Add("@madh", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters["@madh"].Value = madh;


                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                    ketqua = true;
            }
            catch (Exception)
            {


            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ketqua;
        }

        //lay danh sach don hang chua xu ly
        public List<DTODonDatHang> LayDSDonHangDangXuLy()
        {
            List<DTODonDatHang> dsDonHang = new List<DTODonDatHang>();
            string lenh = "Select * from KhachHang kh, DonDH dh, LoaiKH lkh where dh.TrangThai=N'Đang Xử Lý' and kh.MaKH=dh.MaKH and lkh.MaLKH=kh.MaLKH";
            ketnoi.TaoKetNoi();
            DataTable bang = new DataTable();
            try
            {
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                foreach (DataRow dongDL in bang.Rows)
                {
                    DTODonDatHang dtoKH = new DTODonDatHang(dongDL);
                    dsDonHang.Add(dtoKH);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dsDonHang;
        }

        public List<DTODonDatHang> TimTheoma(int ma)
        {
            List<DTODonDatHang> dsTim = new List<DTODonDatHang>();
            string lenh = "Select * from KhachHang kh, DonDH dh where kh.MaKH=dh.MaKH and kh.MaKH = @maKH";
            ketnoi.TaoKetNoi();
            DataTable bang = new DataTable();
            try
            {
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);
                ketnoi.LenhKetNoi.Parameters.Add("@maKH", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters["@maKH"].Value = ma;

                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                foreach (DataRow dongDL in bang.Rows)
                {
                    DTODonDatHang dtoKH = new DTODonDatHang(dongDL);
                    dsTim.Add(dtoKH);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dsTim;
        }


        public DTODonDatHang LayDHTheoMa(string ma)
        {
            ketnoi.TaoKetNoi();
            DTODonDatHang dtoDH = null;
            try
            {
                string lenh = "Select * from KhachHang kh, DonDH dh, LoaiKH l where kh.MaKH=dh.MaKH and l.MaLKH=kh.MaLKH and dh.MaDH=@ma";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@ma", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters["@ma"].Value = ma;

                DataTable bang = new DataTable();
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                DataRow dong = bang.Rows[0];
                dtoDH = new DTODonDatHang(dong);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dtoDH;
        }

        public DTODonDatHang LayDonHangTraHang(string ma)
        {
            ketnoi.TaoKetNoi();
            DTODonDatHang dtoDH = null;
            try
            {
                string lenh = "Select * from KhachHang kh, DonDH dh, LoaiKH l where kh.MaKH=dh.MaKH and l.MaLKH=kh.MaLKH and dh.MaDH=@ma";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@ma", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters["@ma"].Value = ma;

                DataTable bang = new DataTable();
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                DataRow dong = bang.Rows[0];
                dtoDH = new DTODonDatHang(dong);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dtoDH;
        }

        //DAOThemCTDonHang

        public bool ThemChiTietDH(DTOChiTietDH dtoCtDH)
        {
            bool ketqua = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "insert into ChiTietDH(MaDH, MaSP, SoLuong, ThanhTien) values (@madh, @masp, @sl, @tt)";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@madh", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@masp", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@sl", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@tt", SqlDbType.Int);

                ketnoi.LenhKetNoi.Parameters["@madh"].Value = dtoCtDH.MaDH;
                ketnoi.LenhKetNoi.Parameters["@masp"].Value = dtoCtDH.dtoSP.MaSP;
                ketnoi.LenhKetNoi.Parameters["@sl"].Value = dtoCtDH.SoLuong;
                ketnoi.LenhKetNoi.Parameters["@tt"].Value = dtoCtDH.ThanhTien;


                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                    ketqua = true;
            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ketqua;
        }

        //cap nhat chi tiet don hang
        public bool CapNhatChiTietDH(DTOChiTietDH dtoCtDH)
        {
            bool ketqua = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "update ChiTietDH set SoLuong=@sl, ThanhTien=@tt where MaDH=@madh and MaSP=@masp";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@madh", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@masp", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@sl", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@tt", SqlDbType.Int);

                ketnoi.LenhKetNoi.Parameters["@madh"].Value = dtoCtDH.MaDH;
                ketnoi.LenhKetNoi.Parameters["@masp"].Value = dtoCtDH.MaSP;
                ketnoi.LenhKetNoi.Parameters["@sl"].Value = dtoCtDH.SoLuong;
                ketnoi.LenhKetNoi.Parameters["@tt"].Value = dtoCtDH.ThanhTien;


                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                    ketqua = true;
            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ketqua;
        }

        //lay chi tiet don hang theo ma don hang va ma san pham
        public DTOChiTietDH LayChiTietDonHangTheoMaDHMaSP(string ma, int masp)
        {
            DTOChiTietDH ctDH = new DTOChiTietDH();

            string lenh = "Select * from ChiTietDH ct, DonDH dh, KhachHang kh, SanPham sp, LoaiSP lsp, LoaiKH l where ct.MaDH = @madh and ct.maSP = @masp and kh.MaLKH=l.MaLKH and kh.MaKH=dh.MaKH and ct.MaDH=dh.MaDH and ct.MaSP=sp.MaSP and sp.MaLoai = lsp.MaLoai";
            //string lenh = "Select * from ChiTietDonDatHang ct,SanPham sp,LoaiSP lsp where MaDH = " + ma + " and ct.MaSP=sp.MaSP and lsp.MaLoai=lsp.MaLoai";
            //string lenh = "Select * from ChiTietDonDatHang where MaDH=" + ma + "";
            ketnoi.TaoKetNoi();
            DataTable bang = new DataTable();
            try
            {
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);
                ketnoi.LenhKetNoi.Parameters.Add("@madh", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters["@madh"].Value = ma;
                ketnoi.LenhKetNoi.Parameters.Add("@masp", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters["@masp"].Value = masp;
                //dong bo lenh ket noi voi du lieu trong database
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);

                ketnoi.TichHopCSDL.Fill(bang);
                if(bang.Rows.Count > 0)
                    ctDH = new DTOChiTietDH(bang.Rows[0]);
            }
            catch
            {
                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ctDH;
        }

        //lay danh sach chi tiet don hang
        public List<DTOChiTietDH> LayDSChiTietDH(string ma)
        {
            List<DTOChiTietDH> ds = new List<DTOChiTietDH>();

            string lenh = "Select * from ChiTietDH ct, DonDH dh, KhachHang kh, SanPham sp, LoaiSP lsp, LoaiKH l where ct.MaDH = @madh and kh.MaLKH=l.MaLKH and kh.MaKH=dh.MaKH and ct.MaDH=dh.MaDH and ct.MaSP=sp.MaSP and sp.MaLoai = lsp.MaLoai";
            //string lenh = "Select * from ChiTietDonDatHang ct,SanPham sp,LoaiSP lsp where MaDH = " + ma + " and ct.MaSP=sp.MaSP and lsp.MaLoai=lsp.MaLoai";
            //string lenh = "Select * from ChiTietDonDatHang where MaDH=" + ma + "";
            ketnoi.TaoKetNoi();
            DataTable bang = new DataTable();
            try
            {
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);
                ketnoi.LenhKetNoi.Parameters.Add("@madh", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters["@madh"].Value = ma;
                //dong bo lenh ket noi voi du lieu trong database
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                
                ketnoi.TichHopCSDL.Fill(bang);
                foreach (DataRow dongDL in bang.Rows)
                {
                    DTOChiTietDH dtoct = new DTOChiTietDH(dongDL);
                    ds.Add(dtoct);
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ds;
        }
        public DTOSanPham LayGiaSPTheoMa(int ma)
        {
            ketnoi.TaoKetNoi();
            DTOSanPham dtoDH = null;
            try
            {
                string lenh = "Select * from SanPham sp, LoaiSP l where sp.MaLoai=l.MaLoai and MaSP=@ma";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@ma", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters["@ma"].Value = ma;

                DataTable bang = new DataTable();
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                DataRow dong = bang.Rows[0];
                dtoDH = new DTOSanPham(dong);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dtoDH;
        }

        public DTOChiTietDonHang LayTongTien(int ma)
        {
            ketnoi.TaoKetNoi();
            DTOChiTietDonHang dtoDH = null;
            try
            {
                string lenh = "Select MaDH,sum(ThanhTien) as ThanhTien from ChiTietDH where MaDH = " + ma + " GROUP BY MaDH ";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                DataTable bang = new DataTable();
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                DataRow dong = bang.Rows[0];
                dtoDH = new DTOChiTietDonHang(dong);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dtoDH;
        }

        //DAOThanhToanBH
        public bool CapNhatTongTien(DTODonDatHang dtoDH)
        {
            bool ketqua = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "update DonDH set TongTien = @tt, CongNoDH = @cc where MaDH=@ma";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@ma", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@tt", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@cc", SqlDbType.Int);

                ketnoi.LenhKetNoi.Parameters["@ma"].Value = dtoDH.MaDH;
                ketnoi.LenhKetNoi.Parameters["@tt"].Value = dtoDH.TongTien;
                ketnoi.LenhKetNoi.Parameters["@cc"].Value = dtoDH.CongNoDH;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                    ketqua = true;
            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ketqua;
        }
        
        public bool ThemThanhToan(DTOThanhToan dtott)
        {
            bool ketqua = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "insert into ThanhToan(MaDH, MaNV, NgayThanhToan, Sotien, HanTT) values (@madh, @manv, @ngaytt, @st, @hantt)";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@madh", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@manv", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@ngaytt", SqlDbType.DateTime);
                ketnoi.LenhKetNoi.Parameters.Add("@hantt", SqlDbType.DateTime);
                ketnoi.LenhKetNoi.Parameters.Add("@st", SqlDbType.Int);

                ketnoi.LenhKetNoi.Parameters["@madh"].Value = dtott.MaDH;
                ketnoi.LenhKetNoi.Parameters["@manv"].Value = dtott.MaNV;
                ketnoi.LenhKetNoi.Parameters["@ngaytt"].Value = dtott.NgayThanhToan;
                ketnoi.LenhKetNoi.Parameters["@st"].Value = dtott.Sotien;
                ketnoi.LenhKetNoi.Parameters["@hantt"].Value = dtott.HanTT;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                    ketqua = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ketqua;
        }
        //DAO Quan ly cong no
        public bool CapNhatCongNo(DTODonDatHang dtoDH)
        {
            bool ketqua = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "update DonDH set CongNoDH = @cc where MaDH=@ma";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@ma", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@cc", SqlDbType.Int);

                ketnoi.LenhKetNoi.Parameters["@ma"].Value = dtoDH.MaDH;
                ketnoi.LenhKetNoi.Parameters["@cc"].Value = dtoDH.CongNoDH;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                    ketqua = true;
            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ketqua;
        }
        public bool CapNhatTrangThaisauThanhToan(DTODonDatHang dtoDH)
        {
            bool ketqua = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "update DonDH set TrangThai=N'Đóng' where MaDH=@ma";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@ma", SqlDbType.VarChar);

                ketnoi.LenhKetNoi.Parameters["@ma"].Value = dtoDH.MaDH;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                    ketqua = true;
            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ketqua;
        }


        public List<DTODSDonHang> LayDSCongNoBH()
        {
            List<DTODSDonHang> ds = new List<DTODSDonHang>();

            string lenh = "Select * from DonDH dh, KhachHang kh, LoaiKH l, ThanhToan tt where dh.MaDH=tt.MaDH and dh.CongNoDH > 0 and dh.TrangThai!=N'Đóng' and dh.MaKH=kh.MaKH and kh.MaLKH=l.MaLKH";

            ketnoi.TaoKetNoi();
            DataTable bang = new DataTable();
            try
            {
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);
                //dong bo lenh ket noi voi du lieu trong database
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                foreach (DataRow dongDL in bang.Rows)
                {
                    DTODSDonHang dtoct = new DTODSDonHang(dongDL);
                    ds.Add(dtoct);
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ds;
        }


        public bool ThemCongNoBH(DTOCongNoBanHang dtocn)
        {
            bool ketqua = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "insert into CongNoBanHang(MaDH, MaKH, MaNV, NgayTraNo, TienTT) values (@madh, @makh, @manv, @ngaytt, @st)";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@madh", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@makh", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@manv", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@ngaytt", SqlDbType.DateTime);
                ketnoi.LenhKetNoi.Parameters.Add("@st", SqlDbType.Decimal);

                ketnoi.LenhKetNoi.Parameters["@madh"].Value = dtocn.MaDH;
                ketnoi.LenhKetNoi.Parameters["@makh"].Value = dtocn.MaKH;
                ketnoi.LenhKetNoi.Parameters["@manv"].Value = dtocn.MaNV;
                ketnoi.LenhKetNoi.Parameters["@ngaytt"].Value = dtocn.NgayTraNo;
                ketnoi.LenhKetNoi.Parameters["@st"].Value = dtocn.TienTT;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                    ketqua = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ketqua;
        }

        #endregion

        //DAOLayThongTinSua
        public DTOUser LayTTNDTheoMa(string maSua)
        {
            ketnoi.TaoKetNoi();
            DTOUser dtond = null;
            try
            {
                string lenh = "select ND.TenDN, ND.MatKhau, ND.HoTenuser, NQ.NhomQuyen from NguoiDung ND, NhomQuyen NQ where ND.MaDN = @madn ND.MaNhomQ = NQ.MaNhomQ";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@madn", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters["@madn"].Value = maSua;

                DataTable bang = new DataTable();
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                DataRow dong = bang.Rows[0];
                dtond = new DTOUser(dong);
            }
            catch (Exception)
            {


            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dtond;
        }
        public List<DTONhomQuyen> LayDSNhomQ()
        {
            List<DTONhomQuyen> dsNhomQ = new List<DTONhomQuyen>();
            string lenh = "select * from NhomQuyen";
            ketnoi.TaoKetNoi();
            DataTable bang = new DataTable();
            try
            {
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                foreach (DataRow dongDL in bang.Rows)
                {
                    DTONhomQuyen dtoNhomQ = new DTONhomQuyen(dongDL);
                    dsNhomQ.Add(dtoNhomQ);
                }
            }
            catch (Exception)
            {


            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dsNhomQ;
        }
        //DAOLoaiKH
        public List<DTOLoaiKH> TaoDSLKH()
        {
            List<DTOLoaiKH> dsloaikh = new List<DTOLoaiKH>();
            string lenh = "select * from LoaiKH";
            ketnoi.TaoKetNoi();
            DataTable bang = new DataTable();
            try
            {
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                foreach (DataRow dongDL in bang.Rows)
                {
                    DTOLoaiKH dtoloaikh = new DTOLoaiKH(dongDL);
                    dsloaikh.Add(dtoloaikh);
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dsloaikh;
        }

        //Them LoaiKH
        public bool ThemLoaiKH(DTOLoaiKH dtoloaikh)
        {
            bool kq = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = " insert into LoaiKH (TenLKH) values (@tenlkh)";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                //ketnoi.LenhKetNoi.Parameters.Add("@malkh", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@tenlkh", SqlDbType.NVarChar);


                //ketnoi.LenhKetNoi.Parameters["@malkh"].Value = dtoloaikh.MaLKH;
                ketnoi.LenhKetNoi.Parameters["@tenlkh"].Value = dtoloaikh.TenLKH;


                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                {
                    kq = true;

                }

            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return kq;
        }

        //Sua LoaiKH
        public bool SuaLoaiKH(DTOLoaiKH dtoloaikh)
        {
            bool kq = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "update LoaiKH set TenLKH = @tenlkh where MaLKH=@malkh ";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@malkh", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@tenlkh", SqlDbType.NVarChar);

                ketnoi.LenhKetNoi.Parameters["@malkh"].Value = dtoloaikh.MaLKH;
                ketnoi.LenhKetNoi.Parameters["@tenlkh"].Value = dtoloaikh.TenLKH;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                {
                    kq = true;
                }
            }
            catch (Exception)
            { }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return kq;
        }
        //Xoa LoaiKH
        public bool XoaLoaiKH(DTOLoaiKH dtoloaikh)
        {
            bool kq = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "delete from LoaiKH where MaLKH = @malkh";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@malkh", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters["@malkh"].Value = dtoloaikh.MaLKH;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                {
                    kq = true;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return kq;
        }

        public DTOLoaiKH LayThongTinLoaiKH(string maSua)
        {
            ketnoi.TaoKetNoi();
            DTOLoaiKH dtoloaikh = null;
            try
            {
                string lenh = "select * from LoaiKH where MaLKH = @maSua ";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@maSua", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters["@maSua"].Value = maSua;
                ;

                DataTable bang = new DataTable();
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                DataRow dong = bang.Rows[0];
                dtoloaikh = new DTOLoaiKH(dong);

            }
            catch (Exception)
            { }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dtoloaikh;
        }
        //DAOLoaiSanPham
        //Tao danh sach
        public List<DTOLoaiSP> TaoDSLSP()
        {
            List<DTOLoaiSP> dsloaisp = new List<DTOLoaiSP>();
            string lenh = "select * from LoaiSP";
            ketnoi.TaoKetNoi();
            DataTable bang = new DataTable();
            try
            {
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                foreach (DataRow dongDL in bang.Rows)
                {
                    DTOLoaiSP dtoloaisp = new DTOLoaiSP(dongDL);
                    dsloaisp.Add(dtoloaisp);
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dsloaisp;
        }

        //Them LoaiKH
        public bool ThemLoaiSP(DTOLoaiSP dtoloaisp)
        {
            bool kq = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = " insert into LoaiSP(TenLoai) values (@tenlsp)";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                //ketnoi.LenhKetNoi.Parameters.Add("@malkh", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@tenlsp", SqlDbType.NVarChar);


                //ketnoi.LenhKetNoi.Parameters["@malkh"].Value = dtoloaikh.MaLKH;
                ketnoi.LenhKetNoi.Parameters["@tenlsp"].Value = dtoloaisp.TenLSP;


                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                {
                    kq = true;

                }

            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return kq;
        }

        //Sua LoaiKH
        public bool SuaLoaiSP(DTOLoaiSP dtoloaisp)
        {
            bool kq = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "update LoaiSP set TenLoai=@tenlsp where MaLoai=@malsp ";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@malsp", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@tenlsp", SqlDbType.NVarChar);

                ketnoi.LenhKetNoi.Parameters["@malsp"].Value = dtoloaisp.MaLSP;
                ketnoi.LenhKetNoi.Parameters["@tenlsp"].Value = dtoloaisp.TenLSP;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                {
                    kq = true;
                }
            }
            catch (Exception)
            { }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return kq;
        }
        //Xoa LoaiKH
        public bool XoaLoaiSP(DTOLoaiSP dtoloaisp)
        {
            bool kq = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "delete from LoaiSP where MaLoai = @malsp";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@malsp", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters["@malsp"].Value = dtoloaisp.MaLSP;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                {
                    kq = true;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return kq;
        }

        public DTOLoaiSP LayThongTinLoaiSP(string maSua)
        {
            ketnoi.TaoKetNoi();
            DTOLoaiSP dtoloaisp = null;
            try
            {
                string lenh = "select * from LoaiSP where MaLoai = @maSua ";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@maSua", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters["@maSua"].Value = maSua;

                DataTable bang = new DataTable();
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                DataRow dong = bang.Rows[0];
                dtoloaisp = new DTOLoaiSP(dong);

            }
            catch (Exception)
            { }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dtoloaisp;
        }
        //DAONguoiDung
        public List<DTOUser> TaoDSUser()
        {
            List<DTOUser> ds = new List<DTOUser>();
            string lenh = "Select * from User ND, NhomQuyen NQ where ND.MaNhomQ=NQ.MaNhomQ";
            ketnoi.TaoKetNoi();
            DataTable bang = new DataTable();
            try
            {
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);
                //dong bo lenh ket noi voi du lieu trong database
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                foreach (DataRow dongDL in bang.Rows)
                {
                    DTOUser dtond = new DTOUser(dongDL);
                    ds.Add(dtond);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ds;
        }


        public bool ThemUser(DTOUser dtond)
        {
            bool ketqua = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "insert into User(IDUser, MatKhau, HoTenUser, MaNhomQ) values (@id, @mk, @ht, @manq)";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@id", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@mk", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@ht", SqlDbType.NVarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@manq", SqlDbType.Int);

                ketnoi.LenhKetNoi.Parameters["@id"].Value = dtond.ID;
                ketnoi.LenhKetNoi.Parameters["@mk"].Value = dtond.MK;
                ketnoi.LenhKetNoi.Parameters["@ht"].Value = dtond.HTuser;
                ketnoi.LenhKetNoi.Parameters["@manq"].Value = dtond.dtoNhomQ.MaNQ;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                    ketqua = true;
            }
            catch (Exception)
            {


            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ketqua;
        }

        // Sua TT User
        public bool SuaUser(DTOUser dtond)
        {
            bool ketqua = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "update User set MatKhau= @mk, HoTenUser = @ht, MaNhomQ = @manq where IDUser=@id";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@id", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@mk", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@ht", SqlDbType.NVarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@manq", SqlDbType.Int);

                ketnoi.LenhKetNoi.Parameters["@id"].Value = dtond.ID;
                ketnoi.LenhKetNoi.Parameters["@mk"].Value = dtond.MK;
                ketnoi.LenhKetNoi.Parameters["@ht"].Value = dtond.HTuser;
                ketnoi.LenhKetNoi.Parameters["@manq"].Value = dtond.dtoNhomQ.MaNQ;//@malkh thi phai gan vao "MaLKH", sao lai gan cho dtoLoaiKh

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                    ketqua = true;
            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ketqua;
        }

        public DTOUser LayTTUserTheoMa(string maSua)
        {
            ketnoi.TaoKetNoi();
            DTOUser dtond = null;
            try
            {
                string lenh = "select NQ.MaNhomQ,NQ.NhomQuyen,ND.IDUser,ND.MatKhau,ND.HoTenUser from User ND,NhomQuyen NQ where ND.IDUser = @id and NQ.MaNhomQ=ND.MaNhomQ ";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@id", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters["@id"].Value = maSua;

                DataTable bang = new DataTable();
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                DataRow dong = bang.Rows[0];
                dtond = new DTOUser(dong);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dtond;
        }

        //Lay thong tin Nhóm Quyền do vao ListBox 29/03/2015
        //public List<DTONhomQuyen> LayDSNhomQuyen()
        //{
        //    List<DTONhomQuyen> ds = new List<DTONhomQuyen>();
        //    string lenh = "select * from NhomQuyen";
        //    ketnoi.TaoKetNoi();
        //    DataTable bang = new DataTable();
        //    try
        //    {
        //        ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);
        //        ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
        //        ketnoi.TichHopCSDL.Fill(bang);
        //        foreach (DataRow dongDL in bang.Rows)
        //        {
        //            DTONhomQuyen dtonq = new DTONhomQuyen(dongDL);
        //            ds.Add(dtonq);
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    finally
        //    {
        //        ketnoi.DongKetNoi();
        //    }
        //    return ds;
        //}

        public List<DTOUser> TimTheoTenUser(string tenTim)
        {
            List<DTOUser> dsTim = new List<DTOUser>();
            string lenh = "select * from User U, NhomQuyen NQ where U.MaNhomQ = NQ.MaNhomQ and U.HoTenUser like @ht";
            ketnoi.TaoKetNoi();
            DataTable bang = new DataTable();
            try
            {
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);
                ketnoi.LenhKetNoi.Parameters.Add("@ht", SqlDbType.NVarChar);
                ketnoi.LenhKetNoi.Parameters["@ht"].Value = "%" + tenTim + "%";

                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                foreach (DataRow dongDL in bang.Rows)
                {
                    DTOUser dtond = new DTOUser(dongDL);
                    dsTim.Add(dtond);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dsTim;
        }
        public void Kiemtra()
        {

        }
        //DAO Nha Cung Cap
        //Lay du lieu tu Database hien thi ra bang
        public DataTable LayDLNCC()
        {
            string lenh = "select * from NhaCungCap ";
            ketnoi.TaoKetNoi();
            DataTable bang = new DataTable();
            try
            {
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return bang;
        }
        // Tao danh sach 
        public List<DTONhacungcap> TaoDSNCC()
        {
            List<DTONhacungcap> dsncc = new List<DTONhacungcap>();
            string lenh = "select * from NhaCungCap";
            ketnoi.TaoKetNoi();
            DataTable bang = new DataTable();
            try
            {
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                foreach (DataRow dongDL in bang.Rows)
                {
                    DTONhacungcap dtoncc = new DTONhacungcap(dongDL);
                    dsncc.Add(dtoncc);
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dsncc;

        }

        //ThemNCC
        public bool ThemNhaCungCap(DTONhacungcap dtoNCC)
        {
            bool kq = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = " insert into NhaCungCap (TenNCC ,Sdt ,Diachi) values (@tenncc ,@sdt ,@diachi)";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                //ketnoi.LenhKetNoi.Parameters.Add("@mancc", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@tenncc", SqlDbType.NVarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@sdt", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@diachi", SqlDbType.NVarChar);


                // ketnoi.LenhKetNoi.Parameters["@mancc"].Value = dtoNCC.MaNCC;
                ketnoi.LenhKetNoi.Parameters["@tenncc"].Value = dtoNCC.TenNCC;
                ketnoi.LenhKetNoi.Parameters["@sdt"].Value = dtoNCC.Sdt;
                ketnoi.LenhKetNoi.Parameters["@diachi"].Value = dtoNCC.Diachi;


                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                {
                    kq = true;

                }

            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return kq;
        }
        public bool capnhatdanhsach(DTONhacungcap dtoNCC)
        {
            bool kq = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "update NhaCungCap set TenNCC = @tenncc, Sdt = @sdt ,Diachi= @diachi where MaNCC= @mancc";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@mancc", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@tenncc", SqlDbType.NVarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@sdt", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@diachi", SqlDbType.NVarChar);

                ketnoi.LenhKetNoi.Parameters["@mancc"].Value = dtoNCC.MaNCC;
                ketnoi.LenhKetNoi.Parameters["@tenncc"].Value = dtoNCC.TenNCC;
                ketnoi.LenhKetNoi.Parameters["@sdt"].Value = dtoNCC.Sdt;
                ketnoi.LenhKetNoi.Parameters["@diachi"].Value = dtoNCC.Diachi;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                {
                    kq = true;
                }
            }
            catch (Exception)
            { }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return kq;

        }
        public bool XoaVatLieu(DTONhacungcap dtoNCC)
        {
            bool kq = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "delete from NhaCungCap where MaNCC = @mancc";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@mancc", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters["@mancc"].Value = dtoNCC.MaNCC;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                {
                    kq = true;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return kq;
        }

        public DTONhacungcap LayThongTinNhaCungCap(string maSua)
        {
            ketnoi.TaoKetNoi();
            DTONhacungcap dtoNCC = null;
            try
            {
                string lenh = "select * from NhaCungCap where MaNCC = @maSua ";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@maSua", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters["@maSua"].Value = maSua;

                DataTable bang = new DataTable();
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                DataRow dong = bang.Rows[0];
                dtoNCC = new DTONhacungcap(dong);

            }
            catch (Exception)
            { }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dtoNCC;
        }
        //DAOSanPham
        //Lay du lieu tu database hien thi ra bang
        public DataTable LayDLSP()
        {
            string lenh = "select * from SanPham";
            ketnoi.TaoKetNoi();
            DataTable bang = new DataTable();
            try
            {
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi); //???
                ketnoi.TichHopCSDL.Fill(bang);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return bang;
        }

        //Tao danh sach san pham
        public List<DTO.DTOSanPham> TaoDSSP()
        {
            List<DTO.DTOSanPham> dssp = new List<DTOSanPham>();
            string lenh = "select * from SanPham, LoaiSP where SanPham.maloai = loaiSP.maloai";
            ketnoi.TaoKetNoi();
            DataTable bang = new DataTable();
            try
            {
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                foreach (DataRow dongDL in bang.Rows)
                {
                    DTO.DTOSanPham dtosp = new DTO.DTOSanPham(dongDL);
                    dssp.Add(dtosp);

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dssp;
        }

        //Them sp
        public bool ThemSanPham(DTOSanPham dtoSP)
        {
            bool ketqua = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "insert into SanPham(MaSP, TenSP, LoaiSP, GiaSP) values(@masp, @tensp, @loaisp, @giasp)";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@masp", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@tensp", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@loaisp", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@giasp", SqlDbType.VarChar);

                ketnoi.LenhKetNoi.Parameters["@masp"].Value = dtoSP.MaSP;
                ketnoi.LenhKetNoi.Parameters["@tensp"].Value = dtoSP.TenSP;
                ketnoi.LenhKetNoi.Parameters["@loaisp"].Value = dtoSP.dtoLoaiSP;
                ketnoi.LenhKetNoi.Parameters["@giasp"].Value = dtoSP.Gia;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                    ketqua = true;
            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ketqua;
        }

        //Lấy TT loai sp do vao listbox
        public List<DTOLoaiSP> LayDSLSP()
        {
            List<DTOLoaiSP> dsLSP = new List<DTOLoaiSP>();
            string lenh = "select * from LoaiSP";
            ketnoi.TaoKetNoi();
            DataTable bang = new DataTable();
            try
            {
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                foreach (DataRow dongDL in bang.Rows)
                {
                    DTOLoaiSP dtoLSP = new DTOLoaiSP(dongDL);
                    dsLSP.Add(dtoLSP);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dsLSP;
        }

        public List<DTOSanPham> TimTheoTenSP(string tenTim)
        {
            List<DTOSanPham> dsTim = new List<DTOSanPham>();
            string lenh = "Select * from SanPham SP, LoaiSP LSP where SP.MaLoai=LSP.MaLoai and SP.TenSP like @tenSP";
            ketnoi.TaoKetNoi();
            DataTable bang = new DataTable();
            try
            {
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);
                ketnoi.LenhKetNoi.Parameters.Add("@tenSP", SqlDbType.NVarChar);
                ketnoi.LenhKetNoi.Parameters["@tenSP"].Value = "%" + tenTim + "%";

                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                foreach (DataRow dongDL in bang.Rows)
                {
                    DTOSanPham dtoSP = new DTOSanPham(dongDL);
                    dsTim.Add(dtoSP);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dsTim;
        }

        public DTOSanPham TimTheoMaSP(int maSP)
        {
            DTOSanPham dtoSP = new DTOSanPham();
            string lenh = "Select * from SanPham SP, LoaiSP LSP where SP.MaLoai=LSP.MaLoai and SP.MaSP = @masp";
            ketnoi.TaoKetNoi();
            DataTable bang = new DataTable();
            try
            {
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);
                ketnoi.LenhKetNoi.Parameters.Add("@masp", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters["@masp"].Value = maSP;

                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                dtoSP = new DTOSanPham(bang.Rows[0]);
            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dtoSP;
        }
        //DAOTrangThai
        //Tao danh sach
        public List<DTOTrangThai> TaoDSTT()
        {
            List<DTOTrangThai> dstt = new List<DTOTrangThai>();
            string lenh = "select * from TrangThai";
            ketnoi.TaoKetNoi();
            DataTable bang = new DataTable();
            try
            {
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                foreach (DataRow dongDL in bang.Rows)
                {
                    DTOTrangThai dtott = new DTOTrangThai(dongDL);
                    dstt.Add(dtott);
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dstt;
        }

        //Them LoaiKH
        public bool ThemTT(DTOTrangThai dtott)
        {
            bool kq = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = " insert into TrangThai(TenTT) values (@tentt)";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@tentt", SqlDbType.NVarChar);

                ketnoi.LenhKetNoi.Parameters["@tentt"].Value = dtott.TenTT;


                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                {
                    kq = true;

                }

            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return kq;
        }

        //Sua LoaiKH
        public bool SuaTT(DTOTrangThai dtott)
        {
            bool kq = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "update TrangThai set TenTT=@tentt where MaTT=@matt ";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@matt", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@tentt", SqlDbType.NVarChar);

                ketnoi.LenhKetNoi.Parameters["@matt"].Value = dtott.MaTT;
                ketnoi.LenhKetNoi.Parameters["@tentt"].Value = dtott.TenTT;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                {
                    kq = true;
                }
            }
            catch (Exception)
            { }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return kq;
        }
        //Xoa LoaiKH
        public bool XoaTT(DTOTrangThai dtott)
        {
            bool kq = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "delete from TrangThai where MaTT = @matt";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@matt", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters["@matt"].Value = dtott.MaTT;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                {
                    kq = true;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return kq;
        }

        public DTOTrangThai LayThongTinTT(string maSua)
        {
            ketnoi.TaoKetNoi();
            DTOTrangThai dtott = null;
            try
            {
                string lenh = "select * from TrangThai where MaTT = @maSua ";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@maSua", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters["@maSua"].Value = maSua;

                DataTable bang = new DataTable();
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                DataRow dong = bang.Rows[0];
                dtott = new DTOTrangThai(dong);

            }
            catch (Exception)
            { }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dtott;
        }
        //DAOUser_VatLieu
        //Lay du lieu tu Database hien thi ra bang
        public DataTable LayDLVL()
        {
            string lenh = "select * from VatLieu ";
            ketnoi.TaoKetNoi();
            DataTable bang = new DataTable();
            try
            {
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return bang;
        }
        // Tao danh sach Vat Lieu
        public List<DTOVatLieu> TaoDSVL()
        {
            List<DTOVatLieu> ds = new List<DTOVatLieu>();
            string lenh = "select * from VatLieu VL ,NhaCungCap NCC where VL.MaNCC = NCC.MaNCC";
            ketnoi.TaoKetNoi();
            DataTable bang = new DataTable();
            try
            {
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                foreach (DataRow dongDL in bang.Rows)
                {
                    DTOVatLieu dtovl = new DTOVatLieu(dongDL);
                    ds.Add(dtovl);
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ds;

        }

        //ThemVL
        public bool ThemVatLieu(DTOVatLieu dtoVL)
        {
            bool kq = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = " insert into VatLieu (TenVL ,MaNCC ,Donvi ,Gia, SoLuong) values (@tenvl ,@mancc ,@donvi ,@gia, @sl)";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                //ketnoi.LenhKetNoi.Parameters.Add("@maVL", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@tenvl", SqlDbType.NVarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@mancc", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@donvi", SqlDbType.NVarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@gia", SqlDbType.Decimal);
                ketnoi.LenhKetNoi.Parameters.Add("@sl", SqlDbType.Int);

                //ketnoi.LenhKetNoi.Parameters["@maVL"].Value = dtoVL.MaVL;
                ketnoi.LenhKetNoi.Parameters["@tenvl"].Value = dtoVL.TenVL;
                ketnoi.LenhKetNoi.Parameters["@mancc"].Value = dtoVL.dtoNCC.MaNCC;
                ketnoi.LenhKetNoi.Parameters["@donvi"].Value = dtoVL.Donvi;
                ketnoi.LenhKetNoi.Parameters["@gia"].Value = dtoVL.Gia;
                ketnoi.LenhKetNoi.Parameters["@sl"].Value = dtoVL.Soluong;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                {
                    kq = true;

                }

            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return kq;
        }
        public bool capnhatdanhsach(DTOVatLieu dtoVL)
        {
            bool kq = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "update VatLieu set TenVL = @tenvl , MaNCC = @mancc , Donvi = @donvi ,Gia = @gia where MaVL = @maVL";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@maVL", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@tenvl", SqlDbType.NVarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@mancc", SqlDbType.Int);//mancc
                ketnoi.LenhKetNoi.Parameters.Add("@donvi", SqlDbType.NVarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@gia", SqlDbType.Decimal);
                ketnoi.LenhKetNoi.Parameters.Add("@sl", SqlDbType.Int);

                ketnoi.LenhKetNoi.Parameters["@maVL"].Value = dtoVL.MaVL;
                ketnoi.LenhKetNoi.Parameters["@tenvl"].Value = dtoVL.TenVL;
                ketnoi.LenhKetNoi.Parameters["@mancc"].Value = dtoVL.dtoNCC.MaNCC;
                ketnoi.LenhKetNoi.Parameters["@donvi"].Value = dtoVL.Donvi;
                ketnoi.LenhKetNoi.Parameters["@gia"].Value = dtoVL.Gia;
                ketnoi.LenhKetNoi.Parameters["@sl"].Value = dtoVL.Soluong;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                {
                    kq = true;
                }
            }
            catch (Exception)
            { }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return kq;

        }
        public bool XoaVatLieu(DTOVatLieu dtoVL)
        {
            bool kq = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "delete from VatLieu where MaVL = @mavl";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@mavl", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters["@mavl"].Value = dtoVL.MaVL;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                {
                    kq = true;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return kq;
        }

        public DTOVatLieu LayThongTinVatLieu(string maSua)
        {
            ketnoi.TaoKetNoi();
            DTOVatLieu dtoVL = null;
            try
            {
                string lenh = "select * from VatLieu,NhaCungCap  where MaVL = @maSua and VatLieu.MaNCC = NhaCungCap.MaNCC ";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@maSua", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters["@maSua"].Value = maSua;

                DataTable bang = new DataTable();
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                DataRow dong = bang.Rows[0];
                dtoVL = new DTOVatLieu(dong);

            }
            catch (Exception)
            { }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dtoVL;
        }

        public List<DTONhacungcap> LayDSNCC()
        {
            List<DTONhacungcap> dsNCC = new List<DTONhacungcap>();
            string lenh = "select * from NhaCungCap";
            ketnoi.TaoKetNoi();
            DataTable bang = new DataTable();
            try
            {
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                foreach (DataRow dongDL in bang.Rows)
                {
                    DTONhacungcap dtoNCC = new DTONhacungcap(dongDL);
                    dsNCC.Add(dtoNCC);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dsNCC;
        }
    //   DAOCongNoNCC

        public List<DTOPhieuDatVatLieuCC> LayDSCongNoNCC()
        {
            List<DTOPhieuDatVatLieuCC> ds = new List<DTOPhieuDatVatLieuCC>();

            string lenh = "Select * from PDVL_CC vl, NhaCungCap ncc where vl.MaNCC=ncc.MaNCC and vl.CongNoNCC>0";

            ketnoi.TaoKetNoi();
            DataTable bang = new DataTable();
            try
            {
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);
                //dong bo lenh ket noi voi du lieu trong database
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                foreach (DataRow dongDL in bang.Rows)
                {
                    DTOPhieuDatVatLieuCC dtoct = new DTOPhieuDatVatLieuCC(dongDL);
                    ds.Add(dtoct);
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ds;
        }


        public bool ThemCongNoNCC(DTOCongNoVatLieu dtocn)
        {
            bool ketqua = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "insert into CongNoVatLieu(MaPDVLCC, MaNCC, MaNV, NgayTraNo, Sotien) values (@mapd, @macc, @manv, @ngaytt, @st)";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                //ketnoi.LenhKetNoi.Parameters.Add("@macn", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@mapd", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@macc", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@manv", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@ngaytt", SqlDbType.DateTime);
                ketnoi.LenhKetNoi.Parameters.Add("@st", SqlDbType.Int);

              //  ketnoi.LenhKetNoi.Parameters["@macn"].Value = dtocn.MaCNVL;
                ketnoi.LenhKetNoi.Parameters["@mapd"].Value = dtocn.MaPDVLCC;
                ketnoi.LenhKetNoi.Parameters["@macc"].Value = dtocn.MaNCC;
                ketnoi.LenhKetNoi.Parameters["@manv"].Value = dtocn.MaNV;
                ketnoi.LenhKetNoi.Parameters["@ngaytt"].Value = dtocn.NgayTraNo;
                ketnoi.LenhKetNoi.Parameters["@st"].Value = dtocn.Sotien;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                    ketqua = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ketqua;
        }

        public DTOPhieuDatVatLieuCC LayTTPhieuDatTheoMa(string ma)
        {
            ketnoi.TaoKetNoi();
            DTOPhieuDatVatLieuCC dtoDH = null;
            try
            {
                string lenh = "Select * from PDVL_CC pd, NhaCungCap ncc where ncc.MaNCC=pd.MaNCC and pd.MaPDVLCC = @ma ";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@ma", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters["@ma"].Value = ma;

                DataTable bang = new DataTable();
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                DataRow dong = bang.Rows[0];
                dtoDH = new DTOPhieuDatVatLieuCC(dong);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dtoDH;
        }

        public bool CapNhatCongNoNCC(DTOPhieuDatVatLieuCC dtoPD)
        {
            bool ketqua = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "update PDVL_CC set CongNoNCC = @cc where MaPDVLCC=@ma";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@ma", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@cc", SqlDbType.Int);

                ketnoi.LenhKetNoi.Parameters["@ma"].Value = dtoPD.MaPDVLCC;
                ketnoi.LenhKetNoi.Parameters["@cc"].Value = dtoPD.CongNoNCC;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                    ketqua = true;
            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ketqua;
        }

        public List<DTOXuLyPhieuGiao> LayDSPhieuGiao(string ma)
        {
            List<DTOXuLyPhieuGiao> ds = new List<DTOXuLyPhieuGiao>();

            string lenh = "Select * from XuLyPhieuGiao ct, DonDH dh, KhachHang kh, SanPham sp, LoaiSP lsp, LoaiKH l where dh.MaDH=" + ma + " and kh.MaLKH=l.MaLKH and kh.MaKH=dh.MaKH and ct.MaDH=dh.MaDH and ct.MaSP=sp.MaSP and sp.MaLoai = lsp.MaLoai";
            ketnoi.TaoKetNoi();
            DataTable bang = new DataTable();
            try
            {
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);
                //dong bo lenh ket noi voi du lieu trong database
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                foreach (DataRow dongDL in bang.Rows)
                {
                    DTOXuLyPhieuGiao dtoct = new DTOXuLyPhieuGiao(dongDL);
                    ds.Add(dtoct);
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ds;
        }
        public List<DTOXLSC_HDBH> LayDSXLSL_HDBH(string ma)
        {
            List<DTOXLSC_HDBH> ds = new List<DTOXLSC_HDBH>();

            string lenh = "Select * from XLSC_HDBH ct, DonDH dh, KhachHang kh, SanPham sp, LoaiSP lsp, LoaiKH l where dh.MaDH=" + ma + " and kh.MaLKH=l.MaLKH and kh.MaKH=dh.MaKH and ct.MaDH=dh.MaDH and ct.MaSP=sp.MaSP and sp.MaLoai = lsp.MaLoai";
            ketnoi.TaoKetNoi();
            DataTable bang = new DataTable();
            try
            {
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);
                //dong bo lenh ket noi voi du lieu trong database
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                foreach (DataRow dongDL in bang.Rows)
                {
                    DTOXLSC_HDBH dtoct = new DTOXLSC_HDBH(dongDL);
                    ds.Add(dtoct);
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ds;
        }
        public List<DTOKhoSP> LayDSKhoSP()
        {
            List<DTOKhoSP> ds = new List<DTOKhoSP>();

            string lenh = "Select * from KhoSP k, SanPham sp, LoaiSP l where sp.MaLoai=l.MaLoai and k.MaSP=sp.MaSP";

            ketnoi.TaoKetNoi();
            DataTable bang = new DataTable();
            try
            {
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);
                //dong bo lenh ket noi voi du lieu trong database
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                foreach (DataRow dongDL in bang.Rows)
                {
                    DTOKhoSP dtoct = new DTOKhoSP(dongDL);
                    ds.Add(dtoct);
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ds;
        }
        public bool CapNhatSLKhoSP(DTOKhoSP dtoKho)
        {
            bool ketqua = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "update KhoSP set Soluong = @sl where MaSP=@ma";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@ma", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@sl", SqlDbType.Int);

                ketnoi.LenhKetNoi.Parameters["@ma"].Value = dtoKho.MaSP;
                ketnoi.LenhKetNoi.Parameters["@sl"].Value = dtoKho.Soluong;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                    ketqua = true;
            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ketqua;
        }

        public bool CapNhatSLChiTietDH(DTOChiTietDH dto)
        {
            bool ketqua = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "update ChiTietDH set SoLuong = @sl where MaSP=@ma";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@ma", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@sl", SqlDbType.Int);

                ketnoi.LenhKetNoi.Parameters["@ma"].Value = dto.MaSP;
                ketnoi.LenhKetNoi.Parameters["@sl"].Value = dto.SoLuong;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                    ketqua = true;
            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ketqua;
        }
        public bool ThemPhieuGiaoHang(DTOXuLyPhieuGiao dtoCtDH)
        {
            bool ketqua = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "insert into XuLyPhieuGiao(MaDH, MaSP, SoLuong, ThanhTien) values (@madh, @masp, @sl, @tt)";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@madh", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@masp", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@sl", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@tt", SqlDbType.Int);

                ketnoi.LenhKetNoi.Parameters["@madh"].Value = dtoCtDH.MaDH;
                ketnoi.LenhKetNoi.Parameters["@masp"].Value = dtoCtDH.MaSP;
                ketnoi.LenhKetNoi.Parameters["@sl"].Value = dtoCtDH.SoLuong;
                ketnoi.LenhKetNoi.Parameters["@tt"].Value = dtoCtDH.ThanhTien;


                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                    ketqua = true;
            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ketqua;
        }

        public DTOSanPhamCT LayGiaSPTheoMaCT(int ma)
        {
            ketnoi.TaoKetNoi();
            DTOSanPhamCT dtoDH = null;
            try
            {
                string lenh = "Select * from SanPham sp, LoaiSP l where sp.MaLoai=l.MaLoai and MaSP=@ma";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@ma", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters["@ma"].Value = ma;

                DataTable bang = new DataTable();
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                DataRow dong = bang.Rows[0];
                dtoDH = new DTOSanPhamCT(dong);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dtoDH;
        }
        public DTOKhoSP LaySoLuongKhoSP(int ma)
        {
            ketnoi.TaoKetNoi();
            DTOKhoSP dtoDH = null;
            try
            {
                string lenh = "Select * from KhoSP k, SanPham sp, LoaiSP l where k.MaSP=sp.MaSP and sp.MaLoai=l.MaLoai and k.MaSP=@ma";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@ma", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters["@ma"].Value = ma;

                DataTable bang = new DataTable();
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                DataRow dong = bang.Rows[0];
                dtoDH = new DTOKhoSP(dong);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dtoDH;
        }
        public DTOChiTietDonHang LayTongTienGiaoHang(string ma)
        {
            ketnoi.TaoKetNoi();
            DTOChiTietDonHang dtoDH = null;
            try
            {
                string lenh = "Select MaDH,sum(ThanhTien) as ThanhTien from XuLyPhieuGiao where MaDH = " + ma + " GROUP BY MaDH ";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                DataTable bang = new DataTable();
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                DataRow dong = bang.Rows[0];
                dtoDH = new DTOChiTietDonHang(dong);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dtoDH;
        }
        public DTODSDonHang PhieuGiaoHang(string ma)
        {
            ketnoi.TaoKetNoi();
            DTODSDonHang dtoDH = null;
            try
            {
                string lenh = "Select * from DonDH dh, KhachHang kh, LoaiKH l, ThanhToan tt where dh.MaKH=kh.MaKH and kh.MaLKH=l.MaLKH and dh.MaDH=tt.MaDH and dh.MaDH=@ma";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@ma", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters["@ma"].Value = ma;

                DataTable bang = new DataTable();
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                DataRow dong = bang.Rows[0];
                dtoDH = new DTODSDonHang(dong);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dtoDH;
        }
        public bool ThemPhieuGiaoHang(DTOHoaDonBH dto)
        {
            bool ketqua = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "insert into HDBH(MaHDBH, MaKH, NgayHDBH, TongTien) values (@mahd, @makh, @ngaytt, @st)";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@mahd", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@makh", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@ngaytt", SqlDbType.DateTime);
                ketnoi.LenhKetNoi.Parameters.Add("@st", SqlDbType.Decimal);

                ketnoi.LenhKetNoi.Parameters["@mahd"].Value = dto.MaHDBH;
                ketnoi.LenhKetNoi.Parameters["@makh"].Value = dto.MaKH;
                ketnoi.LenhKetNoi.Parameters["@ngaytt"].Value = dto.NgayHDBH;
                ketnoi.LenhKetNoi.Parameters["@st"].Value = dto.TongTien;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                    ketqua = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ketqua;
        }

        public bool ThemXuLyTraHang(DTOXLSC_HDBH dtoXL)
        {
            bool ketqua = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "insert into XLSC_HDBH(MaDH, MaSP, Soluong, ThanhTien) values (@madh, @masp, @sl, @tt)";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@madh", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@masp", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@sl", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@tt", SqlDbType.Int);

                ketnoi.LenhKetNoi.Parameters["@madh"].Value = dtoXL.MaDH;
                ketnoi.LenhKetNoi.Parameters["@masp"].Value = dtoXL.MaSP;
                ketnoi.LenhKetNoi.Parameters["@sl"].Value = dtoXL.Soluong;
                ketnoi.LenhKetNoi.Parameters["@tt"].Value = dtoXL.ThanhTien;


                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                    ketqua = true;
            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ketqua;
        }
        public bool CapNhatTrangThaiDH(string ma)
        {
            bool ketqua = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "update DonDH set TrangThai = N'Đã Xử Lý' where MaDH=" + ma + "";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                    ketqua = true;
            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ketqua;
        }
        //DAO San Pham 
        

        //Lay du lieu tu database hien thi ra bang
       
      
        
       
        public List<DTOSanPham> TimTPTheoTen(string tenTim)
        {
            List<DTOSanPham> dsTim = new List<DTOSanPham>();
            string lenh = "Select * from SanPham SP, LoaiSP LSP where SP.MaLoai=LSP.MaLoai and SP.TenSP like @tenSP";
            ketnoi.TaoKetNoi();
            DataTable bang = new DataTable();
            try
            {
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);
                ketnoi.LenhKetNoi.Parameters.Add("@tenSP", SqlDbType.NVarChar);
                ketnoi.LenhKetNoi.Parameters["@tenSP"].Value = "%" + tenTim + "%";

                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                foreach (DataRow dongDL in bang.Rows)
                {
                    DTOSanPham dtoSP = new DTOSanPham(dongDL);
                    dsTim.Add(dtoSP);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dsTim;
        }

        // Sua TT san pham
        public bool SuaSanPham(DTOSanPham dtoSP)
        {
            bool ketqua = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "update SanPham set TenSP= @tensp, Soluong = @soluong, maloai = @maloai, gia = @gia where masp=@masp";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@masp", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@tensp", SqlDbType.NVarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@soluong", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@gia", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@maloai", SqlDbType.Int);

                ketnoi.LenhKetNoi.Parameters["@masp"].Value = dtoSP.MaSP;
                ketnoi.LenhKetNoi.Parameters["@tensp"].Value = dtoSP.TenSP;
                ketnoi.LenhKetNoi.Parameters["@soluong"].Value = dtoSP.soluong;
                ketnoi.LenhKetNoi.Parameters["@gia"].Value = dtoSP.Gia;
                ketnoi.LenhKetNoi.Parameters["@malkh"].Value = dtoSP.dtoLoaiSP.MaLSP;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                    ketqua = true;
            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ketqua;
        }

        public bool capNhatSoLuong(int soluong, int maSP)
        {
            bool ketqua = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "update SanPham set Soluong = @soluong where masp=@masp";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@masp", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@soluong", SqlDbType.Int);

                ketnoi.LenhKetNoi.Parameters["@masp"].Value = maSP;
                ketnoi.LenhKetNoi.Parameters["@soluong"].Value = soluong;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                    ketqua = true;
            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ketqua;
        }

        //DAO Vat Lieu

        //Lay du lieu tu Database hien thi ra bang
        
        //DAOPhieuNhapThanhPham
        

        //Them phieu  nhap
        public bool ThemPhieuNhap(DTONhapTP dtoPNTP)
        {
            bool ketqua = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "insert into PhieuNSP(MaNSP, MaPhieuGiao, NgayNhap, NgayGiao, NguoiGiao, NguoiNhan, maDH) values(@mansp, @maPhieuGiao, @ngaynhap, @ngaygiao, @nguoigiao, @nguoinhan, @madh)";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@mansp", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@maPhieuGiao", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@ngaynhap", SqlDbType.DateTime);
                ketnoi.LenhKetNoi.Parameters.Add("@ngaygiao", SqlDbType.DateTime);
                ketnoi.LenhKetNoi.Parameters.Add("@nguoigiao", SqlDbType.NVarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@nguoinhan", SqlDbType.NVarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@madh", SqlDbType.VarChar);

                ketnoi.LenhKetNoi.Parameters["@mansp"].Value = dtoPNTP.MaNTP;
                ketnoi.LenhKetNoi.Parameters["@maPhieuGiao"].Value = dtoPNTP.MaPhieuGiao;
                ketnoi.LenhKetNoi.Parameters["@ngaynhap"].Value = dtoPNTP.NgayTao;
                ketnoi.LenhKetNoi.Parameters["@ngaygiao"].Value = dtoPNTP.NgayGiao;
                ketnoi.LenhKetNoi.Parameters["@nguoigiao"].Value = dtoPNTP.NguoiGiao;
                ketnoi.LenhKetNoi.Parameters["@nguoinhan"].Value = dtoPNTP.NguoiNhan;
                ketnoi.LenhKetNoi.Parameters["@madh"].Value = dtoPNTP.MaDH;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                    ketqua = true;
            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ketqua;
        }

        public bool ThemCTPhieuNhap(DTOChiTietNhapTP dtoCTNhap)
        {
            bool ketqua = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "insert into ChitietNhapSP(MaNSP, MaSP, Soluonggiao, Soluongthuc) values(@mansp, @masp, @soluonggiao, @soluongthuc)";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@mansp", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@masp", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@soluonggiao", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@soluongthuc", SqlDbType.Int);

                ketnoi.LenhKetNoi.Parameters["@mansp"].Value = dtoCTNhap.maNTP;
                ketnoi.LenhKetNoi.Parameters["@masp"].Value = dtoCTNhap.maSP;
                ketnoi.LenhKetNoi.Parameters["@soluonggiao"].Value = dtoCTNhap.SoLuongGiao;
                ketnoi.LenhKetNoi.Parameters["@soluongthuc"].Value = dtoCTNhap.SoLuongThuc;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                    ketqua = true;
            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ketqua;
        }

        public bool ThemXuLySuCoPN(string maSuCo, int maSP, int soLuong)
        {
            bool ketqua = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "insert into XLSC_PNSP(MaNSP, MaSP, Soluong) values(@mansp, @masp, @soluong)";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@mansp", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@masp", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@soluong", SqlDbType.Int);

                ketnoi.LenhKetNoi.Parameters["@mansp"].Value = maSuCo;
                ketnoi.LenhKetNoi.Parameters["@masp"].Value = maSP;
                ketnoi.LenhKetNoi.Parameters["@soluong"].Value = soLuong;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                    ketqua = true;
            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ketqua;
        }

        public int LayTongSoLuongTrongDonHang(string maDH)
        {
            ketnoi.TaoKetNoi();
            int soluong = -1;
            try
            {
                string lenh = "select SUM(SoLuong) as soluong from ChiTietDH where MaDH = @madh";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@madh", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters["@madh"].Value = maDH;

                DataTable bang = new DataTable();
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                DataRow dong;
                if (bang.Rows.Count > 0)
                {
                    dong = bang.Rows[0];
                    soluong = (int)dong["soluong"];
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return soluong;
        }

        public int LayTongSoLuongTrongPhieuNhap(string maDH)
        {
            ketnoi.TaoKetNoi();
            int soluong = -1;
            try
            {
                string lenh = "select SUM(ct.Soluongthuc) as soluong from PhieuNSP nsp, ChiTietNhapSP ct where MaDH = @madh and nsp.MaNSP = ct.MaNSP";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@madh", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters["@madh"].Value = maDH;

                DataTable bang = new DataTable();
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                DataRow dong;
                if (bang.Rows.Count > 0)
                {
                    dong = bang.Rows[0];
                    soluong = (int)dong["soluong"];
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return soluong;
        }

        public bool capNhatTrangThai(string maDH, string trangThai)
        {
            bool kq = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "update DonDH set trangthai = @trangthai where MaDH = @maDH";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@maDH", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@trangthai", SqlDbType.NVarChar);
                ketnoi.LenhKetNoi.Parameters["@maDH"].Value = maDH;
                ketnoi.LenhKetNoi.Parameters["@trangthai"].Value = trangThai;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                {
                    kq = true;
                }
            }
            catch (Exception)
            { }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return kq;

        }
        // DAOPhieuNhapVatLieu_NCC

        //Tao danh sach san pham
        public List<DTOPhieuDatVatLieuCC> LayDSPhieuDatVatLieu_NCC()
        {
            List<DTOPhieuDatVatLieuCC> dssp = new List<DTOPhieuDatVatLieuCC>();
            string lenh = "select * from PDVL_CC pd, Nhacungcap ncc where pd.mancc = ncc.mancc and pd.TrangThai = 1";
            ketnoi.TaoKetNoi();
            DataTable bang = new DataTable();
            try
            {
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                foreach (DataRow dongDL in bang.Rows)
                {
                    DTOPhieuDatVatLieuCC dtosp = new DTOPhieuDatVatLieuCC(dongDL);
                    dssp.Add(dtosp);

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dssp;
        }

        public DTOPhieuNhapThanhPham LayXuLySucoTheoMa(string ma)
        {
            ketnoi.TaoKetNoi();
            DTOPhieuNhapThanhPham dtoKH = null;
            try
            {
                string lenh = "Select * from PhieuNSP where MaPhieuGiao = " + ma + "";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                //ketnoi.LenhKetNoi.Parameters.Add("@makh", SqlDbType.Int);
                //ketnoi.LenhKetNoi.Parameters["@makh"].Value = maSua;

                DataTable bang = new DataTable();
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                DataRow dong = bang.Rows[0];
                dtoKH = new DTOPhieuNhapThanhPham(dong);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return dtoKH;
        }
        public List<XuLySuCoNSP> LayDSXuLySuCo(string ma)
        {
            List<XuLySuCoNSP> ds = new List<XuLySuCoNSP>();
            string lenh = "select * from XLSC_PNSP xl, PhieuNSP pn, SanPham sp, LoaiSP l where sp.MaSP = xl.MaSP and sp.MaLoai=l.MaLoai and xl.MaNSP=pn.MaNSP and pn.MaNSP=" + ma + "";

            ketnoi.TaoKetNoi();
            DataTable bang = new DataTable();
            try
            {
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);
                //dong bo lenh ket noi voi du lieu trong database
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                foreach (DataRow dongDL in bang.Rows)
                {
                    XuLySuCoNSP dtoDH = new XuLySuCoNSP(dongDL);
                    ds.Add(dtoDH);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ds;
        }
        public List<DTOChiTietPhieuDatNCC> layDSVatLieuDaDat(string maPhieuDat)
        {
            List<DTOChiTietPhieuDatNCC> ds = new List<DTOChiTietPhieuDatNCC>();
            string lenh = "select * from CTPD_VLCC ctpd, Nhacungcap ncc, PDVL_CC pd, VatLieu vl where pd.mancc = ncc.mancc and ctpd.MaPDVLCC = pd.MaPDVLCC and ctpd.MaVL = vl.MaVL and ctpd.MaPDVLCC = @maPhieu";
            ketnoi.TaoKetNoi();
            DataTable bang = new DataTable();
            try
            {
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);
                ketnoi.LenhKetNoi.Parameters.Add("@maPhieu", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters["@maPhieu"].Value = maPhieuDat;
                ketnoi.TichHopCSDL = new SqlDataAdapter(ketnoi.LenhKetNoi);
                ketnoi.TichHopCSDL.Fill(bang);
                foreach (DataRow dongDL in bang.Rows)
                {
                    DTOChiTietPhieuDatNCC dtosp = new DTOChiTietPhieuDatNCC(dongDL);
                    ds.Add(dtosp);

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ds;
        }

        public bool ThemPhieuNhap(DTOPhieuNVL_SX dtoPhieuVL)
        {
            bool ketqua = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "insert into PhieuNVL_SX(MaPNVLSX, MaPD, Ngaylap, Ngaygiao, NguoiGiao, MaNV) values(@maPhieuNhap, @maPhieuDat, @ngaylap, @ngaygiao, @nguoigiao, @manv)";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@maPhieuNhap", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@maPhieuDat", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@ngaylap", SqlDbType.DateTime);
                ketnoi.LenhKetNoi.Parameters.Add("@ngaygiao", SqlDbType.DateTime);
                ketnoi.LenhKetNoi.Parameters.Add("@nguoigiao", SqlDbType.NVarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@manv", SqlDbType.Int);

                ketnoi.LenhKetNoi.Parameters["@maPhieuNhap"].Value = dtoPhieuVL.MaPNVLSX;
                ketnoi.LenhKetNoi.Parameters["@maPhieuDat"].Value = dtoPhieuVL.dtoPhieuDat.MaPDVLCC;
                ketnoi.LenhKetNoi.Parameters["@ngaylap"].Value = dtoPhieuVL.ngaylap;
                ketnoi.LenhKetNoi.Parameters["@ngaygiao"].Value = dtoPhieuVL.NgayGiao;
                ketnoi.LenhKetNoi.Parameters["@nguoigiao"].Value = dtoPhieuVL.NguoiGiao;
                ketnoi.LenhKetNoi.Parameters["@manv"].Value = dtoPhieuVL.MaNV;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                    ketqua = true;
            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ketqua;
        }

        public bool ThemCTPhieuNhap(DTOChiTietPhieuNhapVL dtoCTNhap)
        {
            bool ketqua = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "insert into CT_NhapVLSX(MaPNVLSX, MaVL, Soluonggiao, Soluongthuc) values(@maPhieuNhap, @mavl, @soluonggiao, @soluongthuc)";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@maPhieuNhap", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@mavl", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@soluonggiao", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@soluongthuc", SqlDbType.Int);

                ketnoi.LenhKetNoi.Parameters["@maPhieuNhap"].Value = dtoCTNhap.dtoPhieuNhapVL.MaPNVLSX;
                ketnoi.LenhKetNoi.Parameters["@mavl"].Value = dtoCTNhap.dtoVatLieu.MaVL;
                ketnoi.LenhKetNoi.Parameters["@soluonggiao"].Value = dtoCTNhap.SoLuongGiao;
                ketnoi.LenhKetNoi.Parameters["@soluongthuc"].Value = dtoCTNhap.SoLuongThuc;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                    ketqua = true;
            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ketqua;
        }

        public bool ThemPhieuGiao(DTOPhieuGiao dtoPhieuGiao)
        {
            bool ketqua = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "insert into PhieuGiao(MaPG, NgayGiao, NguoiGiao) values(@maPhieuGiao, @ngaygiao, @nguoigiao)";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@maPhieuGiao", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@ngaygiao", SqlDbType.DateTime);
                ketnoi.LenhKetNoi.Parameters.Add("@nguoigiao", SqlDbType.VarChar);

                ketnoi.LenhKetNoi.Parameters["@maPhieuGiao"].Value = dtoPhieuGiao.MaPhieuGiao;
                ketnoi.LenhKetNoi.Parameters["@ngaygiao"].Value = dtoPhieuGiao.NgayGiao;
                ketnoi.LenhKetNoi.Parameters["@nguoigiao"].Value = dtoPhieuGiao.NguoiGiao;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                    ketqua = true;
            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ketqua;
        }

        public bool ThemCTPhieuGiao(DTOChiTietPhieuGiao dtoCTNhap)
        {
            bool ketqua = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "insert into ChiTietPhieuGiao(MaPG, MaVL, SoLuongGiao) values(@mapg, @mavl, @soluonggiao)";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@mapg", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@mavl", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@soluonggiao", SqlDbType.Int);

                ketnoi.LenhKetNoi.Parameters["@mapg"].Value = dtoCTNhap.dtoPhieuGiao.MaPhieuGiao;
                ketnoi.LenhKetNoi.Parameters["@mavl"].Value = dtoCTNhap.dtoVatLieu.MaVL;
                ketnoi.LenhKetNoi.Parameters["@soluonggiao"].Value = dtoCTNhap.SoluongGiao;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                    ketqua = true;
            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ketqua;
        }

        public bool capNhatTrangThaiPhieuDat(string maPhieuDat, int trangThai)
        {
            bool kq = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "update PDVL_CC set trangthai = @trangthai where MaPDVLCC = @maPhieuDat";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@maPhieuDat", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@trangthai", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters["@maPhieuDat"].Value = maPhieuDat;
                ketnoi.LenhKetNoi.Parameters["@trangthai"].Value = trangThai;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                {
                    kq = true;
                }
            }
            catch (Exception)
            { }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return kq;

        }

        public bool ThemXuLySuCo(string maPhieu, int MaVL, int SoLuongKhongDat)
        {
            bool ketqua = false;
            ketnoi.TaoKetNoi();
            try
            {
                string lenh = "insert into XLSC_PNVLSX(MaPNVLSX, MaVL, SoLuongKhongDat) values(@maPhieu, @maVL, @soLuong)";
                ketnoi.LenhKetNoi = new SqlCommand(lenh, ketnoi.KetNoi);

                ketnoi.LenhKetNoi.Parameters.Add("@maPhieu", SqlDbType.VarChar);
                ketnoi.LenhKetNoi.Parameters.Add("@maVL", SqlDbType.Int);
                ketnoi.LenhKetNoi.Parameters.Add("@soLuong", SqlDbType.Int);

                ketnoi.LenhKetNoi.Parameters["@maPhieu"].Value = maPhieu;
                ketnoi.LenhKetNoi.Parameters["@maVL"].Value = MaVL;
                ketnoi.LenhKetNoi.Parameters["@soLuong"].Value = SoLuongKhongDat;

                if (ketnoi.LenhKetNoi.ExecuteNonQuery() != 0)
                    ketqua = true;
            }
            catch (Exception)
            {

            }
            finally
            {
                ketnoi.DongKetNoi();
            }
            return ketqua;
        }
    }
}