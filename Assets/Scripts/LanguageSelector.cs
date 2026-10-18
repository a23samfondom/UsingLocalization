using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class LanguageSelector : MonoBehaviour
{
    public Locale englishLocale;
    public Locale spanishLocale;

    public void SetEnglish()
    {
        LocalizationSettings.SelectedLocale = englishLocale;
    }

    public void SetSpanish()
    {
        LocalizationSettings.SelectedLocale = spanishLocale;
    }
    
}
