Use POS
Select * From SaleDetail

Create Procedure SP_Insert_SaleDetail
@SaleID		nvarchar(16)	='',
@ItemID		int				=0,
@SaleQty	int				=0,
@SalePrice	int				=0,
@action		int				=0
As
Begin

If @action=0
	Insert SaleDetail Values(@SaleID, @ItemID, @SaleQty, @SalePrice)

End

-------------------------------------------------------------------------------------------------

Create Procedure SP_Select_SaleDetail
@para1	nvarchar(16)	='',
@para2	nvarchar(16)	='',
@action	int				=0
As
Begin

If @action=0
	Select * From vi_SaleDetail Where SaleID=@para1

End

-----------------------------------------------------------------------------------