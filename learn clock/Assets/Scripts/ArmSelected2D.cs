using UnityEngine;

public class ArmSelected2D : MonoBehaviour
{
    private bool canDrag;
    public bool CanDrag => canDrag;
    
    private void OnMouseDown()
    {
        canDrag = true;
    }

    private void OnMouseUp()
    {
        canDrag = false;
    }
}
