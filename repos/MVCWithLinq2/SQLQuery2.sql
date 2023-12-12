Create database MVCDB

Use MVCDB

CREATE Procedure Student_Select(@Sid Int=Null, @Status Bit=Null)
As
Begin
   If @Sid Is Null And @Status Is Null 		--Fetches all the records of table
      Select Sid, Name, Class, Fees, Photo From Student Order By Sid;
   Else If @Sid Is Null And @Status Is Not Null 	--Fetches records based on Status
      Select Sid, Name, Class, Fees, Photo From Student Where Status=@Status Order By Sid;
   Else If @Sid Is Not Null And @Status Is Null 	--Fetches a single record based on Sid
      Select Sid, Name, Class, Fees, Photo From Student Where Sid=@Sid; 
   Else If @Sid Is Not Null And @Status Is Not Null 	--Fetches a single record based on Sid & Status 
      Select Sid, Name, Class, Fees, Photo From Student Where Sid=@Sid And Status=@Status;
End;
Create Procedure Student_Insert(@Sid int, @Name varchar(50), @Class int, @Fees money, @Photo varchar(100)=null)
As
   Insert Into Student (Sid, Name, Class, Fees,Photo) Values (@Sid, @Name, @Class, @Fees, @Photo)
Create Procedure Student_Update(@Sid int, @Name varchar(50), @Class int, @Fees money, @Photo varchar(100)=Null)
As
   Update Student Set Name=@Name, Class=@Class, Fees=@Fees, Photo=@Photo Where Sid=@Sid;
Create Procedure Student_Delete(@Sid Int)
As
   Update Student Set Status=0 Where Sid=@Sid;
