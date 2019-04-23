using UnityEngine;

[ExecuteInEditMode]
public class LookAt : MonoBehaviour
{
    public Transform target;
    public bool maintainDistance;
    public float distance = 10f;

    void LateUpdate()
    {
        if (target != null)
        {
            transform.LookAt(target);
            if (maintainDistance)
            {
                var _dist = Vector3.Distance(transform.position, target.position);
                if (_dist < distance)
                {
                    transform.position += (transform.position - target.position).normalized * (distance - _dist);
                }
            }
        }
    }
}
