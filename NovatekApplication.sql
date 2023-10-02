-- DROP TABLE mhdbspace_novatek.dbo.AspNetRoles;

CREATE TABLE mhdbspace_novatek.dbo.AspNetRoles (
	Id nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Name nvarchar(256) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	NormalizedName nvarchar(256) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	ConcurrencyStamp nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT PK_AspNetRoles PRIMARY KEY (Id)
);
 CREATE  UNIQUE NONCLUSTERED INDEX RoleNameIndex ON dbo.AspNetRoles (  NormalizedName ASC  )  
	 WHERE  ([NormalizedName] IS NOT NULL)
	 WITH (  PAD_INDEX = OFF ,FILLFACTOR = 100  ,SORT_IN_TEMPDB = OFF , IGNORE_DUP_KEY = OFF , STATISTICS_NORECOMPUTE = OFF , ONLINE = OFF , ALLOW_ROW_LOCKS = ON , ALLOW_PAGE_LOCKS = ON  )
	 ON [PRIMARY ] ;



-- DROP TABLE mhdbspace_novatek.dbo.AspNetUsers;

CREATE TABLE mhdbspace_novatek.dbo.AspNetUsers (
	Id nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	FullName nvarchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	UserName nvarchar(256) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	NormalizedUserName nvarchar(256) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Email nvarchar(256) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	NormalizedEmail nvarchar(256) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	EmailConfirmed bit NOT NULL,
	PasswordHash nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	SecurityStamp nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	ConcurrencyStamp nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	PhoneNumber nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	PhoneNumberConfirmed bit NOT NULL,
	TwoFactorEnabled bit NOT NULL,
	LockoutEnd datetimeoffset NULL,
	LockoutEnabled bit NOT NULL,
	AccessFailedCount int NOT NULL,
	CONSTRAINT PK_AspNetUsers PRIMARY KEY (Id)
);
 CREATE NONCLUSTERED INDEX EmailIndex ON dbo.AspNetUsers (  NormalizedEmail ASC  )  
	 WITH (  PAD_INDEX = OFF ,FILLFACTOR = 100  ,SORT_IN_TEMPDB = OFF , IGNORE_DUP_KEY = OFF , STATISTICS_NORECOMPUTE = OFF , ONLINE = OFF , ALLOW_ROW_LOCKS = ON , ALLOW_PAGE_LOCKS = ON  )
	 ON [PRIMARY ] ;
 CREATE  UNIQUE NONCLUSTERED INDEX UserNameIndex ON dbo.AspNetUsers (  NormalizedUserName ASC  )  
	 WHERE  ([NormalizedUserName] IS NOT NULL)
	 WITH (  PAD_INDEX = OFF ,FILLFACTOR = 100  ,SORT_IN_TEMPDB = OFF , IGNORE_DUP_KEY = OFF , STATISTICS_NORECOMPUTE = OFF , ONLINE = OFF , ALLOW_ROW_LOCKS = ON , ALLOW_PAGE_LOCKS = ON  )
	 ON [PRIMARY ] ;


-- Drop table

-- DROP TABLE mhdbspace_novatek.dbo.Company;

CREATE TABLE mhdbspace_novatek.dbo.Company (
	Id int IDENTITY(1,1) NOT NULL,
	CompanyName nvarchar(250) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CompanyAddress nvarchar(250) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	City nvarchar(25) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Country nvarchar(25) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Phone nvarchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	FoundedDate datetime2 NULL,
	CONSTRAINT PK_Company PRIMARY KEY (Id)
);


-- Drop table

-- DROP TABLE mhdbspace_novatek.dbo.Department;

CREATE TABLE mhdbspace_novatek.dbo.Department (
	Id int IDENTITY(1,1) NOT NULL,
	DepartmentName nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT PK_Department PRIMARY KEY (Id)
);


-- Drop table

-- DROP TABLE mhdbspace_novatek.dbo.Designation;

CREATE TABLE mhdbspace_novatek.dbo.Designation (
	Id int IDENTITY(1,1) NOT NULL,
	DesignationTitle nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT PK_Designation PRIMARY KEY (Id)
);


-- Drop table

-- DROP TABLE mhdbspace_novatek.dbo.AspNetRoleClaims;

