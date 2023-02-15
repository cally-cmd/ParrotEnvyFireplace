using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour
{
    public GameObject wood;

    public GameObject sparkles;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D() {
        if (GameManager.Instance.conversed) {
            print("Collected");
            Destroy(wood);
            Instantiate(sparkles);
        }
    }
}
