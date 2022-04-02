using UnityEngine;
using UnityEngine.UI;

public class Ground : MonoBehaviour
{
    [SerializeField] private Text _gameHealth;
    [SerializeField] private GameObject _gamePanel;
    [SerializeField] private GameObject _losePanel;

    private int _health;

    private void Start()
    {
        _health = 15;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("BadFood"))
        {
            Destroy(collision.gameObject);
            if (collision.gameObject.CompareTag("GoodFood") == true)
            {
                _health = _health + 1;
            }
            _gameHealth.text = _health.ToString();
            if (_health == 3)
            {
                _gamePanel.SetActive(false);
                _losePanel.SetActive(true);
                Time.timeScale = 100;
            }
        }
    }
}
