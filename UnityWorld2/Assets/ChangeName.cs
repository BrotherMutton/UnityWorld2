using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeName : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TMPro.TextMeshProUGUI myText = GetComponent<TextMeshProUGUI>();
        if (Input.GetKeyDown("space")) {
            myText.SetText("Hello World from Matthew Wisner");
            Debug.Log("Key pressed");
        }
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
        }
    }
}
