using System;

namespace NumberBeneratorUtils
{
    
        public class NumberGenerator
        {
            public event Action<int> Even;
            public void Start()
            {

                Random random = new Random();
                for (int i = 0; i < 10; i++)
                {
                    int number = random.Next(11);
                    if (number % 2 == 0)
                    {
                        Even?.Invoke(number);
                    }
                }

            }
        }
    
}
