using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class PlantSlot : MonoBehaviour
{
    public Sprite plantSprite;
    public GameObject plantObject;

    public int price;
    public Image icon;
    public TextMeshProUGUI priceText;

    private void OnValidate()
    {
        if (plantSprite)
        {
            icon.enabled = true;
            icon.sprite = plantSprite;
            priceText.text = price.ToString();
        }
        else
        {
            icon.enabled = false;        }

        }
    }
}
