using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullConditionalOperator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ArrayList a = null;
        a?.Add("야구"); // a? : a 가 null 인지 아닌지
        a?.Add("축구");
        Debug.Log($"Count : {a?.Count}");
        Debug.Log($"{a?[0]}");
        Debug.Log($"{a?[1]}");

        a = new ArrayList();

        a?.Add("야구");
        a?.Add("축구");
        Debug.Log($"Count : {a?.Count}");
        Debug.Log($"{a?[0]}");
        Debug.Log($"{a?[1]}");

        Person person = new Person();

        person.Walk();

    }
}

public class Person
{
    // 변수
    int age;

    // 함수
    public void Walk()
    {

    }
}
