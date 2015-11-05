using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    [SerializeField]private int _highScore;
    [SerializeField]
    private Text text;

    // Use this for initialization
    void Start ()
    {
        _highScore = PlayerPrefs.GetInt("Score");
        text.text = "Your score is: " + _highScore;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
