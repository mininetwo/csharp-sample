using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class StringFormatBasic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string fmt = "{0,-20},{1,-15},{2, 30}";

        var result1 = string.Format(fmt, "Publisher", "Author", "Title");
        var result2 = string.Format(fmt, "Marvel", "Stan Lee", "Iron Man");
        var result3 = string.Format(fmt, "Hanbit", "Sanghyung Park", "This is C#");
        var result4 = string.Format(fmt, "Prentice Hall", "K&R", "The C Programming Language.");

        // ---

        DateTime dt = new DateTime(2018, 11, 3, 23, 18, 22);

        Debug.Log(string.Format("12시간 형식: {0:yyyy-MM-dd tt hh:mm:ss (ddd)}", dt));
        Debug.Log(string.Format("24시간 형식: {0:yyyy-MM-dd HH:mm:ss (dddd)}", dt));

        CultureInfo ciKo = new CultureInfo("ko-KR");

        Debug.Log(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciKo));
        Debug.Log(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciKo));
        Debug.Log(dt.ToString(ciKo));

        CultureInfo ciEn = new CultureInfo("en-US");

        Debug.Log(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciEn));
        Debug.Log(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciEn));
        Debug.Log(dt.ToString(ciEn));
    }
}

