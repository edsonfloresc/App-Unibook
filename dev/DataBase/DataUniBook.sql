-- Insert Role --
BEGIN TRANSACTION
BEGIN TRY
INSERT INTO Role (Name, Deleted) VALUES ('Administrador', 0);
INSERT INTO Role (Name, Deleted) VALUES ('Estudiante', 0);

-- Insert Gender --

INSERT INTO Gender (Name) VALUES ('Masculino');
INSERT INTO Gender (Name) VALUES ('Femenino');

-- Insert Faculty --

INSERT INTO Faculty (Name, Deleted) VALUES ('Tecnologia', 0);
INSERT INTO Faculty (Name, Deleted) VALUES ('Sociales', 0);

-- Insert Career --

INSERT INTO Career (Name, Deleted, Faculty_FacultyId) VALUES ('Sistemas', 0, 1);
INSERT INTO Career (Name, Deleted, Faculty_FacultyId) VALUES ('Derecho', 0, 2);

-- Insert Person --

INSERT INTO Person (Name, LastName, Birthday, Gender_GenderId, Deleted) VALUES ('Juanito', 'Perez', '1/01/2000', 1, 0);
INSERT INTO Person (Name, LastName, Birthday, Gender_GenderId, Deleted) VALUES ('Maria', 'Tapia', '1/05/2003', 2, 0);
INSERT INTO Person (Name, LastName, Birthday, Gender_GenderId, Deleted) VALUES ('Pablo', 'Rodriguez', '1/10/2005', 1, 0);
INSERT INTO Person (Name, LastName, Birthday, Gender_GenderId, Deleted) VALUES ('Fernanda', 'Soliz', '1/12/2011', 2, 0);

-- Insert User --

INSERT INTO [dbo].[User] (Email, Deleted, Role_RoleId, Person_PersonId) VALUES ('juanito@gmail.com', 0, 1, 1);
INSERT INTO [dbo].[User] (Email, Deleted, Role_RoleId, Person_PersonId) VALUES ('maria@gmail.com', 0, 2, 2);
INSERT INTO [dbo].[User] (Email, Deleted, Role_RoleId, Person_PersonId) VALUES ('pablo@gmail.com', 0, 2, 3);
INSERT INTO [dbo].[User] (Email, Deleted, Role_RoleId, Person_PersonId) VALUES ('fernanda@gmail.com', 1, 2, 4);

-- Paswword --

INSERT INTO Password (Psw, State, Date, User_UserId) VALUES ('1234', 1, '1/01/2000', 1);
INSERT INTO Password (Psw, State, Date, User_UserId) VALUES ('1234', 1, '1/05/2003', 2);
INSERT INTO Password (Psw, State, Date, User_UserId) VALUES ('1234', 1, '1/10/2005', 3);
INSERT INTO Password (Psw, State, Date, User_UserId) VALUES ('1234', 1, '1/12/2011', 4);

-- Insert UserCareer --

INSERT INTO UserCareer (User_UserId, Career_CareerId) VALUES (2, 1);
INSERT INTO UserCareer (User_UserId, Career_CareerId) VALUES (3, 2);

-- Insert Contact --

INSERT INTO Contact (Data, Description, Deleted, Person_PersonId) VALUES ('444444', 'Telefono', 0, 2);
INSERT INTO Contact (Data, Description, Deleted, Person_PersonId) VALUES ('Calle 7', 'Casa', 0, 3);
INSERT INTO Contact (Data, Description, Deleted, Person_PersonId) VALUES ('444444', 'Telefono', 0, 3);
INSERT INTO Contact (Data, Description, Deleted, Person_PersonId) VALUES ('777777', 'Celular', 0, 4);

--Insert State--
INSERT INTO State(Description) VALUES ('Perdido');
INSERT INTO State(Description) VALUES ('Buscandolo');
INSERT INTO State(Description) VALUES ('Encontrado');

--Insert Category--

INSERT INTO Category (Description,Active) VALUES ('Tecnología',1);
INSERT INTO Category (Description,Active) VALUES ('Ropa',1);
INSERT INTO Category (Description,Active) VALUES ('Materiales',1);

--Insert Lost Object--

INSERT INTO LostObject (Title,Description,DisplayTime,LostDate,Latitude,Longitude,Category_CategoryId,State_StateId,Person_PersonId) VALUES ('Celular','Se perdio mi celular de color negro',20,12/10/2017,-16.89567,-16.56784,1,1,1);
INSERT INTO LostObject (Title,Description,DisplayTime,LostDate,Latitude,Longitude,Category_CategoryId,State_StateId,Person_PersonId) VALUES ('Chaqueta','Se perdio mi chaqueta en el bloque e',20,12/10/2017,-16.89567,-16.56784,2,1,1);
INSERT INTO LostObject (Title,Description,DisplayTime,LostDate,Latitude,Longitude,Category_CategoryId,State_StateId,Person_PersonId) VALUES ('Celular','Se perdio mi celular de color rojo en el bloque de tecnologia',20,12/10/2017,-16.89567,-16.56784,1,1,1);

--Insert Comment--

INSERT INTO Comment (Description,Date,Active,LostObject_LostObjectId) VALUES ('Yo creo que vi tu celular en el bloque e en el segundo piso',21/10/2017,1);
INSERT INTO Comment (Description,Date,Active,LostObject_LostObjectId) VALUES ('Yo vi tu chaqueta por sociales',21/10/2017,2);
INSERT INTO Comment (Description,Date,Active,LostObject_LostObjectId) VALUES ('Yo tengo tu celular llamame para que te lo devuelva',21/10/2017,1);


END TRY

BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH