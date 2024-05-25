package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class ExperienceDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Title;
        @NotNull
    	private String Company;
        @NotNull
    	private DateTime StartDate;
        @Nullable
    	private DateTime EndDate;
        @NotNull
    	private PersonDto Person;
    
    
    
}