CREATE DATABASE	Lumea_Copiilor;


CREATE TABLE Categorii (
Categorii_Id INT PRIMARY KEY IDENTITY(1,1),
Categorii_Denumire VARCHAR(50)
);

INSERT INTO Categorii VALUES
('Jucarii din plus'),
('Arme si accesorii'),
('Seturi de creatie'),
('Seturi de constructie'),
('Trenuri si vehicule'),
('Papusi si case pentru papusi')

SELECT * FROM Categorii








CREATE TABLE Brand_uri (
Brand_uri_Id INT PRIMARY KEY IDENTITY(1,1),
Brand_uri_Denumire VARCHAR(50)
);

INSERT INTO Brand_uri VALUES
('Bruder'),
('Barbie'),
('Hot Wheels'),
('LEGO'),
('SEVEN_POLSKA'),
('Stip'),
('KAILI TOYS'),
('Gonher'),
('Play-Doh')

SELECT * FROM Brand_uri








CREATE TABLE Produse (
Produse_Id INT PRIMARY KEY IDENTITY(1,1),
Produse_Denumire VARCHAR(100),
Produse_Varsta INT,
Brand_uri_Id INT FOREIGN KEY REFERENCES Brand_uri(Brand_uri_Id),
Produse_Sex VARCHAR(10),
Produse_Pret INT,
Produse_Cantitate INT,
Produse_Tara VARCHAR(50),
Categorii_Id INT FOREIGN KEY REFERENCES Categorii(Categorii_Id)
);
ALTER TABLE Produse
ADD Este_Indisponibil BIT NOT NULL DEFAULT 0;

INSERT INTO Produse Values 

('Perna ortopedica pentru calatorie Spider-Man', 3, 5, 'M', 195, 27, 'Poland',1),
('Perna ortopedica pentru calatorie Minnie', 3, 5, 'F', 195, 21, 'Poland',1),
('Dragon alb', 3, 6, 'F & M', 69, 7, 'Republica Moldova',1),
('Dragon negru', 3, 6, 'F & M', 69, 4, 'Republica Moldova',1),
('Pisica Molly', 3, 6, 'F & M', 165, 0, 'Republica Moldova',1),
('Iepuras Neasa', 3, 6, 'F & M', 69, 3, 'Republica Moldova',1),
('Labuta roz', 3, 6, 'F & M', 189, 9, 'Republica Moldova',1),
('Perna ortopedica pentru calatorie Stitch', 3, 5, 'M', 195, 7, 'Poland',1),
('Perna ortopedica pentru calatorie Paw Patrol girl', 3, 5, 'F', 195, 0, 'Poland',1),

('Blaster cu ventuze si tinta', 6, 7, 'M', 525, 10, 'Republica Moldova', 2),
('Revolver Politie negru (12 gloante)', 3, 8, 'M', 195, 0, 'Republica Moldova', 2),
('Set pistol cu tinte rotative "Space Wars"', 4, 7, 'M', 130, 23, 'Republica Moldova', 2),
('Arma mitraliera cu 8 focuri Command', 6, 8, 'M', 575, 14, 'Republica Moldova', 2),
('Pusca de vanatoare cu 2 tevi', 6, 8, 'M', 485, 7, 'Republica Moldova', 2),
('Pistol de politie cu 8 focuri', 4, 8, 'M', 245, 1, 'Republica Moldova', 2),
('Blaster cu bile', 14, 9, 'M', 695, 7, 'Republica Moldova', 2),

('Pasta pentru modelare', 2, 9, 'F & M', 115, 9, 'SUA', 3),
('Set plastilina Sparkle 6 culori', 3, 9, 'F & M', 239, 20, 'SUA', 3),
('Set Play-Doh "Aur si argint"', 3, 9, 'F & M', 195, 3, 'SUA', 3),
('Set de joaca "Mini-dulciuri"', 3, 9, 'F & M', 55, 19, 'SUA', 3),
('Set de joaca cu pasta de modelare Farm', 3, 9, 'F & M', 175, 3, 'SUA', 3),
('Set de joaca cu pasta de modelare Cosmos',3 , 9, 'F & M', 135, 9, 'SUA', 3),
('Set de joaca cu pasta pentru modelare Breakfast', 4, 9, 'F & M', 109, 21, 'SUA', 3),

