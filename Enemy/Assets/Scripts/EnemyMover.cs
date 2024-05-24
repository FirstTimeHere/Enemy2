using UnityEngine;

[RequireComponent(typeof(Enemy))]

public class EnemyMover : MonoBehaviour
{
    public Target Target { get; private set; }

    private int _speed;
    private int _maxSpeed = 5;

    private Enemy _enemy;

    private void Awake()
    {
        _enemy = GetComponent<Enemy>();
        _speed = Random.Range(0, _maxSpeed);
    }

    private void Update()
    {
        _enemy.GetVisionTarget(Target.transform.position);
        transform.position = Vector3.MoveTowards(transform.position, Target.transform.position, _speed * Time.deltaTime);
    }

    public void GetTargetFromSpawner(Target target)
    {
        Target = target;
    }
}
