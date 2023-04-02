using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public Transform player;
    Transform currPos;
    // Start is called before the first frame update
    void Start()
    {
        currPos = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            player.position = currPos.position;
        }
    }
}
