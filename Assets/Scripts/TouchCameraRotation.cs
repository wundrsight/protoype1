using UnityEngine;

public class TouchCameraRotation : MonoBehaviour
{
    public float sensitivity = 10.0f;

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

            transform.Rotate(new Vector3(-touchDeltaPosition.y, touchDeltaPosition.x, 0) * Time.deltaTime * sensitivity);
        }
    }
}