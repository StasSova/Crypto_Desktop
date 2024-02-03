using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Crypto_Desktop.MVVM.Coin
{
    public class SparklineIn7D
    {
        [JsonPropertyName("price")]
        public double[] Price { get; set; }
    }
}
