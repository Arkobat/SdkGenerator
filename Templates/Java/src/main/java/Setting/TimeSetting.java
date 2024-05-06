package Setting;

public class TimeSetting {
    private long time;
    private TimeUnit timeUnit;

    public long getTotalSeconds() {
        return time * timeUnit.getSeconds();
    }

    // Getters and Setters
    // ...
}