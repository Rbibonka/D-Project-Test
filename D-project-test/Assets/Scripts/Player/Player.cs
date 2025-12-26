using UnityEngine;
using Zenject;

public class Player : MonoBehaviour, IPlayer
{
    [Inject]
    private IEquipmentFactory equipmentFactory;

    private int health;
    private string nickname;
    private Skills[] skills;

    private IEquipment equipment;

    private PlayerInputListener inputListener;
    private bool disposed;

    public void Initialize(
        int health,
        string nickname,
        Skills[] skills)
    {
        inputListener = new();

        this.health = health;
        this.nickname = nickname;
        this.skills = skills;

        equipment = equipmentFactory.Create();
        inputListener.EquipmentChanged += OnEquipmentChanged;
    }

    public void TakeCurrentItem()
    {
        equipment.ChangeItem();
        equipment.CurrentItem.gameObject.SetActive(true);
    }

    public void AddEquipment(Item item)
    {
        equipment.AddItem(item);
    }

    public void SetPosition(Vector3 position)
    {
        transform.position = position;
    }

    private void OnEquipmentChanged()
    {
        equipment.CurrentItem.gameObject.SetActive(false);
        equipment.ChangeItem();
        equipment.CurrentItem.gameObject.SetActive(true);
    }

    public void Dispose()
    {
        if (disposed)
        {
            return;
        }

        inputListener.EquipmentChanged -= OnEquipmentChanged;
        inputListener.Dispose();

        disposed = true;
    }
}