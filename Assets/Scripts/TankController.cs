using UnityEngine;

public class TankController
{
    private TankModel tankModel;
    private TankView tankView;
    private Rigidbody rigidbody;

    public TankController(TankModel _tankModel, TankView _tankView) {
        tankModel = _tankModel;
        tankModel.SetTankController(this);

        tankView = GameObject.Instantiate<TankView>(_tankView);
        tankView.SetTankController(this);
        rigidbody = tankView.GetRigidbody();
    }

    public void Move(float movement, float movementSpeed) {
        rigidbody.velocity = tankView.transform.forward * movement * movementSpeed;
    }

    public void Rotate(float rotation, float rotationSpeed) {
        Vector3 vector = new Vector3(0f, rotation * rotationSpeed, 0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        rigidbody.MoveRotation(rigidbody.rotation * deltaRotation);
    }

    public TankModel GetTankModel() {
        return tankModel;
    }

}
