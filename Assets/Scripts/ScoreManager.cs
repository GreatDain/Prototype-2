using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI _scoreText;
    [SerializeField] GameObject _speedUp;

    int _score = 0;
    int _currentScore = 0;

    public static ScoreManager _ScoreManager { get; private set; }

    public void AddScore(int Score, int Multiplier)
    {
        _score += Score * Multiplier;
        StopCoroutine(IncreaseScore());
        StartCoroutine(IncreaseScore());  
    }

    IEnumerator IncreaseScore()
    {
        while(_currentScore != _score)
        {
            _currentScore += 1;
            yield return new WaitForSeconds(0.1f);
            _scoreText.text = "Score: " + _currentScore.ToString();
        }
        yield return null;
    }

    IEnumerator DecreaseScore()
    {
        while (_currentScore > 0)
        {
            _currentScore -= 1;
            yield return new WaitForSeconds(0.002f);
            _scoreText.text = "Score: " + _currentScore.ToString();
        }
        yield return null;
    }

    public void ResetScore()
    {
        if (Time.timeSinceLevelLoad > 1f)
        {
            _speedUp.gameObject.SetActive(false);
            _score = 0;
            SoundManager.Manager.PlaySound(SoundManager.Manager.gameOver);
            StartCoroutine(DecreaseScore());
        }
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

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && Time.timeSinceLevelLoad > 1f)
        {
            _speedUp.gameObject.SetActive(true);
        }
    }
}
