using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Target _target;
    //public Vector3 TargetPosition { get; private set; }

    //public void GetTransform(Vector3 transformDirection)
    //{
    //    TargetPosition = transformDirection;
    //}

    //private void Awake()
    //{
    //    _target = GetComponent<Target>();
    //    GetTarget(_target);
    //}

    private void Update()
    {
        GetVisionTarget(_target.transform.position);
    }

    public void GetTarget(Target target)
    {
        _target = target;
    }

    protected virtual void GetVisionTarget(Vector3 targetPosition)
    {
        this.transform.LookAt(targetPosition);
    }

    public virtual Vector3 GetTargetPosition()
    {
        return _target.transform.position;
    }
}
