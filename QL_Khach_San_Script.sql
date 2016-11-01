/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     11/1/2016 6:42:57 PM                         */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CT_DAT_PHONG') and o.name = 'FK_CT_DAT_P_CT_DAT_PH_PHIEU_DA')
alter table CT_DAT_PHONG
   drop constraint FK_CT_DAT_P_CT_DAT_PH_PHIEU_DA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CT_DAT_PHONG') and o.name = 'FK_CT_DAT_P_CT_DAT_PH_PHONG')
alter table CT_DAT_PHONG
   drop constraint FK_CT_DAT_P_CT_DAT_PH_PHONG
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CT_DICH_VU') and o.name = 'FK_CT_DICH__CT_DICH_V_DICH_VU')
alter table CT_DICH_VU
   drop constraint FK_CT_DICH__CT_DICH_V_DICH_VU
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CT_DICH_VU') and o.name = 'FK_CT_DICH__CT_DICH_V_PHIEU_TH')
alter table CT_DICH_VU
   drop constraint FK_CT_DICH__CT_DICH_V_PHIEU_TH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CT_GIA_THUE') and o.name = 'FK_CT_GIA_T_CT_GIA_TH_GIA_THUE')
alter table CT_GIA_THUE
   drop constraint FK_CT_GIA_T_CT_GIA_TH_GIA_THUE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CT_GIA_THUE') and o.name = 'FK_CT_GIA_T_CT_GIA_TH_PHONG')
alter table CT_GIA_THUE
   drop constraint FK_CT_GIA_T_CT_GIA_TH_PHONG
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CT_THUE_PHONG') and o.name = 'FK_CT_THUE__CT_THUE_P_PHIEU_TH')
alter table CT_THUE_PHONG
   drop constraint FK_CT_THUE__CT_THUE_P_PHIEU_TH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CT_THUE_PHONG') and o.name = 'FK_CT_THUE__CT_THUE_P_PHONG')
alter table CT_THUE_PHONG
   drop constraint FK_CT_THUE__CT_THUE_P_PHONG
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HOA_DON') and o.name = 'FK_HOA_DON_LAP_NHAN_VIE')
alter table HOA_DON
   drop constraint FK_HOA_DON_LAP_NHAN_VIE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HOA_DON') and o.name = 'FK_HOA_DON_THUOC2_PHIEU_TH')
alter table HOA_DON
   drop constraint FK_HOA_DON_THUOC2_PHIEU_TH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('KHACH_HANG') and o.name = 'FK_KHACH_HA_O_PHONG')
alter table KHACH_HANG
   drop constraint FK_KHACH_HA_O_PHONG
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHIEU_DAT_PHONG') and o.name = 'FK_PHIEU_DA_DAT_KHACH_HA')
alter table PHIEU_DAT_PHONG
   drop constraint FK_PHIEU_DA_DAT_KHACH_HA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHIEU_DAT_PHONG') and o.name = 'FK_PHIEU_DA_LAP_NHAN_VIE')
alter table PHIEU_DAT_PHONG
   drop constraint FK_PHIEU_DA_LAP_NHAN_VIE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHIEU_THUE_PHONG') and o.name = 'FK_PHIEU_TH_LAP_NHAN_VIE')
alter table PHIEU_THUE_PHONG
   drop constraint FK_PHIEU_TH_LAP_NHAN_VIE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHIEU_THUE_PHONG') and o.name = 'FK_PHIEU_TH_THUE_KHACH_HA')
