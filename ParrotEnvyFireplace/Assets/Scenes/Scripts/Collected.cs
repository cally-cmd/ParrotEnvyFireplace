using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collected : MonoBehaviour
{
    public string text;
    private string log;
    private string collected;

    // Start is called before the first frame update
    void Start()
    {
        log = " logs!";
        collected = "You have collected ";
        text = collected + GameManager.Instance.collection + log;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.collection == 1) {
            log = " log!";
        } else {
            log = " logs!";
        }

        if (GameManager.Instance.collection == 5) {
            collected = "You have collected all ";
        } else {
            collected = "You have collected ";
        }
        text = collected + GameManager.Instance.collection + log;
    }

    public void OnTriggerEnter2D(Collider2D col) {
        print("Sign!");
        if (col.gameObject.CompareTag("Player") && GameManager.Instance.conversed) {
            GameManager.Instance.DialogShow(text);
        }
    }

    public void OnTriggerExit2D(Collider2D col) {
        print("Bye sign!");
        if (col.gameObject.CompareTag("Player") && GameManager.Instance.conversed) {
            GameManager.Instance.DialogHide();
        }
    }
}
