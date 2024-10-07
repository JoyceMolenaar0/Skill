using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    [SerializeField]TextMeshProUGUI CountdownTekst;
    private float ElapsedTime;
    private float TimerCount = 5;
    
    void Start()
    {
        ElapsedTime = 0;
        UpdateText();
    }

    // Update is called once per frame
    void Update()
    { 
        ElapsedTime += Time.deltaTime;

        if (ElapsedTime > 1)
        {
            UpdateText();
            
        }
    }

    void UpdateText()
    {
        TimerCount -= 1f;
        CountdownTekst.text = "00:0" + TimerCount;
        ElapsedTime = 0f;

        if (TimerCount < 0 || TimerCount ==0 )
        {
            
        }
    }
}
