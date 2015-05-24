using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InYourFace
{
    public class ArduinoListener
    {
        SerialPort _connectionToArduino;
        public ArduinoListener(string com, List<Player> players)
        {
            _connectionToArduino = new SerialPort(com, 9600);
            _connectionToArduino.Open();

            Task task = Task.Run(() =>
            {
                while (true)
                {
                    int playerIndex = _connectionToArduino.ReadByte();
                    Player pressedPlayer = players.Where(player => player.Id == playerIndex).First();
                    pressedPlayer.IsPressed = true;
                }
            });
        }
    }
}
