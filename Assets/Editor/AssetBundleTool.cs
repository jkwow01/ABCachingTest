﻿using UnityEngine;
using UnityEditor;

public class AssetBundleTool
{
    [MenuItem("Tool/Build AssetBundles")]
    static void BuildAssetBundles()
    {
        BuildPipeline.BuildAssetBundles(Application.streamingAssetsPath, BuildAssetBundleOptions.None, BuildTarget.iOS);
    }
}
