Use POS
Select * From UserSetting

Create Procedure SP_Insert_UserSetting
@UserID		int				=0,
@UserName	nvarchar(30)	='',
@Password	nvarchar(15)	='',
@UserLevel	nvarchar(Max)	='',
@UpdateDate	nvarchar(10)	='',
@action		int				=0
As
Begin

If @action=0
	Insert UserSetting(UserName, Password, UserLevel, UpdateDate) Values(@UserName, @Password, @UserLevel, @UpdateDate) 

If @action=1
	Update UserSetting Set UserName=@UserName, Password=@Password, UserLevel=@UserLevel, UpdateDate=@UpdateDate Where UserID=@UserID

If @action=2
	Delete UserSetting Where UserID=@UserID

End

-------------------------------------------------------------------------------------------------------------------------------------

Create Procedure SP_Select_UserSetting
@para1	nvarchar(max)	='',
@para2	nvarchar(max)	='',
@action int				=0
As
Begin

If @action=0
	Select ROW_NUMBER() Over(Order By UserName) As No, * From UserSetting Order By UserName

If @action=1
	Select * From UserSetting Where UserName=@para1 And Password=@para2

If @action=2
	Select ROW_NUMBER() Over(Order By UserName) As No, * From UserSetting Where UserName Like @para1+'%' Order By UserName

End

-------------------------------------------------------------------------------------------------------------------------------------