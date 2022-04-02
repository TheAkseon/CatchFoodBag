using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour 
{
    [SerializeField] private Text _gameScore;
    [SerializeField] private Text _loseScore;
    [SerializeField] private GameObject _gamePanel;
    [SerializeField] private GameObject _victoryPanel;

    private int _score;

    private void Start()
    {
        _score = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Destroy(collision.gameObject);

            _score = _score + 1;

            _gameScore.text = _score.ToString();
            _loseScore.text = _score.ToString();
            if (_score == 10)
            {
                _gamePanel.SetActive(false);
                _victoryPanel.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
