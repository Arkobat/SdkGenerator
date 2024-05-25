package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class EventRegistrationDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private EventDto Event;
        @NotNull
    	private PersonDto Participant;
        @NotNull
    	private DateTime RegistrationDate;
        @Nullable
    	private WorkshopDto Workshop;
    
    
    
}