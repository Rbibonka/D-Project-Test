using TMPro;

public class PlayerInfoView
{
    private TMP_Text txt_PlayerName;

    private TMP_Text txt_Health;

    public PlayerInfoView(
        TMP_Text txt_PlayerName,
        TMP_Text txt_Health)
    {
        this.txt_PlayerName = txt_PlayerName;
        this.txt_Health = txt_Health;
    }

    public void SetName(string name)
    {
        txt_PlayerName.text = name;
    }

    public void SetHealth(string health)
    {
        txt_Health.text = $"{health}/{health}";
    }
}