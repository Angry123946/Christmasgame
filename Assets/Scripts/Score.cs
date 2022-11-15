using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;


public class Score : MonoBehaviour
{
    public static event Action OnScoreChange;
    

   
    public static float Points { get; private set; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(tag=="good")
        {
            Points = Points + 2;
            Gift.giftcount++;
            OnScoreChange?.Invoke();
            Destroy(collision.gameObject);
        }
        else
        {
            
            OnScoreChange?.Invoke();
            Destroy(collision.gameObject);
        }

        
    }
}


