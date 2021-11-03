CREATE PROCEDURE studentadd_sp
	@std_id				INt,
	@std_name			VARCHAR(15), 
    @std_addr			VARCHAR (30),
    @std_pnum			INT ,         
    @sex				VARCHAR (8)  ,
    @ date_of_birth		date      
AS
	SELECT @param1, @param2
RETURN 0
