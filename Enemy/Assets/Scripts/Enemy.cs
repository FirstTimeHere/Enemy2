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
        GetVisionTarget(TargetPosition);
    }

    protected virtual void GetVisionTarget(Vector3 targetPosition)
    {
        this.transform.LookAt(targetPosition);
    }
}
