package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class ReminderDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Message;
        @NotNull
    	private DateTime RemindAt;
        @NotNull
    	private PersonDto Person;
    
    
    
}