using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_26.Task_1.models
{
    public class Auto
    {
        public string Mark { get; set; }
        public string Year { get; set; }
        public int RentDays { get; set; }
        public override string ToString()
        {
            return new StringBuilder().AppendLine($"Марка автомобиля {Mark}")
                .AppendLine($"\tГод выпуска {Year}")
                .AppendLine($"Кол-во дней аренды {RentDays}").ToString();
        }
    }
}
