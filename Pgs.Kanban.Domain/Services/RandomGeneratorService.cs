using System;
using System.Collections.Generic;
using System.Text;

namespace Pgs.Kanban.Domain.Services
{
    public class RandomGeneratorService
    {

        private static List<int> magicNumber = new List<int>();


        private Random randomGenerator = new Random();
        public int GenerateRandomNumber()
        {


            var number = randomGenerator.Next();
            return number;

        }
        public int GenerateRandomNumber(int maxValue)
        {

            var number = randomGenerator.Next(maxValue);
            return number;
        }

        public void AddNumberToList(int number)
        {
            magicNumber.Add(number);
        }

        public void DeleteNumber(int number)
        {
            magicNumber.Remove(number);
        }
        public List<int> GetNumberList()
        {
            return magicNumber;
        }

    }

}



