DROP DATABASE IF EXISTS `medi_2020`;
CREATE DATABASE IF NOT EXISTS `medi_2020` DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;


DROP TABLE IF EXISTS `doctor`;
CREATE TABLE IF NOT EXISTS `doctor` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Vezeteknev` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `Keresztnev` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `SzakteruletId` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `SzakteruletId` (`SzakteruletId`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;


INSERT INTO `doctor` (`Id`, `Vezeteknev`, `Keresztnev`, `SzakteruletId`) VALUES
(1, 'Dr. Kiss', 'Péter', 3),
(2, 'Dr. Kovács', 'Béla', 1),
(3, 'Prof. dr. Erdész', 'Károly', 7),
(4, 'Dr. Széll', 'Miklós', 6),
(5, 'Dr. Juhász', 'Györgyi', 2),
(6, 'Dr. Kiss', 'László', 4),
(7, 'Dr. Horváthné Vári', 'Beáta', 5),
(8, 'Dr. Neumann', 'Richárd', 10),
(9, 'Prof. dr. Privóczki', 'Noémi', 9),
(10, 'Prof. dr. Rábik', 'Katalin', 8);


DROP TABLE IF EXISTS `patient`;
CREATE TABLE IF NOT EXISTS `patient` (
  `Taj` varchar(11) COLLATE utf8_hungarian_ci NOT NULL,
  `Jelszo` varchar(10) COLLATE utf8_hungarian_ci NOT NULL,
  `Vezeteknev` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `Keresztnev` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `Iranyitoszam` int(4) NOT NULL,
  `Telepules` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `Lakcim` varchar(75) COLLATE utf8_hungarian_ci NOT NULL,
  `Email` varchar(75) COLLATE utf8_hungarian_ci NOT NULL,
  `Telefon` varchar(11) COLLATE utf8_hungarian_ci NOT NULL,
  PRIMARY KEY (`Taj`),
  UNIQUE KEY `Email` (`Email`,`Telefon`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;


INSERT INTO `patient` (`Taj`, `Jelszo`, `Vezeteknev`, `Keresztnev`, `Iranyitoszam`, `Telepules`, `Lakcim`, `Email`, `Telefon`) VALUES
('000-112-344', 'pate3456', 'Hankovszky', 'Péter', 6722, 'Szeged', 'Kossuth Lajos sgt. 18.', 'peterhank@gmail.com', '06203219987'),
('110-987-444', 'jozs9999', 'Halmosi', 'József', 6726, 'Szeged', 'Fésű utca 56.', 'jozseHalm@freemail.hu', '06204449872'),
('123-456-789', 'Aron1982', 'Turcsányi', 'Áron', 6725, 'Szeged', 'Példa utca 45.', 'turcsanyi@gmail.com', '06202345783'),
('200-198-333', 'labd0198', 'Halász', 'Amarilla', 6710, 'Szeged', 'Szentmihályi út 51.', 'amarilla@yahoo.com', '06207891813'),
('221-009-788', 'feme1278', 'Hámos', 'Gábor', 6753, 'Szeged', 'Budai Nagy Antal u. 12.', 'hamosgabor@freemail.hu', '06208774443'),
('228-003-112', 'karet667', 'Balogh', 'Károly', 6791, 'Szeged', 'Szélmalom  utca 57.', 'kareszbalo@gmail.com', '06303255609'),
('312-899-379', 'fsaf7920', 'Prónai', 'András', 6727, 'Szeged', 'Ladvánszky József utca 40.', 'ladvannad@yahoo.com', '06306328465'),
('423-353-811', 'tamk4301', 'Maczelka', 'Judit', 6727, 'Szeged', 'Fekete János utca 21.', 'fektebal93@gmail.com', '06207803330'),
('427-383-390', 'jamr3920', 'Lukács', 'Tamás', 6771, 'Szeged', 'Szőregi út 131.', 'likacstam@freemail.hu', '06304959666'),
('432-881-920', 'harka784', 'Harkai', 'Gyula', 6725, 'Szeged', 'Hajnal utca 6.', 'gyulaharka@gmail.com', '06303342892'),
('438-211-064', 'tund8653', 'Mihaly', 'Péter', 6710, 'Szeged', 'Alsómyomás sor 5.', 'permil@citromail.hu', '06204869522'),
('438-571-597', 'koro6346', 'Koronkai', 'Ivett', 6791, 'Szeged', 'Barátság utca 22/8', 'baratsag@gmail.com', '06704719678'),
('455-122-344', 'gaze0199', 'Horváth', 'Géza', 6722, 'Szeged', 'Jósika utca 11.', 'gezahorvath@gmail.com', '06205559871'),
('462-855-211', 'sand7780', 'Kónya', 'Ágnes', 6721, 'Szeged', 'Öthalom utca 53.', 'othalom@gmail.com', '06704385721'),
('472-571-371', 'lakm2103', 'Rácz', 'Béláné', 6727, 'Szeged', 'Ortutay utca 47.', 'ortutaf@yahoo.com', '06306318347'),
('480-682-157', 'fafk7470', 'Módra', 'Ferenc', 6725, 'Szeged', 'Gőz utca 38.', 'fofgae923@gmail.com', '06306307779'),
('483-150-463', 'gerg8765', 'Gelencsér', 'Sándor', 6722, 'Szeged', 'Szentháromság utca 13.', 'sandorgelencser@yahoo.com', '06304062022'),
('488-201-486', 'mark8876', 'Magda', 'István', 6722, 'Szeged', 'Roosevelt tér 7-11', 'magdaist019@gmail.com', '06306652456'),
('499-443-217', 'magd6705', 'Gera', 'Ágnes', 6728, 'Szeged', 'Ladvánszky utca 7.', 'agnesgera@citromai.hu', '06208739544'),
('554-332-021', 'ajos9872', 'Ipacs', 'Béla', 6723, 'Szeged', 'Szilléri sor 6/A', 'belaipacs@citromail.hu', '06209012227'),
('556-887-002', 'lazo0018', 'Imrenyi', 'Tibor', 6791, 'Szeged', 'Negyvennyolcas utca 43.', 'tiborimrenyi@freemail.hu', '06309987663'),
('577-888-000', 'varm0129', 'Kormányos', 'Anasztázia', 6729, 'Szeged', 'Kapisztrán János utca 58.', 'kapiszt@citromai.hu', '06704616459'),
('599-600-999', 'masf1904', 'Madarász', 'Anita', 6757, 'Szeged', 'Gyálaréti út 81.', 'gyalaret81@gamil.com', '06208910002'),
('642-978-774', 'gyorg324', 'Geréb', 'Rajmund', 6720, 'Szeged', 'Dózsa utca14.', 'rajmgereb@gmail.hu', '06204430358'),
('658-017-313', 'papp4868', 'Papp', 'Csaba', 6724, 'Szeged', 'Gelei József utca 28.', 'feleiff20@gmail.com', '06304440512'),
('659-481-648', 'kors6571', 'Korsós', 'Eckhardt', 6723, 'Szeged', 'Hajlant utca 3/B', 'eckhardtkors@gmail.com', '06204950789'),
('670-950-154', 'szelk993', 'Mágori', 'József', 6753, 'Szeged', 'Budai Nagy Antal utca 101.', 'bidanta@gmail.com', '06304299432'),
('678-999-223', 'kisga568', 'Fekete-Kis', 'Gábor', 6722, 'Szeged', 'Cső utca 2/A', 'feketegab@gmail.com', '06803457891'),
('775-122-333', 'rich2330', 'Gellért', 'Vilmos', 6723, 'Szeged', 'Lugas utca 8.', 'vilmosgellert@freemail.hu', '06203789080'),
('777-324-129', 'jan011', 'Hargitai', 'János', 6728, 'Szeged', 'Felsőnyomás sor 2.', 'janoshargitai@gmail.com', '06209902377'),
('987-654-321', 'peter123', 'Horváth', 'Péter', 6725, 'Szeged', 'Gutenberg u. 67.', 'horvath.peter@freemail.hu', '06803451982');


DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nev` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `Egysegar` int(11) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;


