/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     5/7/2017 6:28:19 AM                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BRANCH') and o.name = 'FK_BRANCH_MANAGED_B_EMPLOYEE')
alter table BRANCH
   drop constraint FK_BRANCH_MANAGED_B_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Customer_PNO') and o.name = 'FK_CUSTOMER_HAVE_CUSTOMER')
alter table Customer_PNO
   drop constraint FK_CUSTOMER_HAVE_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EMPLOYEE') and o.name = 'FK_EMPLOYEE_EMPLOY_BRANCH')
alter table EMPLOYEE
   drop constraint FK_EMPLOYEE_EMPLOY_BRANCH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EMPLOYEE_PNO') and o.name = 'FK_EMPLOYEE_HAS_EMPLOYEE')
alter table EMPLOYEE_PNO
   drop constraint FK_EMPLOYEE_HAS_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('INCLUDE') and o.name = 'FK_INCLUDE_INCLUDE_ORDER')
alter table INCLUDE
   drop constraint FK_INCLUDE_INCLUDE_ORDER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('INCLUDE') and o.name = 'FK_INCLUDE_INCLUDE2_MEAL')
alter table INCLUDE
   drop constraint FK_INCLUDE_INCLUDE2_MEAL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Meal') and o.name = 'FK_MEAL_PREPARE_EMPLOYEE')
alter table Meal
   drop constraint FK_MEAL_PREPARE_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"ORDER"') and o.name = 'FK_ORDER_DELIVER_EMPLOYEE')
alter table "ORDER"
   drop constraint FK_ORDER_DELIVER_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"ORDER"') and o.name = 'FK_ORDER_REQUEST_CUSTOMER')
alter table "ORDER"
   drop constraint FK_ORDER_REQUEST_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SUPPLIEDBY') and o.name = 'FK_SUPPLIED_SUPPLIEDB_SUPPLIER')
alter table SUPPLIEDBY
   drop constraint FK_SUPPLIED_SUPPLIEDB_SUPPLIER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SUPPLIEDBY') and o.name = 'FK_SUPPLIED_SUPPLIEDB_BRANCH')
alter table SUPPLIEDBY
   drop constraint FK_SUPPLIED_SUPPLIEDB_BRANCH
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BRANCH')
            and   name  = 'MANAGED_BY_FK'
            and   indid > 0
            and   indid < 255)
   drop index BRANCH.MANAGED_BY_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BRANCH')
            and   type = 'U')
   drop table BRANCH
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CUSTOMER')
            and   type = 'U')
   drop table CUSTOMER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Customer_PNO')
            and   name  = 'HAVE_FK'
            and   indid > 0
            and   indid < 255)
   drop index Customer_PNO.HAVE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Customer_PNO')
            and   type = 'U')
   drop table Customer_PNO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EMPLOYEE')
            and   name  = 'EMPLOY_FK'
            and   indid > 0
            and   indid < 255)
   drop index EMPLOYEE.EMPLOY_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EMPLOYEE')
            and   type = 'U')
   drop table EMPLOYEE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EMPLOYEE_PNO')
            and   name  = 'HAS_FK'
            and   indid > 0
            and   indid < 255)
   drop index EMPLOYEE_PNO.HAS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EMPLOYEE_PNO')
            and   type = 'U')
   drop table EMPLOYEE_PNO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('INCLUDE')
            and   name  = 'INCLUDE_FK'
            and   indid > 0
            and   indid < 255)
   drop index INCLUDE.INCLUDE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('INCLUDE')
            and   name  = 'INCLUDE2_FK'
            and   indid > 0
            and   indid < 255)
   drop index INCLUDE.INCLUDE2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('INCLUDE')
            and   type = 'U')
   drop table INCLUDE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Meal')
            and   name  = 'PREPARE_FK'
            and   indid > 0
            and   indid < 255)
   drop index Meal.PREPARE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Meal')
            and   type = 'U')
   drop table Meal
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('"ORDER"')
            and   name  = 'DELIVER_FK'
            and   indid > 0
            and   indid < 255)
   drop index "ORDER".DELIVER_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('"ORDER"')
            and   name  = 'REQUEST_FK'
            and   indid > 0
            and   indid < 255)
   drop index "ORDER".REQUEST_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"ORDER"')
            and   type = 'U')
   drop table "ORDER"
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SUPPLIEDBY')
            and   name  = 'SUPPLIEDBY_FK'
            and   indid > 0
            and   indid < 255)
   drop index SUPPLIEDBY.SUPPLIEDBY_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SUPPLIEDBY')
            and   name  = 'SUPPLIEDBY2_FK'
            and   indid > 0
            and   indid < 255)
   drop index SUPPLIEDBY.SUPPLIEDBY2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SUPPLIEDBY')
            and   type = 'U')
   drop table SUPPLIEDBY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SUPPLIER')
            and   type = 'U')
   drop table SUPPLIER
