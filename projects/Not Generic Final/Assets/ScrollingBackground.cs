using UnityEngine;
using System.Collections;

public class ScrollingBackground : MonoBehaviour {

    float scrollSpeed = -5f;
    Vector2 startPos;

	// Use this for initialization
	void Start () {
        startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        float newPos = Mathf.Repeat(Time.time * scrollSpeed, 20);
        transform.position = startPos + Vector2.right * newPos;
	}
}
