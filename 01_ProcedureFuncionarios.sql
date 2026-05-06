USE BibliotecaDB
GO

select * from Usuarios

GO
	CREATE PROCEDURE obterFuncionarios
	AS
	BEGIN
		SELECT * FROM Funcionarios
	END
GO

SELECT * FROM Funcionarios