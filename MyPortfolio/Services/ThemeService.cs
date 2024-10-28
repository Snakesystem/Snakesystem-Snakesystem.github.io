using System;

public class ThemeService
{
    public string CurrentTheme { get; private set; } = "dark"; // Default theme

    public event Action OnThemeChanged;

    public void ToggleTheme()
    {
        CurrentTheme = CurrentTheme == "light" ? "dark" : "light";
        NotifyThemeChanged();
    }

    private void NotifyThemeChanged()
    {
        OnThemeChanged?.Invoke();
    }
}
