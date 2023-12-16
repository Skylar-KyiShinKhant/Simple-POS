Use POS
Select * From Sale

Create Procedure SP_Insert_Sale
@SaleID			int			=0,
@Voucher		nvarchar(16)	='',
@SaleDate		nvarchar(10)	='',
@TotalAmount	int			=0,
@Tax			int			=0,
@GrandTotal		int			=0,
@UserID			int			=0,
@action			int			=0
As
Begin

If @action=0
	Insert Sale Values(@Voucher, @SaleDate, @TotalAmount, @Tax, @GrandTotal, @UserID)

End

-------------------------------------------------------------------------------------------

Create Procedure SP_Select_Sale
@para1	nvarchar(16)	='',
@para2	nvarchar(16)	='',
@action	int				=0
As
Begin

If @action=0
	Select ROW_NUMBER() Over(Order By SaleDate Desc) As No, *From vi_Sale Order By SaleDate Desc

If @action=1
	Select Max(Substring(Voucher,2,3)) As Voucher From Sale Where SaleDate=@para1

If @action=2
	Select DATEDIFF(D, GetDate(), @para1) As No

If @action=3
	Select Max(SaleID) As SaleID From Sale

If @action=4
	Select ROW_NUMBER() Over(Order By SaleDate Desc) As No, *From vi_Sale Where SaleDate Like @para1+'%' Order By SaleDate Desc

If @action=5
	Select ROW_NUMBER() Over(Order By SaleDate Desc) As No, *From vi_Sale Where UserName Like @para1+'%' Order By SaleDate Desc

End

----------------------------------------------------------------------------------------------------------------------------------