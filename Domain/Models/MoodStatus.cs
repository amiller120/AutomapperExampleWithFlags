using System;

namespace Domain.Models
{
    [Flags]
    public enum MoodStatus
    {
        None = 0,
        Tired = 1 << 0,
        Sad = 1 << 1,
        Bored = 1 << 2,
        Happy = 1 << 3,
        Joyous = 1 << 4
    }
}
