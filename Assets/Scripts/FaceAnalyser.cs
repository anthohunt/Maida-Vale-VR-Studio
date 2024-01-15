using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceAnalyser : MonoBehaviour
{
    //this script is currently not in use with this version of the app (04/2023)
    //this script is used to collect data from the face tracker,
    public OVRFaceExpressions oVRFaceExpressions;

    //some face points are listed as examples below
    public float browLowererL;
    public float browLowererR;
    public float innerBrowRaiserL;
    public float innerBrowRaiserR;
    public float outerBrowRaiserL;
    public float outerBrowRaiserR;
    
    public float lipCornerPullerL;
    public float lipCornerPullerR;

    // Update is called once per frame
    void Update()
    {
        //wait to get the face expressions
        if (oVRFaceExpressions.ValidExpressions)
        {
            //brows
            browLowererL = oVRFaceExpressions.browLowererL;
            browLowererR = oVRFaceExpressions.browLowererR;

            innerBrowRaiserL = oVRFaceExpressions.innerBrowRaiserL;
            innerBrowRaiserR = oVRFaceExpressions.innerBrowRaiserR;

            outerBrowRaiserL = oVRFaceExpressions.outerBrowRaiserL;
            outerBrowRaiserR = oVRFaceExpressions.outerBrowRaiserR;

            //mouth
            lipCornerPullerL = oVRFaceExpressions.lipCornerPullerL;
            lipCornerPullerR = oVRFaceExpressions.lipCornerPullerR;
        }
    }
}
