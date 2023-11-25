

using static System.Console;

namespace game.krasn23.learning {
    class GameTest {

        static void MoveViaCastle(IMovable mv) {
            mv.MoveLeft().MoveLeft().MoveUp().MoveDown().MoveLeft().MoveLeft().
                MoveDown().MoveDown();
            
        }

    static void Main(String[] a) {
        WriteLine("---------- Test Game ---------");

            Man man1 = new Man(0, 0, 90);
            Man man2 = new Man(110, 0, 90);
            Monster monster1 = new Monster(11, 0, 0);

            MoveViaCastle(monster1);

            Sprite s = man1;
            Object o = (Object)monster1;

            int a1 = 122;  Object o2 = a1; 

          //  Monster m = (Monster)o;
           // Man m1 = (Man)o;
            Man? m2 = o as Man;
            WriteLine(m2);





        }
    }
}