USE [TestInput]
GO

/****** Object:  StoredProcedure [dbo].[usr_InsertValues]    Script Date: 4/19/2014 9:16:51 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[usr_InsertValues] 
	-- Add the parameters for the stored procedure here
	@p1 varchar(64) = null, 
	@p2 smalldatetime = null,
	@p3 varchar(32) = null,
	@p4 varchar(32) = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [TestInput].[dbo].[mainpage]
		([linedesc],[datemade],[options1],[options2])
		VALUES (@p1, @p2, @p3, @p4)
END

GO


