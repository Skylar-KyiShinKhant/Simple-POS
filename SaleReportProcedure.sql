Use POS
Select * From vi_SaleReport

Create Procedure SP_Select_SaleReport
@para1	nvarchar(16)	='',
@para2	nvarchar(16)	='',
@action	int				=0
As
Begin

If @action=0
	Select Top(1) With Ties * From vi_SaleReport Order By SaleID Desc

If @action=1
	Select ROW_NUMBER() Over(Order By SaleDate Desc) As No, * From vi_SaleReport Where SaleDate Like @para1+'%' Order By SaleDate Desc

If @action=2
	Select ROW_NUMBER() Over(Order By SaleDate Desc) As No, * From vi_SaleReport Where UserName Like @para1+'%' Order By SaleDate Desc

End
------------------------------------------------------------------------------------------------------------------------------------------