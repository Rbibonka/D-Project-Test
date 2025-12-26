using UnityEngine;
using Zenject;

public class Player : MonoBehaviour, IPlayer
{
    private int health;
    private string nickname;
    private string[] skills;

    [Inject]
    private IEquipmentFactory equipmentFactory;

    public void Initialize(
        int health,
        string nickname,
        string[] skills)
    {
        this.health = health;
        this.nickname = nickname;
        this.skills = skills;
    }

    public void AddEquipment(Item item)
    {
        
    }
}