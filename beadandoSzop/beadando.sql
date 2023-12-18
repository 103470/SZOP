-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2023. Dec 18. 18:59
-- Kiszolgáló verziója: 10.4.32-MariaDB
-- PHP verzió: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `beadando`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `cars`
--

CREATE TABLE `cars` (
  `id` int(11) NOT NULL,
  `marka` varchar(255) NOT NULL,
  `tipus` varchar(255) NOT NULL,
  `evjarat` int(11) NOT NULL,
  `kivitel` varchar(255) NOT NULL,
  `uzemanyag` varchar(255) NOT NULL,
  `ar` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `cars`
--

INSERT INTO `cars` (`id`, `marka`, `tipus`, `evjarat`, `kivitel`, `uzemanyag`, `ar`) VALUES
(1, 'BMW', '320i', 2000, 'coupe', 'benzin', 1800000),
(2, 'audi', 'a6', 2014, 'sedan', 'dízel', 6500000),
(4, 'asd', 'asd', 1, 'asd', 'asd', 1),
(5, 'asd5', 'asd5', 5, 'asd5', 'asd5', 5),
(6, 'asd5', 'asd5', 5, 'asd5', 'asd5', 5),
(7, 'asd', 'asd', 6, 'asd', 'asd', 6);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `name` varchar(255) NOT NULL,
  `isAdmin` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `users`
--

INSERT INTO `users` (`id`, `username`, `password`, `name`, `isAdmin`) VALUES
(3, 'admin', 'admin', 'admin', 1),
(4, '', '', '', 0),
(6, 'admin4', 'fc1ebc848e31e0a68e868432225e3c82', 'admin4', 1),
(7, 'admin3', '32cacb2f994f6b42183a1300d9a3e8d6', 'admin3', 1),
(8, 'admin1', 'admin1', 'admin1', 0),
(9, 'admin2', 'c84258e9c39059a89ab77d846ddab909', 'admin2', 0),
(10, 'admin5', 'admin5', 'admin5', 0),
(11, '', '', '', 0),
(12, 'asd4', '52fe8f312eec568cac3e32e0a2813743', 'asd4', 0);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `cars`
--
ALTER TABLE `cars`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `cars`
--
ALTER TABLE `cars`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT a táblához `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
