# Phần mềm Giả lập Dây chuyền Kiểm tra QR

## Giới thiệu

Phần mềm này giả lập một dây chuyền sản xuất với hệ thống kiểm tra mã QR tích hợp. Nó cho phép loại bỏ các sản phẩm không đạt yêu cầu ra khỏi dây chuyền dựa trên mã QR của chúng.

### Tính năng chính

- 🎥 Sử dụng camera để quét và đọc mã QR
- 📊 Quản lý mã QR theo thương hiệu
- 🔄 Mô phỏng quá trình kiểm tra và loại bỏ sản phẩm
- 📱 Tích hợp với phần mềm Droid để giả lập máy quét QR

## Công nghệ sử dụng

- 📷 AForge.Video.DirectShow: Xử lý hình ảnh từ camera
- 📱 Droid: Giả lập máy quét QR
- 🔍 ZXing.Net: Đọc và giải mã QR Code
- 🖨️ QRCoder: Tạo mã QR

## Cấu trúc dự án

Dự án bao gồm các form chính sau:

1. **Home.cs**: Giao diện chính để test quét và đọc mã QR bằng camera
2. **QRManagement.cs**: Quản lý CRUD các mã QR theo thương hiệu
3. **Simulation.cs**: Mô phỏng quá trình lưu bản ghi và loại bỏ hàng không đạt yêu cầu
   
## Cơ sở dữ liệu

Để tạo cơ sở dữ liệu, hãy chạy script SQL sau trong SQL Server Management Studio:

```sql
CREATE DATABASE QRReader
GO
USE QRReader
GO
CREATE TABLE [dbo].[Brand_Code](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [Name] [nvarchar](50) NULL,
    [Description] [nvarchar](255) NULL,
    [Created_at] [datetime] NULL,
    [Updated_at] [datetime] NULL,
 CONSTRAINT [PK_Brand] PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Code_history](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [Brand_Id] [int] NULL,
    [Reader_Id] [int] NULL,
    [Status] [nvarchar](50) NULL,
    [Created_at] [datetime] NULL,
    [Updated_at] [datetime] NULL,
 CONSTRAINT [PK_Code] PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Reader](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [Name] [nvarchar](50) NULL,
    [Description] [nvarchar](255) NULL,
    [Created_at] [datetime] NULL,
    [Updated_at] [datetime] NULL,
 CONSTRAINT [PK_Reader] PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Code_history]  WITH CHECK ADD  CONSTRAINT [FK_Code_Brand] FOREIGN KEY([Brand_Id])
REFERENCES [dbo].[Brand_Code] ([Id])
GO
ALTER TABLE [dbo].[Code_history] CHECK CONSTRAINT [FK_Code_Brand]
GO
ALTER TABLE [dbo].[Code_history]  WITH CHECK ADD  CONSTRAINT [FK_Code_Reader] FOREIGN KEY([Reader_Id])
REFERENCES [dbo].[Reader] ([Id])
GO
ALTER TABLE [dbo].[Code_history] CHECK CONSTRAINT [FK_Code_Reader]
GO
USE [master]
GO
ALTER DATABASE [ReadQR] SET  READ_WRITE 
GO
