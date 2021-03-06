﻿using MvvmCross.Core.ViewModels;
using System.Collections.Generic;

namespace SharedElement.Activity.Core.Utils
{
    public static class MvxBundleUtils
    {
        public static MvxBundle CreateTransitionPresentationBundle(params string[] animationTags)
        {
            return new MvxBundle(new Dictionary<string, string>
            {
                [SharedConstants.Animate_Tag] = string.Join("|", animationTags)
            });
        }
    }
}
