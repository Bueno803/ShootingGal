using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    private Text countdownText;
    private float countdown = 100f;
    private bool countingDown = true; // Countdown starts immediately.

    private void Start()
    {
        countdownText = GetComponent<Text>();
        countdownText.text = "100";
    }

    private void Update()
    {
        if (countingDown)
        {
            if (countdown > 0)
            {
                countdown -= Time.deltaTime;
                countdownText.text = Mathf.Max(Mathf.Round(countdown), 0).ToString();
            }
            else
            {
                countdownText.text = "0";
                countingDown = false;
            }
        }
    }
}
