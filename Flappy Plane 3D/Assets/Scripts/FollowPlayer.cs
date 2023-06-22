using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;

    private Vector3 cameraPosition = new Vector3(40, 0, 10);
    private Vector3 cameraRotate = new Vector3(0, -90, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + cameraPosition;
        transform.eulerAngles = cameraRotate;
    }
}
