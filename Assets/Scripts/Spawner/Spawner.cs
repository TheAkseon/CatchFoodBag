using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _foods;

    private int _randomFood;
    private Vector3 _randomPosition;

    [SerializeField] private float _startTimeBetweenSpawns = 0.001f;
    private float _timeBetweenSpawns;

    private void Start()
    {
        _timeBetweenSpawns = _startTimeBetweenSpawns;
    }

    private void Update()
    {
        if (_timeBetweenSpawns <= 0)
        {
            _randomPosition = new Vector3(Random.Range(-7, 7), transform.position.y, transform.position.z);
            _randomFood = Random.Range(0, _foods.Length);
            Instantiate(_foods[_randomFood], _randomPosition, Quaternion.identity);
            _timeBetweenSpawns = _startTimeBetweenSpawns;
        }
        else
        {
            _timeBetweenSpawns -= Time.deltaTime;
        }
    }
}
