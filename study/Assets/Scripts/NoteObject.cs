using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed; //눌릴 수 있는지
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    //화살표가 Activator에 닿으면 비활성화
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Activator")
        {
            canBePressed = true;
        }
    }

    //화살표가 Activator에서 벗어나면 활성화
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Activator")
        {
            canBePressed = false;
        }
    }
}
