/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     11/20/2016 11:07:33 AM                       */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BookingDetails') and o.name = 'FK_BOOKINGD_BOOKINGDE_BOOKINGS')
alter table BookingDetails
   drop constraint FK_BOOKINGD_BOOKINGDE_BOOKINGS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BookingDetails') and o.name = 'FK_BOOKINGD_BOOKINGDE_ROOMS')
alter table BookingDetails
   drop constraint FK_BOOKINGD_BOOKINGDE_ROOMS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Bookings') and o.name = 'FK_BOOKINGS_HAS_CUSTOMER')
alter table Bookings
   drop constraint FK_BOOKINGS_HAS_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Bookings') and o.name = 'FK_BOOKINGS_HAS_EMPLOYEE')
alter table Bookings
   drop constraint FK_BOOKINGS_HAS_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CheckInDetails') and o.name = 'FK_CHECKIND_CHECKINDE_CHECKINS')
alter table CheckInDetails
   drop constraint FK_CHECKIND_CHECKINDE_CHECKINS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CheckInDetails') and o.name = 'FK_CHECKIND_CHECKINDE_ROOMS')
alter table CheckInDetails
   drop constraint FK_CHECKIND_CHECKINDE_ROOMS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CheckIns') and o.name = 'FK_CHECKINS_HAS_BOOKINGS')
alter table CheckIns
   drop constraint FK_CHECKINS_HAS_BOOKINGS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CheckIns') and o.name = 'FK_CHECKINS_HAS_CUSTOMER')
alter table CheckIns
   drop constraint FK_CHECKINS_HAS_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CheckIns') and o.name = 'FK_CHECKINS_HAS_EMPLOYEE')
alter table CheckIns
   drop constraint FK_CHECKINS_HAS_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Invoices') and o.name = 'FK_INVOICES_HAS_CHECKINS')
alter table Invoices
   drop constraint FK_INVOICES_HAS_CHECKINS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Invoices') and o.name = 'FK_INVOICES_HAS_EMPLOYEE')
alter table Invoices
   drop constraint FK_INVOICES_HAS_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Rooms') and o.name = 'FK_ROOMS_HAS_ROOMTYPE')
alter table Rooms
   drop constraint FK_ROOMS_HAS_ROOMTYPE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ServiceDetails') and o.name = 'FK_SERVICED_SERVICEDE_CHECKINS')
alter table ServiceDetails
   drop constraint FK_SERVICED_SERVICEDE_CHECKINS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ServiceDetails') and o.name = 'FK_SERVICED_SERVICEDE_SERVICES')
alter table ServiceDetails
   drop constraint FK_SERVICED_SERVICEDE_SERVICES
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TypePriceDetails') and o.name = 'FK_TYPEPRIC_TYPEPRICE_ROOMTYPE')
alter table TypePriceDetails
   drop constraint FK_TYPEPRIC_TYPEPRICE_ROOMTYPE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TypePriceDetails') and o.name = 'FK_TYPEPRIC_TYPEPRICE_TYPEPRIC')
