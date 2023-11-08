using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public static ScoreController Instance;
    private static int _scoreValue;
    [SerializeField] private TextMeshProUGUI _score;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        _scoreValue = 0;
        _score.text = "Score: 0";
    }

    // Update is called once per frame
    public void IncreaseScore()
    {
        _scoreValue += 20;
        _score.text = $"Score:\n{_scoreValue}";
    }
}
