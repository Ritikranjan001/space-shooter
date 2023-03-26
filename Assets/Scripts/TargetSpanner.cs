using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpanner : MonoBehaviour
{
    [SerializeField] GameObject Target;
    [SerializeField] Transform SpanPoint;
    [SerializeField] Vector3 SpanOffset;
    [SerializeField] float SpanInterval;

    bool ReadyToSpan = true;
    void Update()
    {
        if(ReadyToSpan)
        {
            ReadyToSpan = false;
            Invoke(nameof(SpanEnemy),SpanInterval);
        }
    }

    private void SpanEnemy()
    {
        float x = Random.Range(-SpanOffset.x , SpanOffset.x);
        float z = Random.Range(-SpanOffset.z , SpanOffset.z);
        Vector3 Offset = new Vector3(x, 0, z);
        Instantiate(Target, SpanPoint.position + Offset, Quaternion.identity);
        ReadyToSpan = true;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(SpanPoint.position, SpanOffset);
    }
}
