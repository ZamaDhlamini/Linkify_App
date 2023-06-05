using myLinkify.Debugging;

namespace myLinkify
{
    public class myLinkifyConsts
    {
        public const string LocalizationSourceName = "myLinkify";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "a235a1c462aa47d1b734e5250d66fdce";
    }
}
