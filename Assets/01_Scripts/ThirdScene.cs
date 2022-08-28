using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdScene : MonoBehaviour
{
    [SerializeField]
    private GameObject start_btn;
    [SerializeField]
    private GameObject back_btn;

    [SerializeField]
    private GameObject second_Scene, third_Scene, fourth_Scene;
    [SerializeField]
    private GameObject WaitingRoom;


    public void OnClickStart()
    {
        third_Scene.SetActive(false);
        WaitingRoom.SetActive(false);
        fourth_Scene.SetActive(true);
    }

    public void OnClickBack()
    {
        third_Scene.SetActive(false);
        second_Scene.SetActive(true);
    }
}
