using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private List<Enemy> _enemys = new List<Enemy>();
    [SerializeField] private List<Target> _targets = new List<Target>();


    [SerializeField][Range(0.1f, 10f)] private float _delay;
    [SerializeField][Range(1, 100)] private int _numbersOfEnemy;

    private void Start()
    {
        StartCoroutine(GetSpawnEnemy(_delay));
    }

    private void Spawn()
    {
        int randomTransform = GetRandom(_spawnPoints.Length);
        int randomEnemy = GetRandom(_enemys.Count);
        int randomTarget = GetRandom(_targets.Count);

        Enemy enemy = Instantiate(_enemys[randomEnemy], _spawnPoints[randomTransform].position, _spawnPoints[randomTransform].rotation);

        Vector3 direction = _targets[randomTarget].transform.position;

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

    private int GetRandom(int maxValue)
    {
        int randomValue = Random.Range(0, maxValue);
        return randomValue;
    }
}
