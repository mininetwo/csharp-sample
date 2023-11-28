using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    string name = "Hong"; // 멤버 변수

    // Start is called before the first frame update
    void Start()
    {
        int age; // 지역 변수
        age = 1;

        Run();

        Debug.Log("START");
    }

    void Run()
    {
        // 동작
        Debug.Log("RUN");
    }
}
