-- Insert Role --

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

INSERT INTO Person (Name, LastName, Birthday, Gender_GenderId) VALUES ('Juanito', 'Perez', '1/01/2000', 1);
INSERT INTO Person (Name, LastName, Birthday, Gender_GenderId) VALUES ('Maria', 'Tapia', '1/05/2003', 2);
INSERT INTO Person (Name, LastName, Birthday, Gender_GenderId) VALUES ('Pablo', 'Rodriguez', '1/10/2005', 1);
INSERT INTO Person (Name, LastName, Birthday, Gender_GenderId) VALUES ('Fernanda', 'Soliz', '1/12/2011', 2);

-- Insert User --

INSERT INTO [dbo].[User] (Email, Password, Deleted, Role_RoleId, Person_PersonId) VALUES ('juanito@gmail.com', '1234', 0, 1, 1);
INSERT INTO [dbo].[User] (Email, Password, Deleted, Role_RoleId, Person_PersonId) VALUES ('maria@gmail.com', '1234', 0, 2, 2);
INSERT INTO [dbo].[User] (Email, Password, Deleted, Role_RoleId, Person_PersonId) VALUES ('pablo@gmail.com', '1234', 0, 2, 3);
INSERT INTO [dbo].[User] (Email, Password, Deleted, Role_RoleId, Person_PersonId) VALUES ('fernanda@gmail.com', '1234', 1, 2, 4);

-- Insert UserCareer --

INSERT INTO UserCareer (User_UserId, Career_CareerId) VALUES (2, 1);
INSERT INTO UserCareer (User_UserId, Career_CareerId) VALUES (3, 2);

-- Insert Contact --

INSERT INTO Contact (Data, Description, Deleted, Person_PersonId) VALUES ('444444', 'Telefono', 0, 2);
INSERT INTO Contact (Data, Description, Deleted, Person_PersonId) VALUES ('Calle 7', 'Casa', 0, 3);
INSERT INTO Contact (Data, Description, Deleted, Person_PersonId) VALUES ('444444', 'Telefono', 0, 3);
INSERT INTO Contact (Data, Description, Deleted, Person_PersonId) VALUES ('777777', 'Celular', 0, 4);
