DROP TABLE IF EXISTS ETH_SENDNOTIFYLOGS;

CREATE TABLE ETH_SENDNOTIFYLOGS
(
  ID BIGINT AUTO_INCREMENT PRIMARY KEY,
  OUTREQUESTNO NVARCHAR(50) NOT NULL,
  TXID NVARCHAR(66) NOT NULL,
  ADDRESS NVARCHAR(45),
  NOTIFIEDCOUNT INT DEFAULT 0,
  NOTIFYRESPONSETEXT TEXT,
  NEXTNOTIFYTIME DATETIME  DEFAULT CURRENT_TIMESTAMP(),
  CREATETIME DATETIME DEFAULT CURRENT_TIMESTAMP()
)ENGINE=InnoDB DEFAULT CHARSET=utf8;

ALTER TABLE ETH_SENDNOTIFYLOGS ADD INDEX IX_ETH_SENDNOTIFYLOGS_NEXTNOTIFYTIME(NEXTNOTIFYTIME);
