using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Score Values")]
    [SerializeField] float _scorePassivePoints;
    [SerializeField] float _timerToAddScorePoints;
    [SerializeField] TextMeshProUGUI scoreTextUI;
    private float _score;
    float _timerScore;

    private void Start()
    {
        
    }

    void Update()
    {

        if (Time.time > _timerScore)
        {
            AddScore(_scorePassivePoints);
            _timerScore = Time.time + _timerToAddScorePoints;
        }
        scoreTextUI.SetText(_score.ToString());

    }

    void AddScore(float moneyIndex)
    {
        _score += moneyIndex;
    }
}
