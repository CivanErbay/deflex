using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownScript : MonoBehaviour
{
    public float countdown = 10f;
    public int countdownDisplay;
    public Text countdownText;

    // Start is called before the first frame update
    void Start()
    {
        countdownText = gameObject.GetComponent<Text>();
        countdownText.text = "Countdown: " + countdownDisplay;
    }

    // Update is called once per frame
    void Update()
    {
        // if(countdown == 0)
        countdown -= Time.deltaTime;
        countdownDisplay = Mathf.RoundToInt(countdown);
        countdownText.text = "Countdown: " + countdownDisplay;
        PlayerPrefs.SetInt("Countdown", countdownDisplay);
    }
}
