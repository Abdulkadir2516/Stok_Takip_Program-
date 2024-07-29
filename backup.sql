-- MySqlBackup.NET 2.3.7.0
-- Dump Time: 2024-04-11 13:08:19
-- --------------------------------------
-- Server version 8.0.31 MySQL Community Server - GPL


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of anlık_satıs
-- 

DROP TABLE IF EXISTS `anlık_satıs`;
CREATE TABLE IF NOT EXISTS `anlık_satıs` (
  `ıd` varchar(50) DEFAULT NULL,
  `Tarih` date DEFAULT NULL,
  `Saat` time DEFAULT NULL,
  `Barkod` varchar(45) DEFAULT NULL,
  `Ürün_adı` varchar(450) DEFAULT NULL,
  `Adet` int DEFAULT NULL,
  `Birim` varchar(7) DEFAULT NULL,
  `Alis_Fiyat` float DEFAULT NULL,
  `Satis_Fiyati` float DEFAULT NULL,
  `Tutar` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table anlık_satıs
-- 

/*!40000 ALTER TABLE `anlık_satıs` DISABLE KEYS */;

/*!40000 ALTER TABLE `anlık_satıs` ENABLE KEYS */;

-- 
-- Definition of butun_satıslar
-- 

DROP TABLE IF EXISTS `butun_satıslar`;
CREATE TABLE IF NOT EXISTS `butun_satıslar` (
  `Tarih` date NOT NULL,
  `Saat` time NOT NULL,
  `Barkod_No` varchar(20) COLLATE utf8mb4_general_ci NOT NULL,
  `Ürün_Adı` varchar(500) COLLATE utf8mb4_general_ci NOT NULL,
  `Adedi` int NOT NULL,
  `Birimi` varchar(6) COLLATE utf8mb4_general_ci NOT NULL,
  `Alıs_Fiyatı` varchar(8) COLLATE utf8mb4_general_ci NOT NULL,
  `Satıs_Fiyatı` varchar(8) COLLATE utf8mb4_general_ci NOT NULL,
  `Tutarı` varchar(8) COLLATE utf8mb4_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- 
-- Dumping data for table butun_satıslar
-- 

/*!40000 ALTER TABLE `butun_satıslar` DISABLE KEYS */;
/*!40000 ALTER TABLE `butun_satıslar` ENABLE KEYS */;

-- 
-- Definition of gruplar
-- 

DROP TABLE IF EXISTS `gruplar`;
CREATE TABLE IF NOT EXISTS `gruplar` (
  `Grup_Adı` varchar(30) COLLATE utf8mb4_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- 
-- Dumping data for table gruplar
-- 

/*!40000 ALTER TABLE `gruplar` DISABLE KEYS */;
INSERT INTO `gruplar`(`Grup_Adı`) VALUES('DİĞER'),('CAM'),('OYUNCAK'),('PLASTİK'),('EV ALETLERİ'),('TEMİZLİK'),('ÇELİK'),('NALBUR'),('KIRTASİYE'),('DA');
/*!40000 ALTER TABLE `gruplar` ENABLE KEYS */;

-- 
-- Definition of gunluk_satıs
-- 

DROP TABLE IF EXISTS `gunluk_satıs`;
CREATE TABLE IF NOT EXISTS `gunluk_satıs` (
  `Tarih` date NOT NULL,
  `Saat` time NOT NULL,
  `Barkod_No` varchar(20) COLLATE utf8mb4_general_ci NOT NULL,
  `Ürün_Adı` varchar(500) COLLATE utf8mb4_general_ci NOT NULL,
  `Adedi` int NOT NULL,
  `Birimi` varchar(6) COLLATE utf8mb4_general_ci NOT NULL,
  `Alıs_Fiyatı` varchar(8) COLLATE utf8mb4_general_ci NOT NULL,
  `Satıs_Fiyatı` varchar(8) COLLATE utf8mb4_general_ci NOT NULL,
  `Tutarı` varchar(8) COLLATE utf8mb4_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- 
-- Dumping data for table gunluk_satıs
-- 

/*!40000 ALTER TABLE `gunluk_satıs` DISABLE KEYS */;
INSERT INTO `gunluk_satıs`(`Tarih`,`Saat`,`Barkod_No`,`Ürün_Adı`,`Adedi`,`Birimi`,`Alıs_Fiyatı`,`Satıs_Fiyatı`,`Tutarı`) VALUES('2024-04-11','08:14:10','ÇALIS','SAPLI ÇALI SÜPÜR',1,'AD','56','150','150'),('2024-04-11','09:03:12','8697745620017','SELTOP TOPRAK 3 ',1,'AD','12.5','20','20'),('2024-04-11','09:33:50','8697416170506','SARAÇ TORBA 50',1,'AD','17.5','35','35'),('2024-04-11','10:16:12','6917863743323','VOLEYBOL TOPU 29',1,'AD','65','105','105'),('2024-04-11','10:16:19','4036730768619','TOP FUTBOL',1,'AD','50','85','85'),('2024-04-11','10:16:24','TOP','PLASTİK TOP',2,'AD','10','20','40'),('2024-04-11','10:21:20','TOP','PLASTİK TOP',8,'AD','10','20','160'),('2024-04-11','10:25:01','POŞET','POŞET',1,'AD','45','58','58'),('2024-04-11','10:32:20','8699721111007','YARA BAND CANSİNBAT',1,'AD','2.5','5','5'),('2024-04-11','10:32:20','8699721111007','YARA BAND CANSİNBAT',1,'AD','2.5','5','5'),('2024-04-11','10:52:47','4036730768619','TOP FUTBOL',1,'AD','50','85','85'),('2024-04-11','11:17:47','8697425881745','GIR GIR',1,'AD','7.5','20','20'),('2024-04-11','11:17:50','8681873050013','ÇAKMAK TAŞLI',1,'AD','6','10','10'),('2024-04-11','11:32:21','8693867000553','ÇAY SÜZGEÇ PASLANMAZ',1,'AD','10.4','18','18'),('2024-04-11','11:53:23','8682109045476','ODA FARFUM',1,'AD','30','50','50'),('2024-04-11','12:26:13','TOP','PLASTİK TOP',1,'AD','10','20','20'),('2024-04-11','12:27:24','2000CC','KAVANOZ 2 LT',1,'AD','26.2','45','45'),('2024-04-11','12:48:36','8699421201183','SEDEF LÜKS DESENLİ KLOZET FIRÇA SETİ',1,'AD','38.85','65','65'),('2024-04-11','12:52:47','ÇALIS','SAPLI ÇALI SÜPÜR',19,'AD','56','100','1900'),('2024-04-11','12:58:13','8680534200613','JEL 450 GR',1,'AD','15','25','25');
/*!40000 ALTER TABLE `gunluk_satıs` ENABLE KEYS */;

-- 
-- Definition of mfw_gold_stoklar
-- 

DROP TABLE IF EXISTS `mfw_gold_stoklar`;
CREATE TABLE IF NOT EXISTS `mfw_gold_stoklar` (
  `barkod_no` varchar(16) DEFAULT NULL,
  `Ürün_Adı` varchar(500) DEFAULT NULL,
  `Ürün_Cinsi` varchar(15) DEFAULT NULL,
  `Toptancısı` varchar(26) DEFAULT NULL,
  `Alıs_Fiyatı` varchar(7) DEFAULT NULL,
  `Satıs_Fiyatı` varchar(7) DEFAULT NULL,
  `İsk_Satıs_Fiyatı` varchar(7) DEFAULT NULL,
  `Stok_Miktarı` int DEFAULT NULL,
  `Birimi` varchar(3) DEFAULT NULL,
  `Alt_Limiti` int DEFAULT NULL,
  `Tarih` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- 
-- Dumping data for table mfw_gold_stoklar
-- 

/*!40000 ALTER TABLE `mfw_gold_stoklar` DISABLE KEYS */;
/*!40000 ALTER TABLE `mfw_gold_stoklar` ENABLE KEYS */;

-- 
-- Definition of toptancı
-- 

DROP TABLE IF EXISTS `toptancı`;
CREATE TABLE IF NOT EXISTS `toptancı` (
  `Toptancı_Adı` varchar(30) COLLATE utf8mb4_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- 
-- Dumping data for table toptancı
-- 

/*!40000 ALTER TABLE `toptancı` DISABLE KEYS */;
INSERT INTO `toptancı`(`Toptancı_Adı`) VALUES('DİĞER'),('DOĞUŞ'),('PAŞABAHÇE'),('GÜRSES'),('ŞENBAŞ'),('KENT OYUNCAK'),('BAŞOL'),('MARMARA ZÜCCACİYE'),('ASA'),('CEYLAN'),('YKM'),('CAN ANBALAJ'),('DEVREN PLASTİK'),('ÇINARCIK ANBALAJ'),('OLGUNLAR'),('İMAMOĞLU'),('SELTOP'),('EFE '),('SEZER'),('ILICA'),('SAYGINLAR'),('CAN CAN '),('SERKAP'),('YENİ YILMAZLAR'),('BARIŞ'),('BEYAZ MENFUŞAT'),('ŞENGÜL');
/*!40000 ALTER TABLE `toptancı` ENABLE KEYS */;

-- 
-- Definition of yönetici
-- 

DROP TABLE IF EXISTS `yönetici`;
CREATE TABLE IF NOT EXISTS `yönetici` (
  `kullanıcı_ıd` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `sifre` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`kullanıcı_ıd`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- 
-- Dumping data for table yönetici
-- 

/*!40000 ALTER TABLE `yönetici` DISABLE KEYS */;
INSERT INTO `yönetici`(`kullanıcı_ıd`,`sifre`) VALUES('1','1');
/*!40000 ALTER TABLE `yönetici` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2024-04-11 13:08:19
-- Total time: 0:0:0:0:574 (d:h:m:s:ms)