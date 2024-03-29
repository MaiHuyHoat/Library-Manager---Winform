USE [master]
GO
/****** Object:  Database [manage_library]    Script Date: 3/3/2024 10:07:10 PM ******/
CREATE DATABASE [manage_library]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'manage_library', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\manage_library.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'manage_library_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\manage_library_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [manage_library] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [manage_library].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [manage_library] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [manage_library] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [manage_library] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [manage_library] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [manage_library] SET ARITHABORT OFF 
GO
ALTER DATABASE [manage_library] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [manage_library] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [manage_library] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [manage_library] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [manage_library] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [manage_library] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [manage_library] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [manage_library] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [manage_library] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [manage_library] SET  DISABLE_BROKER 
GO
ALTER DATABASE [manage_library] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [manage_library] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [manage_library] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [manage_library] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [manage_library] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [manage_library] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [manage_library] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [manage_library] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [manage_library] SET  MULTI_USER 
GO
ALTER DATABASE [manage_library] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [manage_library] SET DB_CHAINING OFF 
GO
ALTER DATABASE [manage_library] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [manage_library] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [manage_library] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [manage_library] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [manage_library] SET QUERY_STORE = ON
GO
ALTER DATABASE [manage_library] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [manage_library]
GO
/****** Object:  User [hoatdfk]    Script Date: 3/3/2024 10:07:10 PM ******/
CREATE USER [hoatdfk] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[author]    Script Date: 3/3/2024 10:07:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[author](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NULL,
	[deleted] [int] NOT NULL,
 CONSTRAINT [PK__author__3213E83F1B0997DA] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[book]    Script Date: 3/3/2024 10:07:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[book](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[image] [varchar](250) NULL,
	[name] [varchar](250) NOT NULL,
	[author_id] [int] NULL,
	[price] [decimal](10, 0) NULL,
	[publication_year] [datetime2](0) NOT NULL,
	[number_off_pages] [int] NULL,
	[category_id] [int] NULL,
	[amount] [int] NOT NULL,
	[publisher_id] [int] NULL,
	[create_day] [datetime2](0) NOT NULL,
	[deleted] [int] NOT NULL,
 CONSTRAINT [PK__book__3213E83F919BB3C2] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[borrow_request]    Script Date: 3/3/2024 10:07:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[borrow_request](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[reader_id] [int] NULL,
	[book_id] [int] NULL,
	[due_date] [datetime2](0) NOT NULL,
	[status] [int] NOT NULL,
	[updated_at] [datetime2](0) NOT NULL,
	[deleted] [int] NOT NULL,
 CONSTRAINT [PK__borrow_r__3213E83F8A7D0965] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[borrow_tracking]    Script Date: 3/3/2024 10:07:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[borrow_tracking](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[request_id] [int] NULL,
	[return_date] [datetime2](0) NOT NULL,
	[return_status] [int] NULL,
	[fine_amound] [decimal](10, 0) NULL,
	[updated_at] [datetime2](0) NOT NULL,
	[deleted] [int] NOT NULL,
 CONSTRAINT [PK__borrow_t__3213E83FF81050F5] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[category]    Script Date: 3/3/2024 10:07:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[category](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](250) NOT NULL,
	[deleted] [int] NOT NULL,
 CONSTRAINT [PK__category__3213E83FC0C91CCD] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[publisher]    Script Date: 3/3/2024 10:07:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[publisher](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](250) NOT NULL,
	[deleted] [int] NOT NULL,
 CONSTRAINT [PK__publishe__3213E83F85FE5DF7] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reader]    Script Date: 3/3/2024 10:07:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reader](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](250) NOT NULL,
	[date_of_birth] [datetime2](0) NOT NULL,
	[reader_address] [varchar](max) NULL,
	[identity_card] [varchar](15) NOT NULL,
	[start_day] [datetime2](0) NOT NULL,
	[end_day] [datetime2](0) NULL,
	[books_borrowed] [int] NULL,
	[borrowed_time] [int] NULL,
	[deposit] [decimal](10, 0) NULL,
	[role_id] [int] NULL,
	[deleted] [int] NOT NULL,
 CONSTRAINT [PK__reader__3213E83F76AA0225] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[role_reader]    Script Date: 3/3/2024 10:07:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[role_reader](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](150) NULL,
	[Deleted] [int] NOT NULL,
 CONSTRAINT [PK__role_rea__3213E83FF53B9B25] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user]    Script Date: 3/3/2024 10:07:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](250) NOT NULL,
	[password] [varchar](250) NOT NULL,
 CONSTRAINT [PK__user__3213E83F0BEB6BDE] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[author] ON 

