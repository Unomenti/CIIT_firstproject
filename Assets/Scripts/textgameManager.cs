using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class textgameManager : MonoBehaviour
{

    public TextMeshProUGUI storyTextMeshPro, hpTextMeshPro, staTextMeshPro;
    public string storyText;
    public int hpValue, staValue;
    public GameObject branch01;
    public GameObject branch02;

    // Start is called before the first frame update
    void Start()
    {
        
}

    // Update is called once per frame
    void Update()
    {
        storyTextMeshPro.text = storyText;
        hpTextMeshPro.text = hpValue.ToString();
        staTextMeshPro.text = staValue.ToString();
    }

    // One of the three gets called by their respective buttons. You know which is which, they share the same name after all, silly >:v
    public void West()
    {
        storyText = "Left foot first, facing your left. You start running west, hoping that it'll lead you somewhere. The fog hasn't cleared, but your body gets warmer. Is it the air, or the fatigue from your body? Before you get the chance to answer that question, you suddenly fall from a drop.";
        hpValue -= 1;
        staValue -= 2;

        branch01.SetActive(false);
    }

    public void South()
    {
        storyText = "You backpedal for a bit before quickly turning around into a full sprint south. The cold air makes your movement stiff, but you press on, as each step gradually gets heavier, and heavier. Eventually, you hear a river ahead of you. You take a breather from what felt like a marathon.";
        staValue -= 7;

        branch01.SetActive(false);
        branch02.SetActive(true);
    }

    public void East()
    {
        storyText = "Your choice of direction leads eastwards.";
    }
}
