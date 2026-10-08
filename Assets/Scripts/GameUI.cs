using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public PlayerController targetPlayer;
    public RectTransform playerHealthbar;

    void Update()
    {
        playerHealthbar.localScale = new Vector3( targetPlayer.GetHealthPercentage(), 1f, 1f);
    }
}
