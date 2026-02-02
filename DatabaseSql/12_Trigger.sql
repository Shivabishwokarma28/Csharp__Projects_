CREATE TRIGGER TriClass
ON Student
AFTER INSERT
AS
BEGIN
print('Something happend to Student table')
END