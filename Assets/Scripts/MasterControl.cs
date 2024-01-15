using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script is used to give specific control of the clients to the server
public class MasterControl : MonoBehaviour
{
    //server can freeze client and control the camera, active remote instrument and passthrough portal
    public bool isFrozenByServer;
    // confirmation by server to allow remote data to be applied to avatar
    public bool readyToStream;
}
