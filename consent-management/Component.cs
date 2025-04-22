namespace ConsentManagementWorld.wit.exports.edgee.components.v1_0_0;

public struct Settings {
    public string Example { get; }

    public Settings(List<(string, string)> settings) {
        Example = string.Empty;
        foreach (var setting in settings) {
            if (setting.Item1 == "example") {
                Example = setting.Item2;
            }
        }
    }
}

public struct Cookies {
    public string Example { get; }

    public Cookies(List<(string, string)> cookies) {
        Example = string.Empty;
        foreach (var cookie in cookies) {
            if (cookie.Item1 == "example") {
                Example = cookie.Item2;
            }
        }
    }
}

public class ConsentManagementImpl: IConsentManagement {
    public static IConsentManagement.Consent? Map(List<(string, string)> cookies, List<(string, string)> settings) {
        Settings s = new Settings(settings);
        Cookies c = new Cookies(cookies);

        if (c.Example == string.Empty) {
            return null;
        } else if (c.Example == "granted") {
            return IConsentManagement.Consent.GRANTED;
        } else if (c.Example == "denied") {
            return IConsentManagement.Consent.DENIED;
        } else {
            return IConsentManagement.Consent.PENDING;
        }

    }
}

