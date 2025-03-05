using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroller : MonoBehaviour
{
    public float beatTempo; //화살표 하강 속도
    public bool hasStarted; //게임이 시작되었는지
    
    void Start()
    {
        beatTempo = beatTempo / 60f; //1초에 몇번 비트가 떨어지는지
    }

    void Update()
    {
        if(!hasStarted) //게임이 시작되지 않았다면
        {
            if(Input.anyKeyDown) //아무 키나 누르면
            {
                hasStarted = true; //게임 시작
            }
        }
        else //게임이 시작되었다면
        {
            //화살표를 아래로 이동
            transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
        }
    }
}
