using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEditor;

public class PaintingInteraction : XRBaseInteractable 
{
    public SceneAsset scene;

    void OnSelectEntering()
    {
        SceneManager.LoadScene(scene.name, LoadSceneMode.Additive);
    }
}
