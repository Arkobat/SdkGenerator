package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class NoteDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Content;
        @NotNull
    	private DateTime CreatedAt;
        @NotNull
    	private PersonDto Author;
    
    
    
}