-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2022. Ápr 16. 21:39
-- Kiszolgáló verziója: 10.4.24-MariaDB
-- PHP verzió: 7.4.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `vms_lethaldevs`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `statistics`
--

CREATE TABLE `statistics` (
  `size` int(11) NOT NULL,
  `querycount` int(11) NOT NULL,
  `avgmileage` double NOT NULL,
  `carscount` int(11) NOT NULL,
  `usercount` int(11) NOT NULL,
  `biggestvehicles` text COLLATE utf8_hungarian_ci NOT NULL,
  `mostcarowner` text COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `password` varchar(255) COLLATE utf8_hungarian_ci NOT NULL,
  `name` varchar(255) COLLATE utf8_hungarian_ci NOT NULL,
  `admin` int(1) NOT NULL DEFAULT 0,
  `birthdate` datetime NOT NULL DEFAULT current_timestamp(),
  `address` varchar(120) COLLATE utf8_hungarian_ci NOT NULL,
  `regdate` datetime NOT NULL DEFAULT current_timestamp(),
  `lastvisit` datetime NOT NULL DEFAULT current_timestamp(),
  `phonenumber` varchar(255) COLLATE utf8_hungarian_ci NOT NULL,
  `email` varchar(255) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `vehicles`
--

CREATE TABLE `vehicles` (
  `vehid` int(11) NOT NULL,
  `owner` varchar(255) COLLATE utf8_hungarian_ci NOT NULL,
  `type` varchar(255) COLLATE utf8_hungarian_ci NOT NULL,
  `prodyear` int(11) NOT NULL,
  `vin` varchar(17) COLLATE utf8_hungarian_ci NOT NULL,
  `license` varchar(7) COLLATE utf8_hungarian_ci NOT NULL,
  `color` varchar(15) COLLATE utf8_hungarian_ci NOT NULL,
  `mileage` varchar(7) COLLATE utf8_hungarian_ci NOT NULL,
  `engine` varchar(255) COLLATE utf8_hungarian_ci NOT NULL,
  `ccm` int(5) NOT NULL,
  `fueltype` varchar(255) COLLATE utf8_hungarian_ci NOT NULL,
  `added` datetime NOT NULL DEFAULT current_timestamp(),
  `active` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `vehicles`
--
ALTER TABLE `vehicles`
  ADD PRIMARY KEY (`vehid`),
  ADD KEY `owner` (`owner`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT a táblához `vehicles`
--
ALTER TABLE `vehicles`
  MODIFY `vehid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
