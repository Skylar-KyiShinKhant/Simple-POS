Use POS
Select * From Supplier

Create Procedure SP_Insert_Supplier
@SupplierID		int				=0,
@SupplierName	nvarchar(30)	='',
@Address		nvarchar(100)	='',
@Phone			nvarchar(20)	='',
@UpdateDate		nvarchar(10)	='',
@action			int				=0
As
Begin

If @action=0
	Insert Supplier Values(@SupplierName, @Address, @Phone, @UpdateDate)

If @action=1
	Update Supplier Set SupplierName=@SupplierName, Address=@Address, Phone=@Phone, UpdateDate=@UpdateDate Where SupplierID=@SupplierID

If @action=2
	Delete Supplier Where SupplierID=@SupplierID

End

----------------------------------------------------------------------------------------------------------------------------------------------

Create Procedure SP_Select_Supplier
@para1	nvarchar(100)	='',
@para2	nvarchar(100)	='',
@action	int				=0
As
Begin

If @action=0
	Select ROW_NUMBER() Over(Order By SupplierName) As No, * From Supplier Order By SupplierName

If @action=1
	Select * From Supplier Where SupplierName=@para1 And Address=@para2

If @action=2
	Select ROW_NUMBER() Over(Order By SupplierName) As No, * From Supplier Where SupplierName Like @para1+'%' Order By SupplierName

If @action=3
	Select ROW_NUMBER() Over(Order By SupplierName) As No, * From Supplier Where Phone Like @para1+'%' Order By SupplierName
		
If @action=4
	Select ROW_NUMBER() Over(Order By SupplierName) As No, * From Supplier Where Address Like @para1+'%' Order By SupplierName

End

--------------------------------------------------------------------------------------------------------------------------------------------