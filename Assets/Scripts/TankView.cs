using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;
    private float movement;
    private float rotation;
    public Rigidbody rigidbody;
    public MeshRenderer[] children;

    // Start is called before the first frame update
    void Start()
    {
        GameObject camera = GameObject.Find("Main Camera");
        camera.transform.SetParent(transform);
        camera.transform.position = new Vector3(0f, 3f, -4f);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        if(movement != 0) {
            tankController.Move(movement, tankController.GetTankModel().movementSpeed);
        }
        if(rotation != 0) {
            tankController.Rotate(rotation, tankController.GetTankModel().rotationSpeed);
        }
    }

    private void Movement() {
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");
    }

    public void SetTankController(TankController _tankController) {
        tankController = _tankController;
    }

    public Rigidbody GetRigidbody() {
        return rigidbody;
    }

    public void ChangeColor(Material color) {
        for(int i = 0; i < children.Length; ++i) {
            children[i].material = color;
        }
    }
}


