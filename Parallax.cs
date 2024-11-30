using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float len, stpos;
    public GameObject cam;
    public float parallaxEffect;

    void Start()
    {
        stpos = transform.position.x;
        len = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void FixedUpdate()
    {
        float objectMoveMultiplier = (cam.transform.position.x * parallaxEffect);

        transform.position = new Vector3(stpos + objectMoveMultiplier, transform.position.y, transform.position.z);

        if (cam.transform.position.x > stpos + len * 0.9 + objectMoveMultiplier) stpos += len;
        else if (cam.transform.position.x < stpos - len * 0.9 + objectMoveMultiplier) stpos -= len;
    }
}
