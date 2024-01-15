using Oculus.Avatar2;
using Oculus.Platform.Samples.VrHoops;
using System;
using System.Diagnostics;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

//The script measures the latency of the data streaming
//of the application. It has variables for tracking the one-way latency, whether or not the latency measurement
//has started and received data. The latency is calculated and displayed if the return data has been received.
//The script also has methods for confirming the one-way and return data receptions.

public class FPSLatencyMeasurement : MonoBehaviour
{
    public Stopwatch stopwatchDataStreaming = new Stopwatch();
    public double latency = 0;
    public MasterControl masterControl;
    public AvatarManager avatarManager;

    [Header("Latency")]
    public double avatarStreamOneWayLatency;
    public int localTimer;

    public OvrAvatarEntity dummyAvatarEntity; // Reference to the dummy latency OvrAvatarEntity component

    public byte[] latencyOneWayData = new byte[23]; // set to a random value that oculus SDK is unlikely to choose
    public byte[] latencyReturnData = new byte[23]; // set to a random value that oculus SDK is unlikely to choose
    public byte[] tempLatencyRemoteStreamData = new byte[23];
    public byte[] latencyRemoteStreamData = new byte[23];


    public bool hasStartedMeasuringLatency;
    public bool hasFinishedMeasuringLatency;

    [Header("FPS")] 
    //public TextMeshProUGUI fpsText;
    public int fps;
    private float deltaTime = 0.0f;

    void FixedUpdate()
    {
        ////bug: to reinitialise latency measurement, the condition is to receive the return dummy latency packet
        ////but if the data content is the same than the previous one, it will not update the boolean,
        ////so this is a little hack, considering past 100 frames, the latency packet should be back already
        //if (hasStartedMeasuringLatency == true && localTimer > 101)
        //{
        //    hasStartedMeasuringLatency = false;
        //}

        if (masterControl.readyToStream)
        {

            //once it reaches 100, start the latency measurement
            if (hasStartedMeasuringLatency == false)
            {

                latencyOneWayData = new byte[23];
                latencyReturnData = new byte[23];
                tempLatencyRemoteStreamData = new byte[23];
                latencyRemoteStreamData = new byte[23];

                //localTimer++;
                //if(localTimer > 99) //every 2 seconds
                //{
                    //start timer (stopped in FPSLatencyMeasurement.cs)
                    stopwatchDataStreaming.Start();

                    // Record the movement from the player's avatar as a dummy data and send to server
                    latencyOneWayData = avatarManager.playerAvatarEntity.RecordStreamData(OvrAvatarEntity.StreamLOD.Low);

                    //out of the loop
                    hasStartedMeasuringLatency = true;

                //    //reinitialise timer to 0
                //    localTimer = 0;
                //}
            }

            // true when the remote latency data has arrived
            if (tempLatencyRemoteStreamData.Length != 23)
            {
                // Apply the latency stream packet to the dummy latency avatar
                dummyAvatarEntity.ApplyStreamData(tempLatencyRemoteStreamData);
                latencyRemoteStreamData = avatarManager.playerAvatarEntity.RecordStreamData(OvrAvatarEntity.StreamLOD.Low);
            }

            //true when return latency data has arrived
            if (latencyReturnData.Length != 23)
            {
                dummyAvatarEntity.ApplyStreamData(latencyReturnData);
                stopwatchDataStreaming.Stop();
                hasFinishedMeasuringLatency = true;
            }

            if(hasFinishedMeasuringLatency)
            {
                latency = stopwatchDataStreaming.ElapsedMilliseconds / 2;

                stopwatchDataStreaming.Reset();

                hasStartedMeasuringLatency = false;
                hasFinishedMeasuringLatency = false;
            }
        }

    }

    private void Update()
    {
        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;

        //calculate FPS at this frame
        fps = Mathf.RoundToInt(1.0f / deltaTime);

        // update the text of the TextMeshProUGUI component
       // fpsText.text = "FPS: " + fps.ToString();
    }
}
