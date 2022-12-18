using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Lose : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    public void Losee()
    {
        panel.SetActive(true);
        Time.timeScale = 0;
    }
}
