using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_Desktop.MVVM.Coin
{
    public class M_Coin
    {
        /// <summary>
        /// Уникальный идентификатор монеты.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Символьный код монеты.
        /// </summary>
        public string Symbol { get; set; }

        /// <summary>
        /// Название монеты.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// URL изображения монеты.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Текущая цена монеты.
        /// </summary>
        public double CurrentPrice { get; set; }

        /// <summary>
        /// Рыночная капитализация монеты.
        /// </summary>
        public long MarketCap { get; set; }

        /// <summary>
        /// Ранг монеты по рыночной капитализации.
        /// </summary>
        public int MarketCapRank { get; set; }

        /// <summary>
        /// Полностью разводимая оценка монеты.
        /// </summary>
        public double FullyDilutedValuation { get; set; }

        /// <summary>
        /// Общий объем монеты за последние 24 часа.
        /// </summary>
        public double TotalVolume { get; set; }

        /// <summary>
        /// Максимальная цена монеты за последние 24 часа.
        /// </summary>
        public double High24h { get; set; }

        /// <summary>
        /// Минимальная цена монеты за последние 24 часа.
        /// </summary>
        public double Low24h { get; set; }

        /// <summary>
        /// Изменение цены монеты за последние 24 часа.
        /// </summary>
        public double PriceChange24h { get; set; }

        /// <summary>
        /// Изменение цены монеты за последние 24 часа в процентном соотношении.
        /// </summary>
        public double PriceChangePercentage24h { get; set; }

        /// <summary>
        /// Изменение рыночной капитализации монеты за последние 24 часа.
        /// </summary>
        public long MarketCapChange24h { get; set; }

        /// <summary>
        /// Изменение рыночной капитализации монеты за последние 24 часа в процентном соотношении.
        /// </summary>
        public double MarketCapChangePercentage24h { get; set; }

        /// <summary>
        /// Количество монет в обращении.
        /// </summary>
        public double CirculatingSupply { get; set; }

        /// <summary>
        /// Общее количество монет в обращении.
        /// </summary>
        public double TotalSupply { get; set; }

        /// <summary>
        /// Максимальное количество монет, которое может существовать.
        /// </summary>
        public double MaxSupply { get; set; }

        /// <summary>
        /// Исторический максимум цены монеты.
        /// </summary>
        public double Ath { get; set; }

        /// <summary>
        /// Изменение цены от исторического максимума в процентном соотношении.
        /// </summary>
        public double AthChangePercentage { get; set; }

        /// <summary>
        /// Дата достижения исторического максимума цены монеты.
        /// </summary>
        public DateTime AthDate { get; set; }

        /// <summary>
        /// Исторический минимум цены монеты.
        /// </summary>
        public double Atl { get; set; }

        /// <summary>
        /// Изменение цены от исторического минимума в процентном соотношении.
        /// </summary>
        public double AtlChangePercentage { get; set; }

        /// <summary>
        /// Дата достижения исторического минимума цены монеты.
        /// </summary>
        public DateTime AtlDate { get; set; }

        /// <summary>
        /// Возврат на инвестиции (ROI).
        /// </summary>
        public double? Roi { get; set; }

        /// <summary>
        /// Время последнего обновления данных.
        /// </summary>
        public DateTime LastUpdated { get; set; }
    }

}
