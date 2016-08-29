using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public int score
    {
        get
        {
            return _score;
        }
        set
        {
            _score = value;
            UpdateText();
        }
    }

    private int _score = 0;

    private void UpdateText()
    {
        GetComponent<Text>().text = "Score: " + _score;
    }
}