alter table TypePriceDetails
   drop constraint FK_TYPEPRIC_TYPEPRICE_TYPEPRIC
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BookingDetails')
            and   name  = 'BOOKINGDETAILS_FK2'
            and   indid > 0
            and   indid < 255)
   drop index BookingDetails.BOOKINGDETAILS_FK2
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BookingDetails')
            and   name  = 'BOOKINGDETAILS_FK'
            and   indid > 0
            and   indid < 255)
   drop index BookingDetails.BOOKINGDETAILS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BookingDetails')
            and   type = 'U')
   drop table BookingDetails
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Bookings')
            and   name  = 'HAS_FK2'
            and   indid > 0
            and   indid < 255)
   drop index Bookings.HAS_FK2
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Bookings')
            and   name  = 'HAS_FK'
            and   indid > 0
            and   indid < 255)
   drop index Bookings.HAS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Bookings')
            and   type = 'U')
   drop table Bookings
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CheckInDetails')
            and   name  = 'CHECKINDETAILS_FK2'
            and   indid > 0
            and   indid < 255)
   drop index CheckInDetails.CHECKINDETAILS_FK2
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CheckInDetails')
            and   name  = 'CHECKINDETAILS_FK'
            and   indid > 0
            and   indid < 255)
   drop index CheckInDetails.CHECKINDETAILS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CheckInDetails')
            and   type = 'U')
   drop table CheckInDetails
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CheckIns')
            and   name  = 'HAS_FK3'
            and   indid > 0
            and   indid < 255)
   drop index CheckIns.HAS_FK3
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CheckIns')
            and   name  = 'HAS_FK2'
            and   indid > 0
            and   indid < 255)
   drop index CheckIns.HAS_FK2
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CheckIns')
            and   name  = 'HAS_FK'
            and   indid > 0
            and   indid < 255)
   drop index CheckIns.HAS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CheckIns')
            and   type = 'U')
   drop table CheckIns
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Customers')
            and   type = 'U')
   drop table Customers
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Employees')
            and   type = 'U')
   drop table Employees
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Invoices')
            and   name  = 'HAS_FK2'
            and   indid > 0
            and   indid < 255)
   drop index Invoices.HAS_FK2
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Invoices')
            and   name  = 'HAS_FK'
            and   indid > 0
            and   indid < 255)
   drop index Invoices.HAS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Invoices')
            and   type = 'U')
   drop table Invoices
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Reports')
            and   type = 'U')
   drop table Reports
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RoomTypes')
            and   type = 'U')
   drop table RoomTypes
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Rooms')
            and   name  = 'HAS_FK'
            and   indid > 0
            and   indid < 255)
   drop index Rooms.HAS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Rooms')
            and   type = 'U')
   drop table Rooms
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ServiceDetails')
            and   name  = 'SERVICEDETAILS_FK2'
            and   indid > 0
            and   indid < 255)
   drop index ServiceDetails.SERVICEDETAILS_FK2
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ServiceDetails')
            and   name  = 'SERVICEDETAILS_FK'
            and   indid > 0
            and   indid < 255)
   drop index ServiceDetails.SERVICEDETAILS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ServiceDetails')
            and   type = 'U')
   drop table ServiceDetails
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Services')
            and   type = 'U')
   drop table Services
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TypePriceDetails')
            and   name  = 'ROOMPRICEDETAIL_FK2'
            and   indid > 0
            and   indid < 255)
   drop index TypePriceDetails.ROOMPRICEDETAIL_FK2
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TypePriceDetails')
            and   name  = 'ROOMPRICEDETAIL_FK'
            and   indid > 0
            and   indid < 255)
   drop index TypePriceDetails.ROOMPRICEDETAIL_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TypePriceDetails')
            and   type = 'U')
   drop table TypePriceDetails
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TypePrices')
            and   type = 'U')
   drop table TypePrices
go

if exists(select 1 from systypes where name='NVARCHAR10')
   drop type NVARCHAR10
go

if exists(select 1 from systypes where name='NVARCHAR50')
   drop type NVARCHAR50
go

/*==============================================================*/
/* Domain: NVARCHAR10                                           */
/*==============================================================*/
create type NVARCHAR10
   from nvarchar(10)
go

/*==============================================================*/
/* Domain: NVARCHAR50                                           */
/*==============================================================*/
create type NVARCHAR50
   from nvarchar(50)
go

/*==============================================================*/
/* Table: BookingDetails                                        */
/*==============================================================*/
create table BookingDetails (
   BookingId            NVARCHAR10           not null,
   RoomId               NVARCHAR10           not null,
   BookingStart         datetime             not null,
   BookingEnd           datetime             not null,
   NumOfCustomer        int                  not null,
   constraint PK_BOOKINGDETAILS primary key (BookingId, RoomId)
)
go

/*==============================================================*/
/* Index: BOOKINGDETAILS_FK                                     */
/*==============================================================*/
create index BOOKINGDETAILS_FK on BookingDetails (
BookingId ASC
)
go

/*==============================================================*/
/* Index: BOOKINGDETAILS_FK2                                    */
/*==============================================================*/
create index BOOKINGDETAILS_FK2 on BookingDetails (
RoomId ASC
)
go

/*==============================================================*/
/* Table: Bookings                                              */
/*==============================================================*/
create table Bookings (
   BookingId            NVARCHAR10           not null,
   CustomerId           NVARCHAR10           not null,
   EmployeeId           NVARCHAR10           not null,
   CreatedDate          datetime             not null,
   constraint PK_BOOKINGS primary key nonclustered (BookingId)
)
go

/*==============================================================*/
/* Index: HAS_FK                                                */
/*==============================================================*/
create index HAS_FK on Bookings (
CustomerId ASC
)
go

/*==============================================================*/
/* Index: HAS_FK2                                               */
/*==============================================================*/
create index HAS_FK2 on Bookings (
EmployeeId ASC
)
go

