using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    internal class Car
    {
        public int Id { get; }
        private static int _idCounter = 0;
        public string Name { get; set; }
        public int Speed { get; set; }
        public string CarCode { get; set; }

        public Car(string name, int speed)
        {
            _idCounter++;
            Id = _idCounter;
            Name = name;
            Speed = speed;
            CarCode = NewCarCode(Id);
        }
        private string NewCarCode(int id)
        {
            string firstLetters = Name.Substring(0, Math.Min(2, Name.Length)).ToUpper();
            int codeNumber = (id > 1000) ? (id - 1000) : id;
            return $"{firstLetters}{codeNumber + 1000}";
        }
    }
}
