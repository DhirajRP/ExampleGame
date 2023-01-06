using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class chest : MonoBehaviour
{
     [SerializeField] TMP_Text textBox;
    [SerializeField] int answer;
    [SerializeField] int range = 100;

    string questionGenerator(in int maxValue, out int ans)
    {
        int opt1, opt2, toggle;
        string question = " ";
        opt1= Random.Range (1,maxValue);
        opt2= Random.Range (1,maxValue);
        toggle = Random.Range(1, 3);
        switch(toggle)
        {
        case 1 :
        {
            question = $"Solve: {opt1} + {opt2}";
            answer = opt1 + opt2 ;
            break;
        }
        case 2 :
        {
            question = $"Solve: {opt1} - {opt2}";
            answer = opt1 - opt2 ;
            break;
        }
        }
        ans = 0;
        return question;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(questionGenerator (in range, out answer));

    }
}