/*==============================================================*/
/* Table: CheckInDetails                                        */
/*==============================================================*/
create table CheckInDetails (
   CheckInId            NVARCHAR10           not null,
   RoomId               NVARCHAR10           not null,
   RoomPrice            decimal              not null,
   NumOfCustomer        int                  not null,
   CheckInDate          datetime             not null,
   CheckOutDate         datetime             not null,
   constraint PK_CHECKINDETAILS primary key (CheckInId, RoomId)
)
go

/*==============================================================*/
/* Index: CHECKINDETAILS_FK                                     */
/*==============================================================*/
create index CHECKINDETAILS_FK on CheckInDetails (
CheckInId ASC
)
go

/*==============================================================*/
/* Index: CHECKINDETAILS_FK2                                    */
/*==============================================================*/
create index CHECKINDETAILS_FK2 on CheckInDetails (
RoomId ASC
)
go

/*==============================================================*/
/* Table: CheckIns                                              */
/*==============================================================*/
create table CheckIns (
   CheckInId            NVARCHAR10           not null,
   CustomerId           NVARCHAR10           not null,
   EmployeeId           NVARCHAR10           not null,
   BookingId            NVARCHAR10           null,
   CreatedDate          datetime             null,
   constraint PK_CHECKINS primary key nonclustered (CheckInId)
)
go

/*==============================================================*/
/* Index: HAS_FK                                                */
/*==============================================================*/
create index HAS_FK on CheckIns (
CustomerId ASC
)
go

/*==============================================================*/
/* Index: HAS_FK2                                               */
/*==============================================================*/
create index HAS_FK2 on CheckIns (
EmployeeId ASC
)
go

/*==============================================================*/
/* Index: HAS_FK3                                               */
/*==============================================================*/
create index HAS_FK3 on CheckIns (
BookingId ASC
)
go

/*==============================================================*/
/* Table: Customers                                             */
/*==============================================================*/
create table Customers (
   CustomerId           NVARCHAR10           not null,
   Name                 NVARCHAR50           null,
   Address              NVARCHAR50           null,
   Phone                NVARCHAR50           null,
   Fax                  NVARCHAR50           null,
   Telex                NVARCHAR50           null,
   constraint PK_CUSTOMERS primary key nonclustered (CustomerId)
)
go

/*==============================================================*/
/* Table: Employees                                             */
/*==============================================================*/
create table Employees (
   EmployeeId           NVARCHAR10           not null,
   Name                 NVARCHAR50           null,
   Password             NVARCHAR10           not null,
   constraint PK_EMPLOYEES primary key nonclustered (EmployeeId)
)
go

/*==============================================================*/
/* Table: Invoices                                              */
/*==============================================================*/
create table Invoices (
   InvoiceId            NVARCHAR10           not null,
   CheckInId            NVARCHAR10           not null,
   EmployeeId           NVARCHAR10           not null,
   CreatedDate          datetime             not null,
   TotalPrice           decimal              not null,
   constraint PK_INVOICES primary key nonclustered (InvoiceId)
)
go

/*==============================================================*/
/* Index: HAS_FK                                                */
/*==============================================================*/
create index HAS_FK on Invoices (
CheckInId ASC
)
go

/*==============================================================*/
/* Index: HAS_FK2                                               */
/*==============================================================*/
create index HAS_FK2 on Invoices (
EmployeeId ASC
)
go

/*==============================================================*/
/* Table: Reports                                               */
/*==============================================================*/
create table Reports (
   ReportId             NVARCHAR10           not null,
   Name                 NVARCHAR50           null,
   CreatedDate          datetime             not null,
   constraint PK_REPORTS primary key nonclustered (ReportId)
)
go

/*==============================================================*/
/* Table: RoomTypes                                             */
/*==============================================================*/
create table RoomTypes (
   TypeId               NVARCHAR10           not null,
   Name                 NVARCHAR50           null,
   constraint PK_ROOMTYPES primary key nonclustered (TypeId)
)
go

/*==============================================================*/
/* Table: Rooms                                                 */
/*==============================================================*/
create table Rooms (
   RoomId               NVARCHAR10           not null,
   TypeId               NVARCHAR10           null,
   constraint PK_ROOMS primary key nonclustered (RoomId)
)
go

/*==============================================================*/
/* Index: HAS_FK                                                */
/*==============================================================*/
create index HAS_FK on Rooms (
TypeId ASC
)
go

/*==============================================================*/
/* Table: ServiceDetails                                        */
/*==============================================================*/
create table ServiceDetails (
   ServiceId            NVARCHAR10           not null,
   CheckInId            NVARCHAR10           not null,
   Quantity             int                  not null default 0
      constraint CKC_QUANTITY_SERVICED check (Quantity >= 0),
   ServicePrice         decimal              not null,
   constraint PK_SERVICEDETAILS primary key (ServiceId, CheckInId)
)
go

