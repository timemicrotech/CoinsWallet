
DROP TABLE IF EXISTS BTC_SENDTRANSACTIONS;

CREATE TABLE BTC_SENDTRANSACTIONS
(
  TXID NVARCHAR(64) PRIMARY KEY,
  AMOUNT DECIMAL(16, 8),
  FEE DECIMAL(16, 8),
  CREATETIME DATETIME DEFAULT CURRENT_TIMESTAMP()
)ENGINE=InnoDB DEFAULT CHARSET=utf8;