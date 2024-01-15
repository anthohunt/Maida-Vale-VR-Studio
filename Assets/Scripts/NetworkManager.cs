using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using UnityEngine;
using extOSC;
using extOSC.Components.Informers;
using extOSC.Components.ReceiverReflections;
using extOSC.Components.Events;

public class NetworkManager : MonoBehaviour
{
    [HideInInspector]
    public float clientID;

    public string serverIP = null;

    [Header("OSC Transmitters")]
    public OSCTransmitter toServer; 

    public OSCTransmitterInformerString timeStamp;
    
    public OSCTransmitterInformerInt fPS;

    public OSCTransmitterInformerBool userIsPresent;

    public OSCTransmitterInformerBlob oneWayLatency;
    public OSCTransmitterInformerBlob returnLatency;
    public OSCTransmitterInformerBlob resetLatency;

    public OSCTransmitterInformerBlob avatarStream;
    
    public OSCTransmitterInformerVector3 headPos;
    public OSCTransmitterInformerVector3 headRot;

    public OSCTransmitterInformerVector3 chestPos;
    public OSCTransmitterInformerVector3 chestRot;

    public OSCTransmitterInformerVector3 leftHandPos;
    public OSCTransmitterInformerVector3 leftHandRot;

    public OSCTransmitterInformerVector3 rightHandPos;
    public OSCTransmitterInformerVector3 rightHandRot;

    public OSCTransmitterInformerVector3 gazeRot;

    public OSCTransmitterInformerFloat browLowererLeft;
    public OSCTransmitterInformerFloat browLowererRight;

    public OSCTransmitterInformerFloat innerBrowRaiserLeft;
    public OSCTransmitterInformerFloat innerBrowRaiserRight;

    public OSCTransmitterInformerFloat outerBrowRaiserLeft;
    public OSCTransmitterInformerFloat outerBrowRaiserRight;

    public OSCTransmitterInformerFloat lipCornerPullerLeft;
    public OSCTransmitterInformerFloat lipCornerPullerRight;

    public OSCTransmitterInformerVector3 passthroughPos;
    public OSCTransmitterInformerVector3 passthroughRot;
    public OSCTransmitterInformerVector3 passthroughScale;

    public OSCTransmitterInformerInt instrumentID;
    public OSCTransmitterInformerVector3 remoteInstrumentPos;
    public OSCTransmitterInformerVector3 remoteInstrumentRot;
    public OSCTransmitterInformerVector3 remoteInstrumentScale;

    public OSCTransmitterInformerVector3 cameraRigPos;
    public OSCTransmitterInformerVector3 cameraRigRot;

    public OSCTransmitterInformerInt questionsScore;

    [Header("OSC Receivers")]
    public OSCReceiverReflectionBlob remoteAvatarData;

    public OSCReceiverReflectionBlob oneWayLatencyReceive;
    public OSCReceiverReflectionBlob returnLatencyReceive;

    public OSCReceiverReflectionVector3 serverCameraRigPos;
    public OSCReceiverReflectionVector3 serverCameraRigRot;

    public OSCReceiverReflectionVector3 serverPassthroughPos;
    public OSCReceiverReflectionVector3 serverPassthroughRot;
    public OSCReceiverReflectionVector3 serverPassthroughScale;

    public OSCReceiverReflectionVector3 serverInstrumentPos;
    public OSCReceiverReflectionVector3 serverInstrumentRot;
    public OSCReceiverReflectionVector3 serverInstrumentScale;

    private void FixedUpdate()
    {
        toServer.RemoteHost = serverIP;
    }

    public void UpdateClientIDTo1()
    {
        clientID = 1;
        UpdateOSCTransmitterAddresses();
    }

    public void UpdateClientIDTo2()
    {
        clientID = 2;
        UpdateOSCTransmitterAddresses();
    }

