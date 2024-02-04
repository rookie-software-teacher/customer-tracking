create table [MusteriTakip];
go
use MusteriTakip


CREATE TABLE [dbo].[Kategoriler](
	[kategorino] [int] NOT NULL,
	[KategoriAdi] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[kategorino] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Musteriler](
	[M��teriNo] [int] NOT NULL,
	[Ad] [varchar](50) NULL,
	[Soyad] [varchar](50) NULL,
	[bor�] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[M��teriNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Urunler](
	[�r�nNo] [int] NOT NULL,
	[UrunAdi] [varchar](100) NULL,
	[Fiyat] [money] NULL,
	[adet] [int] NULL,
	[Kategori] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[�r�nNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[M��teriDetaylar�](
	[s�rano] [int] NOT NULL,
	[m��terino] [int] NULL,
	[harcanantutar] [smallmoney] NULL,
	[�denentutar] [smallmoney] NULL,
	[tarih] [smalldatetime] NULL,
	[a��klama] [nvarchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[s�rano] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[sat��lar](
	[s�raNo] [int] NOT NULL,
	[�r�nno] [int] NULL,
	[M��teriNo] [int] NULL,
	[adet] [int] NULL,
	[sat�lanfiyat] [money] NULL,
	[MusteriID] [int] NULL,
	[Tarih] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[s�raNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

