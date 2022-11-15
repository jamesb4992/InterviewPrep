namespace InterviewPrep
{
    internal class DetermineAnalogTimeFromAngle
    {
        internal static void DetermineAnalogTime(int angle)
        {

            Func<int, string> time = (angle) => $"{angle / 30} : {angle % 30 * 2}";
            Console.WriteLine(time(angle));
        }
    }
}
