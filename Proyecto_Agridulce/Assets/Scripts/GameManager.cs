using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Score Values")]
    [SerializeField] float _scorePerSecond;
    [SerializeField] float _scorePointsTime;
    [SerializeField] TextMeshProUGUI scoreTextUI;
    private float _score;
    float _timeToAddScore;

    private void Start()
    {
        
    }

    void Update()
    {

        if (Time.time > _timeToAddScore)
        {
            AddScore(_scorePerSecond);
            _timeToAddScore = Time.time + _scorePointsTime;
        }
        scoreTextUI.SetText(_score.ToString());

    }

    void AddScore(float moneyIndex)
    {
        _score += moneyIndex;
    }
}
