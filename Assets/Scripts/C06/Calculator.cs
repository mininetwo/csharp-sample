using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace C06
{
    public class Calculator : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            //int result = MyCalculator.Plus(3, 4);
            //Debug.Log(result);

            //result = MyCalculator.Minus(5, 2);
            //Debug.Log(result);

            MyCalculator myCalculator = new MyCalculator();
            myCalculator.temp = 30;

            MyCalculator myCalculator2 = new MyCalculator();
            myCalculator.temp = 40;

            //int result;

            //result = myCalculator.Plus(3, 4);
            //result = myCalculator.Minus(5, 2);
        }
    }

    public class MyCalculator
    {
        public int temp;

            public int Plus(int a, int b)
            {
                int result = a + b;
                return result;
            }

            public int Minus(int a, int b)
            {
                int result = a - b;
                return result;
            }
    

    }
}