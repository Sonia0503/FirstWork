using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarScript : MonoBehaviour {
    
    private float fillAmout;

    [SerializeField]
    private float lerpSpeed;

    [SerializeField]
    private Image content;

    [SerializeField]
    private Text valueText;

    [SerializeField]
    private Color fullColor;

    [SerializeField]
    private Color lowColor;

    [SerializeField]
    private bool lerpColor;

    public float MaxValue { get; set; }

    public float Value
    { set
        {
            string[] tmp = valueText.text.Split(':');
            valueText.text = tmp[0] + ": " + value;
            fillAmout = Map(value, 0, MaxValue,0, 1);
        }
            }

	// Use this for initialization
	void Start () {
        if (lerpColor)
        { content.color = fullColor; }
	}
	
	// Update is called once per frame
	void Update () {
        HandleBar();	
	}

    private void HandleBar ()
    {if (fillAmout != content.fillAmount)
        { content.fillAmount = Mathf.Lerp (content.fillAmount , fillAmout ,Time.deltaTime * lerpSpeed); }

        if (lerpColor)
        { content.color = Color.Lerp(lowColor, fullColor, fillAmout); }
    }

    private float Map (float value, float inMin, float inMax, float outMin, float outMax)
    { return (value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin; }
}
