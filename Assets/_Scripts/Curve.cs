using UnityEngine;

public class Curve : MonoBehaviour
{
    [Range(2,1000)]
    public int numSamples = 10;

    public virtual string Formula()
    {
        return "";
    }
    public virtual Line Sample()
    {
        return new Line();
    }
}