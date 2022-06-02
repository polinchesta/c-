namespace Otdyx
{
    public class OtdyxVip
    {
        public string nameOfOtdyx;
        public decimal priceOfOtdyx;
        public string typeOfOtdyx;

        public OtdyxVip(string nameOfOtdyx, decimal priceOfOtdyx, string typeOfOtdyx)
        {
            this.nameOfOtdyx = nameOfOtdyx;
            this.priceOfOtdyx = priceOfOtdyx;
            this.typeOfOtdyx = typeOfOtdyx;  
        }

        public string BuyOtdyx(decimal priceOfOtdyx)
        {
            if (priceOfOtdyx < this.priceOfOtdyx)
            {
                return "Недостаточно средств, накопите больше денюжек";
            }
            else
            {
                return $"Вы купили тур в {nameOfOtdyx}";
            }
        }
        public string ShowInfo()
        {
            return $"Тур - {nameOfOtdyx}; Цена - {priceOfOtdyx}; Тип отдыха - {typeOfOtdyx};";
        }

    }
}