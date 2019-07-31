using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI _scoreText;

    int _score = 0;

    public static ScoreManager _ScoreManager { get; private set; }

    public void AddScore(int Score, int Multiplier)
    {
        _score += Score * Multiplier;
        _scoreText.text = _score.ToString();
    }

    void Awake()
    {
        if(_ScoreManager == null)
                _ScoreManager = this;
        AddScore(0, 0);
    }

    void Update()
    {
        
    }
}
