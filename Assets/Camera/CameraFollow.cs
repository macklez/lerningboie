
using macklegames;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;


    private void LateUpdate() //on the update of every frame, slightly delayed
    {
        Vector3 desiredPosition = target.position + offset; //Vector3 is a 3d Vector which is the sum of target position and an offset vector
        Vector3 smoothPosition = Vector3.Lerp(transform.localPosition, desiredPosition, smoothSpeed*Time.deltaTime); //lerp means to lag between an initial position and final position
        transform.position = smoothPosition; //the final position is the smoothPosition vector

        transform.LookAt(target); //fixes all rotation problems by always looking at target
    }
}
