using System;
using System.Linq;
using System.Reflection;
using BeatSaberMarkupLanguage;
using BeatSaberMarkupLanguage.Attributes;
using TMPro;
using UnityEngine;

namespace Izuzusama.Beatsaber.Clock
{
    public class ClockController : PersistentSingleton<ClockController>
    {

        [UIComponent("clockText")]
        public TextMeshProUGUI clockText;
        internal void Setup()
        {
            var mainMenu = Resources.FindObjectsOfTypeAll<MainMenuViewController>().FirstOrDefault();
            if (!mainMenu) return;
            BSMLParser.instance.Parse(Utilities.GetResourceContent(Assembly.GetExecutingAssembly(), "Izuzusama.Beatsaber.Clock.View.ClockView.bsml"), mainMenu.gameObject, this);
            Update();
        }

        internal void Update()
        {
            clockText.text = DateTime.Now.ToString(Plugin.config.Value.ClockFormat);
        }
    }
}
