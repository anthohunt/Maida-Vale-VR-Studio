using Oculus.Avatar2;
using Oculus.Interaction.Input;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using System.Diagnostics;
using UnityEngine;

//The script tracks the positions and rotations of various body parts of the player's avatar and
//the remote avatar, including the head, chest, hands, and gaze.
//It also includes latency measurement functionality and can freeze the player's movement
//if instructed by a server.
//The script also has functions for initializing the positions of both the player and the remote player.

public class AvatarManager : MonoBehaviour
{
    [Header("Server")]
    public MasterControl masterControl;
    public Transform cameraRig;
    [HideInInspector]
    public Vector3 serverCameraPosition;
    [HideInInspector]
    public Vector3 serverCameraRotation;

    [Header("OVR")]
    public GameObject oVRRig;
    public OVRManager oVRManager;
    [HideInInspector]
    public bool userIsPresent; // True if the user is present in the Oculus headset

    [Header("Avatar")]
    public OvrAvatarEntity playerAvatarEntity;
    public OvrAvatarEntity remoteAvatarEntity;
    [HideInInspector]
    public byte[] streamData; // Stream data for the player's avatar
    [HideInInspector]
    public byte[] remoteAvatarStreamData; // Stream data for the remote avatar

    [Header("Head")]
  //  [HideInInspector]
    public Vector3 headPosition; // Position of the player's head
  //  [HideInInspector]
    public Vector3 headRotation; // Rotation of the player's head

    //[Header("Chest")]
    //[HideInInspector]
    //public Vector3 chestPosition; // Position of the player's chest
    //[HideInInspector]
    //public Vector3 chestRotation; // Rotation of the player's chest

    [Header("Left Hand")]
  //  [HideInInspector]
    public Vector3 leftHandPosition; // Position of the player's left hand
  //  [HideInInspector]
    public Vector3 leftHandRotation; // Rotation of the player's left hand

    [Header("Right Hand")]
//    [HideInInspector]
    public Vector3 rightHandPosition; // Position of the player's right hand
 //   [HideInInspector]
    public Vector3 rightHandRotation; // Rotation of the player's right hand

    [Header("Gaze")]
 //   [HideInInspector]
    public Vector3 gazeRotation; // Rotation of the player's gaze direction

    //[Header("Latency measurement")]
    //public FPSLatencyMeasurement latencyMeasurement; // Reference to the LatencyMeasurement script
    //public OvrAvatarEntity dummyAvatarEntity; // Reference to the dummy latency OvrAvatarEntity component
    //[HideInInspector]
    //public byte[] latencyStreamData;
    //[HideInInspector]
    //public byte[] latencyRemoteStreamData;

    [Header("Other")]
    public TestDummyData testDummyData;
    public OVRFaceExpressions faceAnalyser;

    [Header("References")]
    public Transform pos1;
    public Transform pos2;

    void FixedUpdate()
    {
        if (oVRManager.isUserPresent)
        {
            userIsPresent = true;
        }
        else if (oVRManager.isUserPresent == false)
        {
            userIsPresent = false;
        }

        //once the Avatar joints/childs are loaded correctly
        if (playerAvatarEntity.transform.childCount > 3)
        {
            #region Avatar record/stream

            if (!testDummyData.isActiveAndEnabled) //if true, data is overriden by the TestDummyData script
            {
                // Get the positions and rotations of the player's body parts
                headPosition = GameObject.Find("CenterEyeAnchor").transform.localPosition;
                headRotation = GameObject.Find("CenterEyeAnchor").transform.localEulerAngles;

                //chestPosition = playerAvatarEntity.transform.Find("Joint Chest").transform.position;
                //chestRotation = playerAvatarEntity.transform.Find("Joint Chest").transform.eulerAngles;

                leftHandPosition = GameObject.Find("LeftHandAnchor").transform.localPosition;
                leftHandRotation = GameObject.Find("LeftHandAnchor").transform.localEulerAngles;

                rightHandPosition = GameObject.Find("RightHandAnchor").transform.localPosition;
                rightHandRotation = GameObject.Find("RightHandAnchor").transform.localEulerAngles;

                // Get the player's gaze rotation
                gazeRotation = GameObject.Find("GazeDirectionIndicator").transform.localEulerAngles;
            }

            // Record the movement from the player's avatar as a binary snapshot
            streamData = playerAvatarEntity.RecordStreamData(OvrAvatarEntity.StreamLOD.Low);

            // confirmation from server
            if (masterControl.readyToStream)
            {
                // Apply the stream data to the remote avatar
                remoteAvatarEntity.ApplyStreamData(remoteAvatarStreamData);
            }

            #endregion Avatar record/stream

            //#region Latency measurement

            //if (masterControl.readyToStream)
            //{
            //    latencyMeasurement.localTimer++;

            //    //once it reaches 100, start the latency measurement
            //    if (latencyMeasurement.hasStartedMeasuringLatency == false && latencyMeasurement.localTimer > 99)
            //    {
            //        //start timer (stopped in FPSLatencyMeasurement.cs)
            //        latencyMeasurement.stopwatchDataStreaming.Start();
                    
            //        // Record the movement from the player's avatar as a dummy data for latency measurement
            //        latencyStreamData = playerAvatarEntity.RecordStreamData(OvrAvatarEntity.StreamLOD.Low);

            //        //status: measurement has started, conditions for if statements are now invalid
            //        latencyMeasurement.hasStartedMeasuringLatency = true;

            //        //reinitialise timer to 0
            //        latencyMeasurement.localTimer = 0;
            //    }

            //    // true when the remote latency data has arrived
            //    if (latencyMeasurement.hasReceivedOneWayData)
            //    {
            //        // Apply the latency stream packet to the dummy latency avatar
            //        dummyAvatarEntity.ApplyStreamData(latencyRemoteStreamData);

            //        //will be true again when the new latency stream packet has arrived
            //        latencyMeasurement.hasReceivedOneWayData = false;
            //    }
            //}
            //#endregion Latency measurement
        }

        // If the server is freezing the player's movement, update the OVR camera rig's position based on the server's camera position
        if (masterControl.isFrozenByServer)
        {
            cameraRig.position = serverCameraPosition;
            cameraRig.eulerAngles = serverCameraRotation;
        }
    }

    //this function is called when selecting user to reinitialise osc message, which will send true to server
    public void UpdatePresence()
    {
        userIsPresent = false;
    }

    // Initialise the positions of the player and the remote player for client 1
    public void InitialisePositionsForClient1()
    {
        oVRRig.transform.position = pos1.position;
        oVRRig.transform.rotation = pos1.rotation;

        remoteAvatarEntity.transform.position = pos2.position;
        remoteAvatarEntity.transform.rotation = pos2.rotation;
    }

    // Initialise the positions of the player and the remote player for client 2
    public void InitialisePositionsForClient2()
    {
        oVRRig.transform.position = pos2.position;
        oVRRig.transform.rotation = pos2.rotation;

        remoteAvatarEntity.transform.position = pos1.position;
        remoteAvatarEntity.transform.rotation = pos1.rotation;
    }
}
