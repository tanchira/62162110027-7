using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62162110027_7
{
    internal abstract class Sports  //class กีฬาเก็บวิธีการออกกำลังกาย   แคลรอลี่ และ คำวนณไว้ 
    {
        public void HowtoExercise()
        {

        }
        private int calorie;
        public int Calorie
        {
            get { return calorie; }
            set { calorie = value; }
        }
        public void Calculat(int Hours)
        {
            int count;
            count = Hours * Calorie;
            Console.WriteLine(count + " Calorie");
        }

    }

}
