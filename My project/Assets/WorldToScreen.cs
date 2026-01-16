using UnityEngine;
// Converts the object's world position to screen position and logs it.`
public class WorldToScreen : MonoBehaviour
{
    void Update()
    {
        Vector3 screenPos =
            Camera.main.WorldToScreenPoint(transform.position);

        Debug.Log(screenPos);
    }
}