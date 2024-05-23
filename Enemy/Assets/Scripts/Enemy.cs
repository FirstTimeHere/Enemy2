using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected Target Target;

    private void Update()
    {
        GetVisionTarget(Target.transform.position);
    }

    public void GetTarget(Target target)
    {
        Target = target;
    }

    protected virtual void GetVisionTarget(Vector3 targetPosition)
    {
        this.transform.LookAt(targetPosition);
    }

    public virtual Vector3 GetTargetPosition()
    {
        return Target.transform.position;
    }
}