INSERT INTO `service` (`Id`, `Nev`, `Egysegar`) VALUES
(1, 'konzultáció', 3000),
(2, 'kontroll', 5000),
(3, 'műtéti beavatkozás', 20000);


DROP TABLE IF EXISTS `specialization`;
CREATE TABLE IF NOT EXISTS `specialization` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nev` varchar(25) COLLATE utf8_hungarian_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;


INSERT INTO `specialization` (`Id`, `Nev`) VALUES
(1, 'urológus'),
(2, 'reumatológus'),
(3, 'bőrgyógyász'),
(4, 'gasztroenterológus'),
(5, 'gyermekgyógyászat'),
(6, 'tüdőgyógyász'),
(7, 'endokrinológus'),
(8, 'nőgyógyász'),
(9, 'pszichiáter'),
(10, 'fül-orr-gégész');


DROP TABLE IF EXISTS `visit`;
CREATE TABLE IF NOT EXISTS `visit` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Idopont` timestamp NOT NULL DEFAULT current_timestamp(),
  `BetegTaj` varchar(11) COLLATE utf8_hungarian_ci NOT NULL,
  `OrvosId` int(11) NOT NULL,
  `SzolgaltatasId` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `OrvosId` (`OrvosId`),
  KEY `SzolgaltatasId` (`SzolgaltatasId`),
  KEY `BetegTaj` (`BetegTaj`)
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;


