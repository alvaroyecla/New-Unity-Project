using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    /*
     * Variables
     * 
     */

    public float maxTime = 10f;
    private float countdown = 0f;


    // Start is called before the first frame update
    void Start()
    {
        countdown = maxTime;   
    }

    // Update is called once per frame
    void Update()
    {
        countdown = countdown - Time.deltaTime;

      //  Debug.Log(countdown);

        if(countdown <= 0)
        {
            Debug.Log("Has palmado");

            Coin.coinsCounter = 0;

            SceneManager.LoadScene("MainScene");

            
        }

    }
}
