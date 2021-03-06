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

GO
/****** Object:  Table [dbo].[GIS_Table]    Script Date: 04/22/2014 11:27:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GIS_Table]') AND type in (N'U'))
DROP TABLE [dbo].[GIS_Table]
GO
/****** Object:  Table [dbo].[GIS_Table]    Script Date: 04/22/2014 11:27:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIS_Table](
	[HMISCode] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[POINT_X] [float] NULL,
	[POINT_Y] [float] NULL
) ON [PRIMARY]
GO

INSERT [dbo].[GIS_Table] ([HMISCode], [POINT_X], [POINT_Y]) VALUES (N'307000011', 10.67903, 37.26863)
INSERT [dbo].[GIS_Table] ([HMISCode], [POINT_X], [POINT_Y]) VALUES (N'4160012', 7.6826, 36.85534)
