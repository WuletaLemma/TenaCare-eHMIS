--/*
-- * 
-- * Copyright © 2006-2017 TenaCareeHMIS  software, by The Administrators of the Tulane Educational Fund, 
-- * dba Tulane University, Center for Global Health Equity is distributed under the GNU General Public License(GPL).
-- * All rights reserved.

-- * This file is part of TenaCareeHMIS
-- * TenaCareeHMIS is free software: 
-- * 
-- * you can redistribute it and/or modify it under the terms of the 
-- * GNU General Public License as published by the Free Software Foundation, 
-- * version 3 of the License, or any later version.
-- * TenaCareeHMIS is distributed in the hope that it will be useful,
-- * but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or 
-- * FITNESS FOR A PARTICULAR PURPOSE.See the GNU General Public License for more details.

-- * You should have received a copy of the GNU General Public License along with TenaCareeHMIS.  
-- * If not, see http://www.gnu.org/licenses/.    
-- * 
-- * 
-- */

/****** Object:  Table [dbo].[EthEHMIS_ImportedFiles]    Script Date: 09/21/2016 11:27:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EthEHMIS_ImportedFiles]') AND type in (N'U'))
DROP TABLE [dbo].[EthEHMIS_ImportedFiles]
GO
/****** Object:  Table [dbo].[EthEHMIS_ImportedFiles]    Script Date: 09/21/2016 11:27:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[EthEHMIS_ImportedFiles](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[User] [varchar](50) NULL,
	[FileName] [varchar](MAX) NULL,
	[Date] [datetime] NULL,
	[FileSize] [varchar](50) NULL,
 CONSTRAINT [PK_EthEHMIS_ImportedFiles] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO