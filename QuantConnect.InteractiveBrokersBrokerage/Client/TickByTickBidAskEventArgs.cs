/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

using System;

namespace QuantConnect.Brokerages.InteractiveBrokers.Client
{
    /// <summary>
    /// Event arguments class for the <see cref="InteractiveBrokersClient.TickByTickBidAsk"/> event.
    /// Carries one tick-by-tick best bid/ask update from reqTickByTickData("BidAsk").
    /// </summary>
    public sealed class TickByTickBidAskEventArgs : EventArgs
    {
        /// <summary>The request's unique identifier.</summary>
        public int RequestId { get; }

        /// <summary>Tick timestamp as Unix epoch seconds (IB server time).</summary>
        public long Time { get; }

        /// <summary>The best bid price.</summary>
        public double BidPrice { get; }

        /// <summary>The best ask price.</summary>
        public double AskPrice { get; }

        /// <summary>The best bid size.</summary>
        public decimal BidSize { get; }

        /// <summary>The best ask size.</summary>
        public decimal AskSize { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TickByTickBidAskEventArgs"/> class.
        /// </summary>
        public TickByTickBidAskEventArgs(int requestId, long time, double bidPrice, double askPrice,
            decimal bidSize, decimal askSize)
        {
            RequestId = requestId;
            Time = time;
            BidPrice = bidPrice;
            AskPrice = askPrice;
            BidSize = bidSize;
            AskSize = askSize;
        }
    }
}
