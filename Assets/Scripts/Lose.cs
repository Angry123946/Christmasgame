using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Lose : MonoBehaviour
{
    private void Awake()
    {
        GameObject panel = GetComponent<Panel>();
    }
    public void Losee()
    {
        panel.SetActive(true);
        Time.timeScale = 0;
    }
}
