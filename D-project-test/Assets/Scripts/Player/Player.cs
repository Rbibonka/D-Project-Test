using UnityEngine;
using Zenject;

public class Player : MonoBehaviour, IPlayer
{
    private int health;
    private string nickname;
    private Skills[] skills;

    [Inject]
    private IEquipmentFactory equipmentFactory;

    public void Initialize(
        int health,
        string nickname,
        Skills[] skills)
    {
        this.health = health;
        this.nickname = nickname;
        this.skills = skills;
    }

    public void AddEquipment(Item item)
    {
        
    }
}