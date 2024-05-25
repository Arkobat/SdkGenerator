package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class AppointmentDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private DateTime AppointmentDate;
        @NotNull
    	private PersonDto Person;
        @NotNull
    	private String Description;
    
    
    
}