using System;

class Player
{
    static void Main(string[] args)
    {

        // game loop
        while (true)
        {
            string enemy1 = Console.ReadLine(); // name of enemy 1
            int dist1 = int.Parse(Console.ReadLine()); // distance to enemy 1
            string enemy2 = Console.ReadLine(); // name of enemy 2
            int dist2 = int.Parse(Console.ReadLine()); // distance to enemy 2

            // Write an action using Console.WriteLine()
            // Enter the code here

            // 코드는 가독성이 가장 중요하므로 코드가 길어지거나 복잡해질 때는 삼항 연산자 사용이 꺼려진다.
            // 삼항연산자는 단순히 코드의 간결성, 가독성을 위해 사용되니 시간복잡도/공간복잡도 영향 없음

            Console.WriteLine((dist1 < dist2)?enemy1:enemy2);

            /*
            if (dist1 < dist2) {
                Console.WriteLine(enemy1);
            } else {
                Console.WriteLine(enemy2);
            }
            */
        }
    }
}
