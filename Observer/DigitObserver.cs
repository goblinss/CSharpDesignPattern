using System;
using System.Threading;

namespace Gushwell.DesignPatterns {

    // 購読者クラスは、IObserver<T>を実装するのがC#流

    public class DigitObserver : IObserver<int> {
        public void OnCompleted() {
 
        }

        public void OnError(Exception error) {

        }

        public void OnNext(int value) {
            Console.WriteLine("DigitObserver:" + value);
            Thread.Sleep(100);
        }

    }
}
