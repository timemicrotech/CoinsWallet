
DROP TABLE IF EXISTS ZEC_TRANSACTIONDETAILS;

CREATE TABLE ZEC_TRANSACTIONDETAILS
(
  ID BIGINT AUTO_INCREMENT PRIMARY KEY,
  TXID NVARCHAR(64) NOT NULL,
  ADDRESS NVARCHAR(64) NOT NULL,
  CATEGORY NVARCHAR(50) NOT NULL,
  AMOUNT DECIMAL(16, 8),
  CREATETIME DATETIME DEFAULT CURRENT_TIMESTAMP()
)ENGINE=InnoDB DEFAULT CHARSET=utf8;

ALTER TABLE ZEC_TRANSACTIONDETAILS ADD INDEX IX_ZEC_TRANSACTIONDETAILS_TXID(TXID);