alter table PHIEU_THUE_PHONG
   drop constraint FK_PHIEU_TH_THUE_KHACH_HA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BAO_CAO')
            and   type = 'U')
   drop table BAO_CAO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CT_DAT_PHONG')
            and   name  = 'CT_DAT_PHONG_FK2'
            and   indid > 0
            and   indid < 255)
   drop index CT_DAT_PHONG.CT_DAT_PHONG_FK2
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CT_DAT_PHONG')
            and   name  = 'CT_DAT_PHONG_FK'
            and   indid > 0
            and   indid < 255)
   drop index CT_DAT_PHONG.CT_DAT_PHONG_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CT_DAT_PHONG')
            and   type = 'U')
   drop table CT_DAT_PHONG
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CT_DICH_VU')
            and   name  = 'CT_DICH_VU_FK2'
            and   indid > 0
            and   indid < 255)
   drop index CT_DICH_VU.CT_DICH_VU_FK2
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CT_DICH_VU')
            and   name  = 'CT_DICH_VU_FK'
            and   indid > 0
            and   indid < 255)
   drop index CT_DICH_VU.CT_DICH_VU_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CT_DICH_VU')
            and   type = 'U')
   drop table CT_DICH_VU
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CT_GIA_THUE')
            and   name  = 'CT_GIA_THUE_FK2'
            and   indid > 0
            and   indid < 255)
   drop index CT_GIA_THUE.CT_GIA_THUE_FK2
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CT_GIA_THUE')
            and   name  = 'CT_GIA_THUE_FK'
            and   indid > 0
            and   indid < 255)
   drop index CT_GIA_THUE.CT_GIA_THUE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CT_GIA_THUE')
            and   type = 'U')
   drop table CT_GIA_THUE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CT_THUE_PHONG')
            and   name  = 'CT_THUE_PHONG_FK2'
            and   indid > 0
            and   indid < 255)
   drop index CT_THUE_PHONG.CT_THUE_PHONG_FK2
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CT_THUE_PHONG')
            and   name  = 'CT_THUE_PHONG_FK'
            and   indid > 0
            and   indid < 255)
   drop index CT_THUE_PHONG.CT_THUE_PHONG_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CT_THUE_PHONG')
            and   type = 'U')
   drop table CT_THUE_PHONG
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DICH_VU')
            and   type = 'U')
   drop table DICH_VU
go

if exists (select 1
            from  sysobjects
           where  id = object_id('GIA_THUE')
            and   type = 'U')
   drop table GIA_THUE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HOA_DON')
            and   name  = 'LAP_FK'
            and   indid > 0
            and   indid < 255)
   drop index HOA_DON.LAP_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HOA_DON')
            and   name  = 'THUOC_FK'
            and   indid > 0
            and   indid < 255)
   drop index HOA_DON.THUOC_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HOA_DON')
            and   type = 'U')
   drop table HOA_DON
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('KHACH_HANG')
            and   name  = 'O_FK'
            and   indid > 0
            and   indid < 255)
   drop index KHACH_HANG.O_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('KHACH_HANG')
            and   type = 'U')
   drop table KHACH_HANG
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NHAN_VIEN')
            and   type = 'U')
   drop table NHAN_VIEN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PHIEU_DAT_PHONG')
            and   name  = 'LAP_FK'
            and   indid > 0
            and   indid < 255)
   drop index PHIEU_DAT_PHONG.LAP_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PHIEU_DAT_PHONG')
            and   name  = 'DAT_FK'
            and   indid > 0
            and   indid < 255)
   drop index PHIEU_DAT_PHONG.DAT_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHIEU_DAT_PHONG')
            and   type = 'U')
   drop table PHIEU_DAT_PHONG
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PHIEU_THUE_PHONG')
            and   name  = 'LAP_FK'
            and   indid > 0
            and   indid < 255)
   drop index PHIEU_THUE_PHONG.LAP_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PHIEU_THUE_PHONG')
            and   name  = 'THUE_FK'
            and   indid > 0
            and   indid < 255)
   drop index PHIEU_THUE_PHONG.THUE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHIEU_THUE_PHONG')
            and   type = 'U')
   drop table PHIEU_THUE_PHONG
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHONG')
            and   type = 'U')
   drop table PHONG
go

/*==============================================================*/
/* Table: BAO_CAO                                               */
/*==============================================================*/
create table BAO_CAO (
   ID_BAO_CAO           varchar(45)          not null,
   TEN_BAO_CAO          varchar(45)          null,
   NGAY_LAP             datetime             not null,
   constraint PK_BAO_CAO primary key nonclustered (ID_BAO_CAO)
)
go

