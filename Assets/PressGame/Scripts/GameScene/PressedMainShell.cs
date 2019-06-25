using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressedMainShell : Shell
{
    public PressedData pressedData;
    public BGData bgData;
    
    protected override void Awake() {
        base.Awake();
        pressedData = GetComponent<PressedData>();
        bgData = GameObject.Find("BG").GetComponent<BGData>();
    }
    private void Update() {
        if (Input.GetMouseButtonDown(0)&&pressedData.clicked==false) {
            Collider2D col = Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition));
            if (col != null && col == GetComponent<BoxCollider2D>()) {
                ClickOn();
            }
        }
        if (Input.GetMouseButtonUp(0)&&pressedData.clicked) {
            ClickOff();
        }
        if (pressedData.clicked && pressedData.currentSize == 0) {
            CreateDeal<DestroyDeal>(pressedData);
        }
    }

    public void ClickOn() {
        CreateDeal<PressedClickDeal>(new List<Data>{
            pressedData,bgData
        });
    }
    public void ClickOff() {
        PressedClickDeal tempDeal =
        CreateDeal<PressedClickDeal>(new List<Data>{
            pressedData,bgData
        });
        tempDeal.isDown = false;
    }
}
