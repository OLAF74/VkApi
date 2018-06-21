using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkApi
{
    /// <summary>
    /// Класс для создания логов
    /// </summary>
    public class Log
    {
        private static StreamWriter file = null;

        /// <summary>
        /// Создает лог файл.
        /// </summary>
        public static void Create()
        {
                file = File.CreateText(string.Format("log_{0}.txt", DateTime.Now.ToString("dd-MM-yyyy--HH-mm-ss")));
                file.AutoFlush = true;
                Append("Log started");
        }

        /// <summary>
        /// Записывает строку в лог.
        /// </summary>
        /// <param name="message">Строка для записи.</param>
        public static async void Append(string message)
        {
            if (file != null)
            {
                await file.WriteLineAsync(string.Format("[{0}]: {1}", DateTime.Now, message));
            }
        }
    }
}