go

/*==============================================================*/
/* Table: BRANCH                                                */
/*==============================================================*/
create table BRANCH (
   BranchNo             int                  not null,
   ID                   int                  not null,
   Location             varchar(50)          not null,
   constraint PK_BRANCH primary key nonclustered (BranchNo)
)
go

/*==============================================================*/
/* Index: MANAGED_BY_FK                                         */
/*==============================================================*/
create index MANAGED_BY_FK on BRANCH (
ID ASC
)
go

/*==============================================================*/
/* Table: CUSTOMER                                              */
/*==============================================================*/
create table CUSTOMER (
   CustomerID           int                  not null,
   CustomerName         varchar(50)          not null,
   Phone                varchar(50)          not null,
   City                 varchar(50)          not null,
   Country              varchar(50)          not null,
   ZipCode              varchar(20)          not null,
   constraint PK_CUSTOMER primary key nonclustered (CustomerID)
)
go

/*==============================================================*/
/* Table: Customer_PNO                                          */
/*==============================================================*/
create table Customer_PNO (
   CID                  int                  not null,
   Phone_Number         varchar(50)          not null,
   CustomerID           int                  not null,
   constraint PK_CUSTOMER_PNO primary key nonclustered (Phone_Number, CID)
)
go

/*==============================================================*/
/* Index: HAVE_FK                                               */
/*==============================================================*/
create index HAVE_FK on Customer_PNO (
CustomerID ASC
)
go

/*==============================================================*/
/* Table: EMPLOYEE                                              */
/*==============================================================*/
create table EMPLOYEE (
   ID                   int                  not null,
   BranchNo             int                  not null,
   FName                varchar(50)          not null,
   LName                varchar(50)          not null,
   Phone                varchar(50)          not null,
   Salary               float                not null,
   Gender               char(1)              not null,
   Role                 varchar(50)          not null,
   City                 varchar(50)          not null,
   Country              varchar(50)          not null,
   ZipCode              varchar(20)          not null,
   constraint PK_EMPLOYEE primary key nonclustered (ID)
)
go

/*==============================================================*/
/* Index: EMPLOY_FK                                             */
/*==============================================================*/
create index EMPLOY_FK on EMPLOYEE (
BranchNo ASC
)
go

/*==============================================================*/
/* Table: EMPLOYEE_PNO                                          */
/*==============================================================*/
create table EMPLOYEE_PNO (
   PID                  int                  not null,
   PhoneNumber          varchar(50)          not null,
   ID                   int                  not null,
   constraint PK_EMPLOYEE_PNO primary key nonclustered (PID, PhoneNumber)
)
go

/*==============================================================*/
/* Index: HAS_FK                                                */
/*==============================================================*/
create index HAS_FK on EMPLOYEE_PNO (
ID ASC
)
go

/*==============================================================*/
/* Table: INCLUDE                                               */
/*==============================================================*/
create table INCLUDE (
   OrderID              int                  not null,
   MealID               int                  not null,
   constraint PK_INCLUDE primary key nonclustered (OrderID, MealID)
)
go

/*==============================================================*/
/* Index: INCLUDE2_FK                                           */
/*==============================================================*/
create index INCLUDE2_FK on INCLUDE (
MealID ASC
)
go

/*==============================================================*/
/* Index: INCLUDE_FK                                            */
/*==============================================================*/
create index INCLUDE_FK on INCLUDE (
OrderID ASC
)
go

/*==============================================================*/
/* Table: Meal                                                  */
/*==============================================================*/
create table Meal (
   MealID               int                  not null,
   ID                   int                  not null,
   MealName             varchar(50)          not null,
   Category             varchar(50)          not null,
   Price                float                not null,
   MealDescription      varchar(50)          not null,
   constraint PK_MEAL primary key nonclustered (MealID)
)
go

