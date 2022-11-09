using UnityEngine;

public class BaseMovement2D : MonoBehaviour
{
    [SerializeField] private ArmSelected2D arm;
    
    private void Update()
    {
        if (arm.CanDrag)
        {
            //Aim player at mouse
            //which direction is up
            Vector3 upAxis = new Vector3(0, 0, -1);
            Vector3 mouseScreenPosition = Input.mousePosition;
            //set mouses z to your targets
            mouseScreenPosition.z = transform.position.z;
            Vector3 mouseWorldSpace = Camera.main.ScreenToWorldPoint(mouseScreenPosition);
            transform.LookAt(mouseWorldSpace, upAxis);
            //zero out all rotations except the axis I want
            transform.eulerAngles = new Vector3(0, 0, -transform.eulerAngles.z);
        }
    }
}