CREATE TABLE mhdbspace_novatek.dbo.AspNetRoleClaims (
	Id int IDENTITY(1,1) NOT NULL,
	RoleId nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	ClaimType nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	ClaimValue nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT PK_AspNetRoleClaims PRIMARY KEY (Id),
	CONSTRAINT FK_AspNetRoleClaims_AspNetRoles_RoleId FOREIGN KEY (RoleId) REFERENCES mhdbspace_novatek.dbo.AspNetRoles(Id) ON DELETE CASCADE
);
 CREATE NONCLUSTERED INDEX IX_AspNetRoleClaims_RoleId ON dbo.AspNetRoleClaims (  RoleId ASC  )  
	 WITH (  PAD_INDEX = OFF ,FILLFACTOR = 100  ,SORT_IN_TEMPDB = OFF , IGNORE_DUP_KEY = OFF , STATISTICS_NORECOMPUTE = OFF , ONLINE = OFF , ALLOW_ROW_LOCKS = ON , ALLOW_PAGE_LOCKS = ON  )
	 ON [PRIMARY ] ;


-- Drop table

-- DROP TABLE mhdbspace_novatek.dbo.AspNetUserClaims;

CREATE TABLE mhdbspace_novatek.dbo.AspNetUserClaims (
	Id int IDENTITY(1,1) NOT NULL,
	UserId nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	ClaimType nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	ClaimValue nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT PK_AspNetUserClaims PRIMARY KEY (Id),
	CONSTRAINT FK_AspNetUserClaims_AspNetUsers_UserId FOREIGN KEY (UserId) REFERENCES mhdbspace_novatek.dbo.AspNetUsers(Id) ON DELETE CASCADE
);
 CREATE NONCLUSTERED INDEX IX_AspNetUserClaims_UserId ON dbo.AspNetUserClaims (  UserId ASC  )  
	 WITH (  PAD_INDEX = OFF ,FILLFACTOR = 100  ,SORT_IN_TEMPDB = OFF , IGNORE_DUP_KEY = OFF , STATISTICS_NORECOMPUTE = OFF , ONLINE = OFF , ALLOW_ROW_LOCKS = ON , ALLOW_PAGE_LOCKS = ON  )
	 ON [PRIMARY ] ;


-- Drop table

-- DROP TABLE mhdbspace_novatek.dbo.AspNetUserLogins;

CREATE TABLE mhdbspace_novatek.dbo.AspNetUserLogins (
	LoginProvider nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	ProviderKey nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	ProviderDisplayName nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	UserId nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CONSTRAINT PK_AspNetUserLogins PRIMARY KEY (LoginProvider,ProviderKey),
	CONSTRAINT FK_AspNetUserLogins_AspNetUsers_UserId FOREIGN KEY (UserId) REFERENCES mhdbspace_novatek.dbo.AspNetUsers(Id) ON DELETE CASCADE
);
 CREATE NONCLUSTERED INDEX IX_AspNetUserLogins_UserId ON dbo.AspNetUserLogins (  UserId ASC  )  
	 WITH (  PAD_INDEX = OFF ,FILLFACTOR = 100  ,SORT_IN_TEMPDB = OFF , IGNORE_DUP_KEY = OFF , STATISTICS_NORECOMPUTE = OFF , ONLINE = OFF , ALLOW_ROW_LOCKS = ON , ALLOW_PAGE_LOCKS = ON  )
	 ON [PRIMARY ] ;


-- Drop table

-- DROP TABLE mhdbspace_novatek.dbo.AspNetUserRoles;

