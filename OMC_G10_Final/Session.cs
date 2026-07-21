namespace OMC_G10_Final
{
    public static class Session
    {
        public static string CurrentUserId { get; set; }
        public static bool IsAdmin { get; set; }
        public static bool IsSupplier { get; set; } = false;
        public static string? AccessibilityFilter { get; set; } = null; // "Mobility", "Hearing", or null
    }
}