('Constructor LEGO DUPLO Cutie in forma de caramida', 2, 4, 'F & M', 499, 11, 'China', 4),
('Boxa pentru depozitare LEGO Small Head - Girl', 3, 4, 'F & M', 559, 3, 'China', 4),
('Constructor LEGO Marvel Truck Hulk vs Thanos', 7, 4, 'M', 595, 9, 'China', 4),
('Constructor LEGO Star Wars Duelul lui Ahsoka Tano pe Peridea', 8, 4, 'M', 1155, 5, 'China', 4),
('Constructor LEGO Architecture London', 12, 4, 'F & M', 945, 2, 'China', 4),
('Constructor LEGO Marvel Ascensiunea Domo', 8, 4, 'M', 2179, 6, 'China', 4),
('Constructor LEGO Marvel Eternii in umbra lui Arishem', 7, 4, 'M', 1485, 3, 'China', 4),

('Container pentru 18 masini', 3, 3, 'M', 209, 1, 'SUA', 5),
('Pista Hot Wheels "Vanatoarea de rechini"', 4, 3, 'M', 873, 10, 'SUA', 5),
('Set din 20 masinute', 3, 3, 'M', 1035, 15, 'SUA', 5),
('Set de joaca Garaj cu 4 nivele', 4, 3, 'M', 975, 8, 'SUA', 5),
('Set de joaca Mega Rechin', 4, 3, 'M', 444, 4, 'SUA', 5),
('Tractor Massey Ferguson cu incarcator frontal', 3, 1, 'M', 995, 12, 'Republica Moldova', 5),
('Masina de teren pentru politie Jeep Wrangler cu figurina', 3, 1, 'M', 1095, 17, 'Republica Moldova', 5),
('Camion-cisterna MAN TGS', 3, 1, 'M', 1395, 13, 'Republica Moldova', 5),
('Mini-excavator JCB cu figurina muncitor', 4, 1, 'M', 465, 11, 'Republica Moldova', 5),

('Papusa Barbie "To Move Fitness"', 3, 2, 'F', 485, 21, 'China', 6),
('Barbie. Set de joaca "Papusa cu calut"', 3, 2, 'F', 995, 18, 'China', 6),
('Barbie. Set de joaca "Echipa de fotbal Chelsea"', 3, 2, 'F', 580, 15, 'China', 6),
('Barbie. Set de joaca cu accesorii "Salon de frumusete"', 3, 2, 'F', 1495, 6, 'China', 6),
('Set de joaca Casuta Barbie', 3, 2, 'F', 1230, 8, 'China', 6),
('Papusa Barbie "Fashion"', 3, 2, 'F', 309, 24, 'China', 6),
('Papusa Barbie "Tinutele in voga"', 3, 2, 'F', 299, 13, 'China', 6),
('Papusa Barbie "Tinutele stilate"', 3, 2, 'F', 189, 12, 'China', 6),
('Papusa Barbie Deluxe Style Blonda in rochie roz', 3, 2, 'F', 460, 20, 'China', 6),
('Papusa Barbie Fantastic fashion Magia imaginilor', 3, 2, 'F', 649, 25, 'China', 6),
('Set de curatenie Barbie', 3, 2, 'F', 195, 4, 'China', 6),
('Set de joaca Barbie "Florarie"', 3, 2, 'F', 785, 29, 'China', 6)












CREATE TABLE Utilizatori (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Nume NVARCHAR(100),
    Prenume NVARCHAR(100),
    Email NVARCHAR(100),
    Username NVARCHAR(100),
    Parola NVARCHAR(100),
    ImagineProfil VARBINARY(MAX)
);

SELECT * FROM Utilizatori









CREATE TABLE Administrator (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Nume NVARCHAR(100),
    Prenume NVARCHAR(100),
    Email NVARCHAR(100),
    Username NVARCHAR(100),
    Parola NVARCHAR(100),
    ImagineProfil VARBINARY(MAX)
);

SELECT * FROM Administrator









