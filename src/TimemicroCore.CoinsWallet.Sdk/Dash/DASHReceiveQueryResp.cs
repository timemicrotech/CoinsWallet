﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TimemicroCore.CoinsWallet.Sdk.Dash
{
    public class DASHReceiveQueryResp : CoinsWalletApiRespData<DASHReceiveQueryRespData>
    {
        public DASHReceiveQueryResp()
        {
            Service = "dash_receivequery";
        }
    }

    public class DASHReceiveQueryRespData
    {
        [JsonProperty("txid")]
        public string TxId { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("confirmations")]
        public int Confirmations { get; set; }
    }
}