/*==============================================================*/
/* Index: PREPARE_FK                                            */
/*==============================================================*/
create index PREPARE_FK on Meal (
ID ASC
)
go

/*==============================================================*/
/* Table: "ORDER"                                               */
/*==============================================================*/
create table "ORDER" (
   OrderID              int                  not null,
   CustomerID           int                  not null,
   ID                   int                  not null,
   OrderName            varchar(50)          not null,
   Quantity             float                not null,
   Price                float                not null,
   Takeaway             bit                  not null,
   TableNo              int                  not null,
   OrderDate            datetime             not null,
   constraint PK_ORDER primary key nonclustered (OrderID)
)
go

/*==============================================================*/
/* Index: REQUEST_FK                                            */
/*==============================================================*/
create index REQUEST_FK on "ORDER" (
CustomerID ASC
)
go

/*==============================================================*/
/* Index: DELIVER_FK                                            */
/*==============================================================*/
create index DELIVER_FK on "ORDER" (
ID ASC
)
go

/*==============================================================*/
/* Table: SUPPLIEDBY                                            */
/*==============================================================*/
create table SUPPLIEDBY (
   SupplierID           int                  not null,
   BranchNo             int                  not null,
   constraint PK_SUPPLIEDBY primary key nonclustered (SupplierID, BranchNo)
)
go

/*==============================================================*/
/* Index: SUPPLIEDBY2_FK                                        */
/*==============================================================*/
create index SUPPLIEDBY2_FK on SUPPLIEDBY (
BranchNo ASC
)
go

/*==============================================================*/
/* Index: SUPPLIEDBY_FK                                         */
/*==============================================================*/
create index SUPPLIEDBY_FK on SUPPLIEDBY (
SupplierID ASC
)
go

/*==============================================================*/
/* Table: SUPPLIER                                              */
/*==============================================================*/
create table SUPPLIER (
   SupplierID           int                  not null,
   SupplierName         varchar(50)          not null,
   ContactNo            int                  not null,
   SuppliedItem         varchar(50)          not null,
   City                 varchar(50)          not null,
   Country              varchar(50)          not null,
   ZipCode              varchar(20)          not null,
   constraint PK_SUPPLIER primary key nonclustered (SupplierID)
)
go

alter table BRANCH
   add constraint FK_BRANCH_MANAGED_B_EMPLOYEE foreign key (ID)
      references EMPLOYEE (ID)
go

alter table Customer_PNO
   add constraint FK_CUSTOMER_HAVE_CUSTOMER foreign key (CustomerID)
      references CUSTOMER (CustomerID)
go

alter table EMPLOYEE
   add constraint FK_EMPLOYEE_EMPLOY_BRANCH foreign key (BranchNo)
      references BRANCH (BranchNo)
go

alter table EMPLOYEE_PNO
   add constraint FK_EMPLOYEE_HAS_EMPLOYEE foreign key (ID)
      references EMPLOYEE (ID)
go

alter table INCLUDE
   add constraint FK_INCLUDE_INCLUDE_ORDER foreign key (OrderID)
      references "ORDER" (OrderID)
go

alter table INCLUDE
   add constraint FK_INCLUDE_INCLUDE2_MEAL foreign key (MealID)
      references Meal (MealID)
go

alter table Meal
   add constraint FK_MEAL_PREPARE_EMPLOYEE foreign key (ID)
      references EMPLOYEE (ID)
go

alter table "ORDER"
   add constraint FK_ORDER_DELIVER_EMPLOYEE foreign key (ID)
      references EMPLOYEE (ID)
go

alter table "ORDER"
   add constraint FK_ORDER_REQUEST_CUSTOMER foreign key (CustomerID)
      references CUSTOMER (CustomerID)
go

alter table SUPPLIEDBY
   add constraint FK_SUPPLIED_SUPPLIEDB_SUPPLIER foreign key (SupplierID)
      references SUPPLIER (SupplierID)
go

alter table SUPPLIEDBY
   add constraint FK_SUPPLIED_SUPPLIEDB_BRANCH foreign key (BranchNo)
      references BRANCH (BranchNo)
go

