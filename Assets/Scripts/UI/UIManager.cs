// ==================== UIManager.cs ====================
using UnityEngine;
using TMPro;

[DefaultExecutionOrder(-100)]    // יוודא ש-UIManager עולה ראשון
public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI messageText;

    private void Awake()
    {
        Instance = this;
    }

    public void SetLevel(int level)
    {
        if (levelText != null)
            levelText.text = "Level: " + level;
        ClearMessage();
    }

    public void SetScore(int fallen)
    {
        if (scoreText != null)
            scoreText.text = "Fallen: " + fallen;
    }

    public void ShowMessage(string msg)
    {
        if (messageText != null)
            messageText.text = msg;
    }

    public void ClearMessage()
    {
        ShowMessage("");
    }

    public void ShowWin()
    {
        ShowMessage("YOU WON!");
    }
}
