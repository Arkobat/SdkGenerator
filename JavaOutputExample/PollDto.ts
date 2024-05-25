package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class PollDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Question;
        @NotNull
    	private DateTime CreatedDate;
        @Nullable
    	private OptionDto Options;
        @NotNull
    	private PersonDto Creator;
    
    
    
}