INSERT [dbo].[author] ([id], [name], [deleted]) VALUES (1, N'Dale Carnegie 2', 0)
INSERT [dbo].[author] ([id], [name], [deleted]) VALUES (2, N'Florence Littauer', 0)
INSERT [dbo].[author] ([id], [name], [deleted]) VALUES (3, N'Donald J.Trump', 0)
INSERT [dbo].[author] ([id], [name], [deleted]) VALUES (4, N'Lan Huong', 0)
INSERT [dbo].[author] ([id], [name], [deleted]) VALUES (5, N'James Allen', 0)
INSERT [dbo].[author] ([id], [name], [deleted]) VALUES (6, N'Thuong M?', 0)
INSERT [dbo].[author] ([id], [name], [deleted]) VALUES (7, N'Nguyễn Thị Hà Bích', 0)
INSERT [dbo].[author] ([id], [name], [deleted]) VALUES (8, N'Aurélien Géron', 0)
INSERT [dbo].[author] ([id], [name], [deleted]) VALUES (9, N'Eric Jubelaker', 0)
INSERT [dbo].[author] ([id], [name], [deleted]) VALUES (10, N'Jim Collins', 0)
INSERT [dbo].[author] ([id], [name], [deleted]) VALUES (11, N'Nguyễn Thái Long', 1)
INSERT [dbo].[author] ([id], [name], [deleted]) VALUES (12, N'Trần Thái', 1)
INSERT [dbo].[author] ([id], [name], [deleted]) VALUES (13, N'Nguyễn Tiến Đạt', 1)
INSERT [dbo].[author] ([id], [name], [deleted]) VALUES (14, N'Nguyen Tien Dat', 1)
SET IDENTITY_INSERT [dbo].[author] OFF
GO
SET IDENTITY_INSERT [dbo].[book] ON 

