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
	[MüþteriNo] [int] NOT NULL,
	[Ad] [varchar](50) NULL,
	[Soyad] [varchar](50) NULL,
	[borç] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[MüþteriNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Urunler](
	[ÜrünNo] [int] NOT NULL,
	[UrunAdi] [varchar](100) NULL,
	[Fiyat] [money] NULL,
	[adet] [int] NULL,
	[Kategori] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ÜrünNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[MüþteriDetaylarý](
	[sýrano] [int] NOT NULL,
	[müþterino] [int] NULL,
	[harcanantutar] [smallmoney] NULL,
	[ödenentutar] [smallmoney] NULL,
	[tarih] [smalldatetime] NULL,
	[açýklama] [nvarchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[sýrano] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[satýþlar](
	[sýraNo] [int] NOT NULL,
	[ürünno] [int] NULL,
	[MüþteriNo] [int] NULL,
	[adet] [int] NULL,
	[satýlanfiyat] [money] NULL,
	[MusteriID] [int] NULL,
	[Tarih] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[sýraNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

