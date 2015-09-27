using UnityEngine;
using System.Collections;

public class LandscapeScroll : MonoBehaviour {

    public float speed = .05f;
    void Start()
    {
    }
    void Update()
    {
        Vector2 offset = new Vector2(Time.time * speed, 0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
