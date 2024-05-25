package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class JurorDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private PersonDto Person;
        @NotNull
    	private CaseDto Case;
        @NotNull
    	private String Verdict;
        @NotNull
    	private DateTime Date;
    
    
    
}