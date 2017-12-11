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

-- Insert Category --

INSERT INTO Category (Name, Purpose) VALUES ('General', 'Dudas Generales');
INSERT INTO Category (Name, Purpose) VALUES ('Diversion', 'Comedia y Alegria');

-- Insert Questions --

INSERT INTO Questions (Title, Content, Points, Solved, Deleted, Category_CategoryId, User_UserId) VALUES ('Que documentos se requiere para inscribirse a la uiversidad?', 'Fui a la universidad y me perdi', 2, 0, 0, 1, 1);
INSERT INTO Questions (Title, Content, Points, Solved, Deleted, Category_CategoryId, User_UserId) VALUES ('Quienes se animan a ir al Hotel Regina?', 'Fiesta de los de sistemas', 5, 1, 0, 2, 2);


-- Insert Answer --

INSERT INTO Answer (Content, Points, Solved, Deleted, Questions_QuestionsId, User_UserId) VALUES ('En la parte superior de la universidad se encuentra informacion', 2, 1, 0, 1, 3);
INSERT INTO Answer (Content, Points, Solved, Deleted, Questions_QuestionsId, User_UserId) VALUES ('yo me apunto para ir a la fiesta', 5, 1, 0, 2, 4);

END TRY

BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH