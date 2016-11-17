/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     11/17/2016 3:52:01 PM                        */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Booking') and o.name = 'FK_BOOKING_HAS_CUSTOMER')
alter table Booking
   drop constraint FK_BOOKING_HAS_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Booking') and o.name = 'FK_BOOKING_HAS_EMPLOYEE')
alter table Booking
   drop constraint FK_BOOKING_HAS_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BookingDetails') and o.name = 'FK_BOOKINGD_BOOKINGDE_BOOKING')
alter table BookingDetails
   drop constraint FK_BOOKINGD_BOOKINGDE_BOOKING
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BookingDetails') and o.name = 'FK_BOOKINGD_BOOKINGDE_ROOMS')
alter table BookingDetails
   drop constraint FK_BOOKINGD_BOOKINGDE_ROOMS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CheckIn') and o.name = 'FK_CHECKIN_HAS_BOOKING')
alter table CheckIn
   drop constraint FK_CHECKIN_HAS_BOOKING
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CheckIn') and o.name = 'FK_CHECKIN_HAS_CUSTOMER')
alter table CheckIn
   drop constraint FK_CHECKIN_HAS_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CheckIn') and o.name = 'FK_CHECKIN_HAS_EMPLOYEE')
alter table CheckIn
   drop constraint FK_CHECKIN_HAS_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CheckInDetails') and o.name = 'FK_CHECKIND_CHECKINDE_CHECKIN')
alter table CheckInDetails
   drop constraint FK_CHECKIND_CHECKINDE_CHECKIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CheckInDetails') and o.name = 'FK_CHECKIND_CHECKINDE_ROOMS')
alter table CheckInDetails
   drop constraint FK_CHECKIND_CHECKINDE_ROOMS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Invoices') and o.name = 'FK_INVOICES_HAS_CHECKIN')
alter table Invoices
   drop constraint FK_INVOICES_HAS_CHECKIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Invoices') and o.name = 'FK_INVOICES_HAS_EMPLOYEE')
alter table Invoices
   drop constraint FK_INVOICES_HAS_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RoomPriceDetail') and o.name = 'FK_ROOMPRIC_ROOMPRICE_ROOMPRIC')
alter table RoomPriceDetail
   drop constraint FK_ROOMPRIC_ROOMPRICE_ROOMPRIC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RoomPriceDetail') and o.name = 'FK_ROOMPRIC_ROOMPRICE_ROOMTYPE')
alter table RoomPriceDetail
   drop constraint FK_ROOMPRIC_ROOMPRICE_ROOMTYPE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Rooms') and o.name = 'FK_ROOMS_HAS_ROOMTYPE')
alter table Rooms
   drop constraint FK_ROOMS_HAS_ROOMTYPE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ServiceDetails') and o.name = 'FK_SERVICED_SERVICEDE_CHECKIN')
alter table ServiceDetails
   drop constraint FK_SERVICED_SERVICEDE_CHECKIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ServiceDetails') and o.name = 'FK_SERVICED_SERVICEDE_SERVICES')
alter table ServiceDetails
   drop constraint FK_SERVICED_SERVICEDE_SERVICES
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Booking')
            and   name  = 'HAS_FK2'
            and   indid > 0
            and   indid < 255)
   drop index Booking.HAS_FK2
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Booking')
            and   name  = 'HAS_FK'
            and   indid > 0
            and   indid < 255)
   drop index Booking.HAS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Booking')
            and   type = 'U')
   drop table Booking
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
           where  id    = object_id('CheckIn')
            and   name  = 'HAS_FK3'
            and   indid > 0
            and   indid < 255)
   drop index CheckIn.HAS_FK3
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CheckIn')
            and   name  = 'HAS_FK2'
            and   indid > 0
            and   indid < 255)
   drop index CheckIn.HAS_FK2
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CheckIn')
            and   name  = 'HAS_FK'
            and   indid > 0
            and   indid < 255)
   drop index CheckIn.HAS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CheckIn')
            and   type = 'U')
   drop table CheckIn
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
            from  sysindexes
           where  id    = object_id('RoomPriceDetail')
            and   name  = 'ROOMPRICEDETAIL_FK2'
            and   indid > 0
            and   indid < 255)
   drop index RoomPriceDetail.ROOMPRICEDETAIL_FK2
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RoomPriceDetail')
            and   name  = 'ROOMPRICEDETAIL_FK'
            and   indid > 0
            and   indid < 255)
   drop index RoomPriceDetail.ROOMPRICEDETAIL_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RoomPriceDetail')
            and   type = 'U')
   drop table RoomPriceDetail
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RoomPrices')
            and   type = 'U')
   drop table RoomPrices
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
/* Table: Booking                                               */
/*==============================================================*/
create table Booking (
   BookingId            NVARCHAR10           not null,
   CustomerId           NVARCHAR10           not null,
   EmployeeId           NVARCHAR10           not null,
   CreatedDate          datetime             not null,
   constraint PK_BOOKING primary key nonclustered (BookingId)
)
go

/*==============================================================*/
/* Index: HAS_FK                                                */
/*==============================================================*/
create index HAS_FK on Booking (
CustomerId ASC
)
go

/*==============================================================*/
/* Index: HAS_FK2                                               */
/*==============================================================*/
create index HAS_FK2 on Booking (
EmployeeId ASC
)
go

