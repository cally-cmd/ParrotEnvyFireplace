using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sign : MonoBehaviour
{
    public string text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D col) {
        print("Sign!");
        if (col.gameObject.CompareTag("Player")) {
            GameManager.Instance.DialogShow(text);
        }
    }

    public void OnTriggerExit2D(Collider2D col) {
        print("Bye sign!");
        if (col.gameObject.CompareTag("Player")) {
            GameManager.Instance.DialogHide(text);
        }
    }
}
