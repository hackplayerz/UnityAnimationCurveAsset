using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Animation Curve",order = 400)]
public class AnimationCurveAsset : ScriptableObject
{
    public AnimationCurve Curve = AnimationCurve.Linear(0, 0, 1, 1);

    public static implicit operator AnimationCurve(AnimationCurveAsset curveAsset )
    {
        return curveAsset.Curve;
    }

    public static implicit operator AnimationCurveAsset(AnimationCurve curveAsset)
    {
        AnimationCurveAsset asset = CreateInstance<AnimationCurveAsset>();
        asset.Curve = curveAsset;
        return asset;
    }
}
