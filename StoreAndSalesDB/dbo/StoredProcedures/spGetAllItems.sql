CREATE PROCEDURE [dbo].[spGetAllItems]

As 
BEGIN

Select * from Item Where [Status] = 1

END