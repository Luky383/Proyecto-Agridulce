using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    private float _currentScore;
    [SerializeField] float _scorePointsPerSecond;
    [SerializeField] TextMeshPro scoreTextUI;

    void Start()
    {
        
    }

    void Update()
    {
        _currentScore += _scorePointsPerSecond * Time.deltaTime;
    }
}