/*==============================================================*/
/* Table: BookingDetails                                        */
/*==============================================================*/
create table BookingDetails (
   BookingId            NVARCHAR10           not null,
   RoomId               NVARCHAR10           not null,
   NumOfCustomer        int                  not null,
   BookingEnd           datetime             not null,
   BookingStart         datetime             not null,
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
/* Table: CheckIn                                               */
/*==============================================================*/
create table CheckIn (
   CheckInId            NVARCHAR10           not null,
   CustomerId           NVARCHAR10           not null,
   EmployeeId           NVARCHAR10           not null,
   BookingId            NVARCHAR10           null,
   CreatedDate          datetime             null,
   constraint PK_CHECKIN primary key nonclustered (CheckInId)
)
go

/*==============================================================*/
/* Index: HAS_FK                                                */
/*==============================================================*/
create index HAS_FK on CheckIn (
CustomerId ASC
)
go

/*==============================================================*/
/* Index: HAS_FK2                                               */
/*==============================================================*/
create index HAS_FK2 on CheckIn (
EmployeeId ASC
)
go

/*==============================================================*/
/* Index: HAS_FK3                                               */
/*==============================================================*/
create index HAS_FK3 on CheckIn (
BookingId ASC
)
go

/*==============================================================*/
/* Table: CheckInDetails                                        */
/*==============================================================*/
create table CheckInDetails (
   CheckInId            NVARCHAR10           not null,
   RoomId               NVARCHAR10           not null,
   RentPrice            decimal              not null,
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
/* Table: Customers                                             */
/*==============================================================*/
create table Customers (
   CustomerId           NVARCHAR10           not null,
   Name                 NVARCHAR50           null,
   Address              NVARCHAR50           null,
   Phone                NVARCHAR50           null,
   FAX                  NVARCHAR50           null,
   TELEX                NVARCHAR50           null,
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
   CreatedDate          datetime             not null,
   Name                 NVARCHAR50           null,
   constraint PK_REPORTS primary key nonclustered (ReportId)
)
go

/*==============================================================*/
/* Table: RoomPriceDetail                                       */
/*==============================================================*/
create table RoomPriceDetail (
   RoomPriceId          varchar(45)          not null,
   TypeId               NVARCHAR10           not null,
   NumOfCustomer        int                  not null,
   constraint PK_ROOMPRICEDETAIL primary key (RoomPriceId, TypeId)
)
go

/*==============================================================*/
/* Index: ROOMPRICEDETAIL_FK                                    */
/*==============================================================*/
create index ROOMPRICEDETAIL_FK on RoomPriceDetail (
RoomPriceId ASC
)
go

/*==============================================================*/
/* Index: ROOMPRICEDETAIL_FK2                                   */
/*==============================================================*/
create index ROOMPRICEDETAIL_FK2 on RoomPriceDetail (
TypeId ASC
)
go

/*==============================================================*/
/* Table: RoomPrices                                            */
/*==============================================================*/
create table RoomPrices (
   RoomPriceId          varchar(45)          not null,
   Price                decimal              not null,
   constraint PK_ROOMPRICES primary key nonclustered (RoomPriceId)
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
   Price                decimal              not null,
   constraint PK_SERVICES primary key nonclustered (ServiceId)
)
go

alter table Booking
   add constraint FK_BOOKING_HAS_CUSTOMER foreign key (CustomerId)
      references Customers (CustomerId)
go

alter table Booking
   add constraint FK_BOOKING_HAS_EMPLOYEE foreign key (EmployeeId)
      references Employees (EmployeeId)
go

alter table BookingDetails
   add constraint FK_BOOKINGD_BOOKINGDE_BOOKING foreign key (BookingId)
      references Booking (BookingId)
go

alter table BookingDetails
   add constraint FK_BOOKINGD_BOOKINGDE_ROOMS foreign key (RoomId)
      references Rooms (RoomId)
go

alter table CheckIn
   add constraint FK_CHECKIN_HAS_BOOKING foreign key (BookingId)
      references Booking (BookingId)
go

alter table CheckIn
   add constraint FK_CHECKIN_HAS_CUSTOMER foreign key (CustomerId)
      references Customers (CustomerId)
go

alter table CheckIn
   add constraint FK_CHECKIN_HAS_EMPLOYEE foreign key (EmployeeId)
      references Employees (EmployeeId)
go

alter table CheckInDetails
   add constraint FK_CHECKIND_CHECKINDE_CHECKIN foreign key (CheckInId)
      references CheckIn (CheckInId)
go

alter table CheckInDetails
   add constraint FK_CHECKIND_CHECKINDE_ROOMS foreign key (RoomId)
      references Rooms (RoomId)
go

alter table Invoices
   add constraint FK_INVOICES_HAS_CHECKIN foreign key (CheckInId)
      references CheckIn (CheckInId)
go

alter table Invoices
   add constraint FK_INVOICES_HAS_EMPLOYEE foreign key (EmployeeId)
      references Employees (EmployeeId)
go

alter table RoomPriceDetail
   add constraint FK_ROOMPRIC_ROOMPRICE_ROOMPRIC foreign key (RoomPriceId)
      references RoomPrices (RoomPriceId)
go

alter table RoomPriceDetail
   add constraint FK_ROOMPRIC_ROOMPRICE_ROOMTYPE foreign key (TypeId)
      references RoomTypes (TypeId)
go

alter table Rooms
   add constraint FK_ROOMS_HAS_ROOMTYPE foreign key (TypeId)
      references RoomTypes (TypeId)
go

alter table ServiceDetails
   add constraint FK_SERVICED_SERVICEDE_CHECKIN foreign key (CheckInId)
      references CheckIn (CheckInId)
go

alter table ServiceDetails
   add constraint FK_SERVICED_SERVICEDE_SERVICES foreign key (ServiceId)
      references Services (ServiceId)
go

