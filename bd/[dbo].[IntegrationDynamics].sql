USE [Producao]  
GO  
  
/****** Object:  Table [dbo].[IntegrationExceptionDynamics]    Script Date: 15-04-2014 23:34:43 ******/  
SET ANSI_NULLS ON  
GO  
  
SET QUOTED_IDENTIFIER ON  
GO  
  
SET ANSI_PADDING ON  
GO  
  
CREATE TABLE [dbo].[IntegrationDynamicsLog](  
    [Id] [bigint] IDENTITY(1,1) NOT NULL,  
    [vc_mesage] [varchar](100) NULL,  
    [vc_type] [varchar](100) NULL,  
    [vc_source] [nvarchar](max) NULL,  
    [vc_json] [nvarchar](max) NULL,  
    [sd_dt_event] [datetime] NULL,  
 CONSTRAINT [ConstDynamics] PRIMARY KEY CLUSTERED   
(  
    [Id] ASC  
)
  WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]  
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
 
  
GO  
  
SET ANSI_PADDING OFF  
GO 

