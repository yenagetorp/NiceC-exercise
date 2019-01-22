using System;

namespace NumberUtils
{
    /// <summary>
    /// The main entry point for the application.
    ///  //To be able to give the calss the ability to publish the event:
    //1. Define the delegate(contrat between the publisher and the subscriber)
    //2. Define an event based on that delegate
    //3. Raise the event
    // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
    /// </summary>
    public class NumberGenerator
    {

        public event Action<int> Even;
        public void Start()
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int number = random.Next(11);
                //if (number % 2 == 0)
                //{
                //    Even?.Invoke(number);
                //}
                Even?.Invoke(number);
            }
        }

    }
}
