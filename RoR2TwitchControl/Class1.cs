using System;
using BepInEx;
using RoR2;

namespace RoR2TwitchControl
{
    [BepInDependency("com.bepis.r2api")]
    //Change these
    [BepInPlugin("com.DeusExMachinaInc.RoR2TwitchControl", "RoR2 Twitch Chat Control", "1.0.0")]
    public class MyModName : BaseUnityPlugin
    {
        public void Awake()
        {
        }
    }
}