CREATE TABLE mhdbspace_novatek.dbo.AspNetUserRoles (
	UserId nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	RoleId nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CONSTRAINT PK_AspNetUserRoles PRIMARY KEY (UserId,RoleId),
	CONSTRAINT FK_AspNetUserRoles_AspNetRoles_RoleId FOREIGN KEY (RoleId) REFERENCES mhdbspace_novatek.dbo.AspNetRoles(Id) ON DELETE CASCADE,
	CONSTRAINT FK_AspNetUserRoles_AspNetUsers_UserId FOREIGN KEY (UserId) REFERENCES mhdbspace_novatek.dbo.AspNetUsers(Id) ON DELETE CASCADE
);
 CREATE NONCLUSTERED INDEX IX_AspNetUserRoles_RoleId ON dbo.AspNetUserRoles (  RoleId ASC  )  
	 WITH (  PAD_INDEX = OFF ,FILLFACTOR = 100  ,SORT_IN_TEMPDB = OFF , IGNORE_DUP_KEY = OFF , STATISTICS_NORECOMPUTE = OFF , ONLINE = OFF , ALLOW_ROW_LOCKS = ON , ALLOW_PAGE_LOCKS = ON  )
	 ON [PRIMARY ] ;


-- Drop table

-- DROP TABLE mhdbspace_novatek.dbo.AspNetUserTokens;

CREATE TABLE mhdbspace_novatek.dbo.AspNetUserTokens (
	UserId nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	LoginProvider nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Name nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Value nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT PK_AspNetUserTokens PRIMARY KEY (UserId,LoginProvider,Name),
	CONSTRAINT FK_AspNetUserTokens_AspNetUsers_UserId FOREIGN KEY (UserId) REFERENCES mhdbspace_novatek.dbo.AspNetUsers(Id) ON DELETE CASCADE
);

-- Drop table

-- DROP TABLE mhdbspace_novatek.dbo.Employee;

