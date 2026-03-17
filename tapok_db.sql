-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Хост: localhost
-- Время создания: Мар 16 2026 г., 11:51
-- Версия сервера: 5.7.24
-- Версия PHP: 7.1.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `tapok_db`
--

-- --------------------------------------------------------

--
-- Структура таблицы `kategorii_tovara`
--

CREATE TABLE `kategorii_tovara` (
  `id` int(11) NOT NULL,
  `nazvanie` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `kategorii_tovara`
--

INSERT INTO `kategorii_tovara` (`id`, `nazvanie`) VALUES
(1, 'Женская обувь'),
(2, 'Мужская обувь');

-- --------------------------------------------------------

--
-- Структура таблицы `polzovateli`
--

CREATE TABLE `polzovateli` (
  `id` int(11) NOT NULL,
  `rol_id` int(11) DEFAULT NULL,
  `fio` varchar(150) NOT NULL,
  `login` varchar(100) NOT NULL,
  `parol` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `polzovateli`
--

INSERT INTO `polzovateli` (`id`, `rol_id`, `fio`, `login`, `parol`) VALUES
(1, 1, 'Никифорова Весения Николаевна', '94d5ous@gmail.com', 'uzWC67'),
(2, 1, 'Сазонов Руслан Германович', 'uth4iz@mail.com', '2L6KZG'),
(3, 1, 'Одинцов Серафим Артёмович', 'yzls62@outlook.com', 'JlFRCZ'),
(4, 2, 'Степанов Михаил Артёмович', '1diph5e@tutanota.com', '8ntwUp'),
(5, 2, 'Ворсин Петр Евгеньевич', 'tjde7c@yahoo.com', 'YOyhfR'),
(6, 2, 'Старикова Елена Павловна', 'wpmrc3do@tutanota.com', 'RSbvHv'),
(7, 3, 'Михайлюк Анна Вячеславовна', '5d4zbu@tutanota.com', 'rwVDh9'),
(8, 3, 'Ситдикова Елена Анатольевна', 'ptec8ym@yahoo.com', 'LdNyos'),
(9, 3, 'Ворсин Петр Евгеньевич', '1qz4kw@mail.com', 'gynQMT'),
(10, 3, 'Старикова Елена Павловна', '4np6se@mail.com', 'AtnDjr'),
(11, 1, 'abc', 'abc', '123');

-- --------------------------------------------------------

--
-- Структура таблицы `postavshchiki`
--

CREATE TABLE `postavshchiki` (
  `id` int(11) NOT NULL,
  `nazvanie` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `postavshchiki`
--

INSERT INTO `postavshchiki` (`id`, `nazvanie`) VALUES
(1, 'Kari'),
(2, 'Обувь для вас');

-- --------------------------------------------------------

--
-- Структура таблицы `proizvoditeli`
--

CREATE TABLE `proizvoditeli` (
  `id` int(11) NOT NULL,
  `nazvanie` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `proizvoditeli`
--

INSERT INTO `proizvoditeli` (`id`, `nazvanie`) VALUES
(5, 'Alessio Nesca'),
(6, 'CROSBY'),
(1, 'Kari'),
(2, 'Marco Tozzi'),
(4, 'Rieker'),
(3, 'Рос');

-- --------------------------------------------------------

--
-- Структура таблицы `punkty_vydachi`
--

CREATE TABLE `punkty_vydachi` (
  `id` int(11) NOT NULL,
  `adres` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `punkty_vydachi`
--

INSERT INTO `punkty_vydachi` (`id`, `adres`) VALUES
(2, '125061, г. Лесной, ул. Подгорная, 8'),
(29, '125703, г. Лесной, ул. Партизанская, 49'),
(28, '125837, г. Лесной, ул. Шоссейная, 40'),
(36, '190949, г. Лесной, ул. Мичурина, 26'),
(24, '344288, г. Лесной, ул. Чехова, 1'),
(16, '394060, г.Лесной, ул. Фрунзе, 43'),
(26, '394242, г. Лесной, ул. Коммунистическая, 43'),
(21, '394782, г. Лесной, ул. Чехова, 3'),
(4, '400562, г. Лесной, ул. Зеленая, 32'),
(11, '410172, г. Лесной, ул. Северная, 13'),
(6, '410542, г. Лесной, ул. Светлая, 46'),
(17, '410661, г. Лесной, ул. Школьная, 50'),
(1, '420151, г. Лесной, ул. Вишневая, 32'),
(32, '426030, г. Лесной, ул. Маяковского, 44'),
(8, '443890, г. Лесной, ул. Коммунистическая, 1'),
(33, '450375, г. Лесной ул. Клубная, 44'),
(23, '450558, г. Лесной, ул. Набережная, 30'),
(20, '450983, г.Лесной, ул. Комсомольская, 26'),
(13, '454311, г.Лесной, ул. Новая, 19'),
(22, '603002, г. Лесной, ул. Дзержинского, 28'),
(15, '603036, г. Лесной, ул. Садовая, 4'),
(9, '603379, г. Лесной, ул. Спортивная, 46'),
(10, '603721, г. Лесной, ул. Гоголя, 41'),
(25, '614164, г.Лесной, ул. Степная, 30'),
(5, '614510, г. Лесной, ул. Маяковского, 47'),
(12, '614611, г. Лесной, ул. Молодежная, 50'),
(31, '614753, г. Лесной, ул. Полевая, 35'),
(7, '620839, г. Лесной, ул. Цветочная, 8'),
(30, '625283, г. Лесной, ул. Победы, 46'),
(34, '625560, г. Лесной, ул. Некрасова, 12'),
(18, '625590, г. Лесной, ул. Коммунистическая, 20'),
(19, '625683, г. Лесной, ул. 8 Марта'),
(35, '630201, г. Лесной, ул. Комсомольская, 17'),
(3, '630370, г. Лесной, ул. Шоссейная, 24'),
(14, '660007, г.Лесной, ул. Октябрьская, 19'),
(27, '660540, г. Лесной, ул. Солнечная, 25');

-- --------------------------------------------------------

--
-- Структура таблицы `roli_sotrudnikov`
--

CREATE TABLE `roli_sotrudnikov` (
  `id` int(11) NOT NULL,
  `nazvanie` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `roli_sotrudnikov`
--

INSERT INTO `roli_sotrudnikov` (`id`, `nazvanie`) VALUES
(3, 'Авторизированный клиент'),
(1, 'Администратор'),
(2, 'Менеджер');

-- --------------------------------------------------------

--
-- Структура таблицы `sostav_zakaza`
--

CREATE TABLE `sostav_zakaza` (
  `id` int(11) NOT NULL,
  `nomer_zakaza` int(11) DEFAULT NULL,
  `artikul_tovara` varchar(10) DEFAULT NULL,
  `kolichestvo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `sostav_zakaza`
--

INSERT INTO `sostav_zakaza` (`id`, `nomer_zakaza`, `artikul_tovara`, `kolichestvo`) VALUES
(21, 1, 'А112Т4', 2),
(22, 1, 'F635R4', 2),
(23, 2, 'H782T5', 1),
(24, 2, 'G783F5', 1),
(25, 3, 'J384T6', 10),
(26, 3, 'D572U8', 10),
(28, 4, 'D329H3', 4),
(29, 5, 'А112Т4', 2),
(30, 5, 'F635R4', 2),
(31, 6, 'H782T5', 1),
(32, 6, 'G783F5', 1),
(33, 7, 'J384T6', 10),
(34, 7, 'D572U8', 10),
(36, 8, 'D329H3', 4),
(38, 9, 'G432E4', 1),
(39, 10, 'S213E3', 5),
(40, 10, 'E482R4', 5);

-- --------------------------------------------------------

--
-- Структура таблицы `tovary`
--

CREATE TABLE `tovary` (
  `artikul` varchar(10) NOT NULL,
  `naimenovanie` varchar(100) NOT NULL,
  `edinica_izmereniya` varchar(10) DEFAULT 'шт.',
  `cena` decimal(10,2) NOT NULL,
  `postavshchik_id` int(11) DEFAULT NULL,
  `proizvoditel_id` int(11) DEFAULT NULL,
  `kategoriya_id` int(11) DEFAULT NULL,
  `deystvuyushchaya_skidka` decimal(5,2) DEFAULT '0.00',
  `kolichestvo_na_sklade` int(11) DEFAULT '0',
  `opisanie_tovara` text,
  `foto` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `tovary`
--

INSERT INTO `tovary` (`artikul`, `naimenovanie`, `edinica_izmereniya`, `cena`, `postavshchik_id`, `proizvoditel_id`, `kategoriya_id`, `deystvuyushchaya_skidka`, `kolichestvo_na_sklade`, `opisanie_tovara`, `foto`) VALUES
('1', 'foo', 'шт.', '99999.00', 2, 2, 1, '1.00', 1, 'mega fluffy', '5.jpg'),
('B431R5', 'Ботинки', 'шт.', '2700.00', 2, 4, 1, '2.00', 5, 'Мужские кожаные ботинки/мужские ботинки', '3.jpg'),
('C436G5', 'Ботинки', 'шт.', '10200.00', 1, 5, 1, '15.00', 9, 'Ботинки женские, ARGO, размер 40', 'picture.png'),
('D268G5', 'Туфли', 'шт.', '4399.00', 2, 4, 1, '3.00', 12, 'Туфли Rieker женские демисезонные, размер 36, цвет коричневый', 'picture.png'),
('D329H3', 'Полуботинки', 'шт.', '1890.00', 2, 5, 1, '4.00', 4, 'Полуботинки Alessio Nesca женские 3-30797-47, размер 37, цвет: бордовый', '8.jpg'),
('D364R4', 'Туфли', 'шт.', '12400.00', 1, 1, 1, '16.00', 5, 'Туфли Luiza Belly женские Kate-lazo черные из натуральной замши', 'picture.png'),
('D572U8', 'Кроссовки', 'шт.', '4100.00', 2, 3, 2, '3.00', 6, '129615-4 Кроссовки мужские', '6.jpg'),
('DFIGUP', 'Красный макасин', 'шт.', '69000.00', 1, 1, 2, '3.00', 3, 'Правильно мокасин', 'makasin_verstapen.jpg'),
('E482R4', 'Полуботинки', 'шт.', '1800.00', 1, 1, 1, '2.00', 14, 'Полуботинки kari женские MYZ20S-149, размер 41, цвет: черный', 'picture.png'),
('F427R5', 'Ботинки', 'шт.', '11800.00', 2, 4, 1, '15.00', 11, 'Ботинки на молнии с декоративной пряжкой FRAU', 'picture.png'),
('F635R4', 'Ботинки', 'шт.', '3244.00', 2, 2, 1, '2.00', 13, 'Ботинки Marco Tozzi женские демисезонные, размер 39, цвет бежевый', '2.jpg'),
('FASKJGY', 'erty', 'шт.', '234.00', 1, 3, 2, '3.00', 12, 'erht', '1.jpg'),
('G432E4', 'Туфли', 'шт.', '2800.00', 1, 1, 1, '3.00', 15, 'Туфли kari женские TR-YR-413017, размер 37, цвет: черный', '10.jpg'),
('G531F4', 'Ботинки', 'шт.', '6600.00', 1, 1, 1, '12.00', 9, 'Ботинки женские зимние ROMER арт. 893167-01 Черный', 'picture.png'),
('G783F5', 'Ботинки', 'шт.', '5900.00', 1, 3, 2, '2.00', 8, 'Мужские ботинки Рос-Обувь кожаные с натуральным мехом', '4.jpg'),
('H535R5', 'Ботинки', 'шт.', '2300.00', 2, 4, 1, '2.00', 7, 'Женские Ботинки демисезонные', 'picture.png'),
('H782T5', 'Туфли', 'шт.', '4499.00', 1, 1, 2, '4.00', 5, 'Туфли kari мужские классика MYZ21AW-450A, размер 43, цвет: черный', '3.jpg'),
('J384T6', 'Ботинки', 'шт.', '3800.00', 2, 4, 2, '2.00', 16, 'B3430/14 Полуботинки мужские Rieker', '5.jpg'),
('J542F5', 'Тапочки', 'шт.', '500.00', 1, 1, 2, '13.00', 0, 'Тапочки мужские Арт.70701-55-67син р.41', 'picture.png'),
('K345R4', 'Полуботинки', 'шт.', '2100.00', 2, 6, 2, '2.00', 3, '407700/01-02 Полуботинки мужские CROSBY', 'picture.png'),
('K358H6', 'Тапочки', 'шт.', '599.00', 1, 4, 2, '20.00', 2, 'Тапочки мужские син р.41', 'picture.png'),
('L754R4', 'Полуботинки', 'шт.', '1700.00', 1, 1, 1, '2.00', 7, 'Полуботинки kari женские WB2020SS-26, размер 38, цвет: черный', 'picture.png'),
('M542T5', 'Кроссовки', 'шт.', '2800.00', 2, 4, 2, '18.00', 3, 'Кроссовки мужские TOFA', 'picture.png'),
('N457T5', 'Полуботинки', 'шт.', '4600.00', 1, 6, 1, '3.00', 13, 'Полуботинки Ботинки черные зимние, мех', 'picture.png'),
('O754F4', 'Туфли', 'шт.', '5400.00', 2, 4, 1, '4.00', 18, 'Туфли женские демисезонные Rieker артикул 55073-68/37', 'picture.png'),
('P764G4', 'Туфли', 'шт.', '6800.00', 1, 6, 1, '15.00', 15, 'Туфли женские, ARGO, размер 38', 'picture.png'),
('S213E3', 'Полуботинки', 'шт.', '2156.00', 2, 6, 2, '3.00', 6, '407700/01-01 Полуботинки мужские CROSBY', 'picture.png'),
('S326R5', 'Тапочки', 'шт.', '9900.00', 2, 6, 2, '17.00', 15, 'Мужские кожаные тапочки \"Профиль С.Дали\"', 'picture.png'),
('S634B5', 'Кеды', 'шт.', '5500.00', 2, 6, 2, '3.00', 0, 'Кеды Caprice мужские демисезонные, размер 42, цвет черный', 'picture.png'),
('T324F5', 'Сапоги', 'шт.', '4699.00', 1, 6, 1, '2.00', 5, 'Сапоги замша Цвет: синий', 'picture.png'),
('А112Т4', 'Ботинки', 'шт.', '4990.00', 1, 1, 1, '3.00', 6, 'Женские Ботинки демисезонные kari', '1.jpg');

-- --------------------------------------------------------

--
-- Структура таблицы `zakazy`
--

CREATE TABLE `zakazy` (
  `nomer_zakaza` int(11) NOT NULL,
  `data_zakaza` date NOT NULL,
  `data_dostavki` date DEFAULT NULL,
  `adres_punkta_vydachi_id` int(11) DEFAULT NULL,
  `fio_klienta_id` int(11) DEFAULT NULL,
  `kod_polucheniya` varchar(10) DEFAULT NULL,
  `status_zakaza` varchar(50) DEFAULT 'Новый'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `zakazy`
--

INSERT INTO `zakazy` (`nomer_zakaza`, `data_zakaza`, `data_dostavki`, `adres_punkta_vydachi_id`, `fio_klienta_id`, `kod_polucheniya`, `status_zakaza`) VALUES
(1, '2025-02-27', '2025-04-20', 1, 4, '901', 'Завершен'),
(2, '2022-09-28', '2025-04-21', 11, 1, '902', 'Завершен'),
(3, '2025-03-21', '2025-04-22', 2, 2, '903', 'Завершен'),
(4, '2025-02-20', '2025-04-23', 11, 3, '904', 'Завершен'),
(5, '2025-03-17', '2025-04-24', 2, 4, '905', 'Завершен'),
(6, '2025-03-01', '2025-04-25', 15, 1, '906', 'Завершен'),
(7, '2025-02-28', '2025-04-26', 3, 2, '907', 'Завершен'),
(8, '2025-03-31', '2025-04-27', 19, 3, '908', 'Новый'),
(9, '2025-04-02', '2025-04-28', 5, 4, '909', 'Новый'),
(10, '2025-04-03', '2025-04-29', 19, 4, '910', 'Новый');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `kategorii_tovara`
--
ALTER TABLE `kategorii_tovara`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nazvanie` (`nazvanie`);

--
-- Индексы таблицы `polzovateli`
--
ALTER TABLE `polzovateli`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `login` (`login`),
  ADD KEY `rol_id` (`rol_id`);

--
-- Индексы таблицы `postavshchiki`
--
ALTER TABLE `postavshchiki`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nazvanie` (`nazvanie`);

--
-- Индексы таблицы `proizvoditeli`
--
ALTER TABLE `proizvoditeli`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nazvanie` (`nazvanie`);

--
-- Индексы таблицы `punkty_vydachi`
--
ALTER TABLE `punkty_vydachi`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `adres` (`adres`);

--
-- Индексы таблицы `roli_sotrudnikov`
--
ALTER TABLE `roli_sotrudnikov`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nazvanie` (`nazvanie`);

--
-- Индексы таблицы `sostav_zakaza`
--
ALTER TABLE `sostav_zakaza`
  ADD PRIMARY KEY (`id`),
  ADD KEY `nomer_zakaza` (`nomer_zakaza`),
  ADD KEY `sostav_zakaza_ibfk_2` (`artikul_tovara`);

--
-- Индексы таблицы `tovary`
--
ALTER TABLE `tovary`
  ADD PRIMARY KEY (`artikul`),
  ADD KEY `postavshchik_id` (`postavshchik_id`),
  ADD KEY `proizvoditel_id` (`proizvoditel_id`),
  ADD KEY `kategoriya_id` (`kategoriya_id`);

--
-- Индексы таблицы `zakazy`
--
ALTER TABLE `zakazy`
  ADD PRIMARY KEY (`nomer_zakaza`),
  ADD KEY `adres_punkta_vydachi_id` (`adres_punkta_vydachi_id`),
  ADD KEY `fio_klienta_id` (`fio_klienta_id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `kategorii_tovara`
--
ALTER TABLE `kategorii_tovara`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `polzovateli`
--
ALTER TABLE `polzovateli`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT для таблицы `postavshchiki`
--
ALTER TABLE `postavshchiki`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `proizvoditeli`
--
ALTER TABLE `proizvoditeli`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT для таблицы `punkty_vydachi`
--
ALTER TABLE `punkty_vydachi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT для таблицы `roli_sotrudnikov`
--
ALTER TABLE `roli_sotrudnikov`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `sostav_zakaza`
--
ALTER TABLE `sostav_zakaza`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `polzovateli`
--
ALTER TABLE `polzovateli`
  ADD CONSTRAINT `polzovateli_ibfk_1` FOREIGN KEY (`rol_id`) REFERENCES `roli_sotrudnikov` (`id`);

--
-- Ограничения внешнего ключа таблицы `sostav_zakaza`
--
ALTER TABLE `sostav_zakaza`
  ADD CONSTRAINT `sostav_zakaza_ibfk_1` FOREIGN KEY (`nomer_zakaza`) REFERENCES `zakazy` (`nomer_zakaza`),
  ADD CONSTRAINT `sostav_zakaza_ibfk_2` FOREIGN KEY (`artikul_tovara`) REFERENCES `tovary` (`artikul`) ON DELETE CASCADE;

--
-- Ограничения внешнего ключа таблицы `tovary`
--
ALTER TABLE `tovary`
  ADD CONSTRAINT `tovary_ibfk_1` FOREIGN KEY (`postavshchik_id`) REFERENCES `postavshchiki` (`id`),
  ADD CONSTRAINT `tovary_ibfk_2` FOREIGN KEY (`proizvoditel_id`) REFERENCES `proizvoditeli` (`id`),
  ADD CONSTRAINT `tovary_ibfk_3` FOREIGN KEY (`kategoriya_id`) REFERENCES `kategorii_tovara` (`id`);

--
-- Ограничения внешнего ключа таблицы `zakazy`
--
ALTER TABLE `zakazy`
  ADD CONSTRAINT `zakazy_ibfk_1` FOREIGN KEY (`adres_punkta_vydachi_id`) REFERENCES `punkty_vydachi` (`id`),
  ADD CONSTRAINT `zakazy_ibfk_2` FOREIGN KEY (`fio_klienta_id`) REFERENCES `polzovateli` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
