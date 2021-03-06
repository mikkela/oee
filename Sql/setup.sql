USE [oee]
GO
/****** Object:  Table [dbo].[ProductionStop]    Script Date: 03/10/2009 21:29:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductionStop](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Version] [int] NOT NULL,
	[Name] [nvarchar](255) NULL,
	[Planned] [bit] NULL,
	[GlobalId] [uniqueidentifier] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductionTeam]    Script Date: 03/10/2009 21:29:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductionTeam](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Version] [int] NOT NULL,
	[GlobalId] [uniqueidentifier] NULL,
	[Name] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Production]    Script Date: 03/10/2009 21:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Production](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Version] [int] NOT NULL,
	[Machine] [nvarchar](255) NULL,
	[OrderNumber] [nvarchar](255) NULL,
	[ProductNumber] [nvarchar](255) NULL,
	[ExpectedItems] [bigint] NULL,
	[ProducedItemsPerHour] [bigint] NULL,
	[ValidatedProducedItemsPerHour] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[OrderNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MachineConfiguration]    Script Date: 03/10/2009 21:28:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MachineConfiguration](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Version] [int] NOT NULL,
	[MachineName] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[MachineName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 03/10/2009 21:28:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Version] [int] NOT NULL,
	[OrderNumber] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[OrderNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 03/10/2009 21:28:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Version] [int] NOT NULL,
	[ProductNumber] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[ProductNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AvailableProductionStops]    Script Date: 03/10/2009 21:28:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AvailableProductionStops](
	[MachineConfigurationId] [bigint] NOT NULL,
	[ProductionStopId] [bigint] NOT NULL,
	[PresentationOrder] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MachineConfigurationId] ASC,
	[PresentationOrder] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductionStopRegistration]    Script Date: 03/10/2009 21:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductionStopRegistration](
	[ProductionLegId] [bigint] NOT NULL,
	[ProductionStopId] [bigint] NULL,
	[Duration] [bigint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductionLeg]    Script Date: 03/10/2009 21:28:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductionLeg](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Version] [int] NOT NULL,
	[ProductionId] [bigint] NULL,
	[ProductionTeamId] [bigint] NULL,
	[ProductionStart] [datetime] NULL,
	[ProductionEnd] [datetime] NULL,
	[CounterStart] [bigint] NULL,
	[CounterEnd] [bigint] NULL,
	[DiscardedItems] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FKE0DB441734A6532C]    Script Date: 03/10/2009 21:28:43 ******/
ALTER TABLE [dbo].[AvailableProductionStops]  WITH CHECK ADD  CONSTRAINT [FKE0DB441734A6532C] FOREIGN KEY([MachineConfigurationId])
REFERENCES [dbo].[MachineConfiguration] ([ID])
GO
ALTER TABLE [dbo].[AvailableProductionStops] CHECK CONSTRAINT [FKE0DB441734A6532C]
GO
/****** Object:  ForeignKey [FKE0DB44179F4819B8]    Script Date: 03/10/2009 21:28:43 ******/
ALTER TABLE [dbo].[AvailableProductionStops]  WITH CHECK ADD  CONSTRAINT [FKE0DB44179F4819B8] FOREIGN KEY([ProductionStopId])
REFERENCES [dbo].[ProductionStop] ([ID])
GO
ALTER TABLE [dbo].[AvailableProductionStops] CHECK CONSTRAINT [FKE0DB44179F4819B8]
GO
/****** Object:  ForeignKey [FKDF1375C472343D1F]    Script Date: 03/10/2009 21:28:57 ******/
ALTER TABLE [dbo].[ProductionLeg]  WITH CHECK ADD  CONSTRAINT [FKDF1375C472343D1F] FOREIGN KEY([ProductionTeamId])
REFERENCES [dbo].[ProductionTeam] ([ID])
GO
ALTER TABLE [dbo].[ProductionLeg] CHECK CONSTRAINT [FKDF1375C472343D1F]
GO
/****** Object:  ForeignKey [FKDF1375C4C80C36A1]    Script Date: 03/10/2009 21:28:58 ******/
ALTER TABLE [dbo].[ProductionLeg]  WITH CHECK ADD  CONSTRAINT [FKDF1375C4C80C36A1] FOREIGN KEY([ProductionId])
REFERENCES [dbo].[Production] ([ID])
GO
ALTER TABLE [dbo].[ProductionLeg] CHECK CONSTRAINT [FKDF1375C4C80C36A1]
GO
/****** Object:  ForeignKey [FKED0B921662E3E16]    Script Date: 03/10/2009 21:29:02 ******/
ALTER TABLE [dbo].[ProductionStopRegistration]  WITH CHECK ADD  CONSTRAINT [FKED0B921662E3E16] FOREIGN KEY([ProductionLegId])
REFERENCES [dbo].[ProductionLeg] ([ID])
GO
ALTER TABLE [dbo].[ProductionStopRegistration] CHECK CONSTRAINT [FKED0B921662E3E16]
GO
/****** Object:  ForeignKey [FKED0B92169F4819B8]    Script Date: 03/10/2009 21:29:02 ******/
ALTER TABLE [dbo].[ProductionStopRegistration]  WITH CHECK ADD  CONSTRAINT [FKED0B92169F4819B8] FOREIGN KEY([ProductionStopId])
REFERENCES [dbo].[ProductionStop] ([ID])
GO
ALTER TABLE [dbo].[ProductionStopRegistration] CHECK CONSTRAINT [FKED0B92169F4819B8]
GO
