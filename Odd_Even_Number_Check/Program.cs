using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Number_Check
{
    public class Program            // 숫자 하나를 입력받아 해당 숫자가 홀수인지, 짝수인지 판단하기
    {
        static void Main(string[] args)
        {
            int num = 0;           // 입력받을 숫자
            int loopCheck = 1;       // While 문 루프 체크

            while (loopCheck > 0)         // loopCheck 가 0이 되면 While 문을 탈출한다.
            {
                if (loopCheck == 1)        // loopCheck 가 1이면 계속 While 문을 돈다.
                {
                    Console.WriteLine("1 이상의 숫자를 입력해 주세요. => ");
                    Console.WriteLine("(단, 종료 하시려면 숫자 0 을 입력해주세요)");
                    Console.WriteLine();
                    int.TryParse(Console.ReadLine(), out num);

                    if (num <= 0)          // 0을 입력하면 종료
                    {
                        Console.WriteLine("종료합니다.");
                        loopCheck = 0;
                    }
                    else if (num % 2 == 0)          // 입력받은 숫자를 2로 나누어 나머지가 0이면 짝수로 판단
                    {
                        Console.WriteLine("해당 숫자는 짝수 입니다.");
                        Console.WriteLine();
                    }
                    else               // 그 외 홀수로 판단
                    {
                        Console.WriteLine("해당 숫자는 홀수 입니다.");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
