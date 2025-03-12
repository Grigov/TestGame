using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cumera : MonoBehaviour
{
    public Transform target;
    public float CameraOffset = -10f;

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 targetPos = target.transform.position;
        transform.position = new Vector3(target.position.x, target.position.y, CameraOffset);
    }
}