CREATE TABLE Cart (
	ID INT PRIMARY KEY IDENTITY(1,1),
	Produse_Id INT FOREIGN KEY REFERENCES Produse(Produse_Id),
	ZiuaAchizitionare Date,
	Cantitatea INT,
	Utilizator_ID INT FOREIGN KEY REFERENCES Utilizatori(ID)
);

SELECT * FROM Cart









CREATE TABLE Cumparat(
	ID INT PRIMARY KEY IDENTITY(1,1),
	Produse_Id INT FOREIGN KEY REFERENCES Produse(Produse_Id),
	ZiuaAchizitionare Date,
	Cantitatea INT,
	Utilizator_ID INT FOREIGN KEY REFERENCES Utilizatori(ID),
);

SELECT * FROM Cumparat









IF OBJECT_ID('OutOfStock', 'U') IS NOT NULL
    DROP TABLE OutOfStock;

CREATE TABLE OutOfStock (
    Produse_Id INT PRIMARY KEY, -- fãrã IDENTITY, pentru a pãstra ID-ul original
    Produse_Denumire VARCHAR(100),
    Produse_Varsta INT,
    Brand_uri_Id INT FOREIGN KEY REFERENCES Brand_uri(Brand_uri_Id),
    Produse_Sex VARCHAR(10),
    Produse_Pret INT,
    Produse_Cantitate INT,
    Produse_Tara VARCHAR(50),
    Categorii_Id INT FOREIGN KEY REFERENCES Categorii(Categorii_Id),
    DataEpuizare DATE DEFAULT GETDATE()
);

SELECT * FROM OutOfStock 










CREATE TABLE Jucarii_Moldova (
    Moldova_Id INT PRIMARY KEY IDENTITY(1,1),
    Produse_Denumire VARCHAR(100),
    Produse_Varsta INT,
    Brand_uri_Id INT FOREIGN KEY REFERENCES Brand_uri(Brand_uri_Id),
    Produse_Sex VARCHAR(10),
    Produse_Pret INT,
    Produse_Cantitate INT,
    Produse_Tara VARCHAR(50),
    Categorii_Id INT FOREIGN KEY REFERENCES Categorii(Categorii_Id)
);

INSERT INTO Jucarii_Moldova (
    Produse_Denumire,
    Produse_Varsta,
    Brand_uri_Id,
    Produse_Sex,
    Produse_Pret,
    Produse_Cantitate,
    Produse_Tara,
    Categorii_Id
)
SELECT 
    Produse_Denumire,
    Produse_Varsta,
    Brand_uri_Id,
    Produse_Sex,
    Produse_Pret,
    Produse_Cantitate,
    Produse_Tara,
    Categorii_Id
FROM Produse
WHERE Produse_Tara = 'Republica Moldova'
  AND Produse_Cantitate > 0;

SELECT * FROM Jucarii_Moldova













CREATE TABLE Produse_Populare (
    Produse_Id INT PRIMARY KEY,
    Produse_Denumire VARCHAR(100),
    Total_Vandut INT,
    Produse_Pret INT,
    Produse_Varsta INT,
    Produse_Sex VARCHAR(10),
    Brand_Nume VARCHAR(100),
    Categorie_Nume VARCHAR(100),
    Produse_Tara VARCHAR(50)
);
/*_________________________________VIEW__________________________________________*/

CREATE VIEW Afisare_Produse 
AS
SELECT P.Produse_Id, P.Produse_Denumire, P.Produse_Varsta, B.Brand_uri_Denumire, P.Produse_Sex, P.Produse_Pret, P.Produse_Cantitate, P.Produse_Tara, C.Categorii_Denumire

FROM Produse P

INNER JOIN Categorii C ON P.Categorii_Id = C.Categorii_Id
INNER JOIN Brand_uri B ON P.Brand_uri_Id = B.Brand_uri_Id
WHERE Este_Indisponibil = 0

SELECT * FROM Afisare_Produse











CREATE OR ALTER VIEW Afisare_Cart AS
SELECT 
    c.ID, 
    p.Produse_Denumire, 
    b.Brand_uri_Denumire, 
    p.Produse_Pret, 
    c.Cantitatea,
    c.Utilizator_ID
