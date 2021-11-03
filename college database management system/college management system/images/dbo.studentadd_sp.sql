CREATE PROCEDURE studentadd_sp
	@std_id varchar(20),
	@name varchar(15),
	@addr varchar(30),
	@phnum varchar(15),
	@sex varchar(8),
	@date_of_birth date

AS
	insert into STUDENT(std_id,name,addr,phnum,sex,date_of_birth)values(@std_id,@name,@addr,@phnum,@sex,@date_of_birth)
RETURN 0