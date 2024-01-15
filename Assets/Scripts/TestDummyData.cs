using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//set this component active to send dummy data, oscillating between 100 and 360 and incrementing at each frame

public class TestDummyData : MonoBehaviour
{
    public AvatarManager avatarManager;
    private float counter = 0;

    private void FixedUpdate()
    {
        if(gameObject.activeInHierarchy)
        {
            counter ++;

            avatarManager.headPosition = new Vector3(counter, counter, counter);          
            avatarManager.headRotation = new Vector3(counter, counter, counter);
            avatarManager.leftHandPosition = new Vector3(counter, counter, counter);
            avatarManager.leftHandRotation = new Vector3(counter, counter, counter);
            avatarManager.rightHandPosition = new Vector3(counter, counter, counter);
            avatarManager.rightHandRotation = new Vector3(counter, counter, counter);

            if(counter > 100)
            {
                counter = 0;
            }
        }
    }
}
