using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIClickMC : EventTrigger
{
    Color initColor;// = GetComponent<Image>().color;
    // Start is called before the first frame update
    void Start()
    {
        initColor = GetComponent<Image>().color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnPointerDown(PointerEventData eventData) 
    {
        if (this.name == "btnCorrect")
        {
            GetComponent<Image>().color = Color.green;
        }
        else {
            GetComponent<Image>().color = Color.red;
        }
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        GetComponent<Image>().color = initColor;
    }
}
