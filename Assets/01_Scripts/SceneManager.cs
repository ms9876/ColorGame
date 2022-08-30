using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    [SerializeField]
    private Button Start_btn;

    [SerializeField]
    private GameObject first_Scene, second_Scene, third_Scene, end_Scene;
    [SerializeField]
    private GameObject WaitingRoom;

    public void ClickStartBtn()
    {
        first_Scene.SetActive(false);
        second_Scene.SetActive(true);
    }

    public void ClickGoBtn()
    {
        second_Scene.SetActive(false);
        third_Scene.SetActive(true);
    }

    public void ClickEnd()
    {
        end_Scene.SetActive(false);
        first_Scene.SetActive(true);
    }
}