    public void UpdateOSCTransmitterAddresses()
    {
        // Transmitters
        timeStamp.TransmitterAddress = "/ToServer/Timestamp/" + clientID;

        fPS.TransmitterAddress = "/ToServer/FPS/" + clientID;

        userIsPresent.TransmitterAddress = "/ToServer/Avatar/PresenceConfirmation/" + clientID;

        oneWayLatency.TransmitterAddress = "/ToServer/Latency/OneWay/" + clientID;
        returnLatency.TransmitterAddress = "/ToServer/Latency/Return/" + clientID;
        resetLatency.TransmitterAddress = "/ToServer/Latency/Reset/" + clientID;

        avatarStream.TransmitterAddress = "/ToServer/Avatar/Stream/" + clientID;

        headPos.TransmitterAddress = "/ToServer/Avatar/Head/Pos/" + clientID;
        headRot.TransmitterAddress = "/ToServer/Avatar/Head/Rot/" + clientID;

        chestPos.TransmitterAddress = "/ToServer/Avatar/Chest/Pos/" + clientID;
        chestRot.TransmitterAddress = "/ToServer/Avatar/Chest/Rot/" + clientID;

        leftHandPos.TransmitterAddress = "/ToServer/Avatar/LeftHand/Pos/" + clientID;
        leftHandRot.TransmitterAddress = "/ToServer/Avatar/LeftHand/Rot/" + clientID;

        rightHandPos.TransmitterAddress = "/ToServer/Avatar/RightHand/Pos/" + clientID;
        rightHandRot.TransmitterAddress = "/ToServer/Avatar/RightHand/Rot/" + clientID;

        gazeRot.TransmitterAddress = "/ToServer/Avatar/Gaze/Rot/" + clientID;

        browLowererLeft.TransmitterAddress = "/ToServer/Avatar/BrowLowererLeft/" + clientID;

        browLowererRight.TransmitterAddress = "/ToServer/Avatar/BrowLowererRight/" + clientID;

        innerBrowRaiserLeft.TransmitterAddress = "/ToServer/Avatar/InnerBrowRaiserLeft/" + clientID;

        innerBrowRaiserRight.TransmitterAddress = "/ToServer/Avatar/InnerBrowRaiserRight/" + clientID;

        outerBrowRaiserLeft.TransmitterAddress = "/ToServer/Avatar/OuterBrowRaiserLeft/" + clientID;

        outerBrowRaiserRight.TransmitterAddress = "/ToServer/Avatar/OuterBrowRaiserRight/" + clientID;

        lipCornerPullerLeft.TransmitterAddress = "/ToServer/Avatar/LipCornerPullerLeft/" + clientID;

        lipCornerPullerRight.TransmitterAddress = "/ToServer/Avatar/LipCornerPullerRight/" + clientID;

        passthroughPos.TransmitterAddress = "/ToServer/Passthrough/Position/" + clientID;
        passthroughRot.TransmitterAddress = "/ToServer/Passthrough/Rotation/" + clientID;
        passthroughScale.TransmitterAddress = "/ToServer/Passthrough/Scale/" + clientID;

        instrumentID.TransmitterAddress = "/ToServer/Instrument/ID/" + clientID;
        remoteInstrumentPos.TransmitterAddress = "/ToServer/Instrument/Position/" + clientID;
        remoteInstrumentRot.TransmitterAddress = "/ToServer/Instrument/Rotation/" + clientID;
        remoteInstrumentScale.TransmitterAddress = "/ToServer/Instrument/Scale/" + clientID;

        cameraRigPos.TransmitterAddress = "/ToServer/Camera/Pos/" + clientID;
        cameraRigRot.TransmitterAddress = "/ToServer/Camera/Rot/" + clientID;

        questionsScore.TransmitterAddress = "/ToServer/QuestionsScore/" + clientID;

        //receivers
        remoteAvatarData.ReceiverAddress = "/ToClient/Avatar/Stream/" + clientID;

        oneWayLatencyReceive.ReceiverAddress = "/ToClient/Latency/OneWay/" + clientID;
        returnLatencyReceive.ReceiverAddress = "/ToClient/Latency/Return/" + clientID;

        serverCameraRigPos.ReceiverAddress = "/ToClient/CameraRig/Pos/" + clientID;
        serverCameraRigRot.ReceiverAddress = "/ToClient/CameraRig/Rot/" + clientID;

        serverPassthroughPos.ReceiverAddress = "/ToClient/Passthrough/Pos/" + clientID;
        serverPassthroughRot.ReceiverAddress = "/ToClient/Passthrough/Rot/" + clientID;
        serverPassthroughScale.ReceiverAddress = "/ToClient/Passthrough/Scale/" + clientID;

        serverInstrumentPos.ReceiverAddress = "/ToClient/Instrument/Pos/" + clientID;
        serverInstrumentRot.ReceiverAddress = "/ToClient/Instrument/Rot/" + clientID;
        serverInstrumentScale.ReceiverAddress = "/ToClient/Instrument/Scale/" + clientID;
    }
}
