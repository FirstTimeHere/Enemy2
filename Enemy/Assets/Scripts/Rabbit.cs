using UnityEngine;

public class Rabbit : Enemy
{
    private Vector3 _scaleTouchTarget = new Vector3(0.1f, 0.1f, 0.1f);

    private bool _isTouchTarget;

    private void Awake()
    {
        Mover = GetComponent<EnemyMover>();
    }

    private void Update()
    {
        GetVisionTarget(Mover.Target.transform.position);

        if (_isTouchTarget)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, _scaleTouchTarget, Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.position == Mover.Target.transform.position)
        {
            _isTouchTarget = true;
        }
    }
}
