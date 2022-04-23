using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEditor;

public class PaintingInteraction : XRBaseInteractable 
{
    public SceneAsset scene;

    protected override void OnSelectEntering(SelectEnterEventArgs args)
    {
        Debug.Log("Interacting with painting");
        SceneManager.LoadScene(scene.name);
    }

    protected override void OnHoverEntering(HoverEnterEventArgs args)
    {
        Debug.Log("Hovering painting");
    }
}
