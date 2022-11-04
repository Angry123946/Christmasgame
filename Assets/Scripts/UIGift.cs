using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIGift : MonoBehaviour
{
    private TextMeshProUGUI m_TextMeshProUGUI;
    private void Awake()
    {
        m_TextMeshProUGUI = GetComponent<TextMeshProUGUI>();
        
    }
    private void Update()
    {
        m_TextMeshProUGUI.text = Gift.giftcount.ToString();
    }
}
