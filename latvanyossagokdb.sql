-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Dec 05. 16:05
-- Kiszolgáló verziója: 10.4.11-MariaDB
-- PHP verzió: 7.4.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `latvanyossagokdb`
--
create table latvanyossagokdb;
use latvanyossagokdb;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `latvanyossagok`
--

CREATE TABLE `latvanyossagok` (
  `id` int(11) NOT NULL,
  `nev` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `leiras` varchar(100) COLLATE utf8_hungarian_ci NOT NULL,
  `ar` int(11) DEFAULT 0,
  `varos_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `latvanyossagok`
--

INSERT INTO `latvanyossagok` (`id`, `nev`, `leiras`, `ar`, `varos_id`) VALUES
(1, 'Szabadság szobor', 'Szabadság szobor a Gellért hegynél', 0, 1),
(2, 'Parlament', 'Magyar parlament', 100000, 1),
(3, 'Brooklyn Bridge', 'Brooklyn híd', 0, 3),
(4, 'Statue of Liberty', 'Szabadság szobor', 3000, 3),
(5, 'Ferrari World', 'Vidámpark', 15000, 4),
(7, 'Central Park', 'park', 0, 3),
(8, 'Stonehenge', 'Stonehenge', 0, 6);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `varosok`
--

CREATE TABLE `varosok` (
  `id` int(11) NOT NULL,
  `nev` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `lakossag` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `varosok`
--

INSERT INTO `varosok` (`id`, `nev`, `lakossag`) VALUES
(1, 'Budapest', 1752000),
(3, 'New York', 8400000),
(4, 'Abu-Dzabi', 1450000),
(5, 'Tokió', 9273000),
(6, 'Wiltshire', 720000);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `latvanyossagok`
--
ALTER TABLE `latvanyossagok`
  ADD PRIMARY KEY (`id`),
  ADD KEY `varos_id` (`varos_id`);

--
-- A tábla indexei `varosok`
--
ALTER TABLE `varosok`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nev` (`nev`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `latvanyossagok`
--
ALTER TABLE `latvanyossagok`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT a táblához `varosok`
--
ALTER TABLE `varosok`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `latvanyossagok`
--
ALTER TABLE `latvanyossagok`
  ADD CONSTRAINT `latvanyossagok_ibfk_1` FOREIGN KEY (`varos_id`) REFERENCES `varosok` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
