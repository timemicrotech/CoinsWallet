﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TimemicroCore.CoinsWallet.Dash.PO
{
    public class ReceiveAddressPO
    {
        public string Address { get; set; }

        public string PrivateKey { get; set; }

        public decimal TotalReceived { get; set; }
    }
}
