package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class MessageDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Content;
        @NotNull
    	private PersonDto Sender;
        @NotNull
    	private PersonDto Recipient;
        @NotNull
    	private DateTime Timestamp;
    
    
    
}