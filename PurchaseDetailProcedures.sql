Use POS
Select * From PurchaseDetail

Create Procedure SP_Insert_PurchaseDetail
@PurchaseID		int		=0,
@ItemID			int		=0,
@PurchaseQty	int		=0,
@PurchasePrice	int		=0,
@action			int		=0
As
Begin

If @action=0
	Insert PurchaseDetail Values(@PurchaseID, @ItemID, @PurchaseQty, @PurchasePrice)

End

-----------------------------------------------------------------------------------------------

Create Procedure SP_Select_PurchaseDetail
@para1	nvarchar(16)	='',
@para2	nvarchar(16)	='',
@action	int				=0
As
Begin

If @action=0
	Select * From vi_PurchaseDetail Where PurchaseID=@para1 Order By ItemName

End

------------------------------------------------------------------------------------------------