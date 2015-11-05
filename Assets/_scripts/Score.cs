using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    private int score;
    private int addScore;
    [SerializeField]
    private Text _text;

    void Start()
    {
        score = 0;
    }

    public void ScoreIncrease(int scoreValueOfObject)
    {
        score += scoreValueOfObject;
        PlayerPrefs.SetInt("Score", score);
        Debug.Log(score);
    }

    void Update()
    {
        _text.text = "Score: " + score;
    }
}