/*==============================================================*/
/* Table: CT_DAT_PHONG                                          */
/*==============================================================*/
create table CT_DAT_PHONG (
   ID_DAT_PHONG         varchar(45)          not null,
   ID_PHONG             varchar(45)          not null,
   SO_KHACH             int                  not null default 1
      constraint CKC_SO_KHACH_CT_DAT_P check (SO_KHACH >= 1),
   constraint PK_CT_DAT_PHONG primary key (ID_DAT_PHONG, ID_PHONG)
)
go

/*==============================================================*/
/* Index: CT_DAT_PHONG_FK                                       */
/*==============================================================*/
create index CT_DAT_PHONG_FK on CT_DAT_PHONG (
ID_DAT_PHONG ASC
)
go

/*==============================================================*/
/* Index: CT_DAT_PHONG_FK2                                      */
/*==============================================================*/
create index CT_DAT_PHONG_FK2 on CT_DAT_PHONG (
ID_PHONG ASC
)
go

/*==============================================================*/
/* Table: CT_DICH_VU                                            */
/*==============================================================*/
create table CT_DICH_VU (
   ID_DICH_VU           varchar(45)          not null,
   ID_THUE_PHONG        varchar(45)          not null,
   SO_LUONG             int                  not null default 0
      constraint CKC_SO_LUONG_CT_DICH_ check (SO_LUONG >= 0),
   TIEN_DV              int                  not null default 0
      constraint CKC_TIEN_DV_CT_DICH_ check (TIEN_DV >= 0),
   constraint PK_CT_DICH_VU primary key (ID_DICH_VU, ID_THUE_PHONG)
)
go

/*==============================================================*/
/* Index: CT_DICH_VU_FK                                         */
/*==============================================================*/
create index CT_DICH_VU_FK on CT_DICH_VU (
ID_DICH_VU ASC
)
go

/*==============================================================*/
/* Index: CT_DICH_VU_FK2                                        */
/*==============================================================*/
create index CT_DICH_VU_FK2 on CT_DICH_VU (
ID_THUE_PHONG ASC
)
go

/*==============================================================*/
/* Table: CT_GIA_THUE                                           */
/*==============================================================*/
create table CT_GIA_THUE (
   ID_PHONG             varchar(45)          not null,
   ID_GIA_THUE          varchar(45)          not null,
   SO_LUONG             int                  not null,
   constraint PK_CT_GIA_THUE primary key (ID_PHONG, ID_GIA_THUE)
)
go

/*==============================================================*/
/* Index: CT_GIA_THUE_FK                                        */
/*==============================================================*/
create index CT_GIA_THUE_FK on CT_GIA_THUE (
ID_PHONG ASC
)
go

/*==============================================================*/
/* Index: CT_GIA_THUE_FK2                                       */
/*==============================================================*/
create index CT_GIA_THUE_FK2 on CT_GIA_THUE (
ID_GIA_THUE ASC
)
go

/*==============================================================*/
/* Table: CT_THUE_PHONG                                         */
/*==============================================================*/
create table CT_THUE_PHONG (
   ID_THUE_PHONG        varchar(45)          not null,
   ID_PHONG             varchar(45)          not null,
   SO_KHACH             int                  not null default 1
      constraint CKC_SO_KHACH_CT_THUE_ check (SO_KHACH >= 1),
   TIEN_THUE            int                  not null default 0
      constraint CKC_TIEN_THUE_CT_THUE_ check (TIEN_THUE >= 0),
   constraint PK_CT_THUE_PHONG primary key (ID_THUE_PHONG, ID_PHONG)
)
go

/*==============================================================*/
/* Index: CT_THUE_PHONG_FK                                      */
/*==============================================================*/
create index CT_THUE_PHONG_FK on CT_THUE_PHONG (
ID_THUE_PHONG ASC
)
go

/*==============================================================*/
/* Index: CT_THUE_PHONG_FK2                                     */
/*==============================================================*/
create index CT_THUE_PHONG_FK2 on CT_THUE_PHONG (
ID_PHONG ASC
)
go

