using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameralook : MonoBehaviour
{
    public float mousespeed;
    public Transform player;
    private float xmove;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float x, y;
        x = Input.GetAxis("Mouse X") * mousespeed * Time.deltaTime;
        y = Input.GetAxis("Mouse Y") * mousespeed * Time.deltaTime;
        xmove = xmove - y;
        xmove = Mathf.Clamp(xmove, -90, 90);
        this.transform.localRotation = Quaternion.Euler(xmove, 0, 0);
        player.Rotate(Vector3.up * x);

    }
}
