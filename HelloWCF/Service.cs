using System;

namespace HelloWCF
{
    class Service : IContract
    {
        public void Say(string input)
        {
            Console.WriteLine("Wiadomość odebrana, w treści znajduje się:  {0}", input);
        }
    }
}