/*==============================================================*/
/* Table: DICH_VU                                               */
/*==============================================================*/
create table DICH_VU (
   ID_DICH_VU           varchar(45)          not null,
   TEN_DICH_VU          varchar(45)          not null,
   DON_GIA              int                  not null default 0
      constraint CKC_DON_GIA_DICH_VU check (DON_GIA >= 0),
   constraint PK_DICH_VU primary key nonclustered (ID_DICH_VU)
)
go

/*==============================================================*/
/* Table: GIA_THUE                                              */
/*==============================================================*/
create table GIA_THUE (
   ID_GIA_THUE          varchar(45)          not null,
   DON_GIA              int                  not null default 0
      constraint CKC_DON_GIA_GIA_THUE check (DON_GIA >= 0),
   constraint PK_GIA_THUE primary key nonclustered (ID_GIA_THUE)
)
go

/*==============================================================*/
/* Table: HOA_DON                                               */
/*==============================================================*/
create table HOA_DON (
   ID_HOA_DON           varchar(45)          not null,
   ID_THUE_PHONG        varchar(45)          not null,
   ID_NHAN_VIEN         varchar(45)          not null,
   NGAY_LAP             datetime             not null,
   TIEN_THUE            int                  not null,
   TIEN_DV              int                  not null,
   TONG_TIEN            int                  not null,
   constraint PK_HOA_DON primary key nonclustered (ID_HOA_DON)
)
go

/*==============================================================*/
/* Index: THUOC_FK                                              */
/*==============================================================*/
create index THUOC_FK on HOA_DON (
ID_THUE_PHONG ASC
)
go

/*==============================================================*/
/* Index: LAP_FK                                                */
/*==============================================================*/
create index LAP_FK on HOA_DON (
ID_NHAN_VIEN ASC
)
go

/*==============================================================*/
/* Table: KHACH_HANG                                            */
/*==============================================================*/
create table KHACH_HANG (
   ID_KHACH_HANG        varchar(45)          not null,
   ID_PHONG             varchar(45)          null,
   TEN                  varchar(45)          null,
   DIA_CHI              varchar(45)          null,
   SDT                  varchar(45)          null,
   FAX                  varchar(45)          null,
   TELEX                varchar(45)          null,
   constraint PK_KHACH_HANG primary key nonclustered (ID_KHACH_HANG)
)
go

/*==============================================================*/
/* Index: O_FK                                                  */
/*==============================================================*/
create index O_FK on KHACH_HANG (
ID_PHONG ASC
)
go

/*==============================================================*/
/* Table: NHAN_VIEN                                             */
/*==============================================================*/
create table NHAN_VIEN (
   ID_NHAN_VIEN         varchar(45)          not null,
   TEN_NV               varchar(45)          null,
   MAT_KHAU             varchar(45)          null,
   constraint PK_NHAN_VIEN primary key nonclustered (ID_NHAN_VIEN)
)
go

/*==============================================================*/
/* Table: PHIEU_DAT_PHONG                                       */
/*==============================================================*/
create table PHIEU_DAT_PHONG (
   ID_DAT_PHONG         varchar(45)          not null,
   ID_KHACH_HANG        varchar(45)          not null,
   ID_NHAN_VIEN         varchar(45)          not null,
   NGAY_DAT             datetime             not null,
   NGAY_DEN             datetime             not null,
   NGAY_DI              datetime             not null,
   constraint PK_PHIEU_DAT_PHONG primary key nonclustered (ID_DAT_PHONG)
)
go

/*==============================================================*/
/* Index: DAT_FK                                                */
/*==============================================================*/
create index DAT_FK on PHIEU_DAT_PHONG (
ID_KHACH_HANG ASC
)
go

/*==============================================================*/
/* Index: LAP_FK                                                */
/*==============================================================*/
create index LAP_FK on PHIEU_DAT_PHONG (
ID_NHAN_VIEN ASC
)
go

/*==============================================================*/
/* Table: PHIEU_THUE_PHONG                                      */
/*==============================================================*/
create table PHIEU_THUE_PHONG (
   ID_THUE_PHONG        varchar(45)          not null,
   ID_KHACH_HANG        varchar(45)          not null,
   ID_NHAN_VIEN         varchar(45)          not null,
   NGAY_NHAN            datetime             not null,
   NGAY_TRA             datetime             not null,
   constraint PK_PHIEU_THUE_PHONG primary key nonclustered (ID_THUE_PHONG)
)
go

