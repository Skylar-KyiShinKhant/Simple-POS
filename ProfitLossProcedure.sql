Use POS
Select * From vi_Purchase_PL
Select * From vi_Sale_PL

Create Procedure SP_Select_ProfitLoss
@para1	nvarchar(150)	='',
@para2	nvarchar(150)	='',
@para3	nvarchar(150)	='',
@action	int				=0
As
Begin

If @action=0
	Select ItemName, Sum(PurchaseQty*PurchasePrice) As PurchaseTotal From vi_Purchase_PL Where ItemName Like @para1+'%' And PurchaseDate Between @para2 And @para3 Group By ItemName Order By ItemName

If @action=1
	Select ItemName, Sum(SaleQty*SalePrice) As SaleTotal From vi_Sale_PL Where ItemName Like @para1+'%' And SaleDate Between @para2 And @para3 Group By ItemName Order By ItemName

If @action=2
	Select DATEDIFF(d, @para1, @para2) As No

End
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------