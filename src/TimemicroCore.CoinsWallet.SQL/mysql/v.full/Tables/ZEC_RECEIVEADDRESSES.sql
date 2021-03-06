DROP TABLE IF EXISTS ZEC_RECEIVEADDRESSES;

CREATE TABLE ZEC_RECEIVEADDRESSES
(
  ADDRESS NVARCHAR(34) PRIMARY KEY NOT NULL,
  PRIVATEKEY NVARCHAR(52),
  TOTALRECEIVED DECIMAL(16, 8) DEFAULT 0,
  CREATETIME DATETIME DEFAULT CURRENT_TIMESTAMP()
)ENGINE=InnoDB DEFAULT CHARSET=utf8;

