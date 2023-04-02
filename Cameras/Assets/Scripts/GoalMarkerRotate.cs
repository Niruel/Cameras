using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalMarkerRotate : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(0, 0, Time.deltaTime * 50));
    }
}
