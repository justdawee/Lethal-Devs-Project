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
  `birthdate` date NOT NULL DEFAULT current_timestamp(),
  `address` varchar(120) COLLATE utf8_hungarian_ci NOT NULL,
  `regdate` datetime NOT NULL DEFAULT current_timestamp(),
  `lastvisit` datetime NOT NULL DEFAULT current_timestamp(),
  `phonenumber` varchar(255) COLLATE utf8_hungarian_ci NOT NULL,
  `email` varchar(255) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `users`
--

INSERT INTO `users` (`id`, `username`, `password`, `name`, `admin`, `birthdate`, `address`, `regdate`, `lastvisit`, `phonenumber`, `email`) VALUES
(1, 'JustDawee', 'jYIhvJFerKbES2+S9uloBQ==', 'Lukács Dávid', 1, '1999-06-03', '2344 Dömsöd, Bajcsy-Zsilinszky utca 14.', '2022-04-10 12:10:58', '2022-04-16 20:59:19', '06205961664', 'justdawee@gmail.com'),
(9, 'MintaJanos', 'hzv735jRwZ5e/duHgl9wIg==', 'Minta János', 0, '2022-04-16', '1234 Budapest, Minta utca 12.', '2022-04-16 19:33:50', '2022-04-16 19:33:50', '06701234567', 'minta@gmail.com'),
(10, 'MintaIstvan', 'hzv735jRwZ5e/duHgl9wIg==', 'MintaIstvan', 0, '2022-04-16', '1234 Budapest, Minta utca 12.', '2022-04-16 19:34:06', '2022-04-16 19:34:06', '06701234567', 'minta@gmail.com'),
(11, 'MintaFerenc', 'hzv735jRwZ5e/duHgl9wIg==', 'MintaFerenc', 0, '2022-04-16', '1234 Budapest, Minta utca 12.', '2022-04-16 19:34:18', '2022-04-16 19:34:18', '06701234567', 'minta@gmail.com');

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
-- A tábla adatainak kiíratása `vehicles`
--

INSERT INTO `vehicles` (`vehid`, `owner`, `type`, `prodyear`, `vin`, `license`, `color`, `mileage`, `engine`, `ccm`, `fueltype`, `added`, `active`) VALUES
(6, 'Lukács Dávid ', 'Audi A6', 2006, 'WVWXK73C78EXXXXXX', 'KRL264', 'Kék', '347987', 'I4', 1987, 'Dízel', '2022-04-14 23:06:34', 1),
(9, 'Lukács Dávid ', 'Volkswagen Passat', 2016, 'WVWBA7AJXCWXXXXXX', 'ABC123', 'Fehér', '12532', 'I4', 1989, 'Dízel', '2022-04-15 10:55:26', 1),
(10, 'Lukács Dávid', 'Nissan GT-R', 2008, 'WVWBA7AJXCWXXXXXX', 'ABC123', 'Fekete', '87622', 'V6', 2967, 'Benzin', '2022-04-15 10:57:48', 1),
(14, 'Lukács Dávid ', 'Seat Corrado', 1996, 'WVWBA7AJXCWXXXXXX', 'ABC123', 'Sárga', '567899', 'I4', 1987, 'Dízel', '2022-04-15 13:27:43', 1);

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
