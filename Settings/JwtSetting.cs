namespace mi_kan_project_backend.Settings
{
    public class JwtSetting
    {
        public string Key { get; set; } = "THIS IS USED TO SIGN AND VERIFY JWT TOKET, REPLACE IT WITH YOUR OWN SECRET";
        public string Issuer { get; set; } = "MrSorasak";
        public string Expire { get; set; } = "1";
        public string Audience { get; set; } = "Sorasak SaingChin";
    }
}
