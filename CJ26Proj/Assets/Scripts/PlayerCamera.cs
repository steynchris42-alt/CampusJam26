using Unity.VisualScripting;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Camera Camera;
    [SerializeField] private float cam_x_rot;
    [SerializeField] private float cam_y_rot;
    [SerializeField] private float cam_Z_rot = 0.0f;

    public void Update()
    {
        cam_x_rot = Camera.transform.eulerAngles.x;
        cam_y_rot = Camera.transform.eulerAngles.y;
     
        transform.rotation = Quaternion.Euler(cam_x_rot, cam_y_rot, cam_Z_rot);
    }
}
