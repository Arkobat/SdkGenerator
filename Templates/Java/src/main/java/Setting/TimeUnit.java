package Setting;

public enum TimeUnit {
    SECOND(1),
    MINUTE(60),
    HOUR(3600),
    DAY(86400);

    private final long seconds;

    TimeUnit(long seconds) {
        this.seconds = seconds;
    }

    public long getSeconds() {
        return seconds;
    }
}
