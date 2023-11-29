
using TMPro;
using UnityEngine;

public enum SystemType {Money = 0, Build}

public class SystemTextViewer : MonoBehaviour
{
    private TextMeshProUGUI textSystem;
    private TMPAlpha tMPAlpha;

    private void Awake()
    {
        textSystem = GetComponent<TextMeshProUGUI>();
        tMPAlpha = GetComponent<TMPAlpha>();
    }

    public void PrintText(SystemType type)
    {
        switch (type)
        {
            case SystemType.Money:
                textSystem.text = "System : Not enough money...";
                break;
            case SystemType.Build:
                textSystem.text = "System : Invalid build tower...";
                break;
        }

        tMPAlpha.FadeOut();
    }
}
