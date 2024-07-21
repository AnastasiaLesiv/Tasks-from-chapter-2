using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIDistanceDisplay : MonoBehaviour
{
    public BouncyBall bouncyBall;

    public TMP_Text distanceText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distanceText.text = "Distance to floor: " + bouncyBall.distanceToFloor.ToString("F2") + "meters";
    }
}
