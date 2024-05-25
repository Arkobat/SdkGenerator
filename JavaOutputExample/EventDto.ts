package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class EventDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Name;
        @NotNull
    	private DateTime Date;
        @Nullable
    	private PersonDto Attendees;
        @NotNull
    	private AddressDto Location;
        @NotNull
    	private EventRegistrationDto Registration;
    
    
    
}