using UnityEngine;

public class TankController
{
    private TankModel tankModel;
    private TankView tankView;

    public TankController(TankModel _tankModel, TankView _tankView) {
        tankModel = _tankModel;
        tankModel.SetTankController(this);

        tankView = _tankView;
        tankView.SetTankController(this);

        GameObject.Instantiate(tankView.gameObject);
    }

}
