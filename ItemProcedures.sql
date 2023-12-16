Use POS
Select * From Item

Create Procedure SP_Insert_Item
@ItemID		int				=0,
@ItemName	nvarchar(150)	='',
@Qty		int				=0,
@Price		int				=0,
@UpdateDate	nvarchar(10)	='',
@action		int				=0

As
Begin

If @action=0
	Insert Item Values(@ItemName, @Qty, @Price, @UpdateDate)
	
If @action=1
	Update Item Set ItemName=@ItemName, Qty=@Qty, Price=@Price, UpdateDate=@UpdateDate Where ItemID=@ItemID
	
If @action=2
	Delete Item Where ItemID=@ItemID
	
If @action=3
	Update Item Set Qty=Qty+@Qty, Price=(@Price*0.05)+@Price Where ItemID=@ItemID

If @action=4
	Update Item Set Qty=Qty-@Qty Where ItemID=@ItemID

End

-------------------------------------------------------------------------------------------------------------------------

Create Procedure SP_Select_Item
@para1	nvarchar(150) = '',
@para2	nvarchar(150) = '',
@action	int			  = 0

As
Begin

If @action=0
	Select ROW_NUMBER() Over(Order By ItemName) As No, * From Item Order By ItemName 

If @action=1
	Select * From Item Where ItemName=@para1

If @action=2
	Select ROW_NUMBER() Over(Order By ItemName) As No, * From Item Where ItemName Like @para1+'%' Order By ItemName

If @action=3
	Select ROW_NUMBER() Over(Order By ItemName) As No, * From Item Where Qty Like @para1+'%' Order By ItemName

If @action=4
	Select ROW_NUMBER() Over(Order By ItemName) As No, * From Item Where Price Like @para1+'%' Order By ItemName

If @action=5
	Select ROW_NUMBER() Over(Order By ItemName) As No, * From Item Where Qty>0 Order By ItemName

If @action=6
	Select ROW_NUMBER() Over(Order By ItemName) As No, * From Item Where Qty>0 And ItemName=@para1 order by ItemName

End

---------------------------------------------------------------------------------------------------------------------------