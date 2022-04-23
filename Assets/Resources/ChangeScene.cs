using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.XR.Interaction.Toolkit;

public class ChangeScene : EventTrigger
{
    public void LoadScene()
    {
        SceneManager.LoadScene("ninja", LoadSceneMode.Additive);
    }

    public void Debugging()
    {
        Debug.Log("Hovering Painting!");
    }
}
