using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalDataBuffer : MonoBehaviour
{
    [Header("Source")]
    public AvatarManager avatarManager;
    public OVRFaceExpressions ovrFaceExpressions;
    public FPSLatencyMeasurement fPsLatencyMeasurement;

    [Header("Record")]
    public int counter = 0;
    public int counterTimer = 0;
    public int bufferSize;

    public bool recordIsOn;
    private bool recordingHasStarted;
    public string participantName;
    public int take;

    [Header("Data")]
    public List<string> headPosition = new List<string>(60000);
    public List<string> headRotation = new List<string>(60000);

    //public List<string> leftHandPosition = new List<string>(60000);
    //public List<string> leftHandRotation = new List<string>(60000);

    //public List<string> rightHandPosition = new List<string>(60000);
    //public List<string> rightHandRotation = new List<string>(60000);

    public List<string> gazeRotation = new List<string>(60000);

    public List<string> timeStamp = new List<string>(60000);

    public List<string> latency = new List<string>(60000);

    public List<string> fPS = new List<string>(60000);

    public List<string> browLowererL = new List<string>(60000);
    public List<string> browLowererR = new List<string>(60000);
    public List<string> cheekPuffL = new List<string>(60000);
    public List<string> cheekPuffR = new List<string>(60000);
    public List<string> cheekRaiserL = new List<string>(60000);
    public List<string> cheekRaiserR = new List<string>(60000);
    public List<string> cheekSuckL = new List<string>(60000);
    public List<string> cheekSuckR = new List<string>(60000);
    public List<string> chinRaiserB = new List<string>(60000);
    public List<string> chinRaiserT = new List<string>(60000);
    public List<string> dimplerL = new List<string>(60000);
    public List<string> dimplerR = new List<string>(60000);
    public List<string> eyesClosedL = new List<string>(60000);
    public List<string> eyesClosedR = new List<string>(60000);
    public List<string> eyesLookDownL = new List<string>(60000);
    public List<string> eyesLookDownR = new List<string>(60000);
    public List<string> eyesLookLeftL = new List<string>(60000);
    public List<string> eyesLookLeftR = new List<string>(60000);
    public List<string> eyesLookRightL = new List<string>(60000);
    public List<string> eyesLookRightR = new List<string>(60000);
    public List<string> eyesLookUpL = new List<string>(60000);
    public List<string> eyesLookUpR = new List<string>(60000);
    public List<string> innerBrowRaiserL = new List<string>(60000);
    public List<string> innerBrowRaiserR = new List<string>(60000);
    public List<string> jawDrop = new List<string>(60000);
    public List<string> jawSidewaysLeft = new List<string>(60000);
    public List<string> jawSidewaysRight = new List<string>(60000);
    public List<string> jawThrust = new List<string>(60000);
    public List<string> lidTightenerL = new List<string>(60000);
    public List<string> lidTightenerR = new List<string>(60000);
    public List<string> lipCornerDepressorL = new List<string>(60000);
    public List<string> lipCornerDepressorR = new List<string>(60000);
    public List<string> lipCornerPullerL = new List<string>(60000);
    public List<string> lipCornerPullerR = new List<string>(60000);
    public List<string> lipFunnelerLB = new List<string>(60000);
    public List<string> lipFunnelerLT = new List<string>(60000);
    public List<string> lipFunnelerRB = new List<string>(60000);
    public List<string> lipFunnelerRT = new List<string>(60000);
    public List<string> lipPressorL = new List<string>(60000);
    public List<string> lipPressorR = new List<string>(60000);
    public List<string> lipPuckerL = new List<string>(60000);
    public List<string> lipPuckerR = new List<string>(60000);
    public List<string> lipStretcherL = new List<string>(60000);
    public List<string> lipStretcherR = new List<string>(60000);
    public List<string> lipSuckLB = new List<string>(60000);
    public List<string> lipSuckLT = new List<string>(60000);
    public List<string> lipSuckRB = new List<string>(60000);
    public List<string> lipSuckRT = new List<string>(60000);
    public List<string> lipTightenerL = new List<string>(60000);
    public List<string> lipTightenerR = new List<string>(60000);
    public List<string> lipsToward = new List<string>(60000);
    public List<string> lowerLipDepressorL = new List<string>(60000);
    public List<string> lowerLipDepressorR = new List<string>(60000);
    public List<string> mouthLeft = new List<string>(60000);
    public List<string> mouthRight = new List<string>(60000);
    public List<string> noseWrinklerL = new List<string>(60000);
    public List<string> noseWrinklerR = new List<string>(60000);
    public List<string> outerBrowRaiserL = new List<string>(60000);
    public List<string> outerBrowRaiserR = new List<string>(60000);
    public List<string> upperLidRaiserL = new List<string>(60000);
    public List<string> upperLidRaiserR = new List<string>(60000);
    public List<string> upperLipRaiserL = new List<string>(60000);
    public List<string> upperLipRaiserR = new List<string>(60000);



    private void FixedUpdate()
    {
        if(recordIsOn)
        {
            recordingHasStarted = true;
            
            counter++;
            counterTimer++;
            if (counter < bufferSize)
            {
                headPosition.Add(avatarManager.headPosition.ToString());
                headRotation.Add(avatarManager.headRotation.ToString());
                //leftHandPosition.Add(avatarManager.leftHandPosition.ToString());
                //leftHandRotation.Add(avatarManager.leftHandRotation.ToString());
                //rightHandPosition.Add(avatarManager.rightHandPosition.ToString());
                //rightHandRotation.Add(avatarManager.rightHandRotation.ToString());
                gazeRotation.Add(avatarManager.gazeRotation.ToString());
                timeStamp.Add(counterTimer.ToString());
                latency.Add(fPsLatencyMeasurement.latency.ToString());

                fPS.Add(fPsLatencyMeasurement.fps.ToString());

                browLowererL.Add(ovrFaceExpressions.browLowererL.ToString());
                browLowererR.Add(ovrFaceExpressions.browLowererR.ToString());
                cheekPuffL.Add(ovrFaceExpressions.cheekPuffL.ToString());
                cheekPuffR.Add(ovrFaceExpressions.cheekPuffR.ToString());
                cheekRaiserL.Add(ovrFaceExpressions.cheekRaiserL.ToString());
                cheekRaiserR.Add(ovrFaceExpressions.cheekRaiserR.ToString());
                cheekSuckL.Add(ovrFaceExpressions.cheekSuckL.ToString());
                cheekSuckR.Add(ovrFaceExpressions.cheekSuckR.ToString());
                chinRaiserB.Add(ovrFaceExpressions.chinRaiserB.ToString());
                chinRaiserT.Add(ovrFaceExpressions.chinRaiserT.ToString());
                dimplerL.Add(ovrFaceExpressions.dimplerL.ToString());
                dimplerR.Add(ovrFaceExpressions.dimplerR.ToString());
                eyesClosedL.Add(ovrFaceExpressions.eyesClosedL.ToString());
                eyesClosedR.Add(ovrFaceExpressions.eyesClosedR.ToString());
                eyesLookDownL.Add(ovrFaceExpressions.eyesLookDownL.ToString());
                eyesLookDownR.Add(ovrFaceExpressions.eyesLookDownR.ToString());
                eyesLookLeftL.Add(ovrFaceExpressions.eyesLookLeftL.ToString());
                eyesLookLeftR.Add(ovrFaceExpressions.eyesLookLeftR.ToString());
                eyesLookRightL.Add(ovrFaceExpressions.eyesLookRightL.ToString());
                eyesLookRightR.Add(ovrFaceExpressions.eyesLookRightR.ToString());
                eyesLookUpL.Add(ovrFaceExpressions.eyesLookUpL.ToString());
                eyesLookUpR.Add(ovrFaceExpressions.eyesLookUpR.ToString());
                innerBrowRaiserL.Add(ovrFaceExpressions.innerBrowRaiserL.ToString());
                innerBrowRaiserR.Add(ovrFaceExpressions.innerBrowRaiserR.ToString());
                jawDrop.Add(ovrFaceExpressions.jawDrop.ToString());
                jawSidewaysLeft.Add(ovrFaceExpressions.jawSidewaysLeft.ToString());
                jawSidewaysRight.Add(ovrFaceExpressions.jawSidewaysRight.ToString());
                jawThrust.Add(ovrFaceExpressions.jawThrust.ToString());
                lidTightenerL.Add(ovrFaceExpressions.lidTightenerL.ToString());
                lidTightenerR.Add(ovrFaceExpressions.lidTightenerR.ToString());
                lipCornerDepressorL.Add(ovrFaceExpressions.lipCornerDepressorL.ToString());
                lipCornerDepressorR.Add(ovrFaceExpressions.lipCornerDepressorR.ToString());
                lipCornerPullerL.Add(ovrFaceExpressions.lipCornerPullerL.ToString());
                lipCornerPullerR.Add(ovrFaceExpressions.lipCornerPullerR.ToString());
                lipFunnelerLB.Add(ovrFaceExpressions.lipFunnelerLB.ToString());
                lipFunnelerLT.Add(ovrFaceExpressions.lipFunnelerLT.ToString());
                lipFunnelerRB.Add(ovrFaceExpressions.lipFunnelerRB.ToString());
                lipFunnelerRT.Add(ovrFaceExpressions.lipFunnelerRT.ToString());
                lipPressorL.Add(ovrFaceExpressions.lipPressorL.ToString());
                lipPressorR.Add(ovrFaceExpressions.lipPressorR.ToString());
                lipPuckerL.Add(ovrFaceExpressions.lipPuckerL.ToString());
                lipPuckerR.Add(ovrFaceExpressions.lipPuckerR.ToString());
                lipStretcherL.Add(ovrFaceExpressions.lipStretcherL.ToString());
                lipStretcherR.Add(ovrFaceExpressions.lipStretcherR.ToString());
                lipSuckLB.Add(ovrFaceExpressions.lipSuckLB.ToString());
                lipSuckLT.Add(ovrFaceExpressions.lipSuckLT.ToString());
                lipSuckRB.Add(ovrFaceExpressions.lipSuckRB.ToString());
                lipSuckRT.Add(ovrFaceExpressions.lipSuckRT.ToString());
                lipTightenerL.Add(ovrFaceExpressions.lipTightenerL.ToString());
                lipTightenerR.Add(ovrFaceExpressions.lipTightenerR.ToString());
                lipsToward.Add(ovrFaceExpressions.lipsToward.ToString());
                lowerLipDepressorL.Add(ovrFaceExpressions.lowerLipDepressorL.ToString());
                lowerLipDepressorR.Add(ovrFaceExpressions.lowerLipDepressorR.ToString());
                mouthLeft.Add(ovrFaceExpressions.mouthLeft.ToString());
                mouthRight.Add(ovrFaceExpressions.mouthRight.ToString());
                noseWrinklerL.Add(ovrFaceExpressions.noseWrinklerL.ToString());
                noseWrinklerR.Add(ovrFaceExpressions.noseWrinklerR.ToString());
                outerBrowRaiserL.Add(ovrFaceExpressions.outerBrowRaiserL.ToString());
                outerBrowRaiserR.Add(ovrFaceExpressions.outerBrowRaiserR.ToString());
                upperLidRaiserL.Add(ovrFaceExpressions.upperLidRaiserL.ToString());
                upperLidRaiserR.Add(ovrFaceExpressions.upperLidRaiserR.ToString());
                upperLipRaiserL.Add(ovrFaceExpressions.upperLipRaiserL.ToString());
                upperLipRaiserR.Add(ovrFaceExpressions.upperLipRaiserR.ToString());
            }
            else
            {
                counter = 0;

                PrintData(headPosition, "headPosition");
                PrintData(headRotation, "headRotation");
                //PrintData(leftHandPosition, "leftHandPosition");
                //PrintData(leftHandRotation, "leftHandRotation");
                //PrintData(rightHandPosition, "rightHandPosition");
                //PrintData(rightHandRotation, "rightHandRotation");
                PrintData(gazeRotation, "gazeRotation");
                PrintData(timeStamp, "timeStamp");
                PrintData(latency, "latency");

                PrintData(fPS, "fPS");

                PrintData(browLowererL, "browLowererL");
                PrintData(browLowererR, "browLowererR");
                PrintData(cheekPuffL, "cheekPuffL");
                PrintData(cheekPuffR, "cheekPuffR");
                PrintData(cheekRaiserL, "cheekRaiserL");
                PrintData(cheekRaiserR, "cheekRaiserR");
                PrintData(cheekSuckL, "cheekSuckL");
                PrintData(cheekSuckR, "cheekSuckR");
                PrintData(chinRaiserB, "chinRaiserB");
                PrintData(chinRaiserT, "chinRaiserT");
                PrintData(dimplerL, "dimplerL");
                PrintData(dimplerR, "dimplerR");
                PrintData(eyesClosedL, "eyesClosedL");
                PrintData(eyesClosedR, "eyesClosedR");
                PrintData(eyesLookDownL, "eyesLookDownL");
                PrintData(eyesLookDownR, "eyesLookDownR");
                PrintData(eyesLookLeftL, "eyesLookLeftL");
                PrintData(eyesLookLeftR, "eyesLookLeftR");
                PrintData(eyesLookRightL, "eyesLookRightL");
                PrintData(eyesLookRightR, "eyesLookRightR");
                PrintData(eyesLookUpL, "eyesLookUpL");
                PrintData(eyesLookUpR, "eyesLookUpR");
                PrintData(innerBrowRaiserL, "innerBrowRaiserL");
                PrintData(innerBrowRaiserR, "innerBrowRaiserR");
                PrintData(jawDrop, "jawDrop");
                PrintData(jawSidewaysLeft, "jawSidewaysLeft");
                PrintData(jawSidewaysRight, "jawSidewaysRight");
                PrintData(jawThrust, "jawThrust");
                PrintData(lidTightenerL, "lidTightenerL");
                PrintData(lidTightenerR, "lidTightenerR");
                PrintData(lipCornerDepressorL, "lipCornerDepressorL");
                PrintData(lipCornerDepressorR, "lipCornerDepressorR");
                PrintData(lipCornerPullerL, "lipCornerPullerL");
                PrintData(lipCornerPullerR, "lipCornerPullerR");
                PrintData(lipFunnelerLB, "lipFunnelerLB");
                PrintData(lipFunnelerLT, "lipFunnelerLT");
                PrintData(lipFunnelerRB, "lipFunnelerRB");
                PrintData(lipFunnelerRT, "lipFunnelerRT");
                PrintData(lipPressorL, "lipPressorL");
                PrintData(lipPressorR, "lipPressorR");
                PrintData(lipPuckerL, "lipPuckerL");
                PrintData(lipPuckerR, "lipPuckerR");
                PrintData(lipStretcherL, "lipStretcherL");
                PrintData(lipStretcherR, "lipStretcherR");
                PrintData(lipSuckLB, "lipSuckLB");
                PrintData(lipSuckLT, "lipSuckLT");
                PrintData(lipSuckRB, "lipSuckRB");
                PrintData(lipSuckRT, "lipSuckRT");
                PrintData(lipTightenerL, "lipTightenerL");
                PrintData(lipTightenerR, "lipTightenerR");
                PrintData(lipsToward, "lipsToward");
                PrintData(lowerLipDepressorL, "lowerLipDepressorL");
                PrintData(lowerLipDepressorR, "lowerLipDepressorR");
                PrintData(mouthLeft, "mouthLeft");
                PrintData(mouthRight, "mouthRight");
                PrintData(noseWrinklerL, "noseWrinklerL");
                PrintData(noseWrinklerR, "noseWrinklerR");
                PrintData(outerBrowRaiserL, "outerBrowRaiserL");
                PrintData(outerBrowRaiserR, "outerBrowRaiserR");
                PrintData(upperLidRaiserL, "upperLidRaiserL");
                PrintData(upperLidRaiserR, "upperLidRaiserR");
                PrintData(upperLipRaiserL, "upperLipRaiserL");
                PrintData(upperLipRaiserR, "upperLipRaiserR");


                headPosition.Clear();
                headRotation.Clear();
                //leftHandPosition.Clear();
                //leftHandRotation.Clear();
                //rightHandPosition.Clear();
                //rightHandRotation.Clear();
                gazeRotation.Clear();
                timeStamp.Clear();
                latency.Clear();

                fPS.Clear();

                browLowererL.Clear();
                browLowererR.Clear();
                cheekPuffL.Clear();
                cheekPuffR.Clear();
                cheekRaiserL.Clear();
                cheekRaiserR.Clear();
                cheekSuckL.Clear();
                cheekSuckR.Clear();
                chinRaiserB.Clear();
                chinRaiserT.Clear();
                dimplerL.Clear();
                dimplerR.Clear();
                eyesClosedL.Clear();
                eyesClosedR.Clear();
                eyesLookDownL.Clear();
                eyesLookDownR.Clear();
                eyesLookLeftL.Clear();
                eyesLookLeftR.Clear();
                eyesLookRightL.Clear();
                eyesLookRightR.Clear();
                eyesLookUpL.Clear();
                eyesLookUpR.Clear();
                innerBrowRaiserL.Clear();
                innerBrowRaiserR.Clear();
                jawDrop.Clear();
                jawSidewaysLeft.Clear();
                jawSidewaysRight.Clear();
                jawThrust.Clear();
                lidTightenerL.Clear();
                lidTightenerR.Clear();
                lipCornerDepressorL.Clear();
                lipCornerDepressorR.Clear();
                lipCornerPullerL.Clear();
                lipCornerPullerR.Clear();
                lipFunnelerLB.Clear();
                lipFunnelerLT.Clear();
                lipFunnelerRB.Clear();
                lipFunnelerRT.Clear();
                lipPressorL.Clear();
                lipPressorR.Clear();
                lipPuckerL.Clear();
                lipPuckerR.Clear();
                lipStretcherL.Clear();
                lipStretcherR.Clear();
                lipSuckLB.Clear();
                lipSuckLT.Clear();
                lipSuckRB.Clear();
                lipSuckRT.Clear();
                lipTightenerL.Clear();
                lipTightenerR.Clear();
                lipsToward.Clear();
                lowerLipDepressorL.Clear();
                lowerLipDepressorR.Clear();
                mouthLeft.Clear();
                mouthRight.Clear();
                noseWrinklerL.Clear();
                noseWrinklerR.Clear();
                outerBrowRaiserL.Clear();
                outerBrowRaiserR.Clear();
                upperLidRaiserL.Clear();
                upperLidRaiserR.Clear();
                upperLipRaiserL.Clear();
                upperLipRaiserR.Clear();

            }
        }
        else if (!recordIsOn && recordingHasStarted)
        {
            string fileName1 = "_" + participantName + "_timer_" + "takeNumber_" + take + ".txt";
            System.IO.File.AppendAllText(Application.persistentDataPath + fileName1, counterTimer.ToString());

            counter = 0;
            counterTimer = 0;

            headPosition.Clear();
            headRotation.Clear();
            //leftHandPosition.Clear();
            //leftHandRotation.Clear();
            //rightHandPosition.Clear();
            //rightHandRotation.Clear();
            gazeRotation.Clear();
            timeStamp.Clear();
            latency.Clear();

            fPS.Clear();

            browLowererL.Clear();
            browLowererR.Clear();
            cheekPuffL.Clear();
            cheekPuffR.Clear();
            cheekRaiserL.Clear();
            cheekRaiserR.Clear();
            cheekSuckL.Clear();
            cheekSuckR.Clear();
            chinRaiserB.Clear();
            chinRaiserT.Clear();
            dimplerL.Clear();
            dimplerR.Clear();
            eyesClosedL.Clear();
            eyesClosedR.Clear();
            eyesLookDownL.Clear();
            eyesLookDownR.Clear();
            eyesLookLeftL.Clear();
            eyesLookLeftR.Clear();
            eyesLookRightL.Clear();
            eyesLookRightR.Clear();
            eyesLookUpL.Clear();
            eyesLookUpR.Clear();
            innerBrowRaiserL.Clear();
            innerBrowRaiserR.Clear();
            jawDrop.Clear();
            jawSidewaysLeft.Clear();
            jawSidewaysRight.Clear();
            jawThrust.Clear();
            lidTightenerL.Clear();
            lidTightenerR.Clear();
            lipCornerDepressorL.Clear();
            lipCornerDepressorR.Clear();
            lipCornerPullerL.Clear();
            lipCornerPullerR.Clear();
            lipFunnelerLB.Clear();
            lipFunnelerLT.Clear();
            lipFunnelerRB.Clear();
            lipFunnelerRT.Clear();
            lipPressorL.Clear();
            lipPressorR.Clear();
            lipPuckerL.Clear();
            lipPuckerR.Clear();
            lipStretcherL.Clear();
            lipStretcherR.Clear();
            lipSuckLB.Clear();
            lipSuckLT.Clear();
            lipSuckRB.Clear();
            lipSuckRT.Clear();
            lipTightenerL.Clear();
            lipTightenerR.Clear();
            lipsToward.Clear();
            lowerLipDepressorL.Clear();
            lowerLipDepressorR.Clear();
            mouthLeft.Clear();
            mouthRight.Clear();
            noseWrinklerL.Clear();
            noseWrinklerR.Clear();
            outerBrowRaiserL.Clear();
            outerBrowRaiserR.Clear();
            upperLidRaiserL.Clear();
            upperLidRaiserR.Clear();
            upperLipRaiserL.Clear();
            upperLipRaiserR.Clear();

            recordingHasStarted = false;
        }
    }

    private void PrintData(List<string> list, string separator)
    {
        string fileName = "_" + participantName + "_" + separator + "_takeNumber_" + take + ".txt";
        string _string = String.Join(separator, list);
        System.IO.File.AppendAllText(Application.persistentDataPath + fileName, _string);
    }
}
