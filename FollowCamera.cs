using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField]
    Camera camera;

    // Update is called once per frame
    void Update()
    {
        Vector3 dist = new Vector3(0f, 0f, 0.5f);
        transform.position = camera.transform.position + dist;       
    }
}
