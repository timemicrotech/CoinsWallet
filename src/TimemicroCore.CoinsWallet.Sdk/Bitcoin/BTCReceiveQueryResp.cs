﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TimemicroCore.CoinsWallet.Sdk.Bitcoin
{
    public class BTCReceiveQueryResp : CoinsWalletApiRespData<BTCReceiveQueryRespData>
    {
        public BTCReceiveQueryResp()
        {
            Service = "btc_receivequery";
        }
    }

    public class BTCReceiveQueryRespData
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