INSERT INTO `visit` (`Id`, `Idopont`, `BetegTaj`, `OrvosId`, `SzolgaltatasId`) VALUES
(1, '2020-06-30 09:59:44', '123-456-789', 3, 1),
(2, '2020-07-14 10:54:54', '987-654-321', 7, 2),
(3, '2020-08-17 12:37:32', '110-987-444', 5, 2),
(4, '2020-08-17 13:02:17', '000-112-344', 4, 2),
(5, '2020-08-17 13:02:17', '123-456-789', 3, 3),
(6, '2020-08-17 13:19:52', '200-198-333', 7, 3),
(7, '2020-07-05 18:00:00', '200-198-333', 9, 2),
(8, '2020-08-10 18:00:00', '221-009-788', 8, 3),
(9, '2020-08-03 18:00:00', '228-003-112', 7, 2),
(10, '2020-08-05 18:00:00', '312-899-379', 8, 3),
(11, '2020-08-01 18:00:00', '423-353-811', 10, 2),
(12, '2020-08-08 18:00:00', '427-383-390', 2, 1),
(13, '2020-08-06 18:00:00', '432-881-920', 2, 1),
(14, '2020-08-09 18:00:00', '455-122-344', 9, 2),
(15, '2020-07-07 18:00:00', '472-571-371', 1, 2),
(16, '2020-07-12 18:00:00', '472-571-371', 4, 1),
(17, '2020-07-26 18:00:00', '480-682-157', 5, 3),
(18, '2020-07-09 18:00:00', '556-887-002', 9, 1),
(19, '2020-07-25 18:00:00', '987-654-321', 10, 3),
(20, '2020-07-28 18:00:00', '777-324-129', 3, 2),
(21, '2020-08-04 18:00:00', '678-999-223', 6, 2),
(22, '2020-08-08 18:00:00', '659-481-648', 8, 2),
(23, '2020-07-22 18:00:00', '488-201-486', 5, 3),
(24, '2020-07-27 18:00:00', '599-600-999', 6, 1),
(25, '2020-08-02 18:00:00', '438-571-597', 1, 3),
(26, '2020-08-05 18:00:00', '658-017-313', 7, 3),
(27, '2020-08-18 18:00:00', '499-443-217', 10, 2),
(28, '2020-08-06 18:00:00', '678-999-223', 3, 2),
(29, '2020-08-05 18:00:00', '678-999-223', 3, 3),
(30, '2020-07-19 18:00:00', '658-017-313', 5, 2),
(31, '2020-08-10 18:00:00', '488-201-486', 10, 1),
(32, '2020-07-08 18:00:00', '678-999-223', 2, 3),
(33, '2020-07-27 18:00:00', '670-950-154', 7, 1),
(34, '2020-07-25 18:00:00', '577-888-000', 10, 1),
(35, '2020-07-27 18:00:00', '987-654-321', 8, 2),
(36, '2020-12-20 19:44:17', '110-987-444', 7, 3),
(37, '2020-10-12 18:44:30', '200-198-333', 4, 3),
(38, '2020-10-27 19:45:30', '221-009-788', 2, 3);


ALTER TABLE `doctor`
  ADD CONSTRAINT `doctor_ibfk_1` FOREIGN KEY (`SzakteruletId`) REFERENCES `specialization` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION;


ALTER TABLE `visit`
  ADD CONSTRAINT `visit_ibfk_1` FOREIGN KEY (`OrvosId`) REFERENCES `doctor` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `visit_ibfk_2` FOREIGN KEY (`SzolgaltatasId`) REFERENCES `service` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `visit_ibfk_3` FOREIGN KEY (`BetegTaj`) REFERENCES `patient` (`Taj`) ON DELETE NO ACTION ON UPDATE NO ACTION;
