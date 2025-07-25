static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake) => !knightIsAwake;

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake) => knightIsAwake || archerIsAwake || prisonerIsAwake;

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) => !archerIsAwake && prisonerIsAwake;

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if (petDogIsPresent)
        {
            if (archerIsAwake == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            if (archerIsAwake == false && knightIsAwake == false && prisonerIsAwake)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
