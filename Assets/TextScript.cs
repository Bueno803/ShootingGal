using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextScript : MonoBehaviour
{
    public float displayDuration = 10f; // Duration in seconds.

    private Text textMeshPro;
    private float displayTimer;

    private void Start()
    {
        textMeshPro = GetComponent<Text>();
        textMeshPro.enabled = true; // Show the text initially.
        displayTimer = displayDuration;
    }

    private void Update()
    {
        if (displayTimer > 0)
        {
            displayTimer -= Time.deltaTime;

            if (displayTimer <= 0)
            {
                textMeshPro.enabled = false; // Hide the text when the timer is up.
            }
        }
    }

    public void DisplayText(string message)
    {
        textMeshPro.text = message;
        textMeshPro.enabled = true; // Show the text.
        displayTimer = displayDuration;
    }
}
