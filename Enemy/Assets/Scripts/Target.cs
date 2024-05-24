using UnityEngine;

public class Target : MonoBehaviour
{
    protected TargetMover TargetMover;

    private Animator _animator;

    private void Awake()
    {
        TargetMover = GetComponent<TargetMover>();
        _animator = GetComponent<Animator>();
        _animator.enabled = false;
    }

    public void GetPoint(Transform transformPoint)
    {
        TargetMover.GetPoint(transformPoint);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject)
        {
            _animator.enabled = true;
        }
    }
}
