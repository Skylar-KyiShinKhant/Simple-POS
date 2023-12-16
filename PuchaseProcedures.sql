Use POS
Select * From Purchase

Create Procedure SP_Insert_Purchase
@PurchaseID		int				=0,
@PurchaseDate	nvarchar(10)	='',
@SupplierID		int				=0,
@TotalAmount	int				=0,
@UserID			int				=0,
@action			int				=0
As
Begin

If @action=0
	Insert Purchase Values(@PurchaseDate, @SupplierID, @TotalAmount, @UserID)

End
	
-----------------------------------------------------------------------------------------------------------------------------------------------

Create Procedure SP_Select_Purchase
@para1	nvarchar(16)	='',
@para2	nvarchar(16)	='',
@action int				=0
As
Begin

If @action=0
	Select ROW_NUMBER() Over(Order By PurchaseDate Desc) As No, * From Purchase Order By PurchaseDate Desc 

If @action=1
	Select Max(PurchaseID) As PurchaseID From Purchase

If @action=2
	Select DATEDIFF(D, GetDate(), @para1) As No

If @action=3
	Select ROW_NUMBER() Over(Order By PurchaseDate Desc) As No, * From vi_Purchase WHere PurchaseDate Like @para1+'%' Order By PurchaseDate Desc

If @action=4
	Select ROW_NUMBER() Over(Order By PurchaseDate Desc) As No, * From vi_Purchase WHere SupplierName Like @para1+'%' Order By PurchaseDate Desc

If @action=5
	Select ROW_NUMBER() Over(Order By PurchaseDate Desc) As No, * From vi_Purchase WHere UserName Like @para1+'%' Order By PurchaseDate Desc

End

-------------------------------------------------------------------------------------------------------------------------------------------------