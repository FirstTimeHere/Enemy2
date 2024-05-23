using UnityEngine;

[RequireComponent(typeof(Target))]
public class TargetMover : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }
}
