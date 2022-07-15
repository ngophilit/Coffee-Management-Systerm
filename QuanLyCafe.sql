CREATE DATABASE QuanLyQuanCafe
GO

USE QuanLyQuanCafe
GO

-- Table Food
-- Food
-- FoodCategory
-- Account
-- Bill
-- BillInfo

CREATE TABLE TableFood
(
	id NVARCHAR(100) PRIMARY KEY,
	name NVARCHAR(100) NOT NULL,
	status NVARCHAR(100) NOT NULL DEFAULT N'Trống'-- Trống || Có người
)
GO

CREATE TABLE FoodCategory
(
	id NVARCHAR(100) PRIMARY KEY,
	name NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE Food
(
	id NVARCHAR(100) PRIMARY KEY,
	name NVARCHAR(100) NOT NULL,
	idCategory NVARCHAR(100) NOT NULL,
	price FLOAT NOT NULL

	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)
GO

CREATE TABLE Account
(
	userName NVARCHAR(100) PRIMARY KEY,
	displayName NVARCHAR(100) NOT NULL,
	password NVARCHAR(100) NOT NULL DEFAULT 0,
	accountType NVARCHAR(100) NOT NULL DEFAULT '0' -- 1: admin; 0: staff
)
GO

CREATE TABLE Bill
(
	id NVARCHAR(100) PRIMARY KEY,
	dateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	dateCheckOut DATE NOT NULL,
	idTable NVARCHAR(100) NOT NULL,
	status NVARCHAR(100) NOT NULL DEFAULT '0' -- 1: đã thanh toán; 0: chưa thanh toán

	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO

CREATE TABLE BillInfo
(
	id NVARCHAR(100) PRIMARY KEY,
	idBill NVARCHAR(100) NOT NULL,
	idFood NVARCHAR(100) NOT NULL,
	count INT NOT NULL DEFAULT 0

	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
)
GO

INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES ('1', N'Bàn số 1', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES ('2', N'Bàn số 2', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES ('3', N'Bàn số 3', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES ('4', N'Bàn số 4', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES ('5', N'Bàn số 5', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES ('6', N'Bàn số 6', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES ('7', N'Bàn số 7', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES ('8', N'Bàn số 8', N'Trống')

GO


INSERT [dbo].[Bill] ([id], [dateCheckIn], [dateCheckOut], [idTable], [status]) VALUES (2, CAST(N'2020-02-01' AS Date), CAST(N'2020-02-01' AS Date), 2, 1)
INSERT [dbo].[Bill] ([id], [dateCheckIn], [dateCheckOut], [idTable], [status]) VALUES (3, CAST(N'2021-01-02' AS Date), CAST(N'2021-01-02' AS Date), 6, 1)
INSERT [dbo].[Bill] ([id], [dateCheckIn], [dateCheckOut], [idTable], [status]) VALUES (4, CAST(N'2022-09-06' AS Date), CAST(N'2022-09-06' AS Date), 1, 1)

GO


INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (1, N'Cà phê Pha Phin')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (2, N'PHINDI')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (3, N'Cà phê Espresso')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (4, N'Trà')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (5, N'Bánh')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (6, N'Freeze')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (7, N'Thức uống khác')

GO


INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (1, N'Phin Sữa đá', 1, 45000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (2, N'Phin Đen đá', 1, 45000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (3, N'Bạc xỉu đá', 1, 45000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (4, N'Phindi Kem sữa', 2, 39000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (5, N'Phindi Hạnh nhân', 2, 39000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (6, N'Phindi Choco', 2, 45000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (7, N'Espresso', 3, 39000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (8, N'Americano', 3, 39000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (9, N'Cappuccino', 3, 65000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (10, N'Latte', 3, 65000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (11, N'Mocha Macchiato', 3, 69000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (12, N'Caramel Macchiato', 3, 69000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (14, N'Trà Sen Vàng', 4, 49000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (16, N'Trà Thạch Đào', 4, 49000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (17, N'Trà Thanh Đào', 4, 49000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (18, N'Trà Thạch Vãi', 4, 49000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (19, N'Trà Xanh Đậu Đỏ', 4, 49000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (20, N'Tiramisu', 5, 29000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (21, N'Bánh chuối', 5, 29000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (22, N'Mouse Đào', 5, 29000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (23, N'Mousse Câco', 5, 29000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (24, N'Phô Mai Trà Xanh', 5, 35000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (25, N'Phô Mai Chanh Dây', 5, 25000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (26, N'Phô Mai Cà phê', 5, 25000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (27, N'Phô Mai Caramel', 5, 25000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (28, N'Freeze Trà Xanh', 6, 49000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (29, N'Freeze Sô-Cô-La', 6, 65000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (30, N'Cookies and Cream', 6, 59000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (31, N'Caramel Phin Freeze', 6, 65000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (32, N'Classic Phin Caramel', 6, 69000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (33, N'Chanh đá xoay', 7, 39000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (34, N'Chanh dây đá viên', 7, 39000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (35, N'Tắc đá viên', 7, 39000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (37, N'Sô-cô-la', 7, 39000)

GO

INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (1, 2, 1, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (2, 2, 4, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (3, 2, 5, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (4, 2, 6, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (5, 3, 7, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (6, 3, 1, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (7, 3, 2, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (8, 3, 20, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (13, 3, 14, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (14, 3, 9, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (15, 4, 1, 5)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (16, 4, 5, 5)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (17, 4, 2, 9)

GO
INSERT [dbo].[Account] ([userName], [displayName], [password], [accountType]) VALUES (N'admin', N'Quản lý', N'123456', 1)
INSERT [dbo].[Account] ([userName], [displayName], [password], [accountType]) VALUES (N'nv1', N'Nguyễn Văn An', N'0000', 0)
GO
