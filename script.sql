USE [Progra2]
GO
/****** Object:  Table [dbo].[Estudiante]    Script Date: 25/10/2023 21:12:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estudiante](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [varchar](250) NOT NULL,
	[Apellidos] [varchar](250) NULL,
	[Edad] [int] NULL,
	[Sexo] [varchar](50) NULL,
 CONSTRAINT [PK_Estudiante] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Estudiante] ON 

INSERT [dbo].[Estudiante] ([Id], [Nombres], [Apellidos], [Edad], [Sexo]) VALUES (1, N'juan', N'perez', 20, N'masculino')
INSERT [dbo].[Estudiante] ([Id], [Nombres], [Apellidos], [Edad], [Sexo]) VALUES (2, N'pedro', N'ATRIBUTO MODIFICADO', 30, N'masculino')
INSERT [dbo].[Estudiante] ([Id], [Nombres], [Apellidos], [Edad], [Sexo]) VALUES (3, N'barbie alejandra', N'nuñez garcia', 25, N'femenino')
INSERT [dbo].[Estudiante] ([Id], [Nombres], [Apellidos], [Edad], [Sexo]) VALUES (5, N'iker', N'casillas', 43, N'masculino')
INSERT [dbo].[Estudiante] ([Id], [Nombres], [Apellidos], [Edad], [Sexo]) VALUES (11, N'Pepita', N'Perez', 0, NULL)
INSERT [dbo].[Estudiante] ([Id], [Nombres], [Apellidos], [Edad], [Sexo]) VALUES (12, N'rosa', N'portillo', 19, N'femenino')
INSERT [dbo].[Estudiante] ([Id], [Nombres], [Apellidos], [Edad], [Sexo]) VALUES (13, N'juan', N'perez', 34, N'masculino')
INSERT [dbo].[Estudiante] ([Id], [Nombres], [Apellidos], [Edad], [Sexo]) VALUES (14, N'Melvin', N'ramirez', 22, N'masculino')
INSERT [dbo].[Estudiante] ([Id], [Nombres], [Apellidos], [Edad], [Sexo]) VALUES (15, N'jonh', N'moreno', 32, N'21')
SET IDENTITY_INSERT [dbo].[Estudiante] OFF
GO
