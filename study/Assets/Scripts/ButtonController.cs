using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private SpriteRenderer theSR;
    public Sprite defaultImage; //안눌린 버튼
    public Sprite pressedImage; //눌린 버튼

    public KeyCode keyToPress; //눌러야할 키
    
    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(Input.GetKeyDown(keyToPress)) //키를 누르게되면
        {
            theSR.sprite = pressedImage; //눌린 키의 이미지로 바꿔줌
        }

        if(Input.GetKeyUp(keyToPress)) //키를 뗐을때
        {
            theSR.sprite = defaultImage; //다시 기본 이미지로 바꿔줌
        }
    }
}
