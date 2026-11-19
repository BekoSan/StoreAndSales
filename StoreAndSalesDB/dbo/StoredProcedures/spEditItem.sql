CREATE PROCEDURE [dbo].[spEditItem]
@ItemId int,
@ItemName nvarchar(250),
@ReorderLevel int = 0,
@HasExpiryDate bit = 0,
@ExpiryDate date = NULL,
@ExpiryAlertDays int = 30
AS
BEGIN

IF @HasExpiryDate = 1 AND @ExpiryDate IS NULL
	BEGIN
		RAISERROR(N'يجب إدخال تاريخ انتهاء للصنف الخاضع للصلاحية.', 16, 1)
		RETURN
	END

	IF @ExpiryAlertDays NOT BETWEEN 1 AND 3650
	BEGIN
		RAISERROR(N'عدد أيام تنبيه الصلاحية يجب أن يكون بين 1 و3650.', 16, 1)
		RETURN
	END

	Update  Item
	Set
	ItemName = @ItemName,
	ReorderLevel = @ReorderLevel,
	HasExpiryDate = @HasExpiryDate,
	ExpiryDate = CASE WHEN @HasExpiryDate = 1 THEN @ExpiryDate ELSE NULL END,
	ExpiryAlertDays = @ExpiryAlertDays

Where Id = @ItemId

END
