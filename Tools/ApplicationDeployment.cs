namespace KCD2.Tools;

public static class ApplicationDeployment
{
    public static bool IsNetworkDeployed
    {
        get
        {
            bool.TryParse(Environment.GetEnvironmentVariable("ClickOnce_IsNetworkDeployed"), out bool result);
            return result;
        }
    }

    public static Uri ActivationUri
    {
        get
        {
            Uri.TryCreate(Environment.GetEnvironmentVariable("ClickOnce_ActivationUri"), UriKind.Absolute, out Uri result);
            return result;
        }
    }

    public static Version CurrentVersion
    {
        get
        {
            Version.TryParse(Environment.GetEnvironmentVariable("ClickOnce_CurrentVersion"), out Version result);
            return result;
        }
    }

    public static string DataDirectory => Environment.GetEnvironmentVariable("ClickOnce_DataDirectory");

    public static bool IsFirstRun
    {
        get
        {
            bool.TryParse(Environment.GetEnvironmentVariable("ClickOnce_IsFirstRun"), out bool result);
            return result;
        }
    }

    public static DateTime TimeOfLastUpdateCheck
    {
        get
        {
            DateTime.TryParse(Environment.GetEnvironmentVariable("ClickOnce_TimeOfLastUpdateCheck"), out DateTime result);
            return result;
        }
    }

    public static string UpdatedApplicationFullName => Environment.GetEnvironmentVariable("ClickOnce_UpdatedApplicationFullName");

    public static Version UpdatedVersion
    {
        get
        {
            Version.TryParse(Environment.GetEnvironmentVariable("ClickOnce_UpdatedVersion"), out Version result);
            return result;
        }
    }

    public static Uri UpdateLocation
    {
        get
        {
            Uri.TryCreate(Environment.GetEnvironmentVariable("ClickOnce_UpdateLocation"), UriKind.Absolute, out Uri result);
            return result;
        }
    }

    public static Version LauncherVersion
    {
        get
        {
            Version.TryParse(Environment.GetEnvironmentVariable("ClickOnce_LauncherVersion"), out Version result);
            return result;
        }
    }
}