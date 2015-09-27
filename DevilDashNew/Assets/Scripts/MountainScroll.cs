using UnityEngine;
using System.Collections;

public class MountainScroll : MonoBehaviour {

    public float speed = .5f;
    void Start()
    {
    }
    void Update()
    {
        Vector2 offset = new Vector2(Time.time * speed, 0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
