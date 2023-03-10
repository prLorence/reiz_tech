namespace reiz_tech {
  public class Clock {
    const int DEGREE_PER_TICK = 30;
    const int MINUTES_PER_TICK = 5;
    private int hoursTick;
    private float minutesTick;

    public Clock(int hours, float minutes) {
      hoursTick = hours == 12 ? 0 : hours;
      minutesTick = minutes / MINUTES_PER_TICK;
    }

    public float GetDegrees() {
      float degrees = Math.Abs(hoursTick * DEGREE_PER_TICK - minutesTick * DEGREE_PER_TICK);
      // since we're taking lesser angle
      if (degrees > 180) {
        degrees = 360f - degrees;
      }
      return degrees;
    }
  }
}