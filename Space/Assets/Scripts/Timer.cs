using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading;

public class Timer : MonoBehaviour
{
    public float timer;
    private float startTime = 60f;
    public TextMeshProUGUI timerText;
    private int t;
    private void Start()
    {
        timerText.text = "Timer:" + timer.ToString();
    }
    void Update()
    {
        if (timer < startTime)
        {
            timer += Time.deltaTime;
            float remainingTime = startTime - timer;
            int intrmainingTime = (int)remainingTime;
            t = intrmainingTime;
            timerText.text = "Timer:" + t.ToString();
        }
    }
}
