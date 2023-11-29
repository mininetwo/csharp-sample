using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IfElse : MonoBehaviour
{
    // 화면에 결과를 출력할 Text
    public TMP_Text text;

    // 사용자에게 입력을 받을 Input Field
    public TMP_InputField inputField;

    // 버튼이 클릭 되었을 때 동작할 함수
    public void ButtonClicked()
    {
        string input = inputField.text;
        int nummber = int.Parse(input);

        if (nummber < 0)
        {
            text.text = "음수";
        }
        else if (nummber > 0)
        {
            text.text = "양수";
        }
        else
        {
            text.text = "0";
        }

        if (nummber % 2 == 0)
        {
            text.text = "짝수";
        }
        else
        {
            text.text = "홀수";
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
}
