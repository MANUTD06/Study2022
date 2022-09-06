using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlatformCountText : MonoBehaviour
{
    public int PlatformsCount;
    public TextMeshProUGUI text;

    private void Update()
    {
        text.text = PlatformsCount.ToString();
    }

}
