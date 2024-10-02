using UnityEngine;

public class DagaController : DisparadorController
{
    public bool hasDaga = false;
    public GameObject[] agarrarDaga;

    protected override void InitializeWeapon()
    {
        SetActiveArms(false);
        base.canShoot = false;
    }

    public void GrabbedDaga()
    {
        SetActiveArms(true);
        base.canShoot = true;
        hasDaga = true;
    }

    private void SetActiveArms(bool active)
    {
        foreach (var go in agarrarDaga)
            go.SetActive(active);
    }

    private void OnTriggerEnter(Collider other)
    {
        var pickup = other.GetComponent<DagaPickup>();
        if (pickup != null)
        {
            this.GrabbedDaga();
            Destroy(pickup.gameObject);
        }
    }
}