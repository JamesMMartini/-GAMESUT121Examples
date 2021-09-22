using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberChanger : MonoBehaviour {

    public enum CountChanger { StageOne, StageTwo }
    public CountChanger countChanger = CountChanger.StageOne;

    public int counter;

    TMP_Text myText;

    private void Awake() {
        myText = GetComponent<TMP_Text>();
    }


    // Start is called before the first frame update
    void Start() {

    }

    void EnumCountChanger() {

        switch (countChanger) {

            case CountChanger.StageOne:
                counter += 1;
                break;

            case CountChanger.StageTwo:
                counter -= 1;
                break;

        }

    }


    // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown(KeyCode.Space)) {
            EnumCountChanger();
            myText.text = counter.ToString();
        }
        if (Input.GetKeyDown(KeyCode.S)) {

            if (countChanger == CountChanger.StageOne)
                countChanger = CountChanger.StageTwo;
            else
                countChanger = CountChanger.StageOne;

        }

    }
}
