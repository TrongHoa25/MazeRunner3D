
using UnityEngine;
using UnityEngine.UI;

public class PlayerKey : MonoBehaviour
{
    public int key = 0;
    public Text counttext;
    // Start is called before the first frame update
   public void setKey()
    {
        if(key <= 3){
            key++;
            counttext.text = "Key: " + this.key.ToString();
        }
    }
}
