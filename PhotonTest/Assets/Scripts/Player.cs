using System;
using Photon.Pun;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public PhotonView view;

    private void Update()
    {
        if (view.IsMine)
        {
            var moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            var moveAmount = moveInput.normalized * speed * Time.deltaTime;
            transform.position += (Vector3)moveAmount;
        }
    }
}
