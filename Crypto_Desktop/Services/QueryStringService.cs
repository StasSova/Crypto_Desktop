using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_Desktop.Services
{
    public static class QueryStringService
    {
        // Определение базового URL для запросов к API
        public static readonly Uri ApiEndPoint = new Uri("https://api.coingecko.com/api/v3/");

        // Метод для добавления строки запроса к URL с использованием параметров
        public static Uri AppendQueryString(string path, Dictionary<string, object> parameter)
        {
            return CreateUrl(path, parameter);
        }

        // Метод для добавления строки запроса к URL без параметров
        public static Uri AppendQueryString(string path)
        {
            return CreateUrl(path, new Dictionary<string, object>());
        }

        // Приватный метод для создания URL с учетом параметров
        private static Uri CreateUrl(string path, Dictionary<string, object> parameter)
        {
            var urlParameters = new List<string>();

            // Проход по параметрам и добавление их в список urlParameters
            foreach (var par in parameter)
            {
                // Если значение параметра не пусто, добавляем его к списку
                urlParameters.Add(par.Value == null || string.IsNullOrWhiteSpace(par.Value.ToString())
                    ? null
                    : $"{par.Key}={par.Value.ToString().ToLower()}");
            }

            // Фильтрация и кодирование параметров URL
            var encodedParams = urlParameters
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Select(WebUtility.HtmlEncode)
                .Select((x, i) => i > 0 ? $"&{x}" : $"?{x}")
                .ToArray();

            // Формирование итогового URL
            string url = encodedParams.Length > 0 ? $"{path}{string.Join(string.Empty, encodedParams)}" : path;

            // Создание Uri с использованием базового URL и сформированной строки запроса
            return new Uri(ApiEndPoint, url);
        }
    }

}
