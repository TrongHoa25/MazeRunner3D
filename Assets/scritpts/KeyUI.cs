using UnityEngine.UI;
using UnityEngine;

public class KeyUI : MonoBehaviour
{
    public Sprite[] keyUI;
    public PlayerKey player;
    public Image Key;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        Key.sprite = keyUI[player.getKeysNum()];
    }
}