INSERT [dbo].[book] ([id], [image], [name], [author_id], [price], [publication_year], [number_off_pages], [category_id], [amount], [publisher_id], [create_day], [deleted]) VALUES (36, N'Dac-nhan-tam.jpg', N'Đắc nhân tâm', 1, CAST(200000 AS Decimal(10, 0)), CAST(N'2023-11-02T17:00:00.0000000' AS DateTime2), 100, 22, 3, 19, CAST(N'2020-11-19T07:30:06.0000000' AS DateTime2), 0)
INSERT [dbo].[book] ([id], [image], [name], [author_id], [price], [publication_year], [number_off_pages], [category_id], [amount], [publisher_id], [create_day], [deleted]) VALUES (37, N'dam-uoc-mo.jpg', N'Dám uoc mo', 1, CAST(200000 AS Decimal(10, 0)), CAST(N'2023-11-11T09:59:40.0000000' AS DateTime2), 100, 22, 6, 19, CAST(N'2020-11-19T07:30:36.0000000' AS DateTime2), 0)
INSERT [dbo].[book] ([id], [image], [name], [author_id], [price], [publication_year], [number_off_pages], [category_id], [amount], [publisher_id], [create_day], [deleted]) VALUES (38, N'nghi-lon-de-thanh-cong.jpg', N'Nghĩ lớn để thành công', 1, CAST(200000 AS Decimal(10, 0)), CAST(N'2023-11-11T14:28:33.0000000' AS DateTime2), 100, 22, 3, 19, CAST(N'2020-11-19T07:30:49.0000000' AS DateTime2), 0)
INSERT [dbo].[book] ([id], [image], [name], [author_id], [price], [publication_year], [number_off_pages], [category_id], [amount], [publisher_id], [create_day], [deleted]) VALUES (39, N'360-dong-tu-bat-quy-tac-day-du.jpg', N'360 động từ bất quy tắc', 1, CAST(200000 AS Decimal(10, 0)), CAST(N'2023-11-11T09:59:40.0000000' AS DateTime2), 100, 24, 5, 19, CAST(N'2020-11-19T07:31:01.0000000' AS DateTime2), 0)
INSERT [dbo].[book] ([id], [image], [name], [author_id], [price], [publication_year], [number_off_pages], [category_id], [amount], [publisher_id], [create_day], [deleted]) VALUES (40, N'khi-nguoi-ta-tu-duy.jpg', N'Khi người ta tư duy', 1, CAST(200000 AS Decimal(10, 0)), CAST(N'2023-11-11T09:59:40.0000000' AS DateTime2), 100, 22, 5, 19, CAST(N'2020-11-19T07:32:05.0000000' AS DateTime2), 0)
INSERT [dbo].[book] ([id], [image], [name], [author_id], [price], [publication_year], [number_off_pages], [category_id], [amount], [publisher_id], [create_day], [deleted]) VALUES (41, N'chieu-bai-quan-ly-vang-cua-bill-gates.jpg', N'Chiêu bài của BillGate', 1, CAST(200000 AS Decimal(10, 0)), CAST(N'2023-11-11T09:59:40.0000000' AS DateTime2), 100, 23, 6, 19, CAST(N'2020-11-19T07:33:23.0000000' AS DateTime2), 0)
INSERT [dbo].[book] ([id], [image], [name], [author_id], [price], [publication_year], [number_off_pages], [category_id], [amount], [publisher_id], [create_day], [deleted]) VALUES (42, N'tu-hoc-tieng-anh-hieu-qua.jpg', N'Tự học tiếng Anh hiệu quả', 1, CAST(200000 AS Decimal(10, 0)), CAST(N'2023-11-11T09:59:40.0000000' AS DateTime2), 100, 24, 5, 19, CAST(N'2020-11-19T07:35:14.0000000' AS DateTime2), 0)
INSERT [dbo].[book] ([id], [image], [name], [author_id], [price], [publication_year], [number_off_pages], [category_id], [amount], [publisher_id], [create_day], [deleted]) VALUES (43, N'R.jfif', N'Tuyển sinh HV', 1, CAST(200000 AS Decimal(10, 0)), CAST(N'2023-11-10T17:00:00.0000000' AS DateTime2), 100, 31, 2, 19, CAST(N'2020-11-19T07:38:54.0000000' AS DateTime2), 0)
INSERT [dbo].[book] ([id], [image], [name], [author_id], [price], [publication_year], [number_off_pages], [category_id], [amount], [publisher_id], [create_day], [deleted]) VALUES (44, N'mat-troi-va-con-nguoi.jpg', N'Mặt trời và con người', 1, CAST(200000 AS Decimal(10, 0)), CAST(N'2023-11-11T09:59:40.0000000' AS DateTime2), 100, 22, 1, 19, CAST(N'2020-11-19T07:41:28.0000000' AS DateTime2), 0)
INSERT [dbo].[book] ([id], [image], [name], [author_id], [price], [publication_year], [number_off_pages], [category_id], [amount], [publisher_id], [create_day], [deleted]) VALUES (45, N'tu-tot-den-vi-dai.jpg', N'Từ tốt đến vĩ đại', 1, CAST(200000 AS Decimal(10, 0)), CAST(N'2023-11-11T09:59:40.0000000' AS DateTime2), 100, 23, 4, 19, CAST(N'2020-11-19T07:42:13.0000000' AS DateTime2), 0)
INSERT [dbo].[book] ([id], [image], [name], [author_id], [price], [publication_year], [number_off_pages], [category_id], [amount], [publisher_id], [create_day], [deleted]) VALUES (46, N'hanh-phuc-that-gian-don.jpg', N'Hạnh phúc thật đơn giản', 1, CAST(200000 AS Decimal(10, 0)), CAST(N'2023-11-11T09:59:40.0000000' AS DateTime2), 100, 22, 1, 19, CAST(N'2020-11-19T07:43:14.0000000' AS DateTime2), 0)
INSERT [dbo].[book] ([id], [image], [name], [author_id], [price], [publication_year], [number_off_pages], [category_id], [amount], [publisher_id], [create_day], [deleted]) VALUES (52, N'mat-thu.jpg', N'Mật thư 2', 1, CAST(200000 AS Decimal(10, 0)), CAST(N'2023-11-10T17:00:00.0000000' AS DateTime2), 100, 29, 4, 19, CAST(N'2020-11-26T05:34:14.0000000' AS DateTime2), 0)
INSERT [dbo].[book] ([id], [image], [name], [author_id], [price], [publication_year], [number_off_pages], [category_id], [amount], [publisher_id], [create_day], [deleted]) VALUES (61, N'uocmovakhatvong.jfif', N'Ước mơ và khát vọng', 9, CAST(100000 AS Decimal(10, 0)), CAST(N'2023-11-12T17:00:00.0000000' AS DateTime2), 100, 22, 3, 19, CAST(N'2023-11-04T15:38:42.0000000' AS DateTime2), 0)
INSERT [dbo].[book] ([id], [image], [name], [author_id], [price], [publication_year], [number_off_pages], [category_id], [amount], [publisher_id], [create_day], [deleted]) VALUES (62, N'R.jfif', N'Long vương', 1, CAST(10892828 AS Decimal(10, 0)), CAST(N'2023-09-25T17:00:00.0000000' AS DateTime2), 245, 30, 6, 34, CAST(N'2023-11-11T14:58:04.0000000' AS DateTime2), 0)
INSERT [dbo].[book] ([id], [image], [name], [author_id], [price], [publication_year], [number_off_pages], [category_id], [amount], [publisher_id], [create_day], [deleted]) VALUES (63, N'OIP (2).jfif', N'Tình yêu màu nhiệm', 1, CAST(38999222 AS Decimal(10, 0)), CAST(N'2023-11-11T15:41:53.0000000' AS DateTime2), 233, 22, 21, 19, CAST(N'2023-11-11T15:01:14.0000000' AS DateTime2), 1)
INSERT [dbo].[book] ([id], [image], [name], [author_id], [price], [publication_year], [number_off_pages], [category_id], [amount], [publisher_id], [create_day], [deleted]) VALUES (64, N'tay-du-ky.png', N'Tây du ký 3', 12, CAST(20000 AS Decimal(10, 0)), CAST(N'1980-06-10T18:18:01.0000000' AS DateTime2), 80, 22, 2, 27, CAST(N'2024-02-26T18:18:02.0000000' AS DateTime2), 1)
INSERT [dbo].[book] ([id], [image], [name], [author_id], [price], [publication_year], [number_off_pages], [category_id], [amount], [publisher_id], [create_day], [deleted]) VALUES (65, N'kinhTeviMo.png', N'Kinh tế vĩ mô', 4, CAST(50000 AS Decimal(10, 0)), CAST(N'2024-02-26T18:34:58.0000000' AS DateTime2), 24, 23, 5, 28, CAST(N'2024-02-26T18:34:58.0000000' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[book] OFF
GO
SET IDENTITY_INSERT [dbo].[borrow_request] ON 

INSERT [dbo].[borrow_request] ([id], [reader_id], [book_id], [due_date], [status], [updated_at], [deleted]) VALUES (1, 5, 37, CAST(N'2023-11-07T17:00:00.0000000' AS DateTime2), 1, CAST(N'2023-11-02T16:39:51.0000000' AS DateTime2), 0)
INSERT [dbo].[borrow_request] ([id], [reader_id], [book_id], [due_date], [status], [updated_at], [deleted]) VALUES (2, 4, 37, CAST(N'2023-11-08T14:43:04.0000000' AS DateTime2), 0, CAST(N'2023-11-02T16:39:51.0000000' AS DateTime2), 0)
INSERT [dbo].[borrow_request] ([id], [reader_id], [book_id], [due_date], [status], [updated_at], [deleted]) VALUES (3, 8, 40, CAST(N'2023-12-08T17:00:00.0000000' AS DateTime2), 1, CAST(N'2023-11-08T14:39:30.0000000' AS DateTime2), 0)
INSERT [dbo].[borrow_request] ([id], [reader_id], [book_id], [due_date], [status], [updated_at], [deleted]) VALUES (4, 8, 45, CAST(N'2023-11-01T17:00:00.0000000' AS DateTime2), 1, CAST(N'2023-11-11T03:44:51.0000000' AS DateTime2), 0)
INSERT [dbo].[borrow_request] ([id], [reader_id], [book_id], [due_date], [status], [updated_at], [deleted]) VALUES (5, 10, 39, CAST(N'2023-11-08T17:00:00.0000000' AS DateTime2), 1, CAST(N'2023-11-11T03:47:06.0000000' AS DateTime2), 0)
INSERT [dbo].[borrow_request] ([id], [reader_id], [book_id], [due_date], [status], [updated_at], [deleted]) VALUES (6, 8, 62, CAST(N'2023-11-10T17:00:00.0000000' AS DateTime2), 0, CAST(N'2023-11-11T15:51:56.0000000' AS DateTime2), 0)
INSERT [dbo].[borrow_request] ([id], [reader_id], [book_id], [due_date], [status], [updated_at], [deleted]) VALUES (7, 8, 37, CAST(N'2023-11-11T17:00:00.0000000' AS DateTime2), 0, CAST(N'2023-11-12T02:05:14.0000000' AS DateTime2), 0)
INSERT [dbo].[borrow_request] ([id], [reader_id], [book_id], [due_date], [status], [updated_at], [deleted]) VALUES (8, 8, 61, CAST(N'2023-11-12T17:00:00.0000000' AS DateTime2), 1, CAST(N'2023-11-12T02:08:05.0000000' AS DateTime2), 0)
INSERT [dbo].[borrow_request] ([id], [reader_id], [book_id], [due_date], [status], [updated_at], [deleted]) VALUES (9, 8, 36, CAST(N'2023-11-25T17:00:00.0000000' AS DateTime2), 0, CAST(N'2023-11-12T02:15:12.0000000' AS DateTime2), 0)
INSERT [dbo].[borrow_request] ([id], [reader_id], [book_id], [due_date], [status], [updated_at], [deleted]) VALUES (10, 8, 61, CAST(N'2023-11-09T17:00:00.0000000' AS DateTime2), 1, CAST(N'2023-11-12T02:16:03.0000000' AS DateTime2), 0)
INSERT [dbo].[borrow_request] ([id], [reader_id], [book_id], [due_date], [status], [updated_at], [deleted]) VALUES (11, 8, 61, CAST(N'2023-11-10T17:00:00.0000000' AS DateTime2), 1, CAST(N'2023-11-12T02:38:38.0000000' AS DateTime2), 0)
INSERT [dbo].[borrow_request] ([id], [reader_id], [book_id], [due_date], [status], [updated_at], [deleted]) VALUES (12, 8, 45, CAST(N'2024-03-01T22:00:46.0000000' AS DateTime2), 1, CAST(N'2024-03-01T22:01:15.0000000' AS DateTime2), 0)
INSERT [dbo].[borrow_request] ([id], [reader_id], [book_id], [due_date], [status], [updated_at], [deleted]) VALUES (13, 8, 38, CAST(N'2024-03-21T20:14:15.0000000' AS DateTime2), 1, CAST(N'2024-03-02T20:14:44.0000000' AS DateTime2), 0)
INSERT [dbo].[borrow_request] ([id], [reader_id], [book_id], [due_date], [status], [updated_at], [deleted]) VALUES (14, 8, 63, CAST(N'2024-03-03T16:44:07.0000000' AS DateTime2), 1, CAST(N'2024-03-03T16:45:04.0000000' AS DateTime2), 0)
INSERT [dbo].[borrow_request] ([id], [reader_id], [book_id], [due_date], [status], [updated_at], [deleted]) VALUES (15, 8, 36, CAST(N'2024-03-13T16:45:29.0000000' AS DateTime2), 0, CAST(N'2024-03-03T16:45:57.0000000' AS DateTime2), 0)
INSERT [dbo].[borrow_request] ([id], [reader_id], [book_id], [due_date], [status], [updated_at], [deleted]) VALUES (16, 8, 63, CAST(N'2024-03-03T16:59:15.0000000' AS DateTime2), 1, CAST(N'2024-03-03T17:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[borrow_request] ([id], [reader_id], [book_id], [due_date], [status], [updated_at], [deleted]) VALUES (17, 8, 63, CAST(N'2024-03-03T21:58:50.0000000' AS DateTime2), 0, CAST(N'2024-03-03T22:01:06.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[borrow_request] OFF
GO
SET IDENTITY_INSERT [dbo].[borrow_tracking] ON 

INSERT [dbo].[borrow_tracking] ([id], [request_id], [return_date], [return_status], [fine_amound], [updated_at], [deleted]) VALUES (1, 1, CAST(N'2023-11-06T17:00:00.0000000' AS DateTime2), 1, CAST(100000 AS Decimal(10, 0)), CAST(N'2023-11-06T08:38:38.0000000' AS DateTime2), 0)
INSERT [dbo].[borrow_tracking] ([id], [request_id], [return_date], [return_status], [fine_amound], [updated_at], [deleted]) VALUES (2, 1, CAST(N'2023-11-05T17:00:00.0000000' AS DateTime2), 1, CAST(80000 AS Decimal(10, 0)), CAST(N'2023-11-06T08:40:21.0000000' AS DateTime2), 0)
INSERT [dbo].[borrow_tracking] ([id], [request_id], [return_date], [return_status], [fine_amound], [updated_at], [deleted]) VALUES (4, 3, CAST(N'2023-11-07T17:00:00.0000000' AS DateTime2), 3, CAST(200000 AS Decimal(10, 0)), CAST(N'2023-11-08T14:40:11.0000000' AS DateTime2), 0)
INSERT [dbo].[borrow_tracking] ([id], [request_id], [return_date], [return_status], [fine_amound], [updated_at], [deleted]) VALUES (5, 4, CAST(N'2023-10-31T17:00:00.0000000' AS DateTime2), 1, CAST(0 AS Decimal(10, 0)), CAST(N'2023-11-11T03:45:06.0000000' AS DateTime2), 0)
INSERT [dbo].[borrow_tracking] ([id], [request_id], [return_date], [return_status], [fine_amound], [updated_at], [deleted]) VALUES (6, 5, CAST(N'2023-11-03T17:00:00.0000000' AS DateTime2), 1, CAST(0 AS Decimal(10, 0)), CAST(N'2023-11-11T03:47:35.0000000' AS DateTime2), 0)
INSERT [dbo].[borrow_tracking] ([id], [request_id], [return_date], [return_status], [fine_amound], [updated_at], [deleted]) VALUES (7, 1, CAST(N'2023-11-03T17:00:00.0000000' AS DateTime2), 1, CAST(0 AS Decimal(10, 0)), CAST(N'2023-11-11T15:52:25.0000000' AS DateTime2), 0)
INSERT [dbo].[borrow_tracking] ([id], [request_id], [return_date], [return_status], [fine_amound], [updated_at], [deleted]) VALUES (8, 8, CAST(N'2023-11-14T17:00:00.0000000' AS DateTime2), 1, CAST(20000 AS Decimal(10, 0)), CAST(N'2023-11-12T02:10:50.0000000' AS DateTime2), 0)
INSERT [dbo].[borrow_tracking] ([id], [request_id], [return_date], [return_status], [fine_amound], [updated_at], [deleted]) VALUES (9, 10, CAST(N'2023-11-10T17:00:00.0000000' AS DateTime2), 3, CAST(100000 AS Decimal(10, 0)), CAST(N'2023-11-12T02:16:21.0000000' AS DateTime2), 0)
INSERT [dbo].[borrow_tracking] ([id], [request_id], [return_date], [return_status], [fine_amound], [updated_at], [deleted]) VALUES (10, 11, CAST(N'2023-11-09T17:00:00.0000000' AS DateTime2), 1, CAST(0 AS Decimal(10, 0)), CAST(N'2023-11-12T02:39:30.0000000' AS DateTime2), 0)
INSERT [dbo].[borrow_tracking] ([id], [request_id], [return_date], [return_status], [fine_amound], [updated_at], [deleted]) VALUES (11, 12, CAST(N'2024-03-02T10:41:58.0000000' AS DateTime2), 4, CAST(200000 AS Decimal(10, 0)), CAST(N'2024-03-02T10:42:07.0000000' AS DateTime2), 0)
INSERT [dbo].[borrow_tracking] ([id], [request_id], [return_date], [return_status], [fine_amound], [updated_at], [deleted]) VALUES (12, 13, CAST(N'2024-03-22T20:14:53.0000000' AS DateTime2), 4, CAST(200000 AS Decimal(10, 0)), CAST(N'2024-03-02T20:15:22.0000000' AS DateTime2), 0)
INSERT [dbo].[borrow_tracking] ([id], [request_id], [return_date], [return_status], [fine_amound], [updated_at], [deleted]) VALUES (13, 14, CAST(N'2024-03-03T17:00:17.0000000' AS DateTime2), 1, CAST(0 AS Decimal(10, 0)), CAST(N'2024-03-03T17:00:19.0000000' AS DateTime2), 0)
INSERT [dbo].[borrow_tracking] ([id], [request_id], [return_date], [return_status], [fine_amound], [updated_at], [deleted]) VALUES (14, 16, CAST(N'2024-03-03T22:01:16.0000000' AS DateTime2), 4, CAST(38999222 AS Decimal(10, 0)), CAST(N'2024-03-03T22:01:23.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[borrow_tracking] OFF
GO
SET IDENTITY_INSERT [dbo].[category] ON 

INSERT [dbo].[category] ([id], [name], [deleted]) VALUES (22, N'Tâm lý - Kỹ năng sống', 0)
INSERT [dbo].[category] ([id], [name], [deleted]) VALUES (23, N'Kinh tế', 0)
INSERT [dbo].[category] ([id], [name], [deleted]) VALUES (24, N'Ngoại ngữ', 0)
INSERT [dbo].[category] ([id], [name], [deleted]) VALUES (25, N'Lập trình', 0)
INSERT [dbo].[category] ([id], [name], [deleted]) VALUES (29, N'Khoa học kỹ thuật', 0)
INSERT [dbo].[category] ([id], [name], [deleted]) VALUES (30, N'Thiên văn học ', 0)
INSERT [dbo].[category] ([id], [name], [deleted]) VALUES (31, N'Sinh học', 0)
SET IDENTITY_INSERT [dbo].[category] OFF
GO
SET IDENTITY_INSERT [dbo].[publisher] ON 

INSERT [dbo].[publisher] ([id], [name], [deleted]) VALUES (19, N'NXB Th? Gi?i', 0)
INSERT [dbo].[publisher] ([id], [name], [deleted]) VALUES (21, N'NXB T?ng h?p TPHCM', 0)
INSERT [dbo].[publisher] ([id], [name], [deleted]) VALUES (26, N'NXB Lao Ð?ng', 0)
INSERT [dbo].[publisher] ([id], [name], [deleted]) VALUES (27, N'NXB Thanh Niên', 0)
INSERT [dbo].[publisher] ([id], [name], [deleted]) VALUES (28, N'NXB Báo', 0)
INSERT [dbo].[publisher] ([id], [name], [deleted]) VALUES (29, N'FUNIX', 0)
INSERT [dbo].[publisher] ([id], [name], [deleted]) VALUES (31, N'NXB Tr?', 1)
INSERT [dbo].[publisher] ([id], [name], [deleted]) VALUES (32, N'janey', 1)
INSERT [dbo].[publisher] ([id], [name], [deleted]) VALUES (33, N'Ð?t d?p d?n', 1)
INSERT [dbo].[publisher] ([id], [name], [deleted]) VALUES (34, N'NXB Trí Tu?', 0)
SET IDENTITY_INSERT [dbo].[publisher] OFF
GO
SET IDENTITY_INSERT [dbo].[reader] ON 

INSERT [dbo].[reader] ([id], [name], [date_of_birth], [reader_address], [identity_card], [start_day], [end_day], [books_borrowed], [borrowed_time], [deposit], [role_id], [deleted]) VALUES (4, N'John Doe 3', CAST(N'2023-11-11T15:49:40.0000000' AS DateTime2), N'123 Main Street, City', N'123456789012345', CAST(N'2023-09-30T17:00:00.0000000' AS DateTime2), CAST(N'2024-02-29T17:00:00.0000000' AS DateTime2), 10, 30, CAST(50 AS Decimal(10, 0)), 1, 1)
INSERT [dbo].[reader] ([id], [name], [date_of_birth], [reader_address], [identity_card], [start_day], [end_day], [books_borrowed], [borrowed_time], [deposit], [role_id], [deleted]) VALUES (5, N'Alice Smith ', CAST(N'1985-08-19T17:00:00.0000000' AS DateTime2), N'456 Elm Street, Town', N'987654321098765', CAST(N'2023-09-14T17:00:00.0000000' AS DateTime2), CAST(N'2024-01-19T17:00:00.0000000' AS DateTime2), 10, 30, CAST(30 AS Decimal(10, 0)), 2, 0)
INSERT [dbo].[reader] ([id], [name], [date_of_birth], [reader_address], [identity_card], [start_day], [end_day], [books_borrowed], [borrowed_time], [deposit], [role_id], [deleted]) VALUES (6, N'Bob Johnson', CAST(N'1992-02-27T17:00:00.0000000' AS DateTime2), N'789 Oak Street, Village', N'543210987654321', CAST(N'2023-10-04T17:00:00.0000000' AS DateTime2), NULL, 10, 30, CAST(20 AS Decimal(10, 0)), 1, 0)
INSERT [dbo].[reader] ([id], [name], [date_of_birth], [reader_address], [identity_card], [start_day], [end_day], [books_borrowed], [borrowed_time], [deposit], [role_id], [deleted]) VALUES (8, N'Mai Huy Hoat', CAST(N'2023-11-22T17:00:00.0000000' AS DateTime2), N'Nam Định', N'036201011604', CAST(N'2023-11-05T17:00:00.0000000' AS DateTime2), CAST(N'2024-01-25T17:00:00.0000000' AS DateTime2), 10, 30, CAST(200000 AS Decimal(10, 0)), 1, 0)
INSERT [dbo].[reader] ([id], [name], [date_of_birth], [reader_address], [identity_card], [start_day], [end_day], [books_borrowed], [borrowed_time], [deposit], [role_id], [deleted]) VALUES (10, N'Mai Huy Hoat', CAST(N'2023-11-11T15:49:12.0000000' AS DateTime2), N'Nam Định', N'03620101 1604', CAST(N'2023-11-16T17:00:00.0000000' AS DateTime2), CAST(N'2024-02-03T17:00:00.0000000' AS DateTime2), 10, 30, CAST(2333 AS Decimal(10, 0)), 1, 0)
SET IDENTITY_INSERT [dbo].[reader] OFF
GO
SET IDENTITY_INSERT [dbo].[role_reader] ON 

INSERT [dbo].[role_reader] ([id], [name], [Deleted]) VALUES (1, N'Sinh viên ', 0)
INSERT [dbo].[role_reader] ([id], [name], [Deleted]) VALUES (2, N'Giáo viên ', 0)
SET IDENTITY_INSERT [dbo].[role_reader] OFF
GO
SET IDENTITY_INSERT [dbo].[user] ON 

INSERT [dbo].[user] ([id], [username], [password]) VALUES (1, N'user', N'1')
SET IDENTITY_INSERT [dbo].[user] OFF
GO
ALTER TABLE [dbo].[author] ADD  CONSTRAINT [DF__author__name__37A5467C]  DEFAULT (NULL) FOR [name]
GO
ALTER TABLE [dbo].[author] ADD  CONSTRAINT [DF__author__deleted__38996AB5]  DEFAULT ((0)) FOR [deleted]
GO
ALTER TABLE [dbo].[book] ADD  CONSTRAINT [DF__book__image__3B75D760]  DEFAULT (NULL) FOR [image]
GO
ALTER TABLE [dbo].[book] ADD  CONSTRAINT [DF__book__author_id__3C69FB99]  DEFAULT (NULL) FOR [author_id]
GO
ALTER TABLE [dbo].[book] ADD  CONSTRAINT [DF__book__price__3D5E1FD2]  DEFAULT (NULL) FOR [price]
GO
ALTER TABLE [dbo].[book] ADD  CONSTRAINT [DF__book__publicatio__3E52440B]  DEFAULT (getdate()) FOR [publication_year]
GO
ALTER TABLE [dbo].[book] ADD  CONSTRAINT [DF__book__number_off__3F466844]  DEFAULT (NULL) FOR [number_off_pages]
GO
ALTER TABLE [dbo].[book] ADD  CONSTRAINT [DF__book__category_i__403A8C7D]  DEFAULT (NULL) FOR [category_id]
GO
ALTER TABLE [dbo].[book] ADD  CONSTRAINT [DF__book__publisher___412EB0B6]  DEFAULT (NULL) FOR [publisher_id]
GO
ALTER TABLE [dbo].[book] ADD  CONSTRAINT [DF__book__create_day__4222D4EF]  DEFAULT (getdate()) FOR [create_day]
GO
ALTER TABLE [dbo].[book] ADD  CONSTRAINT [DF__book__deleted__4316F928]  DEFAULT ((0)) FOR [deleted]
GO
ALTER TABLE [dbo].[borrow_request] ADD  CONSTRAINT [DF__borrow_re__reade__45F365D3]  DEFAULT (NULL) FOR [reader_id]
GO
ALTER TABLE [dbo].[borrow_request] ADD  CONSTRAINT [DF__borrow_re__book___46E78A0C]  DEFAULT (NULL) FOR [book_id]
GO
ALTER TABLE [dbo].[borrow_request] ADD  CONSTRAINT [DF__borrow_re__due_d__47DBAE45]  DEFAULT (getdate()) FOR [due_date]
GO
ALTER TABLE [dbo].[borrow_request] ADD  CONSTRAINT [DF__borrow_re__statu__48CFD27E]  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[borrow_request] ADD  CONSTRAINT [DF__borrow_re__updat__49C3F6B7]  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[borrow_request] ADD  CONSTRAINT [DF__borrow_re__delet__4AB81AF0]  DEFAULT ((0)) FOR [deleted]
GO
ALTER TABLE [dbo].[borrow_tracking] ADD  CONSTRAINT [DF__borrow_tr__reque__4D94879B]  DEFAULT (NULL) FOR [request_id]
GO
ALTER TABLE [dbo].[borrow_tracking] ADD  CONSTRAINT [DF__borrow_tr__retur__4E88ABD4]  DEFAULT (getdate()) FOR [return_date]
GO
ALTER TABLE [dbo].[borrow_tracking] ADD  CONSTRAINT [DF__borrow_tr__retur__4F7CD00D]  DEFAULT (NULL) FOR [return_status]
GO
ALTER TABLE [dbo].[borrow_tracking] ADD  CONSTRAINT [DF__borrow_tr__fine___5070F446]  DEFAULT (NULL) FOR [fine_amound]
GO
ALTER TABLE [dbo].[borrow_tracking] ADD  CONSTRAINT [DF__borrow_tr__updat__5165187F]  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[borrow_tracking] ADD  CONSTRAINT [DF__borrow_tr__delet__52593CB8]  DEFAULT ((0)) FOR [deleted]
GO
ALTER TABLE [dbo].[category] ADD  CONSTRAINT [DF__category__delete__5535A963]  DEFAULT ((0)) FOR [deleted]
GO
ALTER TABLE [dbo].[publisher] ADD  CONSTRAINT [DF__publisher__delet__5812160E]  DEFAULT ((0)) FOR [deleted]
GO
ALTER TABLE [dbo].[reader] ADD  CONSTRAINT [DF__reader__date_of___5AEE82B9]  DEFAULT (getdate()) FOR [date_of_birth]
GO
ALTER TABLE [dbo].[reader] ADD  CONSTRAINT [DF__reader__reader_a__5BE2A6F2]  DEFAULT (NULL) FOR [reader_address]
GO
ALTER TABLE [dbo].[reader] ADD  CONSTRAINT [DF__reader__start_da__5CD6CB2B]  DEFAULT (getdate()) FOR [start_day]
GO
ALTER TABLE [dbo].[reader] ADD  CONSTRAINT [DF__reader__end_day__5DCAEF64]  DEFAULT (NULL) FOR [end_day]
GO
ALTER TABLE [dbo].[reader] ADD  CONSTRAINT [DF__reader__borrowed__5FB337D6]  DEFAULT (NULL) FOR [borrowed_time]
GO
ALTER TABLE [dbo].[reader] ADD  CONSTRAINT [DF__reader__deposit__60A75C0F]  DEFAULT (NULL) FOR [deposit]
GO
ALTER TABLE [dbo].[reader] ADD  CONSTRAINT [DF__reader__role_id__619B8048]  DEFAULT (NULL) FOR [role_id]
GO
ALTER TABLE [dbo].[reader] ADD  CONSTRAINT [DF__reader__deleted__628FA481]  DEFAULT ((0)) FOR [deleted]
GO
ALTER TABLE [dbo].[role_reader] ADD  CONSTRAINT [DF__role_reade__name__656C112C]  DEFAULT (NULL) FOR [name]
GO
ALTER TABLE [dbo].[role_reader] ADD  CONSTRAINT [DF__role_read__Delet__66603565]  DEFAULT ((0)) FOR [Deleted]
GO
ALTER TABLE [dbo].[book]  WITH CHECK ADD  CONSTRAINT [FK_book_author1] FOREIGN KEY([author_id])
REFERENCES [dbo].[author] ([id])
GO
ALTER TABLE [dbo].[book] CHECK CONSTRAINT [FK_book_author1]
GO
ALTER TABLE [dbo].[book]  WITH CHECK ADD  CONSTRAINT [FK_book_category1] FOREIGN KEY([category_id])
REFERENCES [dbo].[category] ([id])
GO
ALTER TABLE [dbo].[book] CHECK CONSTRAINT [FK_book_category1]
GO
ALTER TABLE [dbo].[book]  WITH CHECK ADD  CONSTRAINT [FK_book_publisher1] FOREIGN KEY([publisher_id])
REFERENCES [dbo].[publisher] ([id])
GO
ALTER TABLE [dbo].[book] CHECK CONSTRAINT [FK_book_publisher1]
GO
ALTER TABLE [dbo].[borrow_request]  WITH CHECK ADD  CONSTRAINT [FK_borrow_request_book] FOREIGN KEY([book_id])
REFERENCES [dbo].[book] ([id])
GO
ALTER TABLE [dbo].[borrow_request] CHECK CONSTRAINT [FK_borrow_request_book]
GO
ALTER TABLE [dbo].[borrow_request]  WITH CHECK ADD  CONSTRAINT [FK_borrow_request_reader1] FOREIGN KEY([reader_id])
REFERENCES [dbo].[reader] ([id])
GO
ALTER TABLE [dbo].[borrow_request] CHECK CONSTRAINT [FK_borrow_request_reader1]
GO
ALTER TABLE [dbo].[borrow_tracking]  WITH CHECK ADD  CONSTRAINT [FK_borrow_tracking_borrow_request] FOREIGN KEY([request_id])
REFERENCES [dbo].[borrow_request] ([id])
GO
ALTER TABLE [dbo].[borrow_tracking] CHECK CONSTRAINT [FK_borrow_tracking_borrow_request]
GO
ALTER TABLE [dbo].[reader]  WITH CHECK ADD  CONSTRAINT [FK_reader_role_reader] FOREIGN KEY([role_id])
REFERENCES [dbo].[role_reader] ([id])
GO
ALTER TABLE [dbo].[reader] CHECK CONSTRAINT [FK_reader_role_reader]
GO
USE [master]
GO
ALTER DATABASE [manage_library] SET  READ_WRITE 
GO
