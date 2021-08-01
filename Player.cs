using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomSixOnline
{
    public class Player
    {
        public string Username { get => username; set => username = value; }
        public string ConnectionId { get => connectionId; set => connectionId = value; }
        public string CurrentCharacter { get => currentCharacter; set => currentCharacter = value; }

        private string username;
        private string connectionId;
        private string currentCharacter;

        public Player(){ }
        public Player(string currentCharacter)
        {
            this.currentCharacter = currentCharacter;
        }

        public Player(string username, string connectionId, string currentCharacter)
        {
            this.username = username;
            this.connectionId = connectionId;
            this.currentCharacter = currentCharacter;
        }

        string GetRandomOperator()
        {
            //ALL operators available
            string[] operators = new string[] {"Thunderbird","Flores", "Aruni", "Zero", "Ace", "Melusi", "Oryx",
            "Iana","Wamai","Kali","Amaru","Goyo","Nøkk","Warden","Mozzie","Gridlock","Nomad","Kaid",
            "Clash","Maverick","Maestro","Alibi","Lion","Finka","Vigil","Dokkaebi","Zofia","Ela","Ying",
            "Lesion","Mira","Jackal","Hibana","Echo","Caveira","Capitao","Blackbeard","Vallkyrie","Buck","Frost",
            "Mute","Sledge","Smoke","Ash","Castle","Pulse","Thermite","Montagne","Twitch","Doc","Rook",
            "Jäger","Bandit","Blitz","Iq","Fuze","Glaz","Tachanka","Kapkan"};
            Random rnd = new Random();

            string randomOperator = operators[rnd.Next(0, operators.Length)];
            this.currentCharacter = randomOperator;

            return randomOperator;
        }
    }
}