/*==============================================================*/
/* Index: SERVICEDETAILS_FK                                     */
/*==============================================================*/
create index SERVICEDETAILS_FK on ServiceDetails (
ServiceId ASC
)
go

/*==============================================================*/
/* Index: SERVICEDETAILS_FK2                                    */
/*==============================================================*/
create index SERVICEDETAILS_FK2 on ServiceDetails (
CheckInId ASC
)
go

/*==============================================================*/
/* Table: Services                                              */
/*==============================================================*/
create table Services (
   ServiceId            NVARCHAR10           not null,
   Name                 NVARCHAR50           null,
   Price                decimal              not null,
   constraint PK_SERVICES primary key nonclustered (ServiceId)
)
go

/*==============================================================*/
/* Table: TypePriceDetails                                      */
/*==============================================================*/
create table TypePriceDetails (
   TypePriceId          NVARCHAR10           not null,
   TypeId               NVARCHAR10           not null,
   NumOfCustomer        int                  not null,
   constraint PK_TYPEPRICEDETAILS primary key (TypePriceId, TypeId)
)
go

/*==============================================================*/
/* Index: ROOMPRICEDETAIL_FK                                    */
/*==============================================================*/
create index ROOMPRICEDETAIL_FK on TypePriceDetails (
TypePriceId ASC
)
go

/*==============================================================*/
/* Index: ROOMPRICEDETAIL_FK2                                   */
/*==============================================================*/
create index ROOMPRICEDETAIL_FK2 on TypePriceDetails (
TypeId ASC
)
go

/*==============================================================*/
/* Table: TypePrices                                            */
/*==============================================================*/
create table TypePrices (
   TypePriceId          NVARCHAR10           not null,
   Price                decimal              not null,
   constraint PK_TYPEPRICES primary key nonclustered (TypePriceId)
)
go

alter table BookingDetails
   add constraint FK_BOOKINGD_BOOKINGDE_BOOKINGS foreign key (BookingId)
      references Bookings (BookingId)
go

alter table BookingDetails
   add constraint FK_BOOKINGD_BOOKINGDE_ROOMS foreign key (RoomId)
      references Rooms (RoomId)
go

alter table Bookings
   add constraint FK_BOOKINGS_HAS_CUSTOMER foreign key (CustomerId)
      references Customers (CustomerId)
go

alter table Bookings
   add constraint FK_BOOKINGS_HAS_EMPLOYEE foreign key (EmployeeId)
      references Employees (EmployeeId)
go

alter table CheckInDetails
   add constraint FK_CHECKIND_CHECKINDE_CHECKINS foreign key (CheckInId)
      references CheckIns (CheckInId)
go

alter table CheckInDetails
   add constraint FK_CHECKIND_CHECKINDE_ROOMS foreign key (RoomId)
      references Rooms (RoomId)
go

alter table CheckIns
   add constraint FK_CHECKINS_HAS_BOOKINGS foreign key (BookingId)
      references Bookings (BookingId)
go

alter table CheckIns
   add constraint FK_CHECKINS_HAS_CUSTOMER foreign key (CustomerId)
      references Customers (CustomerId)
go

alter table CheckIns
   add constraint FK_CHECKINS_HAS_EMPLOYEE foreign key (EmployeeId)
      references Employees (EmployeeId)
go

alter table Invoices
   add constraint FK_INVOICES_HAS_CHECKINS foreign key (CheckInId)
      references CheckIns (CheckInId)
go

alter table Invoices
   add constraint FK_INVOICES_HAS_EMPLOYEE foreign key (EmployeeId)
      references Employees (EmployeeId)
go

alter table Rooms
   add constraint FK_ROOMS_HAS_ROOMTYPE foreign key (TypeId)
      references RoomTypes (TypeId)
go

alter table ServiceDetails
   add constraint FK_SERVICED_SERVICEDE_CHECKINS foreign key (CheckInId)
      references CheckIns (CheckInId)
go

alter table ServiceDetails
   add constraint FK_SERVICED_SERVICEDE_SERVICES foreign key (ServiceId)
      references Services (ServiceId)
go

alter table TypePriceDetails
   add constraint FK_TYPEPRIC_TYPEPRICE_ROOMTYPE foreign key (TypeId)
      references RoomTypes (TypeId)
go

alter table TypePriceDetails
   add constraint FK_TYPEPRIC_TYPEPRICE_TYPEPRIC foreign key (TypePriceId)
      references TypePrices (TypePriceId)
go

