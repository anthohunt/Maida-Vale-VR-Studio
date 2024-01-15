using Oculus.Interaction;
using Oculus.Interaction.HandGrab;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

// The script has references to other game objects and components in the scene,
// such as the Oculus camera rig, the passthrough portal, and a hand grab interactable.
// The script has a toggle to activate the passthrough camera and updates the hover indicator's color
// based on the number of interactors. The script also updates the passthrough collider
// based on whether the scene is frozen by the server or not.
public class PassthroughManager : MonoBehaviour
{
    // References to other game objects and components in the scene
    public OVRPassthroughLayer portalComponent;
    public GameObject passthroughPortal;
    public GameObject hoverIndicator;
    public HandGrabInteractable grabInteractable;
    public BoxCollider passthroughCollider;

    [Header("Server")]
    public MasterControl masterControl;

    [HideInInspector]
    public bool passthroughActive;

    public void SetPassthroughActive()
    {
        passthroughActive = true;
    }

    public void SetPassthroughInactive()
    {
        passthroughActive = false;

        if (passthroughPortal.activeInHierarchy)
        {
            passthroughPortal.SetActive(false);
            portalComponent.enabled = false;
        }
    }

    // Activates the Oculus passthrough camera feature
    public void ActivatePassthrough()
    {
        if(passthroughActive)
        {
            //Find the passthrough game object and make it active
            passthroughPortal.SetActive(true);

            // Find the OVRCameraRig game object and enable the OVRPassthroughLayer component
            portalComponent.enabled = true;
        }
    }

    public void Update()
    {
        if (masterControl.isFrozenByServer)
        {
            passthroughCollider.enabled = false;
        }
        else
        {
            passthroughCollider.enabled = true;
        }
    }

    public void UpdateHover()
    {
        if (grabInteractable.Interactors.Count == 1)
        {
            hoverIndicator.GetComponent<MeshRenderer>().material.color = Color.green;
        }
        if (grabInteractable.Interactors.Count == 2)
        {
            hoverIndicator.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}
