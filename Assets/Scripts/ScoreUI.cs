using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;



public sealed class ScoreUI : MonoBehaviour
{
    private TextMeshProUGUI textMesh;



    private void Awake()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        UpdateScore();
        Score.OnScoreChange += UpdateScore;
    }

    private void UpdateScore()
    {
        textMesh.text = Score.Points.ToString();
    }

    private void OnDestroy()
    {
        Score.OnScoreChange -= UpdateScore;
    }
}