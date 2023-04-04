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
            wood.SetActive(false);
            GameObject part = Instantiate(sparkles);
            part.transform.position = transform.position;
            GameManager.Instance.collection += 1;
        }
        if  (GameManager.Instance.collection == 5) {
            GameManager.Instance.RevealPit();
        }
        if (GameManager.Instance.collection > 5){
            GameManager.Instance.Restart();
            wood.SetActive(true);
        }
    }
}
