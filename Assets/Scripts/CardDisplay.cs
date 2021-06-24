using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card card;

    public Text nameText;
    public Text descriptionText;

    public Image artworkImage;

    public Text manaCostText;
    public Text healthText;
    public Text attacktext;

    private void Start()
    {
        nameText.text = card.cardName;
        descriptionText.text = card.description;
        artworkImage.sprite = card.artWork;
        manaCostText.text = card.manaCost.ToString();
        healthText.text = card.health.ToString();
        attacktext.text = card.attack.ToString();
    }
}
