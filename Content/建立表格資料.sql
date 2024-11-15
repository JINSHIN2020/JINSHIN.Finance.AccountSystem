
CREATE TABLE [dbo].[JINSHINFINANCE004](
	[No] [int] IDENTITY(1,1) NOT NULL,
	[IDNo] [nvarchar](10) NULL,
	[SupplyNo] [int] NULL,
	[SName] [nvarchar](50) NULL,
	[SugKey] [nvarchar](5) NULL,
	[FrmSn] [int] NULL,
	[Num] [int] NULL,
	[ChgDate] [datetime] NULL,
	[EDate] [datetime] NULL,
	[CDate] [datetime] NULL,
	[Enable] [bit] NULL,
	[UsrNo] [nvarchar](50) NULL,
	[GNo] [nvarchar](3) NULL,
	[IsBuild] [bit] NULL,
 CONSTRAINT [PK_JINSHINFINANCE004] PRIMARY KEY CLUSTERED 
(
	[No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[JINSHINFINANCE007](
	[PosNo] [int] NOT NULL,
	[SupplyNo] [int] NULL,
	[DeptNo] [int] NULL,
	[JobID] [int] NULL,
	[JobName] [nvarchar](50) NULL,
	[ManageNum] [int] NULL,
	[JobPower] [int] NULL,
	[PowerText] [nvarchar](50) NULL,
	[CreateDate] [datetime] NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateUsr] [nvarchar](50) NULL,
 CONSTRAINT [PK_JINSHINFINANCE007] PRIMARY KEY CLUSTERED 
(
	[PosNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[JINSHINFINANCE008](
	[FormTitle] [nvarchar](50) NOT NULL,
	[FormSn] [int] NOT NULL,
	[CDate] [datetime] NULL,
 CONSTRAINT [PK_JINSHINFINANCE008] PRIMARY KEY CLUSTERED 
(
	[FormSn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[JINSHINFINANCE010](
	[No] [bigint] IDENTITY(1,1) NOT NULL,
	[GnoTh] [int] NULL,
	[UserNo] [nvarchar](50) NULL,
	[UDate] [datetime] NULL,
	[CDate] [datetime] NULL,
 CONSTRAINT [PK_JINSHINFINANCE010] PRIMARY KEY CLUSTERED 
(
	[No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[JINSHINFINANCE012](
	[SN] [bigint] IDENTITY(1,1) NOT NULL,
	[No] [int] NOT NULL,
	[IdNo] [nvarchar](20) NOT NULL,
	[Supply] [nvarchar](150) NOT NULL,
	[SupAddress] [nvarchar](1000) NULL,
	[SuppPhone] [nvarchar](20) NULL,
	[SupKey] [nvarchar](5) NULL,
	[SupEmail] [nvarchar](50) NULL,
	[UsrNo] [nvarchar](50) NULL,
	[CDate] [datetime] NULL,
	[UDate] [datetime] NULL,
	[IdName] [nvarchar](50) NULL,
	[UsrPhone] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[UsrAddress] [nvarchar](500) NULL,
 CONSTRAINT [PK_JINSHINFINANCE012] PRIMARY KEY CLUSTERED 
(
	[SN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE013]    Script Date: 2022/9/10 上午 11:27:42 ******/
CREATE TABLE [dbo].[JINSHINFINANCE013](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[UsrNo] [nvarchar](50) NULL,
	[IdCard] [nvarchar](50) NULL,
	[IdNo] [nvarchar](50) NULL,
	[Supply] [nvarchar](150) NULL,
	[SupAddress] [nvarchar](1000) NULL,
	[SupPhone] [nvarchar](20) NULL,
	[JobTitle] [nvarchar](50) NULL,
	[IDName] [nvarchar](50) NULL,
	[NickName] [nvarchar](50) NULL,
	[Description] [nvarchar](500) NULL,
	[Regdate] [datetime] NULL,
	[updatedate] [datetime] NULL,
	[SnNum] [nvarchar](500) NULL,
	[Enable] [bit] NULL,
	[UserPhone] [nvarchar](15) NULL,
	[AdrNum] [nvarchar](20) NULL,
	[UserAddress] [nvarchar](500) NULL,
	[UsrEmail] [nvarchar](100) NULL,
	[iopen] [bit] NULL,
	[iopenDate] [datetime] NULL,
	[passCode] [nvarchar](10) NULL,
	[Double] [int] NULL,
	[IsReg] [bit] NULL,
	[IsActived] [bit] NULL,
 CONSTRAINT [PK_JINSHINFINANCE013] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE017]    Script Date: 2022/9/10 上午 11:27:42 ******/




CREATE TABLE [dbo].[JINSHINFINANCE017](
	[No] [bigint] IDENTITY(1,1) NOT NULL,
	[SysName] [nvarchar](50) NULL,
	[SysVal] [nvarchar](50) NULL,
	[CreateTime] [datetime] NULL,
	[UDate] [datetime] NULL,
	[VerifyOk] [bit] NULL,
	[UsrNo] [nvarchar](50) NULL,
 CONSTRAINT [PK_JINSHINFINANCE017] PRIMARY KEY CLUSTERED 
(
	[No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE018]    Script Date: 2022/9/10 上午 11:27:42 ******/

CREATE TABLE [dbo].[JINSHINFINANCE018](
	[UsrNo] [nvarchar](50) NOT NULL,
	[SupplyNo] [int] NULL,
	[IDName] [nvarchar](50) NULL,
	[UserName] [nvarchar](50) NULL,
	[Pass] [nvarchar](50) NULL,
	[No] [nvarchar](50) NULL,
	[NickName] [nvarchar](50) NULL,
	[Gender] [bit] NULL,
	[Age] [int] NULL,
	[Photo] [varbinary](max) NULL,
	[Description] [nvarchar](500) NULL,
	[logintime] [datetime] NULL,
	[logincount] [int] NULL,
	[classtype] [int] NULL,
	[classSN] [int] NULL,
	[Regdate] [datetime] NULL,
	[updatedate] [datetime] NULL,
	[dataDate] [datetime] NULL,
	[OUID] [nvarchar](50) NULL,
	[regSN] [nvarchar](500) NULL,
	[Power] [int] NULL,
	[Enable] [bit] NULL,
	[UserPhone] [nvarchar](15) NULL,
	[UserAddress] [nvarchar](500) NULL,
	[UsrEmail] [nvarchar](100) NULL,
	[NoCode] [bit] NULL,
	[NumLen] [int] NULL,
	[PosNo] [int] NULL,
	[JobTitle] [nvarchar](50) NULL,
	[CompanyName] [nvarchar](50) NULL,
	[IdNo] [nvarchar](50) NULL,
	[cardtype] [int] NULL,
	[JFIN24ID] [bigint] NULL,
 CONSTRAINT [PK_JINSHINFINANCE018] PRIMARY KEY CLUSTERED 
(
	[UsrNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE019]    Script Date: 2022/9/10 上午 11:27:42 ******/

CREATE TABLE [dbo].[JINSHINFINANCE019](
	[No] [bigint] IDENTITY(1,1) NOT NULL,
	[SysName] [nvarchar](50) NULL,
	[SysVal] [nvarchar](50) NULL,
	[CreateTime] [datetime] NULL,
	[UDate] [datetime] NULL,
	[VerifyOk] [bit] NULL,
 CONSTRAINT [PK_JINSHINFINANCE019] PRIMARY KEY CLUSTERED 
(
	[No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE020]    Script Date: 2022/9/10 上午 11:27:42 ******/

CREATE TABLE [dbo].[JINSHINFINANCE020](
	[No] [nvarchar](50) NOT NULL,
	[ProName] [nvarchar](50) NULL,
	[ProPos] [int] NULL,
	[DateTime] [datetime] NULL,
	[Enable] [bit] NULL,
 CONSTRAINT [PK_JINSHINFINANCE020] PRIMARY KEY CLUSTERED 
(
	[No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE021]    Script Date: 2022/9/10 上午 11:27:42 ******/




CREATE TABLE [dbo].[JINSHINFINANCE021](
	[sn] [bigint] IDENTITY(1,1) NOT NULL,
	[SupplyNo] [int] NULL,
	[name] [nvarchar](50) NULL,
	[nameid] [nvarchar](50) NULL,
	[classtype] [int] NULL,
	[cardtype] [int] NULL,
	[workTimeVal] [decimal](18, 0) NULL,
	[overTimeVal] [decimal](18, 0) NULL,
	[nonAttendVal] [decimal](18, 0) NULL,
	[sickVal] [decimal](18, 0) NULL,
	[wtBegin] [datetime] NULL,
	[wtContinute] [datetime] NULL,
	[wtReset] [datetime] NULL,
	[wtOver] [datetime] NULL,
	[AoverTimeVal] [decimal](18, 0) NULL,
	[wtEnd] [datetime] NULL,
	[nwstate] [tinyint] NULL,
	[workdate] [datetime] NULL,
	[createtime] [datetime] NULL,
	[updatetime] [datetime] NULL,
	[GNO] [nvarchar](3) NULL,
 CONSTRAINT [PK_JINSHINFINANCE021] PRIMARY KEY CLUSTERED 
(
	[sn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE022]    Script Date: 2022/9/10 上午 11:27:42 ******/




CREATE TABLE [dbo].[JINSHINFINANCE022](
	[sn] [bigint] IDENTITY(1,1) NOT NULL,
	[SupplyNo] [int] NULL,
	[name] [nvarchar](50) NULL,
	[nameid] [nvarchar](50) NULL,
	[timetype] [tinyint] NULL,
	[timevalue] [datetime] NULL,
	[workdate] [datetime] NULL,
	[remark] [nvarchar](50) NULL,
	[addcard] [bit] NULL,
	[IsDelete] [bit] NULL,
	[createtime] [datetime] NULL,
	[GNO] [nvarchar](3) NULL,
	[cardcnt] [int] NULL,
 CONSTRAINT [PK_JINSHINFINANCE022] PRIMARY KEY CLUSTERED 
(
	[sn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE023]    Script Date: 2022/9/10 上午 11:27:42 ******/

CREATE TABLE [dbo].[JINSHINFINANCE023](
	[sn] [bigint] IDENTITY(1,1) NOT NULL,
	[SupplyNo] [int] NULL,
	[wtsn] [bigint] NULL,
	[msn] [bigint] NULL,
	[name] [nvarchar](50) NULL,
	[nameid] [nvarchar](50) NULL,
	[timetype] [tinyint] NULL,
	[WorkDate] [datetime] NULL,
	[FromValue] [datetime] NULL,
	[ToValue] [datetime] NULL,
	[remark] [nvarchar](50) NULL,
	[IsVerify] [int] NULL,
	[VerifyRs] [int] NULL,
	[createtime] [datetime] NULL,
	[GNO] [nvarchar](3) NULL,
	[formid] [int] NULL,
 CONSTRAINT [PK_JINSHINFINANCE023] PRIMARY KEY CLUSTERED 
(
	[sn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE024]    Script Date: 2022/9/10 上午 11:27:42 ******/

CREATE TABLE [dbo].[JINSHINFINANCE024](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[UsrNo] [nvarchar](50) NOT NULL,
	[IdNo] [nvarchar](50) NULL,
	[Supply] [int] NOT NULL,
	[OUID] [nvarchar](50) NOT NULL,
	[SnNum] [nvarchar](50) NOT NULL,
	[A01] [nvarchar](50) NOT NULL,
	[A02] [nvarchar](50) NULL,
	[A03] [nvarchar](50) NULL,
	[A05] [nvarchar](50) NULL,
	[A06] [nvarchar](50) NULL,
	[A07] [nvarchar](50) NULL,
	[A08] [nvarchar](50) NULL,
	[A09] [nvarchar](100) NULL,
	[A10] [nvarchar](50) NULL,
	[A11] [nvarchar](50) NULL,
	[A12] [nvarchar](100) NULL,
	[A13] [nvarchar](50) NULL,
	[A14] [nvarchar](50) NULL,
	[A15] [nvarchar](50) NULL,
	[A16] [nvarchar](50) NULL,
	[A17] [nvarchar](100) NULL,
	[A18] [nvarchar](200) NULL,
	[A19] [nvarchar](50) NULL,
	[A20] [nvarchar](50) NULL,
	[UUsrNo] [nvarchar](50) NOT NULL,
	[UDate] [datetime] NULL,
	[CDate] [datetime] NULL,
	[IsVerify] [bit] NULL,
 CONSTRAINT [PK_JINSHINFINANCE024] PRIMARY KEY CLUSTERED 
(
	[UsrNo] ASC,
	[Supply] ASC,
	[OUID] ASC,
	[SnNum] ASC,
	[A01] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE027]    Script Date: 2022/9/10 上午 11:27:42 ******/

CREATE TABLE [dbo].[JINSHINFINANCE027](
	[IdData] [bigint] IDENTITY(1,1) NOT NULL,
	[SupplyNo] [int] NOT NULL,
	[OUID] [nvarchar](50) NOT NULL,
	[Th] [int] NOT NULL,
	[SnNum] [nvarchar](50) NULL,
	[LiceseCnt] [int] NULL,
	[BuyId] [bigint] NULL,
	[RegId] [bigint] NULL,
	[SnId] [bigint] NOT NULL,
	[CDate] [datetime] NULL,
	[IsCheck] [bit] NULL,
	[OrderNo] [nvarchar](50) NULL,
	[Data] [nvarchar](50) NULL,
 CONSTRAINT [PK_JINSHINFINANCE027] PRIMARY KEY CLUSTERED 
(
	[SupplyNo] ASC,
	[OUID] ASC,
	[Th] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE028]    Script Date: 2022/9/10 上午 11:27:42 ******/

CREATE TABLE [dbo].[JINSHINFINANCE028](
	[IdData] [bigint] IDENTITY(1,1) NOT NULL,
	[SupplyNo] [int] NOT NULL,
	[OUID] [nvarchar](50) NOT NULL,
	[Th] [int] NOT NULL,
	[SnNum] [nvarchar](50) NULL,
	[LiceseCnt] [int] NULL,
	[W02801] [bigint] NULL,
	[W02802] [bigint] NULL,
	[SnId] [bigint] NOT NULL,
	[W02803] [int] NULL,
	[W02804] [nvarchar](50) NULL,
	[W02805] [nvarchar](50) NULL,
	[CDate] [datetime] NULL,
	[W02806] [bit] NULL,
	[W02807] [nvarchar](50) NULL,
	[W02808] [nvarchar](50) NULL,
	[W02809] [nvarchar](50) NULL,
 CONSTRAINT [PK_JINSHINFINANCE028] PRIMARY KEY CLUSTERED 
(
	[IdData] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE029]    Script Date: 2022/9/10 上午 11:27:42 ******/

CREATE TABLE [dbo].[JINSHINFINANCE029](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ProName] [nvarchar](50) NULL,
	[Price] [decimal](18, 2) NULL,
	[datatype] [int] NULL,
	[Months] [int] NULL,
	[CDate] [datetime] NULL,
 CONSTRAINT [PK_JINSHINFINANCE029] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE030]    Script Date: 2022/9/10 上午 11:27:42 ******/

CREATE TABLE [dbo].[JINSHINFINANCE030](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[UsrNo] [nvarchar](50) NOT NULL,
	[IdNo] [nvarchar](50) NULL,
	[Supply] [nvarchar](50) NOT NULL,
	[OUID] [nvarchar](50) NOT NULL,
	[SnNum] [nvarchar](50) NOT NULL,
	[A01] [nvarchar](50) NOT NULL,
	[A02] [nvarchar](50) NULL,
	[RegMonth] [int] NULL,
	[UDate] [datetime] NULL,
	[CDate] [datetime] NULL,
 CONSTRAINT [PK_JINSHINFINANCE030] PRIMARY KEY CLUSTERED 
(
	[UsrNo] ASC,
	[Supply] ASC,
	[OUID] ASC,
	[A01] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE031]    Script Date: 2022/9/10 上午 11:27:42 ******/




CREATE TABLE [dbo].[JINSHINFINANCE031](
	[SN] [int] NOT NULL,
	[DescTitle] [nvarchar](50) NULL,
	[Remark] [nvarchar](50) NULL,
	[IsEnable] [bit] NULL,
	[UDate] [datetime] NULL,
	[CDate] [datetime] NULL,
 CONSTRAINT [PK_JINSHINFINANCE031] PRIMARY KEY CLUSTERED 
(
	[SN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE032]    Script Date: 2022/9/10 上午 11:27:42 ******/




CREATE TABLE [dbo].[JINSHINFINANCE032](
	[SN] [bigint] IDENTITY(1,1) NOT NULL,
	[Acc_No] [nvarchar](15) NOT NULL,
	[Item] [int] NOT NULL,
	[Acc_M] [tinyint] NULL,
	[Acc_ID] [nvarchar](7) NOT NULL,
	[Acc_Date] [datetime] NULL,
	[Acc_Desc] [nvarchar](100) NULL,
	[DataType] [int] NULL,
	[Invoice_No] [nvarchar](10) NULL,
	[Amount] [decimal](18, 2) NULL,
	[Acc_Type] [int] NULL,
	[CreateTime] [datetime] NULL,
 CONSTRAINT [PK_JINSHINFINANCE032] PRIMARY KEY CLUSTERED 
(
	[SN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE033]    Script Date: 2022/9/10 上午 11:27:42 ******/




CREATE TABLE [dbo].[JINSHINFINANCE033](
	[DescID] [int] NOT NULL,
	[Acc_ID] [nvarchar](50) NOT NULL,
	[AffairsNo] [int] NULL,
	[Desc01] [nvarchar](50) NOT NULL,
	[Desc02] [nvarchar](50) NULL,
	[Inv_Class] [int] NULL,
	[Acc_Class] [int] NULL,
	[Acc_Detail] [int] NULL,
	[UDate] [datetime] NULL,
	[CDate] [datetime] NULL,
 CONSTRAINT [PK_JINSHINFINANCE033] PRIMARY KEY CLUSTERED 
(
	[DescID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE034]    Script Date: 2022/9/10 上午 11:27:42 ******/




CREATE TABLE [dbo].[JINSHINFINANCE034](
	[No] [int] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[CreateTime] [datetime] NULL,
 CONSTRAINT [PK_JINSHINFINANCE034] PRIMARY KEY CLUSTERED 
(
	[No] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE035]    Script Date: 2022/9/10 上午 11:27:42 ******/




CREATE TABLE [dbo].[JINSHINFINANCE035](
	[SN] [int] IDENTITY(1,1) NOT NULL,
	[Invoice_No] [nvarchar](20) NULL,
	[Item] [int] NOT NULL,
	[Cost_M] [tinyint] NULL,
	[Acc_ID] [nvarchar](7) NOT NULL,
	[Cost_Date] [datetime] NULL,
	[Cost_Type] [int] NULL,
	[Acc_No] [nvarchar](23) NULL,
	[Acc_Desc] [nvarchar](100) NULL,
	[DataType] [tinyint] NULL,
	[Sell_ID] [nvarchar](10) NULL,
	[Buy_ID] [nvarchar](10) NULL,
	[Amount] [decimal](18, 2) NULL,
	[Status] [int] NULL,
	[HasTax] [bit] NULL,
	[Cost_Check] [bit] NULL,
	[Check_Date] [datetime] NULL,
	[Cost_Compare] [bit] NULL,
	[Cost_Class] [int] NULL,
	[Cost_Detail] [int] NULL,
	[Verify_Month] [tinyint] NULL,
	[Inv_Date] [datetime] NULL,
	[Rec_Type] [int] NULL,
	[Is_Fill] [bit] NULL,
	[CreateTime] [datetime] NULL,
	[Is_Update] [bit] NULL,
	[Is_Reserved] [bit] NULL,
	[Is_Process] [int] NULL,
	[InInvoiceNo] [nvarchar](20) NULL,
	[OrderItem] [int] NULL,
	[IsScan] [bit] NULL,
	[UpdatePerson] [nvarchar](50) NULL,
	[UpdateDateTime] [datetime] NULL,
 CONSTRAINT [PK_JINSHINFINANCE035] PRIMARY KEY CLUSTERED 
(
	[SN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE036]    Script Date: 2022/9/10 上午 11:27:42 ******/




CREATE TABLE [dbo].[JINSHINFINANCE036](
	[SN] [bigint] IDENTITY(1,1) NOT NULL,
	[Acc_Year] [int] NOT NULL,
	[Acc_ID] [nvarchar](7) NOT NULL,
	[Acc_Date] [datetime] NULL,
	[Acc_Desc] [nvarchar](100) NULL,
	[DataType] [tinyint] NULL,
	[Amount] [decimal](18, 2) NULL,
	[InvAmount] [decimal](18, 2) NULL,
	[CancelTimes] [int] NULL,
	[IsVarify] [bit] NULL,
	[CreateTime] [datetime] NULL,
 CONSTRAINT [PK_JINSHINFINANCE036] PRIMARY KEY CLUSTERED 
(
	[Acc_Year] ASC,
	[Acc_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE037]    Script Date: 2022/9/10 上午 11:27:42 ******/




CREATE TABLE [dbo].[JINSHINFINANCE037](
	[No] [int] NOT NULL,
	[MaNo] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[CreateTime] [datetime] NULL,
 CONSTRAINT [PK_JINSHINFINANCE037] PRIMARY KEY CLUSTERED 
(
	[No] ASC,
	[MaNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE038]    Script Date: 2022/9/10 上午 11:27:42 ******/




CREATE TABLE [dbo].[JINSHINFINANCE038](
	[Acc_id] [nvarchar](50) NOT NULL,
	[Acc_Desc] [nvarchar](50) NULL,
	[CDate] [datetime] NULL,
	[UpdatePerson] [nvarchar](50) NULL,
 CONSTRAINT [PK_JINSHINFINANCE038] PRIMARY KEY CLUSTERED 
(
	[Acc_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE039]    Script Date: 2022/9/10 上午 11:27:42 ******/




CREATE TABLE [dbo].[JINSHINFINANCE039](
	[SN] [bigint] IDENTITY(1,1) NOT NULL,
	[Acc_No] [nvarchar](15) NOT NULL,
	[Item] [int] NOT NULL,
	[Acc_M] [tinyint] NULL,
	[Acc_ID] [nvarchar](7) NOT NULL,
	[Acc_Date] [datetime] NULL,
	[Acc_Desc] [nvarchar](100) NULL,
	[DataType] [int] NULL,
	[Invoice_No] [nvarchar](15) NULL,
	[Amount] [decimal](18, 2) NULL,
	[Acc_Type] [int] NULL,
	[Acc_Detail] [int] NULL,
	[Rec_Type] [int] NULL,
	[Sell_ID] [nvarchar](10) NULL,
	[Buy_ID] [nvarchar](10) NULL,
	[CreateTime] [datetime] NULL,
 CONSTRAINT [PK_JINSHINFINANCE039] PRIMARY KEY CLUSTERED 
(
	[SN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE040]    Script Date: 2022/9/10 上午 11:27:42 ******/




CREATE TABLE [dbo].[JINSHINFINANCE040](
	[SN] [int] NULL,
	[Acc_ID] [nvarchar](7) NOT NULL,
	[Acc_Year] [int] NOT NULL,
	[Acc_Date] [datetime] NULL,
	[Acc_Desc] [nvarchar](100) NULL,
	[DataType] [tinyint] NULL,
	[Amount] [decimal](18, 2) NULL,
	[InvAmount] [decimal](18, 2) NULL,
	[CancelTimes] [int] NULL,
	[IsVarify] [bit] NULL,
	[CreateTime] [datetime] NULL,
 CONSTRAINT [PK_JINSHINFINANCE040] PRIMARY KEY CLUSTERED 
(
	[Acc_ID] ASC,
	[Acc_Year] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE041]    Script Date: 2022/9/10 上午 11:27:42 ******/




CREATE TABLE [dbo].[JINSHINFINANCE041](
	[No] [bigint] IDENTITY(1,1) NOT NULL,
	[Acc_ID] [nvarchar](7) NULL,
	[AccName] [nvarchar](50) NULL,
	[EngName] [nvarchar](50) NULL,
	[DataType] [int] NULL,
	[AccDate] [datetime] NULL,
 CONSTRAINT [PK_JINSHINFINANCE041] PRIMARY KEY CLUSTERED 
(
	[No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE042]    Script Date: 2022/9/10 上午 11:27:42 ******/




CREATE TABLE [dbo].[JINSHINFINANCE042](
	[No] [int] IDENTITY(1,1) NOT NULL,
	[SName] [nvarchar](50) NULL,
	[Remark] [nvarchar](50) NULL,
	[UDate] [datetime] NULL,
	[CDate] [datetime] NULL,
 CONSTRAINT [PK_JINSHINFINANCE042] PRIMARY KEY CLUSTERED 
(
	[No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE043]    Script Date: 2022/9/10 上午 11:27:42 ******/




CREATE TABLE [dbo].[JINSHINFINANCE043](
	[Order_No] [nvarchar](50) NOT NULL,
	[OrderName] [nvarchar](50) NULL,
	[TtlPrice] [decimal](18, 2) NULL,
	[UsNo] [nvarchar](50) NULL,
	[Remark] [nvarchar](50) NULL,
	[UDate] [datetime] NULL,
	[CDate] [datetime] NULL,
 CONSTRAINT [PK_JINSHINFINANCE043] PRIMARY KEY CLUSTERED 
(
	[Order_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE044]    Script Date: 2022/9/10 上午 11:27:42 ******/




CREATE TABLE [dbo].[JINSHINFINANCE044](
	[No] [int] NOT NULL,
	[OrderNo] [nvarchar](50) NOT NULL,
	[PName] [nvarchar](50) NULL,
	[ProClass] [nvarchar](50) NULL,
	[PPrice] [decimal](18, 2) NULL,
	[Num] [int] NULL,
	[Discount] [decimal](18, 2) NULL,
	[Remark] [nvarchar](50) NULL,
	[UDate] [datetime] NULL,
	[CDate] [datetime] NULL,
 CONSTRAINT [PK_JINSHINFINANCE044] PRIMARY KEY CLUSTERED 
(
	[No] ASC,
	[OrderNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE045]    Script Date: 2022/9/10 上午 11:27:42 ******/




CREATE TABLE [dbo].[JINSHINFINANCE045](
	[Sn] [int] IDENTITY(1,1) NOT NULL,
	[PName] [nvarchar](50) NULL,
	[PPrice] [decimal](18, 2) NULL,
	[ProClass] [nvarchar](50) NULL,
	[UsrNo] [nvarchar](50) NULL,
	[Num] [int] NULL,
	[Discount] [decimal](18, 2) NULL,
	[Remark] [nvarchar](50) NULL,
	[UDate] [datetime] NULL,
	[CDate] [datetime] NULL,
	[IsDelete] [bit] NULL,
 CONSTRAINT [PK_JINSHINFINANCE045] PRIMARY KEY CLUSTERED 
(
	[Sn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE046]    Script Date: 2022/9/10 上午 11:27:42 ******/




CREATE TABLE [dbo].[JINSHINFINANCE046](
	[No] [bigint] IDENTITY(1,1) NOT NULL,
	[SysName] [nvarchar](50) NULL,
	[SysVal] [nvarchar](50) NULL,
	[CreateTime] [datetime] NULL,
	[UDate] [datetime] NULL,
	[VerifyOk] [bit] NULL,
 CONSTRAINT [PK_JINSHINFINANCE046] PRIMARY KEY CLUSTERED 
(
	[No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE047]    Script Date: 2022/9/10 上午 11:27:42 ******/




CREATE TABLE [dbo].[JINSHINFINANCE047](
	[No] [int] IDENTITY(1,1) NOT NULL,
	[Item] [int] NOT NULL,
	[Verify_Month] [int] NOT NULL,
	[Acc_Date] [datetime] NULL,
	[EmpName] [nvarchar](20) NOT NULL,
	[Acc_ID] [nvarchar](20) NULL,
	[Descrip] [nvarchar](200) NOT NULL,
	[Amount] [decimal](18, 2) NULL,
	[Invoice_No] [nvarchar](50) NULL,
	[Rec_Type] [int] NULL,
	[Inv_Month] [int] NULL,
 CONSTRAINT [PK_JINSHINFINANCE047] PRIMARY KEY CLUSTERED 
(
	[Item] ASC,
	[Verify_Month] ASC,
	[EmpName] ASC,
	[Descrip] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE048]    Script Date: 2022/9/10 上午 11:27:42 ******/




CREATE TABLE [dbo].[JINSHINFINANCE048](
	[SN] [bigint] IDENTITY(1,1) NOT NULL,
	[Acc_Year] [int] NOT NULL,
	[Acc_ID] [nvarchar](7) NOT NULL,
	[Acc_Date] [datetime] NULL,
	[Acc_Desc] [nvarchar](100) NULL,
	[DataType] [tinyint] NULL,
	[Amount] [decimal](18, 2) NULL,
	[CreateTime] [datetime] NULL,
 CONSTRAINT [PK_JINSHINFINANCE048] PRIMARY KEY CLUSTERED 
(
	[Acc_Year] ASC,
	[Acc_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE049]    Script Date: 2022/9/10 上午 11:27:42 ******/




CREATE TABLE [dbo].[JINSHINFINANCE049](
	[AccYear] [int] NOT NULL,
	[IsVerify] [bit] NULL,
	[Remark] [nvarchar](100) NULL,
	[UsrNo] [nvarchar](50) NULL,
	[UDate] [datetime] NULL,
	[CDate] [datetime] NULL,
 CONSTRAINT [PK_JINSHINFINANCE049] PRIMARY KEY CLUSTERED 
(
	[AccYear] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE050]    Script Date: 2022/9/10 上午 11:27:42 ******/




CREATE TABLE [dbo].[JINSHINFINANCE050](
	[No] [int] IDENTITY(1,1) NOT NULL,
	[AffairsName] [nvarchar](50) NULL,
	[CostDate] [datetime] NULL,
	[Sn] [int] NULL,
	[AccId] [nvarchar](7) NULL,
	[datatype] [int] NULL,
	[classtext] [nvarchar](50) NULL,
	[Mdatalink] [int] NULL,
	[Ddatalink] [int] NULL,
	[classtype] [int] NULL,
	[Amount] [decimal](18, 0) NULL,
	[IsDefault] [bit] NULL,
	[CreateTime] [datetime] NULL,
 CONSTRAINT [PK_JINSHINFINANCE050] PRIMARY KEY CLUSTERED 
(
	[No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE051]    Script Date: 2022/9/10 上午 11:27:42 ******/




CREATE TABLE [dbo].[JINSHINFINANCE051](
	[No] [bigint] IDENTITY(1,1) NOT NULL,
	[Acc_Type] [int] NULL,
	[ClassNo] [int] NOT NULL,
	[Item] [int] NOT NULL,
	[AssetsName] [nvarchar](50) NULL,
	[BuyDate] [datetime] NULL,
	[IsFinance] [int] NULL,
	[Acc_ID] [nvarchar](20) NULL,
	[Cnt] [int] NULL,
	[Unit] [nvarchar](20) NULL,
	[Price] [decimal](18, 2) NULL,
	[BookValue] [decimal](18, 2) NULL,
	[ResidualVal] [decimal](18, 2) NULL,
	[RemainVal] [decimal](18, 2) NULL,
	[ReduingAssets] [decimal](18, 2) NULL,
	[MachineYear] [decimal](18, 2) NULL,
	[MonthUsed] [int] NULL,
	[Months] [int] NULL,
	[DepreciatedVal] [decimal](18, 2) NULL,
	[DepreciationVal] [decimal](18, 2) NULL,
	[DepreciateNwDate] [datetime] NULL,
	[Cost_Compare] [bit] NULL,
	[Remark] [nvarchar](1000) NULL,
	[RevaluationVal] [decimal](18, 2) NULL,
	[DepreciateFormula] [decimal](8, 2) NULL,
	[NwYear] [decimal](4, 2) NULL,
 CONSTRAINT [PK_JINSHINFINANCE051] PRIMARY KEY CLUSTERED 
(
	[ClassNo] ASC,
	[Item] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE052]    Script Date: 2022/9/10 上午 11:27:42 ******/




CREATE TABLE [dbo].[JINSHINFINANCE052](
	[SN] [bigint] IDENTITY(1,1) NOT NULL,
	[ClassNo] [int] NOT NULL,
	[Item] [int] NOT NULL,
	[Cost_M] [int] NULL,
	[Acc_ID] [nvarchar](7) NULL,
	[Cost_Date] [datetime] NULL,
	[Cost_Type] [int] NULL,
	[Acc_Desc] [nvarchar](100) NULL,
	[DataType] [int] NULL,
	[AccountDate] [datetime] NULL,
	[Amount] [decimal](18, 0) NULL,
	[Status] [int] NULL,
	[HasTax] [bit] NULL,
	[Cost_Check] [bit] NULL,
	[Check_Date] [datetime] NULL,
	[InInvoiceNo] [nvarchar](20) NULL,
	[CreateTime] [datetime] NULL,
 CONSTRAINT [PK_JINSHINFINANCE052] PRIMARY KEY CLUSTERED 
(
	[ClassNo] ASC,
	[Item] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE053]    Script Date: 2022/9/10 上午 11:27:42 ******/




CREATE TABLE [dbo].[JINSHINFINANCE053](
	[No] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[SubName] [nvarchar](50) NOT NULL,
	[item] [int] NOT NULL,
	[ClassDesc] [nvarchar](100) NULL,
	[CreateTime] [datetime] NULL,
 CONSTRAINT [PK_JINSHINFINANCE053] PRIMARY KEY CLUSTERED 
(
	[Name] ASC,
	[SubName] ASC,
	[item] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE054]    Script Date: 2022/9/10 上午 11:27:42 ******/




CREATE TABLE [dbo].[JINSHINFINANCE054](
	[Sn] [int] IDENTITY(1,1) NOT NULL,
	[Accid] [nvarchar](7) NULL,
	[ComputeNo] [int] NULL,
	[orderth] [int] NULL,
	[datatype] [int] NULL,
	[DescData] [nvarchar](50) NULL,
	[ClassDesc] [nvarchar](50) NULL,
	[MoneyType] [int] NULL,
	[Amount] [decimal](19, 4) NULL,
	[CreateTime] [datetime] NULL,
 CONSTRAINT [PK_JINSHINFINANCE054] PRIMARY KEY CLUSTERED 
(
	[Sn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE055]    Script Date: 2022/9/10 上午 11:27:42 ******/




CREATE TABLE [dbo].[JINSHINFINANCE055](
	[NO] [int] NOT NULL,
	[NoName] [nvarchar](50) NULL,
	[CreateTime] [datetime] NULL,
 CONSTRAINT [PK_JINSHINFINANCE055] PRIMARY KEY CLUSTERED 
(
	[NO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE056]    Script Date: 2022/9/10 上午 11:27:42 ******/




CREATE TABLE [dbo].[JINSHINFINANCE056](
	[Sn] [int] IDENTITY(1,1) NOT NULL,
	[Accid] [nvarchar](7) NULL,
	[ComputeNo] [int] NULL,
	[orderth] [int] NULL,
	[datatype] [int] NULL,
	[DescData] [nvarchar](50) NULL,
	[ClassDesc] [nvarchar](50) NULL,
	[MoneyType] [int] NULL,
	[Amount] [decimal](19, 4) NULL,
	[CreateTime] [datetime] NULL,
 CONSTRAINT [PK_JINSHINFINANCE056] PRIMARY KEY CLUSTERED 
(
	[Sn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE057]    Script Date: 2022/9/10 上午 11:27:42 ******/




CREATE TABLE [dbo].[JINSHINFINANCE057](
	[No] [int] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[CreateTime] [datetime] NULL,
 CONSTRAINT [PK_JINSHINFINANCE057] PRIMARY KEY CLUSTERED 
(
	[No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE058]    Script Date: 2022/9/10 上午 11:27:42 ******/




CREATE TABLE [dbo].[JINSHINFINANCE058](
	[SN] [bigint] NOT NULL,
	[Acc_M] [int] NULL,
	[Acc_No] [nvarchar](15) NULL,
	[Acc_ID] [nvarchar](7) NOT NULL,
	[Item] [int] NOT NULL,
	[Acc_Date] [datetime] NULL,
	[Inv_M] [int] NULL,
	[Inv_Date] [datetime] NULL,
	[Invoice_No] [nvarchar](50) NULL,
	[Acc_Desc] [nvarchar](100) NULL,
	[Inv_Class] [int] NULL,
	[Inv_DetailClass] [int] NULL,
	[DataType] [int] NULL,
	[Amount] [decimal](18, 2) NULL,
	[Is_Inv] [bit] NULL,
	[Is_Verify] [bit] NULL,
	[CreateTime] [datetime] NULL,
	[Is_Fill] [bit] NULL,
	[CostType] [int] NULL,
 CONSTRAINT [PK_JINSHINFINANCE058] PRIMARY KEY CLUSTERED 
(
	[SN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[JINSHINFINANCE059]    Script Date: 2022/9/10 上午 11:27:42 ******/




CREATE TABLE [dbo].[JINSHINFINANCE059](
	[No] [bigint] IDENTITY(1,1) NOT NULL,
	[Sname] [nvarchar](50) NULL,
	[SVal] [nvarchar](50) NULL,
	[CreateTime] [datetime] NULL,
 CONSTRAINT [PK_JINSHINFINANCE059] PRIMARY KEY CLUSTERED 
(
	[No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]


BEGIN TRANSACTION
SET IDENTITY_INSERT [dbo].[JINSHINFINANCE053] ON
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'103', N'1', 1, 1, N'其他建築及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'103', N'1', 2, 2, N'其他建築及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'103', N'1', 3, 3, N'其他建築及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'103', N'1', 4, 4, N'其他建築及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'103', N'1', 5, 5, N'其他建築及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'309', N'1', 1, 6, N'金屬製造設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'311', N'1', 1, 7, N'機械製造設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'311', N'1', 2, 8, N'機械製造設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'320', N'1', 1, 9, N'其他機械及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'320', N'1', 2, 10, N'其他機械及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'320', N'1', 4, 11, N'其他機械及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'320', N'1', 5, 12, N'其他機械及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'320', N'1', 6, 13, N'其他機械及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'320', N'1', 7, 14, N'其他機械及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'320', N'1', 8, 15, N'其他機械及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'320', N'1', 9, 16, N'其他機械及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'320', N'1', 10, 17, N'其他機械及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'320', N'1', 11, 18, N'其他機械及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'320', N'1', 12, 19, N'其他機械及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'320', N'1', 13, 20, N'其他機械及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'320', N'1', 14, 21, N'其他機械及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'320', N'1', 15, 22, N'其他機械及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'320', N'1', 16, 23, N'其他機械及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'320', N'1', 17, 24, N'其他機械及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'320', N'1', 18, 25, N'其他機械及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'320', N'1', 19, 26, N'其他機械及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'320', N'1', 20, 27, N'其他機械及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'320', N'1', 21, 28, N'其他機械及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'320', N'1', 22, 29, N'其他機械及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'320', N'1', 23, 30, N'其他機械及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'320', N'1', 24, 31, N'其他機械及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'320', N'1', 25, 32, N'其他機械及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'320', N'1', 26, 33, N'其他機械及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'320', N'1', 27, 34, N'其他機械及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'320', N'1', 28, 35, N'其他機械及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'320', N'1', 29, 36, N'其他機械及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'320', N'1', 30, 37, N'其他機械及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'320', N'2', 3, 38, N'其他機械及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'501', N'1', 1, 39, N'無形資產-', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'501', N'1', 2, 40, N'其他機械及設備', NULL)
INSERT INTO [dbo].[JINSHINFINANCE053] ([Name], [SubName], [item], [No], [ClassDesc], [CreateTime]) VALUES (N'501', N'1', 3, 41, N'其他機械及設備', NULL)
SET IDENTITY_INSERT [dbo].[JINSHINFINANCE053] OFF

INSERT INTO [dbo].[JINSHINFINANCE018] ([UsrNo], [SupplyNo], [IDName], [UserName], [Pass], [No], [NickName], [Gender], [Age], [Photo], [Description], [logintime], [logincount], [classtype], [classSN], [Regdate], [updatedate], [dataDate], [OUID], [regSN], [Power], [Enable], [UserPhone], [UserAddress], [UsrEmail], [NoCode], [NumLen], [PosNo], [JobTitle], [CompanyName], [IdNo], [cardtype], [JFIN24ID]) VALUES (N'JIN2021012400001', 1, N'蕭榮濱', N'andrew', N'andrew', NULL, NULL, NULL, NULL, NULL, NULL, '20210717 17:20:52.917', 10, 0, NULL, '20210124 14:26:50.880', '20210711 15:28:31.023', NULL, N'da2b68c1-c9c3-4af2-b2c9-a20acc634a64', N'JINSHIN-6f862199-9477-P21f', NULL, 1, N'0903135755', N'桃園市中壢區', N'cktic25@yahoo.com.tw', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)

SET IDENTITY_INSERT [dbo].[JINSHINFINANCE017] ON
INSERT INTO [dbo].[JINSHINFINANCE017] ([No], [SysName], [SysVal], [CreateTime], [UDate], [VerifyOk], [UsrNo]) VALUES (10, N'AccNoNum', N'3', '20201105 23:39:16.250', NULL, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE017] ([No], [SysName], [SysVal], [CreateTime], [UDate], [VerifyOk], [UsrNo]) VALUES (11, N'AccNo', N'WF', '20201105 23:39:16.290', NULL, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE017] ([No], [SysName], [SysVal], [CreateTime], [UDate], [VerifyOk], [UsrNo]) VALUES (12, N'AccNoDate', N'yyyyMMdd', '20201105 23:39:16.303', NULL, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE017] ([No], [SysName], [SysVal], [CreateTime], [UDate], [VerifyOk], [UsrNo]) VALUES (13, N'AccYear', N'2022', '20201121 23:24:27.103', NULL, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE017] ([No], [SysName], [SysVal], [CreateTime], [UDate], [VerifyOk], [UsrNo]) VALUES (14, N'YearSettleMoney', N'-16456.00', '20210222 11:12:04.473', '20220908 22:00:17.417', NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE017] ([No], [SysName], [SysVal], [CreateTime], [UDate], [VerifyOk], [UsrNo]) VALUES (15, N'FinanceSrvAdr', N'localhost', '20210310 01:40:15.507', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[JINSHINFINANCE017] OFF


INSERT INTO [dbo].[JINSHINFINANCE034] ([No], [Name], [CreateTime]) VALUES (0, N'請看一下', '20200207 12:11:34.083')
INSERT INTO [dbo].[JINSHINFINANCE034] ([No], [Name], [CreateTime]) VALUES (1, N'薪資', '20200204 11:04:01.907')
INSERT INTO [dbo].[JINSHINFINANCE034] ([No], [Name], [CreateTime]) VALUES (2, N'辦公', '20200204 11:04:09.080')
INSERT INTO [dbo].[JINSHINFINANCE034] ([No], [Name], [CreateTime]) VALUES (5, N'其他費用', '20200204 11:51:00.693')
INSERT INTO [dbo].[JINSHINFINANCE034] ([No], [Name], [CreateTime]) VALUES (6, N'營業費用', '20200204 11:51:25.713')
INSERT INTO [dbo].[JINSHINFINANCE034] ([No], [Name], [CreateTime]) VALUES (7, N'油資', '20200204 11:04:41.753')
INSERT INTO [dbo].[JINSHINFINANCE034] ([No], [Name], [CreateTime]) VALUES (8, N'廣告費網站', '20200204 11:04:52.017')
INSERT INTO [dbo].[JINSHINFINANCE034] ([No], [Name], [CreateTime]) VALUES (9, N'電話費', '20200204 11:04:57.797')
INSERT INTO [dbo].[JINSHINFINANCE034] ([No], [Name], [CreateTime]) VALUES (10, N'有線電視', '20200204 11:31:58.177')
INSERT INTO [dbo].[JINSHINFINANCE034] ([No], [Name], [CreateTime]) VALUES (11, N'公司勞保費', '20200223 18:11:01.743')
INSERT INTO [dbo].[JINSHINFINANCE034] ([No], [Name], [CreateTime]) VALUES (12, N'金融資產', '20200225 20:03:38.683')
INSERT INTO [dbo].[JINSHINFINANCE034] ([No], [Name], [CreateTime]) VALUES (16, N'利息收入', '20200225 20:02:02.300')
INSERT INTO [dbo].[JINSHINFINANCE034] ([No], [Name], [CreateTime]) VALUES (17, N'手續費收入', '20200226 00:47:59.213')
INSERT INTO [dbo].[JINSHINFINANCE034] ([No], [Name], [CreateTime]) VALUES (18, N'應付帳款', '20200227 10:34:15.767')
INSERT INTO [dbo].[JINSHINFINANCE034] ([No], [Name], [CreateTime]) VALUES (19, N'應付薪資', '20200227 10:34:22.180')
INSERT INTO [dbo].[JINSHINFINANCE034] ([No], [Name], [CreateTime]) VALUES (20, N'其他資產', '20200227 11:53:57.993')
INSERT INTO [dbo].[JINSHINFINANCE034] ([No], [Name], [CreateTime]) VALUES (21, N'無形資產', '20200227 11:54:08.643')
INSERT INTO [dbo].[JINSHINFINANCE034] ([No], [Name], [CreateTime]) VALUES (22, N'折舊', '20200227 11:54:22.713')
INSERT INTO [dbo].[JINSHINFINANCE034] ([No], [Name], [CreateTime]) VALUES (23, N'累計攤銷', '20200227 11:54:29.387')
INSERT INTO [dbo].[JINSHINFINANCE034] ([No], [Name], [CreateTime]) VALUES (24, N'手續費收入', '20200227 11:54:37.173')
INSERT INTO [dbo].[JINSHINFINANCE034] ([No], [Name], [CreateTime]) VALUES (25, N'捐贈', '20200227 11:54:44.577')
INSERT INTO [dbo].[JINSHINFINANCE034] ([No], [Name], [CreateTime]) VALUES (26, N'預付租金', '20200227 11:54:53.977')
INSERT INTO [dbo].[JINSHINFINANCE034] ([No], [Name], [CreateTime]) VALUES (27, N'稅收', '20200227 11:55:27.300')
INSERT INTO [dbo].[JINSHINFINANCE034] ([No], [Name], [CreateTime]) VALUES (28, N'旅費', '20200227 11:55:34.220')
INSERT INTO [dbo].[JINSHINFINANCE034] ([No], [Name], [CreateTime]) VALUES (29, N'稅收', '20200227 11:55:42.773')
INSERT INTO [dbo].[JINSHINFINANCE034] ([No], [Name], [CreateTime]) VALUES (30, N'預付款', '20200227 11:55:53.463')
INSERT INTO [dbo].[JINSHINFINANCE034] ([No], [Name], [CreateTime]) VALUES (31, N'收入', '20220502 16:28:08.940')
INSERT INTO [dbo].[JINSHINFINANCE034] ([No], [Name], [CreateTime]) VALUES (32, N'費用分攤', '20220502 16:29:26.880')

SET IDENTITY_INSERT [dbo].[JINSHINFINANCE050] ON
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (1, NULL, '20200101 00:00:00.000', 1, N'1262', 1, NULL, 30, 1, NULL, NULL, NULL, '20200329 14:28:02.797')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (2, NULL, '20200101 00:00:00.000', 2, N'1113', 2, NULL, 30, 1, NULL, NULL, NULL, '20200329 14:28:02.797')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (3, NULL, '20200101 00:00:00.000', 1, N'6112', 1, NULL, 30, 2, NULL, NULL, 1, '20200329 14:28:02.797')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (4, NULL, '20200101 00:00:00.000', 2, N'1262', 2, NULL, 30, 2, NULL, NULL, 1, '20200329 14:28:02.797')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (5, NULL, '20200103 00:00:00.000', 1, N'6112', 1, NULL, 30, 3, NULL, NULL, 1, '20200329 14:28:02.797')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (6, NULL, '20200103 00:00:00.000', 2, N'6123', 1, NULL, 30, 3, NULL, NULL, 1, '20200329 14:28:02.797')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (7, NULL, '20200103 00:00:00.000', 3, N'1113', 2, NULL, 30, 3, NULL, NULL, 1, '20200329 14:28:02.797')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (8, NULL, '20200105 00:00:00.000', 1, N'6114', 1, NULL, 7, 1, NULL, NULL, NULL, '20200329 14:28:02.797')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (9, NULL, '20200105 00:00:00.000', 2, N'6123', 1, NULL, 7, 1, NULL, NULL, NULL, '20200329 14:28:02.797')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (10, NULL, '20200105 00:00:00.000', 3, N'1113', 2, NULL, 7, 1, NULL, NULL, NULL, '20200329 14:28:02.797')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (13, NULL, '20200130 00:00:00.000', 3, N'6120', 1, NULL, 0, 0, NULL, NULL, 1, '20201230 18:20:58.150')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (14, NULL, '20200130 00:00:00.000', 4, N'1261', 1, NULL, 1, 1, NULL, NULL, 1, '20200329 14:28:02.797')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (15, NULL, '20200130 00:00:00.000', 5, N'2171', 2, NULL, 1, 1, NULL, NULL, 1, '20200329 14:28:02.797')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (17, NULL, '20200110 00:00:00.000', 1, N'2171', 1, NULL, 1, 7, NULL, NULL, 1, '20200329 14:28:02.797')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (18, NULL, '20200110 00:00:00.000', 3, N'2191', 1, NULL, 1, 7, NULL, NULL, 1, '20200329 14:28:02.797')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (19, NULL, '20200110 00:00:00.000', 4, N'1113', 2, NULL, 1, 7, NULL, NULL, 1, '20200329 14:28:02.797')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (20, NULL, '20200110 00:00:00.000', 1, N'6111', 1, NULL, 1, 8, NULL, NULL, 1, '20200329 14:28:02.797')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (21, NULL, '20200110 00:00:00.000', 2, N'1281', 2, NULL, 1, 8, NULL, NULL, 1, '20200329 14:28:02.797')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (22, NULL, '20200110 00:00:00.000', 1, N'6111', 1, NULL, 1, 3, NULL, NULL, 1, '20200329 14:28:02.797')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (23, NULL, '20200110 00:00:00.000', 2, N'6123', 1, NULL, 1, 3, NULL, NULL, 1, '20200329 14:28:02.797')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (24, NULL, '20200110 00:00:00.000', 3, N'1113', 2, NULL, 1, 3, NULL, NULL, 1, '20200329 14:28:02.797')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (25, NULL, '20200110 00:00:00.000', 4, N'1261', 2, NULL, 1, 3, NULL, NULL, 1, '20200329 00:00:00.000')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (28, NULL, '20200101 00:00:00.000', 1, N'6116', 1, N'郵電費', 6, 5, NULL, NULL, 1, '20220901 22:26:33.287')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (29, NULL, '20200101 00:00:00.000', 2, N'6123', 1, N'郵電費', 6, 5, NULL, NULL, 1, '20220901 22:26:36.357')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (30, NULL, '20200101 00:00:00.000', 3, N'1113', 2, N'郵電費', 6, 5, NULL, NULL, 1, '20220901 22:26:37.637')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (47, NULL, NULL, 6, N'2191', 2, N'薪資費用', 1, 2, NULL, NULL, 1, '20201230 17:46:08.917')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (54, NULL, '20200130 00:00:00.000', 1, N'6111', 1, N'薪資費用', 1, 1, NULL, NULL, 1, '20201230 18:44:46.793')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (61, NULL, '20200130 00:00:00.000', 2, N'6120', 1, N'勞保費', 1, 1, NULL, NULL, 1, '20201230 18:44:48.517')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (62, NULL, '20200130 00:00:00.000', 3, N'1281', 1, N'勞健保', 1, 1, NULL, NULL, 1, '20201230 18:44:50.460')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (63, NULL, '20220219 20:54:18.053', 1, N'6134', 1, N'其他費用', 6, 6, NULL, NULL, 1, '20220219 20:54:18.053')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (64, NULL, '20220219 20:54:18.107', 2, N'6123', 2, N'其他費用', 6, 6, NULL, NULL, 1, '20220219 20:54:18.107')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (65, NULL, '20220219 20:54:18.107', 3, N'1113', 3, N'其他費用', 6, 6, NULL, NULL, 1, '20220219 20:54:18.107')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (66, NULL, NULL, 0, N'5111', 1, N'銷貨成本', 2, 1, NULL, 0, 0, '20220501 16:17:53.777')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (67, NULL, NULL, 1, N'5111', 1, N'銷貨成本', 20, 1, NULL, 0, 0, '20220501 16:21:19.597')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (68, NULL, NULL, 2, N'6123', 1, N'稅收', 20, 1, NULL, 0, 0, '20220501 16:21:31.523')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (69, NULL, NULL, 3, N'1113', 2, N'銀行存款', 20, 1, NULL, 0, 0, '20220501 16:21:51.130')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (70, NULL, NULL, 1, N'6113', 1, N'文具用品', 6, 7, NULL, 0, 0, '20220501 16:25:48.987')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (71, NULL, NULL, 2, N'6123', 1, N'文具用品', 6, 7, NULL, 0, 0, '20220501 16:25:54.387')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (72, NULL, NULL, 3, N'1113', 2, N'文具用品', 6, 7, NULL, 0, 0, '20220501 16:25:58.197')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (73, NULL, NULL, 1, N'6134', 1, N'媒體投資娛樂費', 32, 1, NULL, 512, 0, '20220502 16:37:10.573')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (74, NULL, NULL, 2, N'1262', 2, N'媒體投資娛樂費', 32, 1, NULL, 512, 0, '20220502 16:38:58.070')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (75, NULL, NULL, 1, N'1262', 1, N'預付租金', 26, 1, NULL, 0, 0, '20220502 16:40:34.867')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (76, NULL, NULL, 2, N'1113', 2, N'銀行存款', 26, 1, NULL, 0, 0, '20220502 16:40:50.690')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (77, NULL, NULL, 1, N'1191', 1, N'應收帳款', 31, 2, NULL, 0, 0, '20220502 16:42:18.737')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (78, NULL, NULL, 2, N'4111', 2, N'銷貨收入', 31, 2, NULL, 0, 0, '20220502 16:46:11.427')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (80, NULL, NULL, 2, N'2222', 2, N'預收收入', 31, 1, NULL, 0, 0, '20220502 16:48:03.993')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (81, NULL, NULL, 1, N'1113', 1, N'銀行存款', 31, 1, NULL, 0, 0, '20220502 16:48:20.897')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (82, NULL, NULL, 1, N'6112', 1, N'Office365', 2, 2, NULL, 375, 0, '20220502 20:04:04.733')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (83, NULL, NULL, 2, N'6123', 1, N'Office365', 2, 2, NULL, 19, 0, '20220502 20:04:25.140')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (84, NULL, NULL, 3, N'1113', 2, N'Office365', 2, 2, NULL, 394, 0, '20220502 20:05:07.353')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (85, NULL, NULL, 1, N'6112', 1, N'租金支出', 6, 1, NULL, 1000, 0, '20220901 21:40:23.800')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (87, NULL, NULL, 2, N'1262', 2, N'預付租金', 6, 1, NULL, 1000, 0, '20220901 21:40:27.310')
INSERT INTO [dbo].[JINSHINFINANCE050] ([No], [AffairsName], [CostDate], [Sn], [AccId], [datatype], [classtext], [Mdatalink], [Ddatalink], [classtype], [Amount], [IsDefault], [CreateTime]) VALUES (88, NULL, NULL, 1, N'1113', 2, N'銀行存款', 2, 1, NULL, 0, 0, '20220908 21:24:42.667')
SET IDENTITY_INSERT [dbo].[JINSHINFINANCE050] OFF

INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (43, N'1281', NULL, N'勞健保', N'勞健保', 3, 1, 2, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (44, N'1281', NULL, N'業務', N'郵電費', 2, 1, 3, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (45, N'1266', NULL, N'業務', N'郵電費', 2, 1, 3, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (46, N'6111', NULL, N'一個員工', N'實領薪', 3, 1, 1, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (47, N'6120', NULL, N'勞保', N'公司勞保', 3, 11, 0, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (48, N'6116', NULL, N'電話', N'電話費', 2, 9, 0, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (49, N'6112', NULL, N'Office365', N'Office365', 2, 5, 0, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (50, N'7243', NULL, N'金融資產', N'手續費', 5, 12, 1, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (51, N'7236', NULL, N'金融資產', N'手續費收入', 6, 17, 0, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (52, N'6123', NULL, N'金融資產', N'交易稅', 5, 12, 2, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (53, N'7111', NULL, N'利息', N'利息收入', 6, 16, 0, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (54, N'7162', NULL, N'金融資產', N'投資支出', 5, 12, 3, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (55, N'7161', NULL, N'金融資產', N'投資收入', 5, 12, 4, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (56, N'7141', NULL, N'股利收入', N'股利收入', 5, 12, 5, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (57, N'1261', NULL, N'業務', N'郵電費', 2, 1, 3, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (58, N'2171', NULL, N'薪資', N'應付帳款', 11, 18, 0, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (59, N'2191', NULL, N'薪資', N'應付薪資', 11, 19, 0, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (60, N'2171', NULL, N'', N'應付帳款', 11, 18, 1, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (61, N'2191', NULL, N'', N'應付薪資', 11, 19, 1, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (62, N'1586', NULL, N'', N'其他資產', 12, 20, 0, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (63, N'1533', NULL, N'', N'無形資產', 12, 21, 0, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (64, N'6125', NULL, N'', N'折舊', 3, 22, 0, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (65, N'6126', NULL, N'', N'累計攤銷', 3, 23, 0, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (66, N'7236', NULL, N'', N'手續費收入', 6, 24, 0, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (67, N'6122', NULL, N'', N'捐贈', 3, 25, 0, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (68, N'1262', NULL, N'', N'預付租金', 3, 26, 0, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (69, N'6123', NULL, N'', N'稅收', 13, 27, 0, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (70, N'6114', NULL, N'', N'旅費', 2, 28, 0, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (71, N'5162', NULL, N'', N'稅收', 13, 29, 0, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (72, N'1266', NULL, N'', N'預付貨款', 3, 30, 0, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (73, N'6134', NULL, N'', N'其他費用', 3, 31, 0, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (74, N'1121', NULL, N'金融資產', N'金融資產', 5, 12, 7, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (75, N'6112', NULL, N'辦公租金', N'辦公租金', 3, 2, 0, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (78, N'1261', 5, N'業務支出', N'業務支出', NULL, NULL, NULL, '20210106 12:09:59.307', '20210106 10:02:45.263')
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (79, N'6112', 6, N'辦公費用', N'辦公費用', NULL, NULL, NULL, NULL, '20210514 17:34:28.860')
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (80, N'6112', 6, N'辦公費用', N'月份office', NULL, NULL, NULL, '20210514 20:49:36.017', '20210514 17:34:40.233')
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (81, N'1262', 7, N'辦公租金', N'租金', NULL, NULL, NULL, NULL, '20210514 18:36:15.267')
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (82, N'1281', 5, N'業務支出', N'業務支出', NULL, NULL, NULL, NULL, '20210514 21:37:32.143')
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (83, N'1261', 9, N'員工勞健保', N'勞健保', NULL, NULL, NULL, NULL, '20210516 23:55:17.157')
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (84, N'1281', 9, N'員工勞健保', N'勞健保', NULL, NULL, NULL, NULL, '20210516 23:55:26.360')
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (85, N'6120', 8, N'公司勞保', N'公司勞保', NULL, NULL, NULL, NULL, '20210516 23:55:42.583')
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (86, N'6112', 10, N'軟體Office', N'office365', NULL, NULL, NULL, '20210518 13:30:08.647', '20210518 13:28:55.213')
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (87, N'6116', 3, N'郵電費', N'郵電費', NULL, NULL, NULL, NULL, '20210518 13:33:43.437')
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (88, N'6111', 11, N'薪資支出', N'薪資', NULL, NULL, NULL, '20220108 16:11:13.337', '20210518 19:57:32.617')
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (89, N'2191', 12, N'應付薪資', N'薪資', NULL, NULL, NULL, NULL, '20210518 21:13:16.793')
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (90, N'1121', 13, N'證交款', N'金融資產', NULL, NULL, NULL, NULL, '20210519 18:06:31.167')
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (91, N'6134', 14, N'最新消息媒體', N'預付投資、最新消息媒體', NULL, NULL, NULL, NULL, '20210519 20:30:29.507')
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (92, N'6134', 4, N'郵資', N'郵', NULL, NULL, NULL, NULL, '20210519 20:37:13.783')
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (93, N'2171', 15, N'支付公司勞保', N'公司勞保', NULL, NULL, NULL, NULL, '20210519 23:06:05.793')
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (94, N'5111', 16, N'銷貨成本', N' ', NULL, NULL, NULL, '20220908 22:41:06.353', '20220501 16:13:01.183')
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (95, N'6123', 16, N'銷貨成本', N'稅收', NULL, NULL, NULL, NULL, '20220501 16:13:27.027')
INSERT INTO [dbo].[JINSHINFINANCE033] ([DescID], [Acc_ID], [AffairsNo], [Desc01], [Desc02], [Inv_Class], [Acc_Class], [Acc_Detail], [UDate], [CDate]) VALUES (96, N'1113', 16, N'銷貨成本', N'銷貨成本', NULL, NULL, NULL, NULL, '20220501 16:13:48.023')

INSERT INTO [dbo].[JINSHINFINANCE049] ([AccYear], [IsVerify], [Remark], [UsrNo], [UDate], [CDate]) VALUES (109, 0, NULL, NULL, '20220622 19:37:06.530', '20210222 11:09:42.960')
INSERT INTO [dbo].[JINSHINFINANCE049] ([AccYear], [IsVerify], [Remark], [UsrNo], [UDate], [CDate]) VALUES (110, 1, NULL, NULL, '20220622 19:57:02.853', '20220604 18:31:14.907')
INSERT INTO [dbo].[JINSHINFINANCE049] ([AccYear], [IsVerify], [Remark], [UsrNo], [UDate], [CDate]) VALUES (111, 1, NULL, N'JIN2021012400002', '20220908 21:59:59.000', '20220908 21:25:45.263')


INSERT INTO [dbo].[JINSHINFINANCE031] ([SN], [DescTitle], [Remark], [IsEnable], [UDate], [CDate]) VALUES (3, N'郵電費', NULL, NULL, '20210516 23:54:43.313', '20210102 18:02:26.563')
INSERT INTO [dbo].[JINSHINFINANCE031] ([SN], [DescTitle], [Remark], [IsEnable], [UDate], [CDate]) VALUES (4, N'郵資', NULL, NULL, '20210104 01:52:33.367', '20210103 21:29:09.677')
INSERT INTO [dbo].[JINSHINFINANCE031] ([SN], [DescTitle], [Remark], [IsEnable], [UDate], [CDate]) VALUES (5, N'業務支出', NULL, NULL, NULL, '20210106 10:02:29.390')
INSERT INTO [dbo].[JINSHINFINANCE031] ([SN], [DescTitle], [Remark], [IsEnable], [UDate], [CDate]) VALUES (6, N'辦公費用', NULL, NULL, NULL, '20210514 17:33:34.460')
INSERT INTO [dbo].[JINSHINFINANCE031] ([SN], [DescTitle], [Remark], [IsEnable], [UDate], [CDate]) VALUES (7, N'辦公租金', NULL, NULL, NULL, '20210514 18:36:01.837')
INSERT INTO [dbo].[JINSHINFINANCE031] ([SN], [DescTitle], [Remark], [IsEnable], [UDate], [CDate]) VALUES (8, N'公司勞保', NULL, NULL, NULL, '20210516 23:54:53.737')
INSERT INTO [dbo].[JINSHINFINANCE031] ([SN], [DescTitle], [Remark], [IsEnable], [UDate], [CDate]) VALUES (9, N'員工勞健保', NULL, NULL, NULL, '20210516 23:55:06.917')
INSERT INTO [dbo].[JINSHINFINANCE031] ([SN], [DescTitle], [Remark], [IsEnable], [UDate], [CDate]) VALUES (10, N'軟體Office', NULL, NULL, '20210518 13:29:10.487', '20210518 13:28:09.700')
INSERT INTO [dbo].[JINSHINFINANCE031] ([SN], [DescTitle], [Remark], [IsEnable], [UDate], [CDate]) VALUES (11, N'薪資支出', NULL, NULL, NULL, '20210518 19:57:16.963')
INSERT INTO [dbo].[JINSHINFINANCE031] ([SN], [DescTitle], [Remark], [IsEnable], [UDate], [CDate]) VALUES (12, N'應付薪資', NULL, NULL, NULL, '20210518 21:13:00.040')
INSERT INTO [dbo].[JINSHINFINANCE031] ([SN], [DescTitle], [Remark], [IsEnable], [UDate], [CDate]) VALUES (13, N'證交款', NULL, NULL, NULL, '20210519 18:06:10.250')
INSERT INTO [dbo].[JINSHINFINANCE031] ([SN], [DescTitle], [Remark], [IsEnable], [UDate], [CDate]) VALUES (14, N'最新消息媒體', NULL, NULL, NULL, '20210519 20:30:07.513')
INSERT INTO [dbo].[JINSHINFINANCE031] ([SN], [DescTitle], [Remark], [IsEnable], [UDate], [CDate]) VALUES (15, N'支付公司勞保', NULL, NULL, NULL, '20210519 23:05:52.303')
INSERT INTO [dbo].[JINSHINFINANCE031] ([SN], [DescTitle], [Remark], [IsEnable], [UDate], [CDate]) VALUES (16, N'銷貨成本', NULL, NULL, NULL, '20220501 16:12:35.687')

SET IDENTITY_INSERT [dbo].[JINSHINFINANCE046] ON
INSERT INTO [dbo].[JINSHINFINANCE046] ([No], [SysName], [SysVal], [CreateTime], [UDate], [VerifyOk]) VALUES (10, N'AccNoNum', N'3', '20201105 23:39:16.250', NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE046] ([No], [SysName], [SysVal], [CreateTime], [UDate], [VerifyOk]) VALUES (11, N'AccNo', N'WF', '20201105 23:39:16.290', NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE046] ([No], [SysName], [SysVal], [CreateTime], [UDate], [VerifyOk]) VALUES (12, N'AccNoDate', N'yyyyMMdd', '20201105 23:39:16.303', NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE046] ([No], [SysName], [SysVal], [CreateTime], [UDate], [VerifyOk]) VALUES (13, N'AccYear', N'2020', '20201121 23:24:27.103', NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE046] ([No], [SysName], [SysVal], [CreateTime], [UDate], [VerifyOk]) VALUES (14, N'YearSettleMoney', N'-305316.00', '20210222 11:12:04.473', '20220604 19:30:50.797', NULL)
INSERT INTO [dbo].[JINSHINFINANCE046] ([No], [SysName], [SysVal], [CreateTime], [UDate], [VerifyOk]) VALUES (15, N'FinanceSrvAdr', N'114.32.203.5', '20210310 01:40:15.507', NULL, NULL)
SET IDENTITY_INSERT [dbo].[JINSHINFINANCE046] OFF

SET IDENTITY_INSERT [dbo].[JINSHINFINANCE029] ON
INSERT INTO [dbo].[JINSHINFINANCE029] ([ID], [ProName], [Price], [datatype], [Months], [CDate]) VALUES (1, N'金心財務報稅系統', 1000.00, 2, 1, '20220703 13:36:34.087')
INSERT INTO [dbo].[JINSHINFINANCE029] ([ID], [ProName], [Price], [datatype], [Months], [CDate]) VALUES (2, N'金心財務報稅系統', 1900.00, 2, 2, '20220703 13:36:34.270')
INSERT INTO [dbo].[JINSHINFINANCE029] ([ID], [ProName], [Price], [datatype], [Months], [CDate]) VALUES (3, N'金心財務報稅系統', 2700.00, 2, 3, '20220703 13:36:34.273')
INSERT INTO [dbo].[JINSHINFINANCE029] ([ID], [ProName], [Price], [datatype], [Months], [CDate]) VALUES (4, N'金心財務報稅系統', 4500.00, 2, 6, '20220703 13:36:34.273')
INSERT INTO [dbo].[JINSHINFINANCE029] ([ID], [ProName], [Price], [datatype], [Months], [CDate]) VALUES (5, N'金心財務報稅系統', 9000.00, 2, 12, '20220703 13:36:34.273')
INSERT INTO [dbo].[JINSHINFINANCE029] ([ID], [ProName], [Price], [datatype], [Months], [CDate]) VALUES (6, N'金心財務報稅系統', 18000.00, 1, 12, '20220703 13:45:17.170')
SET IDENTITY_INSERT [dbo].[JINSHINFINANCE029] OFF

INSERT INTO [dbo].[JINSHINFINANCE044] ([No], [OrderNo], [PName], [ProClass], [PPrice], [Num], [Discount], [Remark], [UDate], [CDate]) VALUES (1, N'RE2021010200001', N'蘿蔔糕', N'食品', 30.00, 3, 1.00, NULL, NULL, '20210102 17:42:39.550')
INSERT INTO [dbo].[JINSHINFINANCE044] ([No], [OrderNo], [PName], [ProClass], [PPrice], [Num], [Discount], [Remark], [UDate], [CDate]) VALUES (1, N'RE2021010300001', N'蘿蔔糕', N'食品', 40.00, 4, 1.00, NULL, NULL, '20210103 16:57:12.710')

SET IDENTITY_INSERT [dbo].[JINSHINFINANCE028] ON
INSERT INTO [dbo].[JINSHINFINANCE028] ([IdData], [SupplyNo], [OUID], [Th], [SnNum], [LiceseCnt], [W02801], [W02802], [SnId], [W02803], [W02804], [W02805], [CDate], [W02806], [W02807], [W02808], [W02809]) VALUES (47, 1, N'f83d55dc-ed1a-497c-9c92-783af231c13c', 1, N'JINSHIN-51fab7c3-da28-104G', 1, 11, 11, 0, 91, N'qVKlgBqsH8G8DPkCDt8Q==', N'riTdovHAL0ioG8DPkCDt8Q==', '20220905 11:22:57.490', 1, N'X7f8R/3uD97RNHOYx8jHCK8hDcPunEV1', N'u8WdQOjhJkwd6MBu7uYBZA==', N'wmMFdZOsFns=')
INSERT INTO [dbo].[JINSHINFINANCE028] ([IdData], [SupplyNo], [OUID], [Th], [SnNum], [LiceseCnt], [W02801], [W02802], [SnId], [W02803], [W02804], [W02805], [CDate], [W02806], [W02807], [W02808], [W02809]) VALUES (48, 1, N'f83d55dc-ed1a-497c-9c92-783af231c13c', 2, N'JINSHIN-1e22d156-3158-0ApV', 1, 12, 12, 0, 30, N'qVKlgBqsH8G8DPkCDt8Q==', N'ZY/Jwd3aCOFcATTkDXBa3Q==', '20220905 11:26:24.887', 1, N'X7f8R/3uD96pX6GRJo6/rz3S1BbfOylR', N'u8WdQOjhJkwd6MBu7uYBZA==', N'iVHV06N6iZw=')
INSERT INTO [dbo].[JINSHINFINANCE028] ([IdData], [SupplyNo], [OUID], [Th], [SnNum], [LiceseCnt], [W02801], [W02802], [SnId], [W02803], [W02804], [W02805], [CDate], [W02806], [W02807], [W02808], [W02809]) VALUES (49, 1, N'f83d55dc-ed1a-497c-9c92-783af231c13c', 3, N'JINSHIN-4a33ec14-bde5-Ss94', 1, 13, 13, 0, 61, N'qVKlgBqsH8G8DPkCDt8Q==', N'dFZBE13/M5TiJvcld5x2eA==', '20220905 11:28:15.733', 1, N'X7f8R/3uD97sFBYTwTymJj3S1BbfOylR', N'u8WdQOjhJkwd6MBu7uYBZA==', N'PdLUFt87KVE=')
INSERT INTO [dbo].[JINSHINFINANCE028] ([IdData], [SupplyNo], [OUID], [Th], [SnNum], [LiceseCnt], [W02801], [W02802], [SnId], [W02803], [W02804], [W02805], [CDate], [W02806], [W02807], [W02808], [W02809]) VALUES (50, 1, N'f83d55dc-ed1a-497c-9c92-783af231c13c', 1, N'JINSHIN-b4461697-00e1-0D0i', 1, 14, 14, 0, 30, N'riPuhQ7GZCYkrqcFy+JTfA==', N'UiNJOv/zMuckrqcFy+JTfA==', '20220906 15:07:21.663', 1, N'01mIuKv2mUHzzC272Stq2tZc91Y379EK', N'Sl3+REMcCgnsx8a4y4Wiow==', N'hiBtCaDYxFo=')
INSERT INTO [dbo].[JINSHINFINANCE028] ([IdData], [SupplyNo], [OUID], [Th], [SnNum], [LiceseCnt], [W02801], [W02802], [SnId], [W02803], [W02804], [W02805], [CDate], [W02806], [W02807], [W02808], [W02809]) VALUES (51, 1, N'f83d55dc-ed1a-497c-9c92-783af231c13c', 1, N'JINSHIN-b4461697-00e1-0D0i', 1, 14, 14, 0, 30, N'oiW8jL55vOsk/r6Zl16Pag==', N'wHU4mAFgYd4k/r6Zl16Pag==', '20220907 16:15:27.597', 1, N'ITRKdumjtJrcVY13wbLs7+IZAA+xb69j', N'549rqJkqs4qzBamyRGicCQ==', N'NlHtS7SgRoU=')
SET IDENTITY_INSERT [dbo].[JINSHINFINANCE028] OFF

INSERT INTO [dbo].[JINSHINFINANCE043] ([Order_No], [OrderName], [TtlPrice], [UsNo], [Remark], [UDate], [CDate]) VALUES (N'RE2021010200001', N'2021010217餐點', 30.00, NULL, NULL, NULL, '20210102 17:42:39.550')
INSERT INTO [dbo].[JINSHINFINANCE043] ([Order_No], [OrderName], [TtlPrice], [UsNo], [Remark], [UDate], [CDate]) VALUES (N'RE2021010300001', N'2021010316餐點', 40.00, NULL, NULL, NULL, '20210103 16:57:12.710')

SET IDENTITY_INSERT [dbo].[JINSHINFINANCE024] ON
INSERT INTO [dbo].[JINSHINFINANCE024] ([UsrNo], [Supply], [OUID], [SnNum], [A01], [ID], [IdNo], [A02], [A03], [A05], [A06], [A07], [A08], [A09], [A10], [A11], [A12], [A13], [A14], [A15], [A16], [A17], [A18], [A19], [A20], [UUsrNo], [UDate], [CDate], [IsVerify]) VALUES (N'JIN2021012400001', 1, N'da2b68c1-c9c3-4af2-b2c9-a20acc634a64', N'JINSHIN-ea20582a-ef32-Qy0K', N'', 24, N'69746686', N'+YerRtZKJ3tnAAeRS+MjJw==', N'P7fpE4kWnjwrxjbFI5gEbw==', N'NkI3TDJPNw==', N'vNLRin8BSzezBamyRGicCQ==', N'P7fpE4kWnjylmtrsqjV9iA==', N'b1Bh2q1dNxihIZob9FR4wlfKZybPhBJqB4bAs9aAQQ4=', N'b1Bh2q1dNxhYSF6yb3UmYuPxpF8oZArd', N'pukPufB7XF4=', N'XYegYuQTuIELpDxZojCIJA==', N'lzxUG+sSeacVXBJjWjU3W0RAhXtvVqE/', N'wi3+4yBUIeTfZDs0Teo3eg==', N'JfSRjC7DrDNnhu7k36DG8rMFqbJEaJwJ', N'AHzYGPGbVr4bEBMb3xSB1oUpHF1A2jdX', N'BjsW8tA1cJs=', N'zOG58Ab0jlw=', N'sAVh+hpFSNRIbzvxOoMMRRFuCcy/FcWL0HzessKmL3MDwemQ2WETfrMFqbJEaJwJ', N'F6rv7mN2HpSdhv22NCcg57MFqbJEaJwJ', NULL, N'JIN2021012400001', '20220907 16:49:34.867', '20220907 16:49:34.867', NULL)
INSERT INTO [dbo].[JINSHINFINANCE024] ([UsrNo], [Supply], [OUID], [SnNum], [A01], [ID], [IdNo], [A02], [A03], [A05], [A06], [A07], [A08], [A09], [A10], [A11], [A12], [A13], [A14], [A15], [A16], [A17], [A18], [A19], [A20], [UUsrNo], [UDate], [CDate], [IsVerify]) VALUES (N'JIN2021012400002', 1, N'f83d55dc-ed1a-497c-9c92-783af231c13c', N'JINSHIN-b4461697-00e1-0D0i', N'::1', 23, N'69746686', N'PwWKz9i5IUlyfNIyyK8avA==', N'JQ5gfkbTy9WJFlVWm5y4EQ==', N'Nk8xQjZQNw==', N'qkwKAQp5ncvsx8a4y4Wiow==', N'JQ5gfkbTy9VPNUh/5wf9LQ==', N'b8quYG2XalDODoTZDEnl+nIzwmAkJMkG7MfGuMuFoqM=', N'b8quYG2XalD4wqqC/bZBjSxpxvhc18SF', N'2fSlsJ7hh3g=', N'TBD2hMBAoMWZ8XfP0WJAiQ==', N's5L5ck0OhtsF5XnV69CWAa1HEeFYYVus', N'AXLRbZaqfzgh0LdZhGsuEA==', N'IpNb4GGargk/6SoGTAHa8+zHxrjLhaKj', N'H4xkbP4mFu5OSIE1wgDwmAkjZlPjhkNC', N'iZrfHx95edA=', N'PH7XFRjsmyc=', N'+EnepvYdBNmXlRudZcyZuE2H6Qj0XSym+tIgWfH88DAJ+706CBCqv+zHxrjLhaKj', N'7UPd2JLdj6qmm37T5Png/uzHxrjLhaKj', N'14', N'', '20220906 15:06:58.027', '20220906 15:06:58.027', 1)
SET IDENTITY_INSERT [dbo].[JINSHINFINANCE024] OFF

SET IDENTITY_INSERT [dbo].[JINSHINFINANCE041] ON
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (1, N'1113', N'銀行存款', N'', 1, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (2, N'1121', N'金融資產', N'', 1, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (3, N'1122', N'未實現損益', N'', 1, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (4, N'1239', N'原料', N'', 1, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (5, N'1240', N'物料', N'', 1, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (6, N'1261', N'預付薪資', N'', 1, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (7, N'1262', N'預付租金', N'', 1, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (8, N'1266', N'預付貨款', N'', 1, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (9, N'1281', N'暫付款', N'', 1, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (10, N'1284', N'存出保證金', N'', 1, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (11, N'1533', N'累計攤銷-電腦軟體', N'', 1, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (12, N'1551', N'其他無形資產', N'', 1, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (13, N'1555', N'累計攤銷-其他物料', N'', 1, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (14, N'1583', N'存出保證金', N'', 1, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (15, N'1586', N'其他資產', N'', 1, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (16, N'2171', N'應付帳款', N'', 2, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (17, N'2191', N'應付薪資', N'', 2, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (18, N'2197', N'其他應付費用', N'', 2, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (19, N'3111', N'普通股股本', N'', 2, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (20, N'3113', N'預收股本', N'', 2, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (21, N'3351', N'累計盈損', N'', 2, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (22, N'5111', N'銷貨成本', N'', 1, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (23, N'5124', N'進貨折讓', N'', 2, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (24, N'5153', N'文具用品', N'', 1, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (25, N'5156', N'郵電費', N'', 1, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (26, N'5162', N'稅捐', N'', 1, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (27, N'6111', N'薪資支出', N'', 1, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (28, N'6112', N'租金支出', N'', 1, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (29, N'6113', N'文具用品', N'', 1, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (30, N'6114', N'旅費', N'', 1, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (31, N'6115', N'運費', N'', 1, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (32, N'6116', N'郵電費', N'', 1, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (33, N'6120', N'保險費', N'', 1, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (34, N'6122', N'捐贈', N'', 1, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (35, N'6123', N'稅捐', N'', 1, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (36, N'6125', N'折舊', N'', 1, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (37, N'6126', N'各項耗竭及攤提', N'', 1, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (38, N'6134', N'其他營業費用', N'', 1, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (39, N'6166', N'上年度捐益調整', N'', 1, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (40, N'7111', N'利息收入', N'', 2, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (41, N'7141', N'股利收入', N'', 2, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (42, N'7161', N'投資利益', N'', 2, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (43, N'7162', N'投資損失', N'', 2, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (44, N'7236', N'手續費收入', N'', 2, '20200227 20:07:18.127')
INSERT INTO [dbo].[JINSHINFINANCE041] ([No], [Acc_ID], [AccName], [EngName], [DataType], [AccDate]) VALUES (45, N'7243', N'手續費', N'', 2, '20200227 20:07:18.127')
SET IDENTITY_INSERT [dbo].[JINSHINFINANCE041] OFF

INSERT INTO [dbo].[JINSHINFINANCE038] ([Acc_id], [Acc_Desc], [CDate], [UpdatePerson]) VALUES (N'1113', N'預付109年1.2月租金', '20220720 15:41:59.917', N'andrew')
INSERT INTO [dbo].[JINSHINFINANCE038] ([Acc_id], [Acc_Desc], [CDate], [UpdatePerson]) VALUES (N'1239', N'1.2m充電傳輸、DVD-R 10入', '20220720 15:42:00.300', N'andrew')
INSERT INTO [dbo].[JINSHINFINANCE038] ([Acc_id], [Acc_Desc], [CDate], [UpdatePerson]) VALUES (N'1261', N'1月份業務支出 ', '20220720 15:42:00.240', N'andrew')
INSERT INTO [dbo].[JINSHINFINANCE038] ([Acc_id], [Acc_Desc], [CDate], [UpdatePerson]) VALUES (N'1262', N'預付109年1.2月租金', '20220720 15:41:58.337', N'andrew')
INSERT INTO [dbo].[JINSHINFINANCE038] ([Acc_id], [Acc_Desc], [CDate], [UpdatePerson]) VALUES (N'1281', N'108年12月勞健保', '20220720 15:42:00.210', N'andrew')
INSERT INTO [dbo].[JINSHINFINANCE038] ([Acc_id], [Acc_Desc], [CDate], [UpdatePerson]) VALUES (N'2171', N'108年1月業務支出', '20220720 15:41:59.980', N'andrew')
INSERT INTO [dbo].[JINSHINFINANCE038] ([Acc_id], [Acc_Desc], [CDate], [UpdatePerson]) VALUES (N'2191', N'108年12月份薪資', '20220720 15:42:00.187', N'andrew')
INSERT INTO [dbo].[JINSHINFINANCE038] ([Acc_id], [Acc_Desc], [CDate], [UpdatePerson]) VALUES (N'5124', N'0106-WH59436994-Office換約折讓單', '20220720 15:42:00.173', N'andrew')
INSERT INTO [dbo].[JINSHINFINANCE038] ([Acc_id], [Acc_Desc], [CDate], [UpdatePerson]) VALUES (N'6111', N'108年12月勞健保', '20220720 15:42:00.193', N'andrew')
INSERT INTO [dbo].[JINSHINFINANCE038] ([Acc_id], [Acc_Desc], [CDate], [UpdatePerson]) VALUES (N'6112', N'1月份辦公費用', '20220720 15:41:59.923', N'andrew')
INSERT INTO [dbo].[JINSHINFINANCE038] ([Acc_id], [Acc_Desc], [CDate], [UpdatePerson]) VALUES (N'6114', N'加油', '20220720 15:42:00.120', N'andrew')
INSERT INTO [dbo].[JINSHINFINANCE038] ([Acc_id], [Acc_Desc], [CDate], [UpdatePerson]) VALUES (N'6116', N'1月份郵電費', '20220720 15:42:00.217', N'andrew')
INSERT INTO [dbo].[JINSHINFINANCE038] ([Acc_id], [Acc_Desc], [CDate], [UpdatePerson]) VALUES (N'6120', N'1月份公司勞保', '20220720 15:42:00.270', N'andrew')
INSERT INTO [dbo].[JINSHINFINANCE038] ([Acc_id], [Acc_Desc], [CDate], [UpdatePerson]) VALUES (N'6123', N'1月份Office', '20220720 15:42:00.107', N'andrew')
INSERT INTO [dbo].[JINSHINFINANCE038] ([Acc_id], [Acc_Desc], [CDate], [UpdatePerson]) VALUES (N'6134', N'水電材料1項', '20220720 15:42:00.230', N'andrew')

SET IDENTITY_INSERT [dbo].[JINSHINFINANCE030] ON
INSERT INTO [dbo].[JINSHINFINANCE030] ([UsrNo], [Supply], [OUID], [A01], [ID], [IdNo], [SnNum], [A02], [RegMonth], [UDate], [CDate]) VALUES (N'JIN2021012400001', N'金心資訊科技有限公司', N'da2b68c1-c9c3-4af2-b2c9-a20acc634a64', N'dLK3jXiwrl8g4TdFzP5/fw==', 1, N'69746686', N'', N'01BycFWj749p3/h6Y9iuiw==', NULL, NULL, '20220702 21:02:07.110')
SET IDENTITY_INSERT [dbo].[JINSHINFINANCE030] OFF

INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (0, 0, N'請看一下', '20200209 14:54:23.403')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (1, 1, N'薪資', '20200223 18:10:10.003')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (1, 2, N'辦公費用', '20201226 22:08:34.217')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (1, 6, N'營業地租金', '20201226 22:12:16.420')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (1, 7, N'油資', '20201226 22:27:15.193')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (1, 12, N'手續費', '20200225 20:22:52.070')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (1, 18, N'不包括薪資', '20200227 12:03:37.090')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (1, 19, N'不包括薪資', '20200227 12:03:43.190')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (1, 20, N'產品', '20220501 16:20:21.827')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (1, 26, N'預付租金', '20220502 16:31:54.640')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (1, 30, N'預付租金', '20201226 22:06:47.977')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (1, 31, N'預收收入', '20220502 16:30:22.617')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (1, 32, N'媒體帳務分攤', '20220502 16:30:40.260')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (2, 1, N'自付勞健保', '20200209 02:52:52.553')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (2, 2, N'Office365', '20201226 22:08:58.557')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (2, 6, N'yes123人力銀行', '20201226 22:12:41.470')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (2, 12, N'交易稅', '20200225 20:23:12.453')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (2, 20, N'銷貨成本', '20220502 16:33:45.997')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (2, 30, N'租金支付', '20201226 22:43:52.313')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (2, 31, N'應收帳款', '20220502 16:31:14.430')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (3, 1, N'業務支出', '20200209 02:53:05.780')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (3, 6, N'公司勞保費', '20201226 22:12:56.873')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (3, 12, N'投資支出', '20200225 20:23:22.227')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (3, 30, N'租金支付(現金)', '20201226 22:45:29.647')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (4, 6, N'薪資', '20201226 22:17:07.363')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (4, 12, N'投資收入', '20200225 20:23:29.277')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (5, 1, N'應付帳款', '20200209 19:16:17.653')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (5, 6, N'郵電費', '20201226 22:17:34.607')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (5, 12, N'股利收入', '20200225 20:23:36.677')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (6, 1, N'應付薪資', '20200209 02:53:27.067')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (6, 6, N'其他費用', '20220219 20:50:40.320')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (6, 12, N'手續費收入', '20200225 20:25:56.520')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (7, 1, N'支付應付薪資', '20201226 22:19:10.873')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (7, 6, N'文具用品', '20220501 16:25:21.620')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (7, 12, N'金融資產', '20200228 14:26:42.350')
INSERT INTO [dbo].[JINSHINFINANCE037] ([No], [MaNo], [Name], [CreateTime]) VALUES (8, 1, N'支付暫付款', '20201226 22:19:22.867')

SET IDENTITY_INSERT [dbo].[JINSHINFINANCE012] ON
INSERT INTO [dbo].[JINSHINFINANCE012] ([SN], [No], [IdNo], [Supply], [SupAddress], [SuppPhone], [SupKey], [SupEmail], [UsrNo], [CDate], [UDate], [IdName], [UsrPhone], [Email], [UsrAddress]) VALUES (1, 1, N'69746686', N'金心資訊科技有限公司', N'', N'0900123123', N'JIN', N'cktic25@yahoo.com.tw', N'JIN2021012400001', '20210222 08:16:51.927', '20220831 00:11:02.343', NULL, NULL, NULL, NULL)
INSERT INTO [dbo].[JINSHINFINANCE012] ([SN], [No], [IdNo], [Supply], [SupAddress], [SuppPhone], [SupKey], [SupEmail], [UsrNo], [CDate], [UDate], [IdName], [UsrPhone], [Email], [UsrAddress]) VALUES (2, 0, N'69746689', N'金心資訊科技有限公司', N'桃園市中壢', N'0900123123', N'JIN', N'cktic25@yahoo.com.tw', N'JIN2021012400001', '20210222 08:25:27.273', NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[JINSHINFINANCE012] OFF

SET IDENTITY_INSERT [dbo].[JINSHINFINANCE059] ON
INSERT INTO [dbo].[JINSHINFINANCE059] ([No], [Sname], [SVal], [CreateTime]) VALUES (1, N'LDataDays', N'3600', '20210111 16:30:35.877')
INSERT INTO [dbo].[JINSHINFINANCE059] ([No], [Sname], [SVal], [CreateTime]) VALUES (10001, N'MonthDays', N'2592000', '20210223 11:18:46.250')
SET IDENTITY_INSERT [dbo].[JINSHINFINANCE059] OFF

INSERT INTO [dbo].[JINSHINFINANCE057] ([No], [Name], [CreateTime]) VALUES (0, N'請看一下', '20200207 12:12:38.957')
INSERT INTO [dbo].[JINSHINFINANCE057] ([No], [Name], [CreateTime]) VALUES (1, N'攤提', '20200207 10:53:50.483')
INSERT INTO [dbo].[JINSHINFINANCE057] ([No], [Name], [CreateTime]) VALUES (2, N'憑證', '20200219 18:01:11.330')
INSERT INTO [dbo].[JINSHINFINANCE057] ([No], [Name], [CreateTime]) VALUES (3, N'帳務', '20200219 18:00:57.177')
INSERT INTO [dbo].[JINSHINFINANCE057] ([No], [Name], [CreateTime]) VALUES (5, N'金融資產', '20200212 23:58:53.103')
INSERT INTO [dbo].[JINSHINFINANCE057] ([No], [Name], [CreateTime]) VALUES (6, N'收入', '20200212 23:56:24.540')
INSERT INTO [dbo].[JINSHINFINANCE057] ([No], [Name], [CreateTime]) VALUES (7, N'收據', '20200207 10:56:13.957')
INSERT INTO [dbo].[JINSHINFINANCE057] ([No], [Name], [CreateTime]) VALUES (9, N'沖帳', '20200207 10:56:21.947')
INSERT INTO [dbo].[JINSHINFINANCE057] ([No], [Name], [CreateTime]) VALUES (10, N'折讓', '20200213 01:32:23.343')
INSERT INTO [dbo].[JINSHINFINANCE057] ([No], [Name], [CreateTime]) VALUES (11, N'雙向', '20200219 17:52:09.020')
INSERT INTO [dbo].[JINSHINFINANCE057] ([No], [Name], [CreateTime]) VALUES (12, N'資產', '20200227 11:58:24.187')
INSERT INTO [dbo].[JINSHINFINANCE057] ([No], [Name], [CreateTime]) VALUES (13, N'國稅', '20200227 11:59:47.903')
INSERT INTO [dbo].[JINSHINFINANCE057] ([No], [Name], [CreateTime]) VALUES (99999, N'傳票等待更新', '20200318 00:50:41.833')

CREATE PROCEDURE [dbo].[GetTableNo] 
	-- Add the parameters for the stored procedure here
	@data int,@title nvarchar(50),@DataNum int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @Result nvarchar(50),@YEAR nvarchar(4),@Month nvarchar(2),@Day nvarchar(2)
	DECLARE @RS nvarchar(50)
	DECLARE @NUM int
	DECLARE @DATAINT INT
	DECLARE @DATALENGTH INT
	DECLARE @DATETIME DATETIME
	SET @YEAR= YEAR(GETDATE())
	SET @MONTH=RIGHT(REPLICATE('0',2) + CAST(MONTH(GETDATE()) AS NVARCHAR(2)),2)  
	SET @DAY=RIGHT(REPLICATE('0',2) + CAST(DAY(GETDATE()) AS NVARCHAR(2)),2)

	IF (@DATA = 1)
	BEGIN
	  SELECT @DATETIME = MAX(Regdate) FROM JINSHINFINANCE028 WHERE USRNO LIKE  '%' + @TITLE + @YEAR + @MONTH +@DAY + '%' 
	  SELECT @RESULT = USRNO FROM JINSHINFINANCE028 WHERE Regdate = @DATETIME	 
	END 

	IF (@RESULT IS NOT NULL)
	BEGIN
	  SET @DATAINT = CAST(RIGHT(@RESULT,@DataNum) AS INT) +1;
	  SET @DATALENGTH = len(@DATAINT);
	  SELECT @TITLE + @YEAR + @MONTH +@DAY + REPLICATE('0', @DataNum - @DataLength) + ltrim(CAST((@DataInt) as nvarchar(50)));
	  RETURN
	END ELSE 
	BEGIN
	   SELECT @TITLE + @YEAR + @MONTH + @DAY + REPLICATE('0',@DataNum - 1) + '1';
	   RETURN
	END
	SELECT @RS
	RETURN
END


COMMIT TRANSACTION
