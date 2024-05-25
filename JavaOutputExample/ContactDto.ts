package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class ContactDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Name;
        @NotNull
    	private String PhoneNumber;
        @NotNull
    	private String Email;
        @NotNull
    	private PersonDto Owner;
    
    
    
}