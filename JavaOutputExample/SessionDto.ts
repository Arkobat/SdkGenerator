package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class SessionDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String SessionName;
        @NotNull
    	private DateTime StartTime;
        @NotNull
    	private DateTime EndTime;
        @NotNull
    	private WorkshopDto Workshop;
        @Nullable
    	private FeedbackDto Feedback;
    
    
    
}