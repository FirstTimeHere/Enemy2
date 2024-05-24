using UnityEngine;

[RequireComponent(typeof(Target))]
public class TargetMover : MonoBehaviour
{
    private Vector3 _point;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _point, Time.deltaTime);
    }

    public void GetPoint(Transform point)
    {
        _point = point.transform.position;
    }
}
