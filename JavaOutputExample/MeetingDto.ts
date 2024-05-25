package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class MeetingDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Title;
        @NotNull
    	private DateTime StartTime;
        @NotNull
    	private DateTime EndTime;
        @Nullable
    	private PersonDto Participants;
        @NotNull
    	private AddressDto Location;
        @NotNull
    	private AppointmentDto Appointment;
    
    
    
}