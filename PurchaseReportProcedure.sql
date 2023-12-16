Use POS
Select * from vi_PurchaseReport

Create Procedure SP_Select_PurchaseReport
@para1	nvarchar(16)	='',
@para2	nvarchar(16)	='',
@action	int				=0
As
Begin

If @action=0
	Select ROW_NUMBER() Over(Order By PurchaseDate Desc) As No, * From vi_PurchaseReport Where PurchaseDate Like @para1+'%' Order By PurchaseDate Desc

If @action=1
	Select ROW_NUMBER() Over(Order By PurchaseDate Desc) As No, * From vi_PurchaseReport Where SupplierName Like @para1+'%' Order By PurchaseDate Desc

If @action=2
	Select ROW_NUMBER() Over(Order By PurchaseDate Desc) As No, * From vi_PurchaseReport Where UserName Like @para1+'%' Order By PurchaseDate Desc

End

-------------------------------------------------------------------------------------------------------------------------------------------------------