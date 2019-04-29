using UnityEngine;

public class MatchMovement : MonoBehaviour
{
    public Transform source;
    public float scale = 5f;

    private Vector3 pos;
    private Vector3 sourcePos;

    void Start()
    {
        if (source != null)
        {
            pos = transform.position;
            sourcePos = source.position;
        }
    }

    void Update()
    {
        if (source != null)
        {
            transform.position = pos + (sourcePos - source.position) * scale;
        }
    }
}