CREATE TABLE mhdbspace_novatek.dbo.Employee (
	Id int IDENTITY(1,1) NOT NULL,
	FullName nvarchar(75) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Dob datetime2 NOT NULL,
	Email nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Phone nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	EmployeeAddress nvarchar(250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CompanyId int NULL,
	DepartmentId int NULL,
	DesignationId int NULL,
	JoiningDate datetime2 NULL,
	IsActive bit NULL,
	CONSTRAINT PK_Employee PRIMARY KEY (Id),
	CONSTRAINT FK_Employee_Company_CompanyId FOREIGN KEY (CompanyId) REFERENCES mhdbspace_novatek.dbo.Company(Id),
	CONSTRAINT FK_Employee_Department_DepartmentId FOREIGN KEY (DepartmentId) REFERENCES mhdbspace_novatek.dbo.Department(Id),
	CONSTRAINT FK_Employee_Designation_DesignationId FOREIGN KEY (DesignationId) REFERENCES mhdbspace_novatek.dbo.Designation(Id)
);
 CREATE NONCLUSTERED INDEX IX_Employee_CompanyId ON dbo.Employee (  CompanyId ASC  )  
	 WITH (  PAD_INDEX = OFF ,FILLFACTOR = 100  ,SORT_IN_TEMPDB = OFF , IGNORE_DUP_KEY = OFF , STATISTICS_NORECOMPUTE = OFF , ONLINE = OFF , ALLOW_ROW_LOCKS = ON , ALLOW_PAGE_LOCKS = ON  )
	 ON [PRIMARY ] ;
 CREATE NONCLUSTERED INDEX IX_Employee_DepartmentId ON dbo.Employee (  DepartmentId ASC  )  
	 WITH (  PAD_INDEX = OFF ,FILLFACTOR = 100  ,SORT_IN_TEMPDB = OFF , IGNORE_DUP_KEY = OFF , STATISTICS_NORECOMPUTE = OFF , ONLINE = OFF , ALLOW_ROW_LOCKS = ON , ALLOW_PAGE_LOCKS = ON  )
	 ON [PRIMARY ] ;
 CREATE NONCLUSTERED INDEX IX_Employee_DesignationId ON dbo.Employee (  DesignationId ASC  )  
	 WITH (  PAD_INDEX = OFF ,FILLFACTOR = 100  ,SORT_IN_TEMPDB = OFF , IGNORE_DUP_KEY = OFF , STATISTICS_NORECOMPUTE = OFF , ONLINE = OFF , ALLOW_ROW_LOCKS = ON , ALLOW_PAGE_LOCKS = ON  )
	 ON [PRIMARY ] ;

-- Drop table

-- DROP TABLE mhdbspace_novatek.dbo.[Increment];

CREATE TABLE mhdbspace_novatek.dbo.[Increment] (
	Id int IDENTITY(1,1) NOT NULL,
	EmployeeId int NOT NULL,
	DesignationId int NOT NULL,
	IncrementPercentage decimal(18,2) NOT NULL,
	IncrementDate datetime2 NOT NULL,
	CONSTRAINT PK_Increment PRIMARY KEY (Id),
	CONSTRAINT FK_Increment_Designation_DesignationId FOREIGN KEY (DesignationId) REFERENCES mhdbspace_novatek.dbo.Designation(Id) ON DELETE CASCADE,
	CONSTRAINT FK_Increment_Employee_EmployeeId FOREIGN KEY (EmployeeId) REFERENCES mhdbspace_novatek.dbo.Employee(Id) ON DELETE CASCADE
);
 CREATE NONCLUSTERED INDEX IX_Increment_DesignationId ON dbo.Increment (  DesignationId ASC  )  
	 WITH (  PAD_INDEX = OFF ,FILLFACTOR = 100  ,SORT_IN_TEMPDB = OFF , IGNORE_DUP_KEY = OFF , STATISTICS_NORECOMPUTE = OFF , ONLINE = OFF , ALLOW_ROW_LOCKS = ON , ALLOW_PAGE_LOCKS = ON  )
	 ON [PRIMARY ] ;
 CREATE NONCLUSTERED INDEX IX_Increment_EmployeeId ON dbo.Increment (  EmployeeId ASC  )  
	 WITH (  PAD_INDEX = OFF ,FILLFACTOR = 100  ,SORT_IN_TEMPDB = OFF , IGNORE_DUP_KEY = OFF , STATISTICS_NORECOMPUTE = OFF , ONLINE = OFF , ALLOW_ROW_LOCKS = ON , ALLOW_PAGE_LOCKS = ON  )
	 ON [PRIMARY ] ;


-- Drop table

-- DROP TABLE mhdbspace_novatek.dbo.Salary;

CREATE TABLE mhdbspace_novatek.dbo.Salary (
	Id int IDENTITY(1,1) NOT NULL,
	EmployeeId int NOT NULL,
	SalaryAmount decimal(18,2) NOT NULL,
	StartDate datetime2 NOT NULL,
	EndDate datetime2 NULL,
	CONSTRAINT PK_Salary PRIMARY KEY (Id),
	CONSTRAINT FK_Salary_Employee_EmployeeId FOREIGN KEY (EmployeeId) REFERENCES mhdbspace_novatek.dbo.Employee(Id) ON DELETE CASCADE
);
 CREATE NONCLUSTERED INDEX IX_Salary_EmployeeId ON dbo.Salary (  EmployeeId ASC  )  
	 WITH (  PAD_INDEX = OFF ,FILLFACTOR = 100  ,SORT_IN_TEMPDB = OFF , IGNORE_DUP_KEY = OFF , STATISTICS_NORECOMPUTE = OFF , ONLINE = OFF , ALLOW_ROW_LOCKS = ON , ALLOW_PAGE_LOCKS = ON  )
	 ON [PRIMARY ] ;
	 
	 
-- Get Filtered Employee Report
	 
	 
	 CREATE PROCEDURE GetFilteredEmployeeReport
    @CompanyId INT = NULL,
    @DepartmentId INT = NULL,
    @DesignationId INT = NULL
AS
BEGIN
	SELECT
	E.Id AS EmployeeId,
	E.FullName AS EmployeeName,
	C.CompanyName,
	D.DepartmentName,
	Des.DesignationTitle,
	S.SalaryAmount
FROM
	dbo.Employee AS E
LEFT JOIN dbo.Company AS C ON
	E.CompanyId = C.Id
LEFT JOIN dbo.Department AS D ON
	E.DepartmentId = D.Id
LEFT JOIN dbo.Designation AS Des ON
	E.DesignationId = Des.Id
LEFT JOIN dbo.Salary AS S ON
	E.Id = S.EmployeeId
WHERE
	(@CompanyId IS NULL
		OR E.CompanyId = @CompanyId)
	AND (@DepartmentId IS NULL
		OR E.DepartmentId = @DepartmentId)
	AND (@DesignationId IS NULL
		OR E.DesignationId = @DesignationId)
	AND E.IsActive = 1;
END;