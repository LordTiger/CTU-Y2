
CREATE TABLE IF NOT EXISTS `cust_Data` (
    `cid` int(11) NOT NULL AUTO_INCREMENT,
    `cName` varchar(25) NOT NULL,
    `cSurname` varchar(30) NOT NULL,
    `cNumber` varchar(11) NOT NULL,
    `cEmail` varchar(100) NOT NULL,
    `cAmount` DECIMAL(10, 0) NOT NULL,
    `time` timestamp NOT NULL DEFAULT current_timestamp(),
    PRIMARY KEY (`cid`)
);

CREATE TABLE IF NOT EXISTS `admin_Data` (
    `aid` int(11) NOT NULL AUTO_INCREMENT,
    `aName` varchar(25) NOT NULL,
    `aEmail` varchar(100) NOT NULL,
    `aPassword` varchar(100) NOT NULL,
    PRIMARY KEY (`aid`)
);