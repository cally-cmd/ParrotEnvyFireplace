using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set;}

    public GameObject dialogBox;
    public TextMeshProUGUI text;

    public void DialogShow(string s) {
        dialogBox.SetActive(true);
        StopAllCoroutines();
        StartCoroutine(TypeText(s));
    }

    IEnumerator TypeText(string s) {
        text.text = "";
        foreach (char c in s.ToCharArray()) {
            text.text += c;
            yield return new WaitForSeconds(0.02f);
        }
    }

    public void DialogHide() {
        dialogBox.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }

    }
}
