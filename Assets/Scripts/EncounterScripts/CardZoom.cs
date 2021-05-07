// Written by: Damien Carlson

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardZoom : MonoBehaviour
{
    // Properties =====================================================================================================================

    public GameObject Canvas;
    private GameObject zoomCard;

    public MinionStatFiller CardFiller;

    private string monster = "MonsterTemplate(Clone)";
    private int yOffset = 195;
    public bool tryingToZoom = false;

    // Methods ========================================================================================================================

    public void Awake()
    {
        Canvas = GameObject.Find("Main Canvas");
        CardFiller = gameObject.GetComponent<MinionStatFiller>();
    }

    public void OnHoverEnter(Object cardType)
    {
        tryingToZoom = true;

        // Places the card below the cursor if monster
        if (cardType.name == monster)
            yOffset *= -1;

        //Debug.Log($"Zoomed card = \n " +    //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% Debug (Don't forget to remove this)
        //    $"ID: {CardFiller.id} \n" +
        //    $"Name: {CardFiller.cardName} \n" +
        //    $"ManaCost: {CardFiller.manaCost}"); 

        // Creates a duplicate of the card and places it to the upper center of the cursor.
        zoomCard = Instantiate(gameObject, new Vector2(Input.mousePosition.x, Input.mousePosition.y + yOffset), Quaternion.identity);
        zoomCard.transform.SetParent(Canvas.transform, true);

        // Assign the duplicate card a layer.
        zoomCard.layer = LayerMask.NameToLayer("Zoom");

        // Increase the size of duplicate.
        RectTransform rect = zoomCard.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(256, 374);

        // Resets y offset
        if (yOffset < 0)
            yOffset *= -1;
        
    }

    public void OnHoverExit()
    {
        // Delete the duplicate card when cursor leaves the original card.
        Destroy(zoomCard);

        tryingToZoom = false;
    }
}
