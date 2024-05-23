using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Transform[] _spawnTargetPoints;
    [SerializeField] private List<Enemy> _enemys = new List<Enemy>();
    [SerializeField] private List<Target> _targets = new List<Target>();

    [SerializeField][Range(0.1f, 10f)] private float _delay;
    [SerializeField][Range(1, 100)] private int _numbersOfEnemy;

    private List<Target> _targetCreated = new List<Target>();

    private void Awake()
    {
        for (int i = 0; i < _targets.Count; i++)
        {
            int randomIndexSpawnPoint = Random.Range(0, _spawnTargetPoints.Length);
            _targetCreated.Add(Instantiate(_targets[i], _spawnTargetPoints[randomIndexSpawnPoint].position, _spawnTargetPoints[randomIndexSpawnPoint].rotation));
        }
    }

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

        enemy.GetTarget(_targetCreated[randomTarget]);
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
