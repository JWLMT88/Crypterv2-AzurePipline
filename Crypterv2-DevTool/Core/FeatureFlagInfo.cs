﻿using LILO_Packager.v2.Core;

namespace Crypterv2_DevTool.Core
{
    [Serializable]
    public class FeatureFlagInfo
    {
        public FeatureFlags Feature { get; }
        public bool IsEnabled { get; }

        public FeatureFlagInfo(FeatureFlags feature, bool isEnabled)
        {
            Feature = feature;
            IsEnabled = isEnabled;
        }
    }
}
