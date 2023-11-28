using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringSearch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string greeting = "Good Moring";
        Debug.Log(greeting);

        // IndexOf()
        var result = greeting.IndexOf("Good");
        result = greeting.IndexOf("o");

        var result2 = greeting.StartsWith("Good");
        result2 = greeting.StartsWith("Morning");

        result2 = greeting.EndsWith("Good");
        result2 = greeting.EndsWith("Morning");

        result2 = greeting.Contains("Evening");
        result2 = greeting.Contains("Morning");

        var result3 = greeting.Replace("Morning", "Evening");

        

        Debug.Log($"INdexOf: 'Good'  { greeting.IndexOf("Good")}");
        Debug.Log($"INdexOf: 'o'  { greeting.IndexOf("o")}");

        // LastIndexOf()
        Debug.Log($"LastIndexOf 'Good' : { greeting.LastIndexOf("Good") }");
        Debug.Log($"LastIndexOf 'g' : { greeting.LastIndexOf("g") }");

        // StartWith()
        Debug.Log($"StartWith 'Good' : { greeting.LastIndexOf("Good") }");
        Debug.Log($"StartWith 'g' : { greeting.LastIndexOf("Morning") }");

        // EndWith()
        Debug.Log($"EndWith 'Good' : { greeting.LastIndexOf("Good") }");
        Debug.Log($"EndWith 'Morning' : { greeting.LastIndexOf("Morning") }");

        // Contains()
        Debug.Log($"Contains 'Evening' : { greeting.LastIndexOf("Evening") }");
        Debug.Log($"Contains 'Morning' : { greeting.LastIndexOf("Morning") }");

        // Replace
        Debug.Log($"Replaced 'Mornig' with 'Evening' : { greeting.Replace("Morning", "Evening")}" );
    }
}
