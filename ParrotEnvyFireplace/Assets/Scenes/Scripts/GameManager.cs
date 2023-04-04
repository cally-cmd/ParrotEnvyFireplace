using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set;}
    public GameObject button;
    public GameObject fire;
    public GameObject pit;
    public GameObject audio;
    public bool conversed;
    public int collection;
    public GameObject dialogBox; // <a href=https://www.pngmart.com/image/53302 target="_blank">Text Box Frame PNG Transparent Image</a>
    public TextMeshProUGUI text;
    public bool cantalk;

    public void DialogShow(string s) {
        dialogBox.SetActive(true);
        StopAllCoroutines();
        StartCoroutine(TypeText(s));
    }

    public void RevealPit() {
        fire.SetActive(true);
        pit.SetActive(true);
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

    public void StartGame() {
        cantalk = true;
        button.gameObject.SetActive(false);
        pit.SetActive(false);
        fire.SetActive(false);
        audio.SetActive(true);
    }

    public void Restart(){
        button.SetActive(true);
        GameManager.Instance.Start();

    }

    // Start is called before the first frame update
    void Start()
    {
        conversed = false;
        dialogBox.SetActive(false);
        pit.SetActive(false);
        collection = 0;
        fire.SetActive(false);
        audio.SetActive(false);
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
