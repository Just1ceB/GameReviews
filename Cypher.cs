using System.Configuration;
using MySqlX.XDevAPI.CRUD;

namespace GamesReviews
{
    internal class Cypher
    {
        /// <summary>
        /// Function will cypher any string via simple shifting string characters by <c>key</c> that passed as <b>parameter</b>
        /// </summary>
        /// <param name="srcText">Text to cypher</param>
        /// <param name="key">Key to the cypher (How many characters the character shifts)</param>
        /// <returns>
        /// Encrypted source text via shifting string characters by <c>key</c> that was passed as <b>parameter</b>
        /// </returns>
        public static string ShiftCypher(string srcText, int key)
        {
            string encryptedStr = "";
            key %= 50;

            for (int i = 0; i < srcText.Length; i++)
            {
                encryptedStr += (char)(srcText[i] + key);
            }

            return encryptedStr;
        }
    }
}
