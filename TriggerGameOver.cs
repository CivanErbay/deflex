using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGameOver : MonoBehaviour
{
    public GameObject GameOverScrn;
    private int countdown;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        countdown = PlayerPrefs.GetInt("Countdown");
        Debug.Log(countdown);
        Debug.Log("blub");
        if (countdown == 0)
        {
            Debug.Log("true");
            GameOverScrn.SetActive(true);
        }
    }
}