/*==============================================================*/
/* Index: THUE_FK                                               */
/*==============================================================*/
create index THUE_FK on PHIEU_THUE_PHONG (
ID_KHACH_HANG ASC
)
go

/*==============================================================*/
/* Index: LAP_FK                                                */
/*==============================================================*/
create index LAP_FK on PHIEU_THUE_PHONG (
ID_NHAN_VIEN ASC
)
go

/*==============================================================*/
/* Table: PHONG                                                 */
/*==============================================================*/
create table PHONG (
   ID_PHONG             varchar(45)          not null,
   LOAI_PHONG           varchar(45)          null,
   constraint PK_PHONG primary key nonclustered (ID_PHONG)
)
go

alter table CT_DAT_PHONG
   add constraint FK_CT_DAT_P_CT_DAT_PH_PHIEU_DA foreign key (ID_DAT_PHONG)
      references PHIEU_DAT_PHONG (ID_DAT_PHONG)
go

alter table CT_DAT_PHONG
   add constraint FK_CT_DAT_P_CT_DAT_PH_PHONG foreign key (ID_PHONG)
      references PHONG (ID_PHONG)
go

alter table CT_DICH_VU
   add constraint FK_CT_DICH__CT_DICH_V_DICH_VU foreign key (ID_DICH_VU)
      references DICH_VU (ID_DICH_VU)
go

alter table CT_DICH_VU
   add constraint FK_CT_DICH__CT_DICH_V_PHIEU_TH foreign key (ID_THUE_PHONG)
      references PHIEU_THUE_PHONG (ID_THUE_PHONG)
go

alter table CT_GIA_THUE
   add constraint FK_CT_GIA_T_CT_GIA_TH_GIA_THUE foreign key (ID_GIA_THUE)
      references GIA_THUE (ID_GIA_THUE)
go

alter table CT_GIA_THUE
   add constraint FK_CT_GIA_T_CT_GIA_TH_PHONG foreign key (ID_PHONG)
      references PHONG (ID_PHONG)
go

alter table CT_THUE_PHONG
   add constraint FK_CT_THUE__CT_THUE_P_PHIEU_TH foreign key (ID_THUE_PHONG)
      references PHIEU_THUE_PHONG (ID_THUE_PHONG)
go

alter table CT_THUE_PHONG
   add constraint FK_CT_THUE__CT_THUE_P_PHONG foreign key (ID_PHONG)
      references PHONG (ID_PHONG)
go

alter table HOA_DON
   add constraint FK_HOA_DON_LAP_NHAN_VIE foreign key (ID_NHAN_VIEN)
      references NHAN_VIEN (ID_NHAN_VIEN)
go

alter table HOA_DON
   add constraint FK_HOA_DON_THUOC2_PHIEU_TH foreign key (ID_THUE_PHONG)
      references PHIEU_THUE_PHONG (ID_THUE_PHONG)
go

alter table KHACH_HANG
   add constraint FK_KHACH_HA_O_PHONG foreign key (ID_PHONG)
      references PHONG (ID_PHONG)
go

alter table PHIEU_DAT_PHONG
   add constraint FK_PHIEU_DA_DAT_KHACH_HA foreign key (ID_KHACH_HANG)
      references KHACH_HANG (ID_KHACH_HANG)
go

alter table PHIEU_DAT_PHONG
   add constraint FK_PHIEU_DA_LAP_NHAN_VIE foreign key (ID_NHAN_VIEN)
      references NHAN_VIEN (ID_NHAN_VIEN)
go

alter table PHIEU_THUE_PHONG
   add constraint FK_PHIEU_TH_LAP_NHAN_VIE foreign key (ID_NHAN_VIEN)
      references NHAN_VIEN (ID_NHAN_VIEN)
go

alter table PHIEU_THUE_PHONG
   add constraint FK_PHIEU_TH_THUE_KHACH_HA foreign key (ID_KHACH_HANG)
      references KHACH_HANG (ID_KHACH_HANG)
go

