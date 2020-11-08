using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62162110027_7
{
    internal abstract class Sports  //class กีฬาเก็บวิธีการออกกำลังกาย   แคลรอลี่ และ คำวนณไว้ 
    {
        public void HowtoExercise()  //มีวิธีการออกกำลังกาย
        {

        }
        private int calorie;
        public int Calorie  // มีแคลรอลี่
        {
            get { return calorie; }
            set { calorie = value; }
        }
        public void Calculat(int Hours)  // คิดชั่วโมงในการเล่นกีฬา ไว้ คำนวณแคลในการเล่นต่อชั่วโมง
        {
            int count;
            count = Hours * Calorie;
            Console.WriteLine(count + " Calorie");
        }

    }

    //แต่ละ class วิธีออกกำลังกาย แต่ละวิธีการจะมีการออกกำลังกายคนละแบบกัน
    class HighImpactAerobics : Sports   //class  แอโรบิค มีวิธีการที่ เต้นแอโรบิค
    {

        public void HowtoExercise()   
        {
            Console.WriteLine("HowtoExercise : Basic dance exercises   ");  
        }

    }
    class RunningUpStairs : Sports  //class วิ่ง มีธิการ วิ่งขึ้นลงบันได
    {
        public void HowtoExercise()
        {
            Console.WriteLine("HowtoExercise : Run up and down stairs      ");
        }
    }
    class JumpRope : Sports
    {
        public void HowtoExercise() // class กระโดด  มีวิธีการ กระโดดเชือก
        {
            Console.WriteLine("HowtoExercise : Rope skipping       ");
        }
    }

    //class PlaySelect เพื่อเอาไว้เลือกเมื่อเราอยากออกกำลังกายแบบไหน
    class PlaySelect  
    {

        public void Select()
        {
            Console.WriteLine("HowtoExercise & Calorie To lose weight \n");  //วิธีการออกกำลังกายและแคลอรี่เพื่อลดน้ำหนัก 
            Console.WriteLine("Which sport would you like to lose weight with ? "); //คุณต้องการลดน้ำหนักด้วยกีฬาชนิดใด
            Console.WriteLine("1 = HighImpactAerobics   2 =  RunningUpStairs   3 = JumpRope \n");  //กำหนดเลขเพื่อให้เลือก
            Console.Write("Press the number to select a sport. : "); //
            int.TryParse(Console.ReadLine(), out int number);

            Console.Write("How many hours of exercise do you need ? :");
            int.TryParse(Console.ReadLine(), out int Hour);


            switch (number)
            {
                case 1:
                    HighImpactAerobics Aerobics = new HighImpactAerobics();
                    Aerobics.HowtoExercise();
                    Aerobics.Calorie = 533;
                    Console.WriteLine(Aerobics.Calorie + " Calorie  / 1 Hour");
                    Console.Write("You need  " + Hour + " Hour = ");
                    Aerobics.Calculat(Hour);
                    Console.Write(" Calorie ");
                    break;
                case 2:
                    RunningUpStairs Run = new RunningUpStairs();
                    Run.HowtoExercise();
                    Run.Calorie = 657;
                    Console.WriteLine(Run.Calorie + " Calorie  / 1 Hour");
                    Console.Write("You need  " + Hour + " Hour = ");
                    Run.Calculat(Hour);
                    Console.Write(" Calorie ");
                    break;
                case 3:
                    JumpRope Jump = new JumpRope();
                    Jump.HowtoExercise();
                    Jump.Calorie = 861;
                    Console.WriteLine(Jump.Calorie + " Calorie  / 1 Hour");
                    Console.Write("You need  " + Hour + " Hour = ");
                    Jump.Calculat(Hour);
                    Console.Write(" Calorie ");

                    break;
                default:
                    Console.WriteLine("Fall");
                    break;


            }

        }

    }

}
