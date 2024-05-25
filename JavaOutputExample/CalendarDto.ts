package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class CalendarDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private PersonDto Owner;
        @Nullable
    	private MeetingDto Meetings;
        @Nullable
    	private EventDto Events;
    
    
    
}