using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birds : MonoBehaviour
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

    void OnMouseOver() {
        if (GameManager.Instance.cantalk != true) {
            GameManager.Instance.DialogHide();
        } else {
        GameManager.Instance.DialogShow(text);
        GameManager.Instance.conversed = true;
        }//Delay();
    }

    IEnumerator Delay() {
        yield return new WaitForSeconds(10f);
    }
}
