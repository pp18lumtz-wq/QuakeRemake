using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField]
    // Update is called once per frame
    private Vector3 rotationSpeed = new Vector3(0f, 0f, 0f);
     public bool canRotate = true;
     private void Update()
    {
        if (canRotate)
        {
            transform.Rotate(rotationSpeed * Time.deltaTime);
        }
    }
}
