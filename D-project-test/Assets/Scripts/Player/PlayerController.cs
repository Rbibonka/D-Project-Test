using UnityEngine;
using Zenject;

public class PlayerController : MonoBehaviour, IPlayer
{
    [Inject]
    private IEquipmentFactory equipmentFactory;

    [Inject]
    private IEffectPlayer effectPlayer;

    [SerializeField]
    private Transform backTransform;

    [SerializeField]
    private Transform leftTransform;

    [SerializeField]
    private ParticleSystem changeWeaponEffectPrefab;

    private int health;
    private string nickname;
    private Skills[] skills;

    private IEquipment equipment;

    private PlayerInputListener inputListener;
    private PlayerView view;
    private bool disposed;

    public void Initialize(
        int health,
        string nickname,
        Skills[] skills)
    {
        inputListener = new();
        view = new(changeWeaponEffectPrefab);

        this.health = health;
        this.nickname = nickname;
        this.skills = skills;

        equipment = equipmentFactory.Create();
        inputListener.EquipmentChanged += OnEquipmentChanged;
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

    public void TakeNextItem()
    {
        equipment.ChangeItem();

        var socketTransform = SelectItemSocket(equipment.CurrentItem.ItemSocketPart);

        effectPlayer.PlayEffect(socketTransform.position);

        equipment.CurrentItem.gameObject.SetActive(true);
        equipment.CurrentItem.SetToGrabPoint(socketTransform);
    }

    public void AddEquipment(Item item)
    {
        item.gameObject.SetActive(false);

        equipment.AddItem(item);
    }

    public void SetPosition(Vector3 position)
    {
        transform.position = position;
    }

    private void OnEquipmentChanged()
    {
        if (equipment.CurrentItem != null)
        {
            equipment.CurrentItem.gameObject.SetActive(false);
        }

        TakeNextItem();
    }

    private Transform SelectItemSocket(ItemSocketParts itemSocketParts)
    {
        switch (itemSocketParts)
        {
            case ItemSocketParts.Back: return backTransform;
            case ItemSocketParts.LeftHand: return leftTransform;
            default: throw new System.Exception("No socket");
        }
    }
}