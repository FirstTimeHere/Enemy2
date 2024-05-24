using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected EnemyMover Mover;

    private void Awake()
    {
        Mover = GetComponent<EnemyMover>();
    }

    public void GetTarget(Target target)
    {
        Mover.GetTargetFromSpawner(target);
    }

    public void GetVisionTarget(Vector3 targetPosition)
    {
        transform.LookAt(targetPosition);
    }
}
