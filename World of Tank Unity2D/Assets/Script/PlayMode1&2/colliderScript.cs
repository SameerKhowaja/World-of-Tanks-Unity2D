using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderScript : MonoBehaviour
{
    public BoxCollider2D wall_T, wall_B, wall_L, wall_R;
    public Camera mcamera;
    public Transform p1, p2;

    private void Start()
    {
        p1.transform.position = new Vector3(mcamera.ScreenToWorldPoint(new Vector3(75f, 0f, 0f)).x - 0.5f, 0f);
        p2.transform.position = new Vector3(mcamera.ScreenToWorldPoint(new Vector3(Screen.width-15f, 0f, 0f)).x - 0.5f, 0f);
    }

    void Update()
    {
        wall_T.size = new Vector2(mcamera.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
        wall_T.transform.position = new Vector3(0f, mcamera.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y + 0.5f);

        wall_B.size = new Vector2(mcamera.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
        wall_B.transform.position = new Vector3(0f, mcamera.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).y - 0.5f, 0f);

        wall_L.size = new Vector2(1f, mcamera.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
        wall_L.transform.position = new Vector3(mcamera.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x - 0.5f, 0f);

        wall_R.size = new Vector2(1f, mcamera.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
        wall_R.transform.position = new Vector3(mcamera.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + 0.5f, 0f, 0f);

    }
}