FROM Cart c
INNER JOIN Produse p ON c.Produse_Id = p.Produse_Id
INNER JOIN Utilizatori u ON c.Utilizator_ID = u.ID
INNER JOIN Brand_uri b ON p.Brand_uri_Id = b.Brand_uri_Id

SELECT * FROM Afisare_Cart








CREATE VIEW Afisare_OutOfStock 
AS
SELECT S.Produse_Id AS ID, S.Produse_Denumire AS Denumire, S.Produse_Varsta AS Varsta, B.Brand_uri_Denumire AS Brand, S.Produse_Sex AS Sex, S.Produse_Pret AS Pret, S.Produse_Tara AS Tara, C.Categorii_Denumire AS Categorie
FROM OutOfStock S
INNER JOIN Categorii C ON S.Categorii_Id = C.Categorii_Id
INNER JOIN Brand_uri B ON S.Brand_uri_Id = B.Brand_uri_Id

SELECT * FROM Afisare_OutOfStock 












CREATE OR ALTER VIEW Vedere_Jucarie_MinMaxPret AS
SELECT 
    p.Produse_Id,
    p.Produse_Denumire,
    p.Produse_Varsta,
    b.Brand_uri_Denumire,
    p.Produse_Sex,
    p.Produse_Pret,
    p.Produse_Cantitate,
    p.Produse_Tara,
    c.Categorii_Denumire,
    'Cea mai ieftinã' AS TipJucarie
FROM Produse p
JOIN Brand_uri b ON p.Brand_uri_Id = b.Brand_uri_Id
JOIN Categorii c ON p.Categorii_Id = c.Categorii_Id
WHERE p.Produse_Pret = (
        SELECT MIN(Produse_Pret) 
        FROM Produse 
        WHERE Este_Indisponibil = 0
    )
  AND p.Este_Indisponibil = 0

UNION ALL

SELECT 
    p.Produse_Id,
    p.Produse_Denumire,
    p.Produse_Varsta,
    b.Brand_uri_Denumire,
    p.Produse_Sex,
    p.Produse_Pret,
    p.Produse_Cantitate,
    p.Produse_Tara,
    c.Categorii_Denumire,
    'Cea mai scumpã' AS TipJucarie
FROM Produse p
JOIN Brand_uri b ON p.Brand_uri_Id = b.Brand_uri_Id
JOIN Categorii c ON p.Categorii_Id = c.Categorii_Id
WHERE p.Produse_Pret = (
        SELECT MAX(Produse_Pret) 
        FROM Produse 
        WHERE Este_Indisponibil = 0
    )
  AND p.Este_Indisponibil = 0;


  SELECT * FROM Vedere_Jucarie_MinMaxPret


  











CREATE VIEW Afisare_Jucarii_md 
AS
SELECT M.Moldova_Id, M.Produse_Denumire, M.Produse_Varsta, B.Brand_uri_Denumire, M.Produse_Sex, M.Produse_Pret, M.Produse_Cantitate, C.Categorii_Denumire

FROM Jucarii_Moldova M

INNER JOIN Categorii C ON M.Categorii_Id = C.Categorii_Id
INNER JOIN Brand_uri B ON M.Brand_uri_Id = B.Brand_uri_Id

SELECT * FROM Afisare_Jucarii_md












CREATE VIEW Afisare_Cumparat 
AS
SELECT C.ID, P.Produse_Denumire, C.ZiuaAchizitionare, C.Cantitatea, U.Username
FROM Cumparat C
INNER JOIN Produse P ON C.Produse_Id = P.Produse_Id
INNER JOIN Utilizatori U ON C.Utilizator_ID = U.ID

SELECT * FROM Afisare_Cumparat
/*_________________________________STORED PROCEDURE__________________________________________*/
CREATE OR ALTER PROCEDURE MutaProduseEpuizate
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO OutOfStock (
        Produse_Id,
        Produse_Denumire,
        Produse_Varsta,
        Brand_uri_Id,
        Produse_Sex,
        Produse_Pret,
        Produse_Cantitate,
        Produse_Tara,
        Categorii_Id
    )
    SELECT 
        Produse_Id,
        Produse_Denumire,
        Produse_Varsta,
        Brand_uri_Id,
        Produse_Sex,
        Produse_Pret,
        Produse_Cantitate,
        Produse_Tara,
        Categorii_Id
    FROM Produse
    WHERE Produse_Cantitate = 0 AND Este_Indisponibil = 0;

    UPDATE Produse
    SET Este_Indisponibil = 1
    WHERE Produse_Cantitate = 0 AND Este_Indisponibil = 0;
