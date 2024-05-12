using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private List<Enemy> _enemys = new List<Enemy>();
    [SerializeField] private List<Transform> _targets = new List<Transform>();


    [SerializeField][Range(0.1f, 10f)] private float _delay;
    [SerializeField][Range(1, 100)] private int _numbersOfEnemy;

    private int _backRotation = -180;

    private void Start()
    {
        StartCoroutine(GetSpawnEnemy(_delay));
    }

    private void Spawn()
    {
        int randomValue = GetRandom(_spawnPoints);
        Enemy enemy = Instantiate(_enemys[randomValue], _spawnPoints[randomValue].position, _spawnPoints[randomValue].rotation);

        Vector3 direction;

        if (_spawnPoints[randomValue].localEulerAngles.y == _backRotation)
        {
            direction = Vector3.back;
        }
        else
        {
            direction = Vector3.forward;
        }

        enemy.GetTransform(direction);
    }

    private IEnumerator GetSpawnEnemy(float delay)
    {
        var wait = new WaitForSeconds(delay);

        while (_numbersOfEnemy > 0)
        {
            Spawn();
            _numbersOfEnemy--;
            yield return wait;
        }
    }

    private int GetRandom(Transform[] spawnPoints)
    {
        int randomValue = Random.Range(0, spawnPoints.Length);
        return randomValue;
    }
}
