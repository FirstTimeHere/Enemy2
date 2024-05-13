using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Vector3 TargetPosition {  get; private set; }

    public void GetTransform(Vector3 transformDirection)
    {
        TargetPosition = transformDirection;
    }

    private void Update()
    {
        GetVisionTarget();
    }

    protected virtual void GetVisionTarget()
    {
        this.transform.LookAt(TargetPosition);
    }
}
