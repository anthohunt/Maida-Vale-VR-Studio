using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The script manages the different musical instruments in a virtual environment.
//It allows for the selection of a specific instrument, such as a piano or guitar,
//and tracks the position, rotation, and scale of the active instrument.
//The script also includes control for the client and server, which determines whether the instrument
//is being updated or frozen in place.

public class InstrumentManager : MonoBehaviour
{
    [Header("Server")]
    public MasterControl masterControl;

    [HideInInspector]
    public int instrumentID; // The ID of the active instrument

    [Header("Avatar")]
    public Transform remoteAvatar;

    [Header("Instruments")]
    public Transform piano; // The transform of the piano game object
    public Transform guitar; // The transform of the guitar game object

    [HideInInspector]
    public Vector3 activeInstrumentPos; // The position of the active instrument
    [HideInInspector]
    public Vector3 activeInstrumentRot; // The rotation of the active instrument
    [HideInInspector]
    public Vector3 activeInstrumentScale; // The scale of the active instrument

    [HideInInspector]
    public bool startTracking; // Whether or not to start tracking the instrument

    //piano
    public void SetInstrumentIDTo1()
    {
        instrumentID = 1;
    }
    //guitar
    public void SetInstrumentIDTo2()
    {
        instrumentID = 2;
    }
    //vox
    public void SetInstrumentIDTo3()
    {
        instrumentID = 3;
    }

    // Set the active instrument
    public void SetInstruments()
    {
        if (instrumentID == 1)
        {
            piano.gameObject.SetActive(true);
            guitar.gameObject.SetActive(false);
        }
        if (instrumentID == 2)
        {
            piano.gameObject.SetActive(false);
            guitar.gameObject.SetActive(true);

            guitar.SetParent(remoteAvatar.Find("Joint Chest").transform);
            guitar.localPosition = new Vector3(0, 0.15f, -0.3f);
            guitar.localEulerAngles = new Vector3(0, -40, 0);
        }
        if (instrumentID == 3)
        {
            piano.gameObject.SetActive(false);
            guitar.gameObject.SetActive(false);
        }
        startTracking = true;
    }

    private void Update()
    {
        if(startTracking)
        {
            // client control
            if (!masterControl.isFrozenByServer)
            {
                if (instrumentID == 1)
                {
                    activeInstrumentPos = piano.position;
                    activeInstrumentRot = piano.eulerAngles;
                    activeInstrumentScale = piano.localScale;
                }
                if (instrumentID == 2)
                {
                    activeInstrumentPos = guitar.position;
                    activeInstrumentRot = guitar.eulerAngles;
                    activeInstrumentScale = guitar.localScale;
                }
            }

            // server control
            if (masterControl.isFrozenByServer)
            {
                if (instrumentID == 1)
                {
                    piano.position = activeInstrumentPos;
                    piano.eulerAngles = activeInstrumentRot;
                    piano.localScale = activeInstrumentScale;
                }
                if (instrumentID == 2)
                {
                    guitar.position = activeInstrumentPos;
                    guitar.eulerAngles = activeInstrumentRot;
                    guitar.localScale = activeInstrumentScale;
                }
            }
        }
    }
}
