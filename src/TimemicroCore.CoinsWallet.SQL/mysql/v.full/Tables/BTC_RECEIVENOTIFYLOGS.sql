DROP TABLE IF EXISTS BTC_RECEIVENOTIFYLOGS;

CREATE TABLE BTC_RECEIVENOTIFYLOGS
(
  ID BIGINT AUTO_INCREMENT PRIMARY KEY,
  TXID NVARCHAR(64) NOT NULL,
  ADDRESS NVARCHAR(52),
  AMOUNT DECIMAL(16, 8) DEFAULT 0,
  NOTIFIEDCOUNT INT DEFAULT 0,
  NOTIFYRESPONSETEXT TEXT,
  NEXTNOTIFYTIME DATETIME  DEFAULT CURRENT_TIMESTAMP(),
  CREATETIME DATETIME DEFAULT CURRENT_TIMESTAMP()
)ENGINE=InnoDB DEFAULT CHARSET=utf8;

ALTER TABLE BTC_RECEIVENOTIFYLOGS ADD INDEX IX_BTC_RECEIVENOTIFYLOGS_NEXTNOTIFYTIME(NEXTNOTIFYTIME);
