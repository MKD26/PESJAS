using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float targetTime = 00.0f;
    public float roundTargetTime;
    public Text textfeld;

    public bool gameEnde;
    

    void Update()
    {
        if (gameEnde == false)
        {
            targetTime += Time.deltaTime;
            roundTargetTime = (Mathf.Round(targetTime));
            textfeld.text = roundTargetTime.ToString();
        }

        

    }

   


}

