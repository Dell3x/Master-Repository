using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card card;

    private int cardCount;


    [SerializeField] private Text nameText;
    [SerializeField] private Text descriptionText;

    [SerializeField] private Image artworkImage;

    [SerializeField] private Text manaCostText;
    [SerializeField] private Text healthText;
    [SerializeField] private Text attacktext;

    [Header("Cards")]

    [SerializeField] private Object[] cardsInfo;


    private void Start()
    {
        cardsInfo = Resources.LoadAll("SO");
    }
    private void Update()
    {
        card = (Card)cardsInfo[cardCount];

        nameText.text = card.cardName;
        descriptionText.text = card.description;
        artworkImage.sprite = card.artWork;
        manaCostText.text = card.manaCost.ToString();
        healthText.text = card.health.ToString();
        attacktext.text = card.attack.ToString();
    }

    public void NextCard()
    {
        cardCount++;
        if (cardCount == 5)
        {
            cardCount = 0;
        }
    }

    public void PreviousCard()
    {
        if (cardCount == 0)
        {
            cardCount = 5;
        }
        cardCount--;
    }
}
