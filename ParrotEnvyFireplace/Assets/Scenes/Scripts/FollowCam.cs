using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public float bound;
    public GameObject sprite;

    public float easing;

    private float lBound;
    private float rBound;
    private float uBound;
    private float dBound;
    // Start is called before the first frame update
    void Start()
    {
        lBound = bound * Camera.main.pixelWidth;
        rBound = Camera.main.pixelWidth - lBound;
        dBound = bound * Camera.main.pixelHeight;
        uBound = Camera.main.pixelHeight - dBound;
    }

    void FixedUpdate() {
        if (sprite) { // Does this check to see if the sprite does not have a Null value?
            Vector3 sPos = Camera.main.WorldToScreenPoint(sprite.transform.position);
            Vector3 pos = transform.position;

            if (sPos.x < lBound) {
                pos.x -= lBound - sPos.x;
            } else if (sPos.x > rBound) {
                pos.x += sPos.x - rBound;
            }

            if (sPos.y < dBound) {
                pos.y -= dBound - sPos.y;
            } else if (sPos.y > uBound) {
                pos.y += sPos.y - uBound;
            }

            pos = Vector3.Lerp(transform.position, pos, easing);

            transform.position = pos;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
