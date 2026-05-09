-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 07, 2026 at 02:53 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_toko_parfum`
--

-- --------------------------------------------------------

--
-- Table structure for table `parfum`
--

CREATE TABLE `parfum` (
  `id` int(11) NOT NULL,
  `nama_parfum` varchar(255) NOT NULL,
  `merk` varchar(255) NOT NULL,
  `harga` decimal(15,2) NOT NULL DEFAULT 0.00,
  `stok` int(11) NOT NULL DEFAULT 0,
  `notes` text DEFAULT NULL,
  `gambar_path` varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `parfum`
--

INSERT INTO `parfum` (`id`, `nama_parfum`, `merk`, `harga`, `stok`, `notes`, `gambar_path`) VALUES
(1, 'Mantag', 'cont.', 2000.00, 5, '[TOP]Cherry, Lemongrass[/TOP][HEART]Oud[/HEART][BASE]Woody[/BASE][CONC]Eau de Parfum[/CONC]', 'C:\\Users\\acer\\Documents\\gojekERD-Halaman-2.drawio.png'),
(2, 'asd', 'aff', 900000.00, 3, '[TOP]asd[/TOP][HEART]asf[/HEART][BASE]f[/BASE][CONC]Eau de Parfum[/CONC]', 'C:\\Users\\acer\\Documents\\gojekERD-Halaman-2.drawio.png');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `parfum`
--
ALTER TABLE `parfum`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `parfum`
--
ALTER TABLE `parfum`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
