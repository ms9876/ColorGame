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
    private GameObject second_Scene, third_Scene, fourth_Scene, player, playScene;
    [SerializeField]
    private GameObject WaitingRoom;
    [SerializeField]
    private GameObject mouse;


    public void OnClickStart()
    {
        third_Scene.SetActive(false);
        WaitingRoom.SetActive(false);
        playScene.SetActive(true);
        fourth_Scene.SetActive(true);
        mouse.SetActive(false);
        player.SetActive(true);

    }

    public void OnClickBack()
    {
        third_Scene.SetActive(false);
        second_Scene.SetActive(true);
    }
}