END;













CREATE OR ALTER PROCEDURE GetPapusiDisponibile
AS
BEGIN
    SELECT 
        p.Produse_Id,
        p.Produse_Denumire,
        p.Produse_Varsta,
        b.Brand_uri_Denumire,
        p.Produse_Sex,
        p.Produse_Pret,
        p.Produse_Cantitate,
        p.Produse_Tara,
        c.Categorii_Denumire
    FROM Produse p
    JOIN Brand_uri b ON p.Brand_uri_Id = b.Brand_uri_Id
    JOIN Categorii c ON p.Categorii_Id = c.Categorii_Id
    WHERE (p.Produse_Denumire LIKE '%papusa%' OR p.Produse_Denumire LIKE '%Papusa%')
      AND p.Este_Indisponibil = 0
    ORDER BY p.Produse_Pret ASC;
END;

EXEC GetPapusiDisponibile














CREATE OR ALTER PROCEDURE GetPretMediuPeTara
    @Tara VARCHAR(50)
AS
BEGIN
    SELECT 
        @Tara AS Tara,
        AVG(CAST(Produse_Pret AS FLOAT)) AS Pret_Mediu
    FROM Produse
    WHERE Produse_Tara = @Tara
      AND Este_Indisponibil = 0;
END;















CREATE OR ALTER PROCEDURE GetTariDisponibile
AS
BEGIN
    SELECT DISTINCT Produse_Tara
    FROM Produse
    WHERE Este_Indisponibil = 0 AND Produse_Tara IS NOT NULL;
END;














CREATE OR ALTER PROCEDURE GetTotalProduseVanduteInZi
    @Data DATE
AS
BEGIN
    SELECT 
        ZiuaAchizitionare,
        SUM(Cantitatea) AS Total_Produse_Vandute
    FROM Cumparat
    WHERE ZiuaAchizitionare = @Data
    GROUP BY ZiuaAchizitionare;
END;















CREATE OR ALTER PROCEDURE GetJucariiFiltrate
    @PretMax INT,
    @VarstaMin INT,
    @VarstaMax INT
AS
BEGIN
    SELECT 
        Produse_Denumire,
        Produse_Varsta,
        Produse_Pret,
        Produse_Sex,
        Produse_Cantitate,
        Produse_Tara
    FROM Produse
    WHERE Produse_Pret <= @PretMax
      AND Produse_Varsta BETWEEN @VarstaMin AND @VarstaMax;
END;













CREATE OR ALTER PROCEDURE RefreshProdusePopulare
AS
BEGIN

    DELETE FROM Produse_Populare;


    INSERT INTO Produse_Populare (
        Produse_Id,
        Produse_Denumire,
        Total_Vandut,
        Produse_Pret,
        Produse_Varsta,
        Produse_Sex,
        Brand_Nume,
        Categorie_Nume,
        Produse_Tara
    )
    SELECT 
        p.Produse_Id,
        p.Produse_Denumire,
        SUM(c.Cantitatea) AS Total_Vandut,
        p.Produse_Pret,
        p.Produse_Varsta,
        p.Produse_Sex,
        b.Brand_uri_Denumire,
        cat.Categorii_Denumire,
        p.Produse_Tara
    FROM Cumparat c
    JOIN Produse p ON p.Produse_Id = c.Produse_Id
    JOIN Brand_uri b ON p.Brand_uri_Id = b.Brand_uri_Id
    JOIN Categorii cat ON p.Categorii_Id = cat.Categorii_Id
    GROUP BY 
        p.Produse_Id,
        p.Produse_Denumire,
        p.Produse_Pret,
        p.Produse_Varsta,
        p.Produse_Sex,
        b.Brand_uri_Denumire,
        cat.Categorii_Denumire,
        p.Produse_Tara
    ORDER BY SUM(c.Cantitatea) DESC;
END;
