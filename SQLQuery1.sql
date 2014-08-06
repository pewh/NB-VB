Create Database DB_RemcoInsentif
go
use DB_RemcoInsentif

Create Table Karyawan
(
Id_Karyawan Char(8) Primary Key,
Nama varChar(200),
Alamat varChar(200),
Jenis_Kelamin Char(1),
Tgl_Masuk SmallDateTime,
Status_Karyawan Char(1)
)
go

Create view v_Karyawan as
select a.*,JK = 
      CASE Jenis_Kelamin
         WHEN '0' THEN 'Laki-Laki'
         WHEN '1' THEN 'Perempuan'
      END,
SK = 
      CASE Status_Karyawan
         WHEN '0' THEN 'Non Aktif'
         WHEN '1' THEN 'Aktif'
      END
from Karyawan a
go

Create Procedure Simpan_Karyawan
(
@IK Char(8),@N varChar(200),@A varChar(200),@JK Char(1),@TM SmallDateTime,@SK Char(1)
)
as
Insert Into Karyawan values(@IK,@N,@A,@JK,@TM,@SK)

go

Create Procedure Ubah_Karyawan
(
@IK Char(8),@N varChar(200),@A varChar(200),@JK Char(1),@TM SmallDateTime,@SK Char(1)
)
as
Update Karyawan set Nama=@N,Alamat=@A,Jenis_Kelamin=@JK,Tgl_Masuk=@TM,Status_Karyawan=@SK where Id_Karyawan=@IK

go

Create Procedure Hapus_Karyawan
(
@IK Char(8)
)
as
Delete Karyawan where Id_Karyawan=@IK

go

sp_columns karyawan
Create Table History_Insentif
(
Period_Id Char(4),
Period_Name varChar(200),
Id_Karyawan Char(8),
Absensi Int,
Penampilan Int,
Sikap Int,
Lama_Kerja Int,
Insentif Int
)
select 
Alter view v_History_Insentif as
select a.*
,Absen = 
      CASE Absensi
         WHEN 0 THEN '>= 25 hari'
         WHEN 1 THEN '< 25 hari'
      END,
Tmpl = 
      CASE Penampilan
         WHEN 0 THEN 'Rapi'
         WHEN 1 THEN 'Tidak Rapi'
      END,
Skp = 
      CASE Sikap
         WHEN 0 THEN 'Sopan'
         WHEN 1 THEN 'Tidak Sopan'
      END,
LK = 
      CASE Lama_Kerja
         WHEN 0 THEN '> 6 bln'
         WHEN 1 THEN '< 6 bln'
      END,
Ins = 
      CASE Insentif
         WHEN 0 THEN 'Ya'
         WHEN 1 THEN 'Tidak'
      END,
b.Nama from History_Insentif a left join Karyawan b on a.Id_Karyawan=b.Id_karyawan
go 

select *from v_history_insentif
select *from history_insentif
delete from history_insentif
Alter Procedure Simpan_History_Insentif
(
@PI Char(4),@PN varChar(200),@IK Char(8),@A Int,@P Int,@S Int,@LK Int,@I Int
)
as
Insert Into History_Insentif values(@PI,@PN,@IK,@A,@P,@S,@LK,@I)

go

Alter Procedure Ubah_History_Insentif
(
@PI Char(4),@PN varChar(200),@IK Char(8),@A Int,@P Int,@S Int,@LK Int,@I Int
)
as
Update History_Insentif set Absensi=@A,Penampilan=@P,Sikap=@S,Lama_Kerja=@LK,Insentif=@I 
where Period_Id=@PI and Id_Karyawan=@IK

go

Create Procedure Hapus_History_Insentif
(
@PI Char(4),@IK Char(8)
)
as
Delete History_Insentif
where Period_Id=@PI and Id_Karyawan=@IK

go

Create Table Naive_Bayes
(
Tahun Int,
Bulan Int,
Id_Karyawan Char(8),
P_Absensi Int,
P_Penampilan Int,
P_Sikap Int,
P_Lama_Kerja Int,
Insentif Int,
Nilai_Ya Float,
Nilai_Tidak Float
)

go

Create Procedure Simpan_Naive_Bayes
(
@T Int,@B Int,@IK Char(8),@PA Int,@PP Int,@PS Int,@PLK Int,@Ins Int,@NY Float,@NT Float
)
as
Insert Into Naive_Bayes values(@T,@B,@IK,@PA,@PP,@PS,@PLK,@Ins,@NY,@NT)

go
select distinct Period_ID,Period_ from History_Insentif
go
select *from History_Insentif
select Period_Id,(cast(count(Insentif)+1 as float)-sum(Insentif))/count(Insentif) as Ya_Insentif,(cast(sum(Insentif)+1 as float)/count(Insentif))  as  Tdk_Insentif,Count(Insentif) as Jumlah from History_Insentif
group by Period_ID