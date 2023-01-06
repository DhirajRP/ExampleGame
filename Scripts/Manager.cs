using UnityEngine;
using TMPro;
public class Manager : MonoBehaviour
{
        [SerializeField] TMP_Text textBox;
        [SerializeField] float answer;
        
    void Start()
   
    {
        int range = 100;
        textBox.text = questionGenerator(ref range);    
    }
    string questionGenerator(ref int maxValue)
    {
        int toggle;
        string question = " ";
        int opt1= Random.Range (1,maxValue);
        int opt2= Random.Range (1,maxValue);
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

        return question;
    }

    void Update()
    {
    
        
      
    }
}
