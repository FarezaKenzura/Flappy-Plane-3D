using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    private float speed = 20.0f;
    private float rotateSpeed = 45.0f;

    [Header("Event")]
    public UnityEvent onPlayerLose;
    public UnityEvent onPlayerWin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.down * Time.deltaTime * speed);
        transform.Rotate(Vector3.right * rotateSpeed * verticalInput * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            onPlayerLose.Invoke();
            Time.timeScale = 0f;
        }
        if (other.gameObject.CompareTag("Win"))
        {
            onPlayerWin.Invoke();
            Time.timeScale = 0f;
        }
    }
}
