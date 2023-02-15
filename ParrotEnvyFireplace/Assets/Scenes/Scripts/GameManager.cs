using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set;}
    private AudioSource audio;
    public GameObject button;
    public bool conversed;
    public GameObject dialogBox; // <a href=https://www.pngmart.com/image/53302 target="_blank">Text Box Frame PNG Transparent Image</a>
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
            yield return new WaitForSeconds(0.05f);
        }
        yield return new WaitForSeconds(10f);
        DialogHide();
    }

    public void DialogHide() {
        dialogBox.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        conversed = false;
        dialogBox.SetActive(false);
        audio = GetComponent<AudioSource>();
        
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
    IEnumerator Sound(){
        audio.Play();
        yield return new WaitForSeconds(audio.clip.length);
    }

    public void StartGame(){
        button.gameObject.SetActive(false);
        //StartCoroutine("Sound");
}
}
