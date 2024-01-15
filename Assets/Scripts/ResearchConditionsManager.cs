using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Avatar2;
using Unity.VisualScripting;

//!!!// 31/05/2023 for salford demo, line 70 has been commented, when done, comment out and delete this

// The script controls whether the face and body of the avatar should be activated based
// on the values of the "activateFace" and "activateBody" variables.
// When either the face or body is not activated, the corresponding references to the
// OvrAvatarEntity component are set to null, and when they are activated,
// the references are set to the corresponding custom scripts.
// The tracking of the avatar is updated in each frame using the "CustomUpdateAvatarTracking" function
// from the OvrAvatarEntity component.

public class ResearchConditionsManager : MonoBehaviour
{
    public OvrAvatarEntity ovrAvatarEntity; // Reference to the OvrAvatarEntity component
    public OvrAvatarEntity remoteAvatarEntity;

    public SampleInputManager sampleInputManager; // Reference to the SampleInputManager component
    public SampleFacePoseBehavior sampleFacePoseBehavior; // Reference to the SampleFacePoseBehavior component
    public SampleEyePoseBehavior sampleEyePoseBehavior; // Reference to the SampleEyePoseBehavior component
    public OvrAvatarLipSyncContext ovrAvatarLipSyncContext; // Reference to the OvrAvatarLipSyncContext component
    private GameObject avatarSkin;
    public NetworkManager networkManager;
    public Transform ovrRIG;

    public bool activateFace; // Should the face be activated?
    public bool activateBody; // Should the body be activated?

    private bool oneTime;

    // Update is called once per frame
    private void Update()
    {
        if (ovrAvatarEntity.transform.childCount > 3 && !oneTime)
        {
            avatarSkin = ovrAvatarEntity.gameObject.transform.Find("AllLOD").transform.GetChild(0).gameObject; //get the skin of the player's avatar
            oneTime = true;
        }

        if (ovrAvatarEntity.transform.childCount > 3)
        {

            if (!activateBody)
            {
                ovrAvatarEntity._bodyTracking = null;
                ovrAvatarEntity.CustomUpdateAvatarTracking(); // Update the avatar tracking in a custom snippet from OVRAvatarEntity
                avatarSkin.layer = LayerMask.NameToLayer("HiddenMesh"); //player's avatar is invisible to user

                if (networkManager.clientID == 1)
                {
                    ovrAvatarEntity.transform.eulerAngles = new Vector3(0, 135, 0); //rotate the avatar to face the user
                    remoteAvatarEntity.transform.eulerAngles = new Vector3(0, -45, 0); //rotate the avatar to face the user
                }
                else if (networkManager.clientID == 2)
                {
                    ovrAvatarEntity.transform.eulerAngles = new Vector3(0, -45, 0); //rotate the avatar to face the user
                    remoteAvatarEntity.transform.eulerAngles = new Vector3(0, 135, 0); //rotate the avatar to face the user
                }
            }
            else
            {
                ovrAvatarEntity.transform.eulerAngles = ovrRIG.eulerAngles;

                if (networkManager.clientID == 1)
                {
                    //remoteAvatarEntity.transform.eulerAngles = new Vector3(0, 90, 0); //rotate the avatar to face the user
                }
                else if (networkManager.clientID == 2)
                {
                    remoteAvatarEntity.transform.eulerAngles = new Vector3(0, 0, 0); //rotate the avatar to face the user
                }

                ovrAvatarEntity._bodyTracking = sampleInputManager;
                ovrAvatarEntity.CustomUpdateAvatarTracking(); // Update the avatar tracking in a custom snippet from OVRAvatarEntity
                avatarSkin.layer = LayerMask.NameToLayer("Default"); // and visible again
            }

            if (!activateFace)
            {
                ovrAvatarEntity._facePoseBehavior = null;
                ovrAvatarEntity._eyePoseBehavior = null;
                ovrAvatarEntity._lipSync = null;

                ovrAvatarEntity.CustomUpdateAvatarTracking(); // Update the avatar tracking in a custom snippet from OVRAvatarEntity
            }
            else
            {
                ovrAvatarEntity._facePoseBehavior = sampleFacePoseBehavior;
                ovrAvatarEntity._eyePoseBehavior = sampleEyePoseBehavior;
                ovrAvatarEntity._lipSync = ovrAvatarLipSyncContext;

                ovrAvatarEntity.CustomUpdateAvatarTracking(); // Update the avatar tracking in a custom snippet from OVRAvatarEntity
            }
        }
    }
}
