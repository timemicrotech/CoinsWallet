﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TimemicroCore.CoinsWallet.BitcoinCash.PO
{
    public class CoinsWalletDbContext : DbContext
    {
        public CoinsWalletDbContext(DbContextOptions<CoinsWalletDbContext> options)
            : base(options)
        { }

        public DbSet<ReceiveAddressPO> ReceiveAddresses { get; set; }

        public DbSet<BlockPO> Blocks { get; set; }

        public DbSet<TransactionPO> Transactions { get; set; }

        public DbSet<TransactionDetailsPO> TransactionDetails { get; set; }

        public DbSet<ReceiveNotifyLogPO> ReceiveNotifyLogs { get; set; }

        public DbSet<SendRequestPO> SendRequests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReceiveAddressPO>(entity =>
            {
                entity.ToTable("BCH_RECEIVEADDRESSES");
                entity.HasKey(x => x.Address);
                entity.Property(x => x.Address).HasColumnName("ADDRESS");
                entity.Property(x => x.PrivateKey).HasColumnName("PRIVATEKEY");
                entity.Property(x => x.TotalReceived).HasColumnName("TOTALRECEIVED");
            });

            modelBuilder.Entity<BlockPO>(entity =>
            {
                entity.ToTable("BCH_BLOCKS");
                entity.HasKey(x => x.Hash);
                entity.Property(x => x.Hash).HasColumnName("HASH");
                entity.Property(x => x.Height).HasColumnName("HEIGHT");
                entity.Property(x => x.State).HasColumnName("STATE");
            });

            modelBuilder.Entity<TransactionPO>(entity =>
            {
                entity.ToTable("BCH_TRANSACTIONS");
                entity.HasKey(x => x.TxId);
                entity.Property(x => x.TxId).HasColumnName("TXID");
                entity.Property(x => x.BlockHash).HasColumnName("BLOCKHASH");
                entity.Property(x => x.Confirmations).HasColumnName("CONFIRMATIONS");
                entity.Property(x => x.State).HasColumnName("STATE");
            });

            modelBuilder.Entity<TransactionDetailsPO>(entity =>
            {
                entity.ToTable("BCH_TRANSACTIONDETAILS");
                entity.HasKey(x => new { x.TxId, x.Address });
                entity.Property(x => x.TxId).HasColumnName("TXID");
                entity.Property(x => x.Address).HasColumnName("ADDRESS");
                entity.Property(x => x.Amount).HasColumnName("AMOUNT");
                entity.Property(x => x.Category).HasColumnName("CATEGORY");
            });

            modelBuilder.Entity<ReceiveNotifyLogPO>(entity =>
            {
                entity.ToTable("BCH_RECEIVENOTIFYLOGS");
                entity.HasKey(x => x.Id);
                entity.Property(x => x.TxId).HasColumnName("TXID");
                entity.Property(x => x.Address).HasColumnName("ADDRESS");
                entity.Property(x => x.Amount).HasColumnName("AMOUNT");
                entity.Property(x => x.NotifiedCount).HasColumnName("NOTIFIEDCOUNT");
                entity.Property(x => x.NotifyResponseText).HasColumnName("NOTIFYRESPONSETEXT");
                entity.Property(x => x.NextNotifyTime).HasColumnName("NEXTNOTIFYTIME");
            });

            modelBuilder.Entity<SendRequestPO>(entity =>
            {
                entity.ToTable("BCH_SENDREQUESTS");
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Id).HasColumnName("ID");
                entity.Property(x => x.OutRequestNo).HasColumnName("OUTREQUESTNO");
                entity.Property(x => x.Address).HasColumnName("ADDRESS");
                entity.Property(x => x.Amount).HasColumnName("AMOUNT");
                entity.Property(x => x.State).HasColumnName("STATE");
            });
        }
    }
}