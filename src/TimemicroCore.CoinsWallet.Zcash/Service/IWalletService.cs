﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TimemicroCore.CoinsWallet.Zcash.Service
{
    public interface IWalletService
    {
        string GetNewAddress();

        /// <summary>
        /// 同步块
        /// </summary>
        void SyncBlock();

        /// <summary>
        /// 同步交易
        /// </summary>
        /// <param name="blockCount"></param>
        void SyncTransaction(int blockCount);

        /// <summary>
        /// 确认交易
        /// </summary>
        void ConfirmTransaction();
    }
}
